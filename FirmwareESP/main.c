#include <stdio.h>
#include "freertos/FreeRTOS.h"
#include "freertos/task.h"
#include "esp_spi_flash.h"
#include "driver/gpio.h"
#include "driver/adc.h"
#include "esp_adc_cal.h"
#include "freertos/FreeRTOS.h"
#include "freertos/task.h"
#include "freertos/event_groups.h"
#include "esp_wifi.h"
#include "esp_system.h"
#include "esp_event.h"
#include "esp_event_loop.h"
#include "nvs_flash.h"
#include "driver/gpio.h"
#include "lwip/err.h"
#include "lwip/sockets.h"
#include "lwip/sys.h"
#include "lwip/netdb.h"
#include "lwip/dns.h"// I am not sure if we need this, but too scared to delete.
#include <stdio.h>
#include <string.h>
#include <stdlib.h>
#include <sys/fcntl.h>
#include "esp_log.h"
#include <netinet/in.h>  
#include "driver/uart.h"

#define UART_TX_PIN  (GPIO_NUM_17)  //define GPIO_17 como uart_tx
#define UART_RX_PIN  (GPIO_NUM_16)  //define GPIO_16 como uart_rx
#define UART_RTS_PIN  (UART_PIN_NO_CHANGE) //default RTS, sem controle de fluxo
#define UART_CTS_PIN  (UART_PIN_NO_CHANGE) //default CTS, sem controle de fluxo

uint8_t CheckSum = 0;
uint16_t CountCheckSum = 0;

uint8_t CalculeCheckSum(const uint8_t *payload, const uint16_t length){

    CheckSum = 0;
    
    CountCheckSum = 0;
            
    while(CountCheckSum < length){
        CheckSum ^= payload[CountCheckSum];
        CountCheckSum++;                
    }
    
    return (uint8_t)CheckSum;
}

int readADC(int channel)
{
    adc1_config_channel_atten(ADC_CHANNEL_6, ADC_ATTEN_DB_11);
    long read = 0;

    if(channel == 1)
    {
        for(int j = 1; j<=5; j++)
        {
            read += adc1_get_raw(ADC1_CHANNEL_6);            
        }
        read /= 5;      
        return (int)read;
    }
    else
    {
        for(int j = 1; j<=5; j++)
        {
            read += adc1_get_raw(ADC1_CHANNEL_7);            
        }
        read /= 5;      
        return (int)read;
    }  
}

static void RX_task()
{
    uart_config_t uart_config = {
        .baud_rate = 9600,
        .data_bits = UART_DATA_8_BITS,
        .parity    = UART_PARITY_DISABLE,
        .stop_bits = UART_STOP_BITS_1,
        .flow_ctrl = UART_HW_FLOWCTRL_DISABLE
    };
    uart_param_config(UART_NUM_2, &uart_config);
    uart_set_pin(UART_NUM_2, UART_TX_PIN, UART_RX_PIN, UART_RTS_PIN, UART_CTS_PIN);
    uart_driver_install(UART_NUM_2, 256 * 2, 0, 0, NULL, 0);

    // Configura um buffer temporário 
    uint8_t data[256];

    while(true)
    {
        int len = uart_read_bytes(UART_NUM_2, data, 255, 1/portTICK_RATE_MS); //le o buffer uart_2 e salva em data, o tamanho é retornado e posto em len
        vTaskDelay(100 / portTICK_PERIOD_MS);
        if(len > 0)
        {
            //https://docs.espressif.com/projects/esp-idf/en/latest/api-reference/peripherals/adc.html#_CPPv411adc_atten_t
            //https://docs.espressif.com/projects/esp-idf/en/latest/api-reference/peripherals/adc.html#example-of-reading-calibrated-values
            //https://github.com/espressif/esp-idf/blob/master/examples/peripherals/adc/main/adc1_example_main.c
            
            if((data[0] == 0x7F) & (data[1] == 0xFF) & (data[2] == 0x80))
            {   //request buffer

                int count=0;
                char sendPack[127];
                int read1 = 0, read2 = 0;   
                int max1 = 0, max2 = 0;
                int min1 = 5000, min2 = 5000;    
                
                adc1_config_width(ADC_WIDTH_BIT_12);
                adc1_config_channel_atten(ADC_CHANNEL_6, ADC_ATTEN_DB_11);
                adc1_config_channel_atten(ADC_CHANNEL_7, ADC_ATTEN_DB_11);
                
                while(count++ < 200)
                {
                    //send back "<|size|s1|s2|cs\n", size in char, s1 and s2 like a 123,321                    
                    read1 = readADC(1); //adc1_get_raw(ADC1_CHANNEL_6);
                    if(read1 > max1) max1 = read1;
                    if(read1 < min1) min1 = read1;        

                    read2 = readADC(2); //adc1_get_raw(ADC_CHANNEL_7);
                    if(read2 > max2) max2 = read2;
                    if(read2 < min2) min2 = read2;
                    
                }
                
                //int size = sprintf(sendPack, "min, max, mid\nADC1: %d, %d, %d  |  ADC2: %d, %d, %d\n", min1, max1, ((max1+min1)/2), min2, max2, ((max2+min2)/2));
                //uart_write_bytes(UART_NUM_2, (const char *)sendPack, size);

                int dif1 = max1 - ((max1+min1)/2);
                int dif2 = max2 - ((max2+min2)/2);

                int size = sprintf(sendPack, "min, max, mid, dif\nADC1: %d, %d, %d, %d  |  ADC2: %d, %d, %d, %d\n", min1, max1, ((max1+min1)/2), dif1, min2, max2, ((max2+min2)/2), dif2);
                uart_write_bytes(UART_NUM_2, (const char *)sendPack, size);

                //x - 1,41 -> diferença máxima (pico <-> 1,58)
                //1 - 0,000732421875 -> 1 adc = isso (em V)

                //dif máxima = 1925  |  dif minima = 0
                //portanto, cada 1adc = 0,05195 A passando pelo sensor
                //portanto, considerando a rede em 220V, cada 1adc = 114,29W
                float r1 = dif1 * 11.429; //passo o valor já convertido para W 
                float r2 = dif2 * 11.429; //passo o valor já convertido para W 
                
                //int size = sprintf(sendPack, "ADC1: %d, %.3f |  ADC2: %d, %.3f\n", dif1, r1, dif2, r2);
                //uart_write_bytes(UART_NUM_2, (const char *)sendPack, size);
                
                int sendSize = 0;
                char Sensor1[15];
                char Sensor2[15];

                sendSize += sprintf(Sensor1, "%.3f", r1);
                sendSize += sprintf(Sensor2, "%.3f", r2);
                sendSize += 6;

                char packFinal_semCS[50], packFinal[50];
                int tam ;
                sendSize = sprintf(packFinal_semCS,"%c|%c|%s|%s|",'<',sendSize,Sensor1,Sensor2);
                tam = sprintf(packFinal,"%c|%c|%s|%s|%c\n",'<',sendSize,Sensor1,Sensor2,CalculeCheckSum((uint8_t *)packFinal_semCS, sendSize));
                uart_write_bytes(UART_NUM_2, (const char *)packFinal, tam);

            }
        }
    }
}

void app_main()
{    
    xTaskCreate(RX_task, "uart_task", 2048, NULL, 10, NULL);
}