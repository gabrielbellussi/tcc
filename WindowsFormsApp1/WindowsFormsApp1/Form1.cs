'using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.IO.Ports;
using System.IO;
using System.Runtime.InteropServices;
using System.Windows.Forms.DataVisualization.Charting;
using System.Collections;

/*
 *  Protocolo de mensagens
 * 
 *  [0x7F][SIZE],[SENSOR1],[SENSOR2],[CHECKSUM] 
 *  
 *  Exemplo:
 *  
 *  [0x7F]|[0x12]|17,451|23,512|0x[CS]
 *  [0x7F]|[0xFF]|[0x80]
 *  
 *  obs: o check sum é calculado com a string iniciada em 0 e terminada no caracter pré-checksum
 *  
 */
namespace WindowsFormsApp1
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        static string logsPath = Path.GetDirectoryName(Application.ExecutablePath) + "\\dados.txt";


        private void frmPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            Environment.Exit(Environment.ExitCode);
        }


        #region Variáveis Serial
        static SerialPort serial = new SerialPort();
        static Color errorColor = Color.DarkRed;
        static Color successColor = Color.Green;
        static Color defaultColor = Color.Black;
        static Color newPackColor = Color.FromArgb(110, 200, 180);

        

        public struct SerialPackage
        {
            public float Sensor1;

            public float Sensor2;

        }
        SerialPackage serialPack = new SerialPackage();
        #endregion

        #region Variáveis Tabelas
        public const int idTabGeral = 1, idTabDia = 2, idTabPeriodo = 3;

        double SomaSensor1_tblDiaria, SomaSensor2_tblDiaria;
        long count_tblDiaria = 0;

        double SomaSensor1_tblPeriodo, SomaSensor2_tblPeriodo;
        long count_tblPeriodo = 0;

        #endregion

        #region Variáveis Gráficos

        Color CorMenu = Color.FromArgb(27, 27, 27);
        Color CorSelectMenu = Color.FromArgb(55, 82, 178);
        Color CorTextoMenu = Color.White;
        Color CorBarra = Color.FromArgb(40, 40, 40);
        Color CorSensor1 = Color.FromArgb(255, 102, 0);
        Color CorSensor2 = Color.FromArgb(55, 82, 178);
        Color CorGrid = Color.FromArgb(229, 229, 229);

        bool new10Minute = false;
        float total10MinuteS1 = 0;
        float total10MinuteS2 = 0;
        int count10Minute = 0;
        string lastMinute;

        bool isFirstLive = true;
        bool selectedSeries = false;
        bool selectedSeries2 = false;
        bool selectedSeries3 = false;
        bool selectedSeries4 = false;
        bool loadSucess = false;

        #endregion


        public string CalcularCheckSum(string payload)
        {
            byte[] byteToCalculate = Encoding.ASCII.GetBytes(payload);
            int checksum = 0;
            foreach (byte chData in byteToCalculate)
            {
                checksum ^= chData;
            }
            return checksum.ToString("X2");
        }


        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            panelSerial.Dock = panelTabelas.Dock = panelGraficos.Dock = DockStyle.Fill;
            panelSerial.Show();
            panelTabelas.Hide();
            panelGraficos.Hide();

            //btTabelas.Enabled = btGraficos.Enabled = false;

            AtualizarPortasSerial();
            boxBaudrate.SelectedIndex = 4;
            boxDatabits.SelectedIndex = 1;
            boxParity.SelectedIndex = 0;
            boxStopbits.SelectedIndex = 0;
            boxHandshake.SelectedIndex = 0;

            if (!File.Exists(logsPath))
            {
                using (StreamWriter wr = File.CreateText(logsPath))
                {
                    wr.Write("");
                }
            }
            else
            {
                    TabelaGeral.DataSource = CriarDataTable();
                    TabelaDiaria.DataSource = CriarDataTable();
                    TabelaPeriodo.DataSource = CriarDataTable();

                    AtualizarTabela(idTabGeral);

                    DataInicialTexto.Hide();
                    DataFinalTexto.Hide();

                    pSensor1.BackColor = CorSensor1;
                    pSensor2.BackColor = CorSensor2;
                    p2Sensor1.BackColor = CorSensor1;
                    p2Sensor2.BackColor = CorSensor2;
                    p3Sensor1.BackColor = CorSensor1;
                    p3Sensor2.BackColor = CorSensor2;
            }


            serial.DataReceived += new SerialDataReceivedEventHandler(serial_DataReceived_Event);
            
        }

        private void RequestDados()
        {
            try
            {
                lastMinute = DateTime.Now.Minute.ToString();

                while (serial.IsOpen)
                {
                    Thread.Sleep(1000);
                    if (DateTime.Now.Minute.ToString() != lastMinute)
                    {
                        lastMinute = DateTime.Now.Minute.ToString();
                        //realizar o calculo do consumo total desse minuto
                        float mediaS1 = total10MinuteS1 / count10Minute;
                        float mediaS2 = total10MinuteS2 / count10Minute;

                        //zerar a somatoria e o contador
                        total10MinuteS1 = total10MinuteS2 = count10Minute = 0;

                        //salvar isso no arquivo de texto
                         
                        using (StreamWriter writer = File.AppendText(logsPath))
                        {
                            writer.WriteLine(DateTime.Now.ToString("dd/MM/yyyy") + "|" + DateTime.Now.ToString("HH:mm") + "|" + mediaS1 + "|" + mediaS2);
                        }
                    }

                    byte[] bufferRequest = { 0x7F, 0XFF, 0X80 };
                    serial.Write(bufferRequest, 0, 3);
                }
            }
            catch(Exception ex)
            {
                System.Diagnostics.Debug.WriteLine(DateTime.Now.ToString("hh:mm:ss:fff") + ex.Message);
            }
            
        }

        #region PanelSerial
        private void debug(string text, Color forecolor)
        {
            debugSerial.SelectionColor = forecolor;
            debugSerial.AppendText(text + Environment.NewLine);
            //debugSerial.SelectionColor = Color.Black;
            debugSerial.ScrollToCaret();
        }
        
        public void serial_DataReceived_Event(object sender, SerialDataReceivedEventArgs e)
        {
            try
            {
                string buffer = string.Empty;
                if ((serial.BytesToRead >= 17))
                {
                    buffer = serial.ReadLine();
                    
                    if (buffer[0] == '<')
                    {
                        int size = buffer[2];

                        string checkSum = Convert.ToByte(buffer[size]).ToString("X2");
                        
                        if (CalcularCheckSum(buffer.Substring(0, size)) == checkSum)
                        {
                            //IF check sum OK
                            
                            string[] SerialPackSplit = buffer.Split('|');
                            SerialPackSplit[2].Replace('.', ',');
                            SerialPackSplit[3].Replace('.', ',');

                            //DebugOtherThread((float.Parse(SerialPackSplit[2])).ToString() + " - " + (float.Parse(SerialPackSplit[3])).ToString(), defaultColor);

                            serialPack.Sensor1 = (float.Parse(SerialPackSplit[2]))/1000;

                            serialPack.Sensor2 = (float.Parse(SerialPackSplit[3]))/1000;

                            DebugOtherThread(DateTime.Now.ToString("dd/MM/yyyy HH:mm") + " - <|" + size.ToString() + buffer.Substring(3, size - 3) + checkSum, defaultColor);

                            //checkSum OK, somar e incrementar
                            total10MinuteS1 += serialPack.Sensor1;
                            total10MinuteS2 += serialPack.Sensor2;
                            count10Minute++;

                            //DEBUG
                            DebugOtherThread("Total Sensor 1: " + total10MinuteS1 + " | Total Sensor 2: " + total10MinuteS2 + " | Medições: " + count10Minute + "\n", newPackColor);

                        }
                    }
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine(DateTime.Now.ToString("hh:mm:ss:fff") + ex.Message);
            }
        }

        delegate void DebugOtherThreadCallback(string texto, Color cor);
        private void DebugOtherThread(string texto, Color cor)
        {
            if (this.debugSerial.InvokeRequired)
            {
                this.debugSerial.BeginInvoke(new DebugOtherThreadCallback(DebugOtherThread), new object[] { texto, cor });
            }
            else
            {
                debug(texto, cor);
            }
        }

        private void AtualizarPortasSerial()
        {
            boxPort.Items.Clear();

            foreach (string i in SerialPort.GetPortNames())
            {
                boxPort.Items.Add(i);
            }
        }

        private void ConectarSerial()
        {
            if (boxPort.Text == "")
            {
                debug("Selecione uma porta serial!", errorColor);
            }else
            {
                try
                {
                    serial.PortName = boxPort.Text;
                    serial.BaudRate = Int32.Parse(boxBaudrate.Text);
                    serial.DataBits = Int16.Parse(boxDatabits.Text);

                    if (boxParity.Text == "None") serial.Parity = Parity.None;
                    else if (boxParity.Text == "Even") serial.Parity = Parity.Even;
                    else if (boxParity.Text == "Mark") serial.Parity = Parity.Mark;
                    else if (boxParity.Text == "Odd") serial.Parity = Parity.Odd;
                    else if (boxParity.Text == "Space") serial.Parity = Parity.Space;

                    if (boxStopbits.Text == "One") serial.StopBits = StopBits.One;
                    else if (boxStopbits.Text == "OnePointFive") serial.StopBits = StopBits.OnePointFive;
                    else if (boxStopbits.Text == "Two") serial.StopBits = StopBits.Two;
                    else if (boxStopbits.Text == "None") serial.StopBits = StopBits.None;

                    if (boxHandshake.Text == "None") serial.Handshake = Handshake.None;
                    else if (boxHandshake.Text == "RequestToSend") serial.Handshake = Handshake.RequestToSend;
                    else if (boxHandshake.Text == "RequestToSendXOnXOff") serial.Handshake = Handshake.RequestToSendXOnXOff;
                    else if (boxHandshake.Text == "XOnXOff") serial.Handshake = Handshake.XOnXOff;

                    

                    serial.Open();

                    btOpen.Text = "Close";

                    boxPort.Enabled = boxBaudrate.Enabled = boxDatabits.Enabled = boxHandshake.Enabled = boxParity.Enabled = boxStopbits.Enabled = btReload.Enabled = false;

                    debug("Serial " + boxPort.Text + " iniciada.", successColor);
                    new Thread(RequestDados).Start();
                }
                catch(Exception ex)
                {
                    debug("Falha ao iniciar serial: " + ex.Message, errorColor);
                }
            }
        }

        private void PaintPanel(object sender, PaintEventArgs e)
        {
            Panel p = sender as Panel;
            ControlPaint.DrawBorder(e.Graphics, p.DisplayRectangle, Color.FromArgb(195, 195, 195), ButtonBorderStyle.Solid);
        }

        private void btReload_Click(object sender, EventArgs e)
        {
            AtualizarPortasSerial();
        }

        private void btOpen_Click(object sender, EventArgs e)
        {
            if (btOpen.Text == "Open") ConectarSerial();
            else
            {
                try
                {
                    serial.Close();
                    btOpen.Text = "Open";
                    boxPort.Enabled = boxBaudrate.Enabled = boxDatabits.Enabled = boxHandshake.Enabled = boxParity.Enabled = boxStopbits.Enabled = btReload.Enabled = true;
                    debug("Serial " + boxPort.Text + " fechada.", successColor);
                }
                catch (Exception ex)
                {
                    debug("Falha ao fechar serial: " + ex.Message, errorColor);
                }
            }
        }
        #endregion

        private void btSerial_Click(object sender, EventArgs e)
        {
            panelSerial.Show();
            panelTabelas.Hide();
            panelGraficos.Hide();
        }

        private void btTabelas_Click(object sender, EventArgs e)
        {
            panelSerial.Hide();
            panelTabelas.Show();
            panelGraficos.Hide();
        }

        private void btGraficos_Click(object sender, EventArgs e)
        {
            panelSerial.Hide();
            panelTabelas.Hide();
            panelGraficos.Show();
        }

        #region PanelTabelas

        public DataTable CriarDataTable()
        {
            DataTable TabelaTemporaria = new DataTable();

            TabelaTemporaria.Columns.Add("Data", typeof(string));
            TabelaTemporaria.Columns.Add("Hora", typeof(string));
            TabelaTemporaria.Columns.Add("ID Sensor", typeof(string));
            TabelaTemporaria.Columns.Add("Demanda (W)", typeof(float));

            return TabelaTemporaria;
        }

        private void btAtualizarTabelaGeral_Click(object sender, EventArgs e)
        {
            AtualizarTabela(idTabGeral);
        }

        private void btLoadDiaria_Click(object sender, EventArgs e)
        {
            AtualizarTabela(idTabDia);
        }

        private void btLoadPeriodo_Click(object sender, EventArgs e)
        {
            AtualizarTabela(idTabPeriodo);
        }
              
        private void AtualizarTabela(int index)
        {
            DataTable TabelaTemporaria = new DataTable();
            TabelaTemporaria = CriarDataTable();
            switch (index)
            {
                case idTabGeral:
                    {
                        TabelaTemporaria = CarregarDados(index);
                        TabelaGeral.DataSource = TabelaTemporaria;
                        TabelaGeral.BackgroundColor = TabelaGeral.DefaultCellStyle.BackColor;
                        break;
                    }

                case idTabDia:
                    {
                        TabelaTemporaria = CarregarDados(index);
                        TabelaDiaria.DataSource = TabelaTemporaria;
                        TabelaDiaria.BackgroundColor = TabelaGeral.DefaultCellStyle.BackColor;
                        break;
                    }

                case idTabPeriodo:
                    {
                        TabelaTemporaria = CarregarDados(index);
                        TabelaPeriodo.DataSource = TabelaTemporaria;
                        TabelaPeriodo.BackgroundColor = TabelaGeral.DefaultCellStyle.BackColor;
                        break;
                    }

            }
        }
        
        private DataTable CarregarDados(int index)
        {
            DataTable TabelaTemporaria = new DataTable();
            TabelaTemporaria = CriarDataTable();
            string line;

            try
            {
                StreamReader reader = new StreamReader(logsPath);
                TabelaTemporaria.Rows.Clear();
                switch (index)
                {
                    case idTabGeral:
                        {
                            while ((line = reader.ReadLine()) != null)
                            {
                                    string[] lineSplit = line.Split('|');
                                    //split: [0] data, [1] hora, [2] id sensor, [3] consumo sensor id
                                    TabelaTemporaria.Rows.Add(lineSplit[0], lineSplit[1], "1", float.Parse(lineSplit[2]));
                                    TabelaTemporaria.Rows.Add(lineSplit[0], lineSplit[1], "2", float.Parse(lineSplit[3]));
                            }

                            break;
                        }

                    case idTabDia:
                        {
                            //MessageBox.Show(DataDiario.Value.ToString("dd/MM/yyyy"));
                            SomaSensor1_tblDiaria = SomaSensor2_tblDiaria = count_tblDiaria = 0;

                            while ((line = reader.ReadLine()) != null)
                            {
                                string[] lineSplit = line.Split('|');

                                if (lineSplit[0] == DataDiario_tabela.Value.ToString("dd/MM/yyyy"))
                                {
                                    count_tblDiaria++;
                                    SomaSensor1_tblDiaria += float.Parse(lineSplit[2]);
                                    SomaSensor2_tblDiaria += float.Parse(lineSplit[3]);
                                    TabelaTemporaria.Rows.Add(lineSplit[0], lineSplit[1], "1", float.Parse(lineSplit[2]));
                                    TabelaTemporaria.Rows.Add(lineSplit[0], lineSplit[1], "2", float.Parse(lineSplit[3]));
                                }
                            }
                            break;
                        }

                    case idTabPeriodo:
                        {
                            SomaSensor1_tblPeriodo = SomaSensor2_tblPeriodo = count_tblPeriodo = 0;
                            DateTime data1 = new DateTime();
                            DateTime data2 = new DateTime();
                            TimeSpan hora1 = new TimeSpan();
                            TimeSpan hora2 = new TimeSpan();

                            DateTime dataFile = new DateTime();
                            TimeSpan horaFile = new TimeSpan();

                            hora1 = TimeSpan.Parse(horaInicio_tabela.Text);
                            data1 = Convert.ToDateTime(dateInicio_tabela.Text);
                            hora2 = TimeSpan.Parse(horaFim_tabela.Text);
                            data2 = Convert.ToDateTime(dateFim_tabela.Text);


                            //MessageBox.Show(hora1.ToString());
                            data1 = data1.Date + hora1;
                            data2 = data2.Date + hora2;
                            //MessageBox.Show(data1.ToString());

                            if (DateTime.Compare(data1, data2) > 0) MessageBox.Show("A data de início deve ser anterior à final.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            else
                            {
                                while ((line = reader.ReadLine()) != null)
                                {                              
                                    string[] lineSplit = line.Split('|');
                                    horaFile = TimeSpan.Parse(lineSplit[1]);
                                    dataFile = Convert.ToDateTime(lineSplit[0]);
                                    dataFile = dataFile.Date + horaFile;

                                    //MessageBox.Show(dataFile.ToString());

                                    if (DateTime.Compare(dataFile, data1) >= 0 && DateTime.Compare(dataFile, data2) <= 0)
                                    {
                                        count_tblPeriodo++;

                                        SomaSensor1_tblPeriodo += float.Parse(lineSplit[2]);
                                        SomaSensor2_tblPeriodo += float.Parse(lineSplit[3]);
                                        TabelaTemporaria.Rows.Add(lineSplit[0], lineSplit[1], "1", float.Parse(lineSplit[2]));
                                        TabelaTemporaria.Rows.Add(lineSplit[0], lineSplit[1], "2", float.Parse(lineSplit[3]));
                                    }
                                    else
                                    if (Convert.ToDateTime(lineSplit[0]) == data1)
                                    {
                                        //Apresentar apenas os horários após a data de inicio

                                    }
                                }
                            }
                            break;
                        }
                }

                reader.Close();
                return TabelaTemporaria;

            }
            catch(Exception ex)
            {
                System.Diagnostics.Debug.WriteLine(DateTime.Now.ToString("hh:mm:ss:fff") + ex.Message);
            }

            return TabelaTemporaria;
        }
        
        private void btConsumo_TabelaDiaria_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Debug.WriteLine(SomaSensor1_tblDiaria.ToString() + "-" + SomaSensor2_tblDiaria.ToString() + "-" + count_tblDiaria.ToString());
            System.Diagnostics.Debug.WriteLine((SomaSensor1_tblDiaria * ((float)count_tblDiaria /60)).ToString(".##") + " | " + (SomaSensor2_tblDiaria * ((float)count_tblDiaria / 60)).ToString(".##"));

            string frase = "Consumo Sensor 1: " + ((SomaSensor1_tblDiaria * ((float)count_tblDiaria / 60)) / 1000).ToString(".##") +
                " kWh\nConsumo Sensor 2: " + ((SomaSensor2_tblDiaria * ((float)count_tblDiaria / 60)) / 1000).ToString(".##") + " kWh";

            MessageBox.Show(frase, "Consumos");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Debug.WriteLine(SomaSensor1_tblPeriodo.ToString() + "-" + SomaSensor2_tblPeriodo.ToString() + "-" + count_tblPeriodo.ToString());
            System.Diagnostics.Debug.WriteLine((SomaSensor1_tblPeriodo * ((float)count_tblPeriodo / 60)).ToString(".##") + " | " + (SomaSensor2_tblPeriodo * ((float)count_tblDiaria / 60)).ToString(".##"));

            string frase = "Consumo Sensor 1: " + ((SomaSensor1_tblPeriodo * ((float)count_tblPeriodo / 60)) / 1000).ToString(".##") +
                " kWh\nConsumo Sensor 2: " + ((SomaSensor2_tblPeriodo * ((float)count_tblPeriodo / 60)) / 1000).ToString(".##") + " kWh";

            MessageBox.Show(frase, "Consumos");
        }

        #endregion

        #region PanelGraficos

        DataPoint _prevPoint;

        public void CarregarLive()
        {
            #region Variaveis
            StreamReader reader = new StreamReader(logsPath);
            DataTable table = new DataTable();
            GraficoLive.Series.Clear();
            GraficoLive.ChartAreas[0].AxisX.Interval = 1;

            string line;

            var series1 = new System.Windows.Forms.DataVisualization.Charting.Series
            {
                Name = "Sensor 1",
                Color = CorSensor1,
                BorderWidth = 1,
                IsVisibleInLegend = false,
                IsXValueIndexed = true,
                ChartType = SeriesChartType.Line,
            };
            series1.BorderWidth = 2;
            series1.MarkerStyle = MarkerStyle.None;
            

            var series2 = new System.Windows.Forms.DataVisualization.Charting.Series
            {
                Name = "Sensor 2",
                Color = CorSensor2,
                BorderWidth = 1,
                IsVisibleInLegend = false,
                IsXValueIndexed = true,
                ChartType = SeriesChartType.Line,

            };
            series2.BorderWidth = 2;
            series2.MarkerStyle = MarkerStyle.None;
            

            this.GraficoLive.Series.Add(series1);
            this.GraficoLive.Series.Add(series2);
            GraficoLive.ChartAreas["ChartArea1"].AxisX.MajorGrid.LineColor = CorGrid;
            GraficoLive.ChartAreas["ChartArea1"].AxisY.Title = "Demanda";
            GraficoLive.ChartAreas["ChartArea1"].AxisY.MajorGrid.LineColor = CorGrid;

            //TESTAR DEPOIS// GraficoLive.Series["Sensor 1"].ToolTip = "Y Value: #VALY";
            
            //bool ErroFindDados = true;
            #endregion

            try
            {
                foreach (var series in GraficoLive.Series)
                {
                    series.Points.Clear();
                }

                string allText = reader.ReadToEnd();    //pega o texto todo
                string[] lines = allText.Split('\n');   //separa em linhas
                int size = allText.Split('\n').Count(); //conta as linhas
                System.Diagnostics.Debug.WriteLine(size.ToString());
                //if (size > 59) size = 59;
                if(size < 62)
                {
                    for (int i = size; i > 0; i--)
                    {
                        string[] lineSplit = lines[size - i].Split('|');
                        System.Diagnostics.Debug.WriteLine(lines[size - i]);
                        series1.Points.AddXY(lineSplit[1], lineSplit[2].Replace(',', '.'));
                        series2.Points.AddXY(lineSplit[1], lineSplit[3].Replace(',', '.'));
                    }
                }
                else
                {
                    for (int i = 62; i > 0; i--)
                    {
                        string[] lineSplit = lines[size - i].Split('|');
                        System.Diagnostics.Debug.WriteLine(lines[size - i]);
                        series1.Points.AddXY(lineSplit[1], lineSplit[2].Replace(',', '.'));
                        series2.Points.AddXY(lineSplit[1], lineSplit[3].Replace(',', '.'));
                    }
                }
                
            }
            catch(Exception ex)
            {
                reader.Close();
                System.Diagnostics.Debug.WriteLine(DateTime.Now.ToString("hh:mm:ss:fff") + ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CarregarDiaria();
        }

        private void CarregarDiaria()
        {
            #region Variaveis
            string line;
            string[] lineSplit;
            StreamReader reader = new StreamReader(logsPath);
            DataTable table = new DataTable();
            //GraficoDiario.ChartAreas[0].AxisX.Interval = 5;
            //GraficoDiario.ChartAreas[0].AxisY.Interval = 1;

            var series1 = new System.Windows.Forms.DataVisualization.Charting.Series
            {
                Name = "Sensor 1",
                Color = CorSensor1,
                BorderWidth = 2,
                IsVisibleInLegend = false,
                IsXValueIndexed = true,
                ChartType = SeriesChartType.Line,

            };
            series1.BorderWidth = 2;
            series1.MarkerStyle = MarkerStyle.None;

            var series2 = new System.Windows.Forms.DataVisualization.Charting.Series
            {
                Name = "Sensor 2",
                Color = CorSensor2,
                BorderWidth = 2,
                IsVisibleInLegend = false,
                IsXValueIndexed = true,
                ChartType = SeriesChartType.Line,

            };
            series2.BorderWidth = 2;
            series2.MarkerStyle = MarkerStyle.None;
            

            this.GraficoDiario.Series.Clear();
            this.GraficoDiario.Series.Add(series1);
            this.GraficoDiario.Series.Add(series2);
            GraficoDiario.ChartAreas["ChartArea1"].AxisX.MajorGrid.LineColor = CorGrid;
            GraficoDiario.ChartAreas["ChartArea1"].AxisY.Title = "Demanda";
            GraficoDiario.ChartAreas["ChartArea1"].AxisY.MajorGrid.LineColor = CorGrid;
            bool ErroFindDados = true;

            int i = 0;

            #endregion

            try
            {
                foreach (var series in GraficoDiario.Series)
                {
                    series.Points.Clear();
                }

                while ((line = reader.ReadLine()) != null)
                {

                    /*
                     * lineSplit[0] == DataDiario.Value.ToString("dd/MM/yyyy")
                     */

                    lineSplit = line.Split('|');

                    System.Diagnostics.Debug.WriteLine(DataDiario_grafico.Value.ToString("dd/MM/yyyy") + " | " + lineSplit[0]);

                    if (lineSplit[0] == DataDiario_grafico.Value.ToString("dd/MM/yyyy"))
                    {
                        ErroFindDados = false;
                        series1.Points.AddXY(lineSplit[1], lineSplit[2].Replace(',', '.'));
                        series2.Points.AddXY(lineSplit[1], lineSplit[3].Replace(',', '.'));
                    }

                }
                loadSucess = true;
                if (ErroFindDados)
                {
                    MessageBox.Show("Nenhum dado encontrado para essa data.", "Erro");
                    loadSucess = false;
                }

                ErroFindDados = true;
                GraficoDiario.Invalidate();
                reader.Close();
            }
            catch(Exception ex)
            {
                reader.Close();
                System.Diagnostics.Debug.WriteLine(DateTime.Now.ToString("hh:mm:ss:fff") + ex.Message);
            }


        }

        private void btCarregarPeriodo_Grafico_Click(object sender, EventArgs e)
        {
            CarregarPeriodo();
        }

        bool y = false;

        private void GraficoLive_MouseMove(object sender, MouseEventArgs e)
        {
            // this if statement clears the values from the previously activated point.
            if (y)
            {
                y = false;
                _prevPoint.MarkerStyle = MarkerStyle.None;
                _prevPoint.IsValueShownAsLabel = false;
                //GraficoLive.Cursor = Cursors.Default;
            }

            var result = GraficoLive.HitTest(e.X, e.Y, ChartElementType.DataPoint);
            if (result.ChartElementType == ChartElementType.DataPoint)
            {
                GraficoLive.Cursor = Cursors.Hand;
                var prop = result.Object as DataPoint;
                if (prop != null)
                {
                    prop.IsValueShownAsLabel = true;
                    prop.MarkerStyle = MarkerStyle.Circle;
                    _prevPoint = prop;
                    y = true;
                }
            }
        }
               

        private void GraficoDiario_MouseMove(object sender, MouseEventArgs e)
        {
            // this if statement clears the values from the previously activated point.
            if (y)
            {
                y = false;
                _prevPoint.MarkerStyle = MarkerStyle.None;
                _prevPoint.IsValueShownAsLabel = false;
                //GraficoLive.Cursor = Cursors.Default;
            }

            var result = GraficoDiario.HitTest(e.X, e.Y, ChartElementType.DataPoint);
            if (result.ChartElementType == ChartElementType.DataPoint)
            {
                GraficoDiario.Cursor = Cursors.Hand;
                var prop = result.Object as DataPoint;
                if (prop != null)
                {
                    prop.IsValueShownAsLabel = true;
                    prop.MarkerStyle = MarkerStyle.Circle;
                    _prevPoint = prop;
                    y = true;
                }
            }           

        }

        private void GraficoPeriodo_MouseMove(object sender, MouseEventArgs e)
        {
            // this if statement clears the values from the previously activated point.
            if (y)
            {
                y = false;
                _prevPoint.MarkerStyle = MarkerStyle.None;
                _prevPoint.IsValueShownAsLabel = false;
                //GraficoLive.Cursor = Cursors.Default;
            }

            var result = GraficoPeriodo.HitTest(e.X, e.Y, ChartElementType.DataPoint);
            if (result.ChartElementType == ChartElementType.DataPoint)
            {
                GraficoPeriodo.Cursor = Cursors.Hand;
                var prop = result.Object as DataPoint;
                if (prop != null)
                {
                    prop.IsValueShownAsLabel = true;
                    prop.MarkerStyle = MarkerStyle.Circle;
                    _prevPoint = prop;
                    y = true;
                }
            }
        }
        

        private void button3_Click(object sender, EventArgs e)
        {
            CarregarLive();
        }
        
        private void CarregarPeriodo()
        {
            #region Variaveis
            string line;
            string[] lineSplit;
            StreamReader reader = new StreamReader(logsPath);

            DateTime data1 = new DateTime();
            DateTime data2 = new DateTime();
            DateTime lastData = new DateTime();
            TimeSpan hora1 = new TimeSpan();
            TimeSpan hora2 = new TimeSpan();

            DateTime dataFile = new DateTime();
            TimeSpan horaFile = new TimeSpan();

            hora1 = TimeSpan.Parse(horaInicio_Grafico.Text);
            data1 = Convert.ToDateTime(dataInicio_Grafico.Text);
            hora2 = TimeSpan.Parse(horaFim_Grafico.Text);
            data2 = Convert.ToDateTime(dataFim_Grafico.Text);

            //MessageBox.Show(hora1.ToString());
            data1 = data1.Date + hora1;
            data2 = data2.Date + hora2;
            //MessageBox.Show(data1.ToString());

            DataTable table = new DataTable();
            //GraficoPeriodo.ChartAreas[0].AxisX.Interval = 6;
            //GraficoPeriodo.ChartAreas[0].AxisY.Interval = 5;

            System.Diagnostics.Debug.WriteLine(data1 + "|" + data2);

            var series1 = new System.Windows.Forms.DataVisualization.Charting.Series
            {
                Name = "Sensor 1",
                Color = CorSensor1,
                BorderWidth = 1,
                IsVisibleInLegend = false,
                IsXValueIndexed = true,
                ChartType = SeriesChartType.Line,

            };
            series1.BorderWidth = 2;
            series1.MarkerStyle = MarkerStyle.None;
            

            var series2 = new System.Windows.Forms.DataVisualization.Charting.Series
            {
                Name = "Sensor 2",
                Color = CorSensor2,
                BorderWidth = 1,
                IsVisibleInLegend = false,
                IsXValueIndexed = true,
                ChartType = SeriesChartType.Line,

            };
            series2.BorderWidth = 2;
            series2.MarkerStyle = MarkerStyle.None;
            

            this.GraficoPeriodo.Series.Clear();
            this.GraficoPeriodo.Series.Add(series1);
            this.GraficoPeriodo.Series.Add(series2);
            GraficoPeriodo.ChartAreas["ChartArea1"].AxisX.MajorGrid.LineColor = CorGrid;
            GraficoPeriodo.ChartAreas["ChartArea1"].AxisY.Title = "Demanda";
            GraficoPeriodo.ChartAreas["ChartArea1"].AxisY.MajorGrid.LineColor = CorGrid;
            bool ErroFindDados = true;
            bool isFirst = true;

            #endregion

            try
            {
                if (DateTime.Compare(data1, data2) > 0) MessageBox.Show("A data de início deve ser anterior à final.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                else
                {
                    while ((line = reader.ReadLine()) != null)
                    {
                            lineSplit = line.Split('|');
                            horaFile = TimeSpan.Parse(lineSplit[1]);
                            dataFile = Convert.ToDateTime(lineSplit[0]);
                            dataFile = dataFile.Date + horaFile;

                        if (DateTime.Compare(dataFile, data1) >= 0 && DateTime.Compare(dataFile, data2) <= 0)
                        {
                            if (isFirst)
                            {
                                lastData = dataFile;
                                DataInicialTexto.Text = dataFile.ToShortDateString().ToString();
                                DataInicialTexto.Show();
                                isFirst = false;
                            }
                            DataFinalTexto.Text = dataFile.ToShortDateString().ToString();
                            DataFinalTexto.Show();
                            ErroFindDados = false;

                            series1.Points.AddXY(lineSplit[1], lineSplit[2].Replace(',', '.'));
                            series2.Points.AddXY(lineSplit[1], lineSplit[3].Replace(',', '.'));

                        }
                    }
                    loadSucess = true;
                    /*
                    if (series1.Points.Count() <= 15)
                    {
                        GraficoPeriodo.ChartAreas[0].AxisX.Interval = 1;
                        series1.MarkerStyle = MarkerStyle.Circle;
                        series1.MarkerSize = 4;
                        series2.MarkerStyle = MarkerStyle.Circle;
                        series2.MarkerSize = 4;
                    }*/

                    if (ErroFindDados)
                    {
                        MessageBox.Show("Nenhum dado encontrado para essa data.", "Erro");
                        loadSucess = false;
                    }

                    ErroFindDados = true;


                    //GraficoDiario.Legends.Clear();
                    GraficoPeriodo.Invalidate();

                    reader.Close();
                }
            }
            catch
            {
                MessageBox.Show("Erro");
            }

        }

        #endregion

    }
}
