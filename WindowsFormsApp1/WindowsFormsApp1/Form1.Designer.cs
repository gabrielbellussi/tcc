namespace WindowsFormsApp1
{
    partial class frmPrincipal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Menu = new System.Windows.Forms.Panel();
            this.btGraficos = new System.Windows.Forms.Button();
            this.btTabelas = new System.Windows.Forms.Button();
            this.btSerial = new System.Windows.Forms.Button();
            this.panelSerial = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.debugSerial = new System.Windows.Forms.RichTextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btOpen = new System.Windows.Forms.Button();
            this.btReload = new System.Windows.Forms.Button();
            this.boxHandshake = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.boxStopbits = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.boxParity = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.boxDatabits = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.boxBaudrate = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.boxPort = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panelTabelas = new System.Windows.Forms.Panel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabGeral = new System.Windows.Forms.TabPage();
            this.btAtualizarTabelaGeral = new System.Windows.Forms.Button();
            this.TabelaGeral = new System.Windows.Forms.DataGridView();
            this.tabDia = new System.Windows.Forms.TabPage();
            this.TabelaDiaria = new System.Windows.Forms.DataGridView();
            this.btLoadDiaria = new System.Windows.Forms.Button();
            this.DataDiario_tabela = new System.Windows.Forms.DateTimePicker();
            this.tabPeriodo = new System.Windows.Forms.TabPage();
            this.horaInicio_tabela = new System.Windows.Forms.MaskedTextBox();
            this.btLoadPeriodo = new System.Windows.Forms.Button();
            this.TabelaPeriodo = new System.Windows.Forms.DataGridView();
            this.horaFim_tabela = new System.Windows.Forms.MaskedTextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.dateFim_tabela = new System.Windows.Forms.DateTimePicker();
            this.label11 = new System.Windows.Forms.Label();
            this.dateInicio_tabela = new System.Windows.Forms.DateTimePicker();
            this.panelGraficos = new System.Windows.Forms.Panel();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.tabLive = new System.Windows.Forms.TabPage();
            this.button3 = new System.Windows.Forms.Button();
            this.GraficoLive = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.pSensor2 = new System.Windows.Forms.Panel();
            this.pSensor1 = new System.Windows.Forms.Panel();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.GraficoDiario = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.p2Sensor2 = new System.Windows.Forms.Panel();
            this.p2Sensor1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.DataDiario_grafico = new System.Windows.Forms.DateTimePicker();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.GraficoPeriodo = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.p3Sensor2 = new System.Windows.Forms.Panel();
            this.p3Sensor1 = new System.Windows.Forms.Panel();
            this.DataFinalTexto = new System.Windows.Forms.Label();
            this.DataInicialTexto = new System.Windows.Forms.Label();
            this.horaInicio_Grafico = new System.Windows.Forms.MaskedTextBox();
            this.btCarregarPeriodo_Grafico = new System.Windows.Forms.Button();
            this.horaFim_Grafico = new System.Windows.Forms.MaskedTextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.dataFim_Grafico = new System.Windows.Forms.DateTimePicker();
            this.label19 = new System.Windows.Forms.Label();
            this.dataInicio_Grafico = new System.Windows.Forms.DateTimePicker();
            this.btConsumo_TabelaDiaria = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.Menu.SuspendLayout();
            this.panelSerial.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panelTabelas.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabGeral.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TabelaGeral)).BeginInit();
            this.tabDia.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TabelaDiaria)).BeginInit();
            this.tabPeriodo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TabelaPeriodo)).BeginInit();
            this.panelGraficos.SuspendLayout();
            this.tabControl2.SuspendLayout();
            this.tabLive.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GraficoLive)).BeginInit();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GraficoDiario)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GraficoPeriodo)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(119)))), ((int)(((byte)(182)))));
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1174, 65);
            this.panel1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(12, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(165, 31);
            this.label2.TabIndex = 2;
            this.label2.Text = "Supervisório";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(15, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(249, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Análise de Consumo de Energia Elétrica";
            // 
            // Menu
            // 
            this.Menu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(119)))), ((int)(((byte)(182)))));
            this.Menu.Controls.Add(this.btGraficos);
            this.Menu.Controls.Add(this.btTabelas);
            this.Menu.Controls.Add(this.btSerial);
            this.Menu.Dock = System.Windows.Forms.DockStyle.Left;
            this.Menu.Location = new System.Drawing.Point(0, 65);
            this.Menu.Name = "Menu";
            this.Menu.Size = new System.Drawing.Size(150, 565);
            this.Menu.TabIndex = 3;
            // 
            // btGraficos
            // 
            this.btGraficos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btGraficos.Dock = System.Windows.Forms.DockStyle.Top;
            this.btGraficos.FlatAppearance.BorderSize = 0;
            this.btGraficos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(59)))), ((int)(((byte)(94)))));
            this.btGraficos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(59)))), ((int)(((byte)(94)))));
            this.btGraficos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btGraficos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btGraficos.ForeColor = System.Drawing.SystemColors.Control;
            this.btGraficos.Location = new System.Drawing.Point(0, 100);
            this.btGraficos.Name = "btGraficos";
            this.btGraficos.Size = new System.Drawing.Size(150, 50);
            this.btGraficos.TabIndex = 3;
            this.btGraficos.Text = "Gráficos";
            this.btGraficos.UseVisualStyleBackColor = true;
            this.btGraficos.Click += new System.EventHandler(this.btGraficos_Click);
            // 
            // btTabelas
            // 
            this.btTabelas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btTabelas.Dock = System.Windows.Forms.DockStyle.Top;
            this.btTabelas.FlatAppearance.BorderSize = 0;
            this.btTabelas.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(59)))), ((int)(((byte)(94)))));
            this.btTabelas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(59)))), ((int)(((byte)(94)))));
            this.btTabelas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btTabelas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btTabelas.ForeColor = System.Drawing.SystemColors.Control;
            this.btTabelas.Location = new System.Drawing.Point(0, 50);
            this.btTabelas.Name = "btTabelas";
            this.btTabelas.Size = new System.Drawing.Size(150, 50);
            this.btTabelas.TabIndex = 2;
            this.btTabelas.Text = "Tabelas";
            this.btTabelas.UseVisualStyleBackColor = true;
            this.btTabelas.Click += new System.EventHandler(this.btTabelas_Click);
            // 
            // btSerial
            // 
            this.btSerial.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btSerial.Dock = System.Windows.Forms.DockStyle.Top;
            this.btSerial.FlatAppearance.BorderSize = 0;
            this.btSerial.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(59)))), ((int)(((byte)(94)))));
            this.btSerial.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(59)))), ((int)(((byte)(94)))));
            this.btSerial.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btSerial.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSerial.ForeColor = System.Drawing.SystemColors.Control;
            this.btSerial.Location = new System.Drawing.Point(0, 0);
            this.btSerial.Name = "btSerial";
            this.btSerial.Size = new System.Drawing.Size(150, 50);
            this.btSerial.TabIndex = 1;
            this.btSerial.Text = "Serial";
            this.btSerial.UseVisualStyleBackColor = true;
            this.btSerial.Click += new System.EventHandler(this.btSerial_Click);
            // 
            // panelSerial
            // 
            this.panelSerial.BackColor = System.Drawing.SystemColors.Control;
            this.panelSerial.Controls.Add(this.panel3);
            this.panelSerial.Controls.Add(this.panel2);
            this.panelSerial.Location = new System.Drawing.Point(960, 81);
            this.panelSerial.Name = "panelSerial";
            this.panelSerial.Size = new System.Drawing.Size(202, 537);
            this.panelSerial.TabIndex = 4;
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.Controls.Add(this.debugSerial);
            this.panel3.Location = new System.Drawing.Point(15, 34);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(21, 489);
            this.panel3.TabIndex = 2;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.PaintPanel);
            // 
            // debugSerial
            // 
            this.debugSerial.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.debugSerial.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.debugSerial.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.debugSerial.ForeColor = System.Drawing.Color.Black;
            this.debugSerial.Location = new System.Drawing.Point(3, 4);
            this.debugSerial.Name = "debugSerial";
            this.debugSerial.ReadOnly = true;
            this.debugSerial.Size = new System.Drawing.Size(15, 482);
            this.debugSerial.TabIndex = 0;
            this.debugSerial.Text = "";
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.btOpen);
            this.panel2.Controls.Add(this.btReload);
            this.panel2.Controls.Add(this.boxHandshake);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.boxStopbits);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.boxParity);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.boxDatabits);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.boxBaudrate);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.boxPort);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Location = new System.Drawing.Point(42, 34);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(148, 446);
            this.panel2.TabIndex = 1;
            // 
            // btOpen
            // 
            this.btOpen.Location = new System.Drawing.Point(6, 295);
            this.btOpen.Name = "btOpen";
            this.btOpen.Size = new System.Drawing.Size(75, 23);
            this.btOpen.TabIndex = 13;
            this.btOpen.Text = "Open";
            this.btOpen.UseVisualStyleBackColor = true;
            this.btOpen.Click += new System.EventHandler(this.btOpen_Click);
            // 
            // btReload
            // 
            this.btReload.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btReload.BackgroundImage")));
            this.btReload.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btReload.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btReload.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.btReload.FlatAppearance.BorderSize = 0;
            this.btReload.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Control;
            this.btReload.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control;
            this.btReload.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btReload.Location = new System.Drawing.Point(121, 23);
            this.btReload.Name = "btReload";
            this.btReload.Size = new System.Drawing.Size(21, 21);
            this.btReload.TabIndex = 12;
            this.btReload.UseVisualStyleBackColor = true;
            this.btReload.Click += new System.EventHandler(this.btReload_Click);
            // 
            // boxHandshake
            // 
            this.boxHandshake.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.boxHandshake.FormattingEnabled = true;
            this.boxHandshake.Items.AddRange(new object[] {
            "None",
            "RequestToSend",
            "RequestToSendXOnXOff",
            "XOnXOff"});
            this.boxHandshake.Location = new System.Drawing.Point(6, 263);
            this.boxHandshake.Name = "boxHandshake";
            this.boxHandshake.Size = new System.Drawing.Size(109, 21);
            this.boxHandshake.TabIndex = 11;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(3, 244);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(81, 16);
            this.label8.TabIndex = 10;
            this.label8.Text = "Handshake:";
            // 
            // boxStopbits
            // 
            this.boxStopbits.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.boxStopbits.FormattingEnabled = true;
            this.boxStopbits.Items.AddRange(new object[] {
            "One",
            "OnePointFive",
            "Two",
            "None"});
            this.boxStopbits.Location = new System.Drawing.Point(6, 215);
            this.boxStopbits.Name = "boxStopbits";
            this.boxStopbits.Size = new System.Drawing.Size(109, 21);
            this.boxStopbits.TabIndex = 9;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(3, 196);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 16);
            this.label7.TabIndex = 8;
            this.label7.Text = "Stop Bits:";
            // 
            // boxParity
            // 
            this.boxParity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.boxParity.FormattingEnabled = true;
            this.boxParity.Items.AddRange(new object[] {
            "None",
            "Even",
            "Mark",
            "Odd",
            "Space"});
            this.boxParity.Location = new System.Drawing.Point(6, 167);
            this.boxParity.Name = "boxParity";
            this.boxParity.Size = new System.Drawing.Size(109, 21);
            this.boxParity.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(3, 148);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 16);
            this.label6.TabIndex = 6;
            this.label6.Text = "Parity:";
            // 
            // boxDatabits
            // 
            this.boxDatabits.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.boxDatabits.FormattingEnabled = true;
            this.boxDatabits.Items.AddRange(new object[] {
            "7",
            "8"});
            this.boxDatabits.Location = new System.Drawing.Point(6, 119);
            this.boxDatabits.Name = "boxDatabits";
            this.boxDatabits.Size = new System.Drawing.Size(109, 21);
            this.boxDatabits.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(3, 100);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Data Bits:";
            // 
            // boxBaudrate
            // 
            this.boxBaudrate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.boxBaudrate.FormattingEnabled = true;
            this.boxBaudrate.Items.AddRange(new object[] {
            "300",
            "1200",
            "2400",
            "4800",
            "9600",
            "14400",
            "56000",
            "115200"});
            this.boxBaudrate.Location = new System.Drawing.Point(6, 71);
            this.boxBaudrate.Name = "boxBaudrate";
            this.boxBaudrate.Size = new System.Drawing.Size(109, 21);
            this.boxBaudrate.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(3, 52);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 16);
            this.label4.TabIndex = 2;
            this.label4.Text = "Baudrate:";
            // 
            // boxPort
            // 
            this.boxPort.FormattingEnabled = true;
            this.boxPort.Location = new System.Drawing.Point(6, 23);
            this.boxPort.Name = "boxPort";
            this.boxPort.Size = new System.Drawing.Size(109, 21);
            this.boxPort.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 4);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "Port:";
            // 
            // panelTabelas
            // 
            this.panelTabelas.Controls.Add(this.tabControl1);
            this.panelTabelas.Location = new System.Drawing.Point(174, 81);
            this.panelTabelas.Name = "panelTabelas";
            this.panelTabelas.Size = new System.Drawing.Size(456, 537);
            this.panelTabelas.TabIndex = 2;
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabGeral);
            this.tabControl1.Controls.Add(this.tabDia);
            this.tabControl1.Controls.Add(this.tabPeriodo);
            this.tabControl1.Location = new System.Drawing.Point(18, 17);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(420, 503);
            this.tabControl1.TabIndex = 3;
            // 
            // tabGeral
            // 
            this.tabGeral.BackColor = System.Drawing.SystemColors.Control;
            this.tabGeral.Controls.Add(this.btAtualizarTabelaGeral);
            this.tabGeral.Controls.Add(this.TabelaGeral);
            this.tabGeral.Location = new System.Drawing.Point(4, 22);
            this.tabGeral.Name = "tabGeral";
            this.tabGeral.Padding = new System.Windows.Forms.Padding(3);
            this.tabGeral.Size = new System.Drawing.Size(425, 477);
            this.tabGeral.TabIndex = 0;
            this.tabGeral.Text = "Tabela Geral";
            // 
            // btAtualizarTabelaGeral
            // 
            this.btAtualizarTabelaGeral.Location = new System.Drawing.Point(6, 6);
            this.btAtualizarTabelaGeral.Name = "btAtualizarTabelaGeral";
            this.btAtualizarTabelaGeral.Size = new System.Drawing.Size(75, 23);
            this.btAtualizarTabelaGeral.TabIndex = 1;
            this.btAtualizarTabelaGeral.Text = "Atualizar";
            this.btAtualizarTabelaGeral.UseVisualStyleBackColor = true;
            this.btAtualizarTabelaGeral.Click += new System.EventHandler(this.btAtualizarTabelaGeral_Click);
            // 
            // TabelaGeral
            // 
            this.TabelaGeral.AllowUserToAddRows = false;
            this.TabelaGeral.AllowUserToDeleteRows = false;
            this.TabelaGeral.AllowUserToOrderColumns = true;
            this.TabelaGeral.AllowUserToResizeColumns = false;
            this.TabelaGeral.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.TabelaGeral.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.TabelaGeral.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TabelaGeral.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.TabelaGeral.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.TabelaGeral.BackgroundColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.TabelaGeral.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.TabelaGeral.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.TabelaGeral.DefaultCellStyle = dataGridViewCellStyle3;
            this.TabelaGeral.GridColor = System.Drawing.SystemColors.Control;
            this.TabelaGeral.Location = new System.Drawing.Point(6, 34);
            this.TabelaGeral.Name = "TabelaGeral";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.TabelaGeral.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.TabelaGeral.Size = new System.Drawing.Size(413, 422);
            this.TabelaGeral.TabIndex = 0;
            // 
            // tabDia
            // 
            this.tabDia.BackColor = System.Drawing.SystemColors.Control;
            this.tabDia.Controls.Add(this.btConsumo_TabelaDiaria);
            this.tabDia.Controls.Add(this.TabelaDiaria);
            this.tabDia.Controls.Add(this.btLoadDiaria);
            this.tabDia.Controls.Add(this.DataDiario_tabela);
            this.tabDia.Location = new System.Drawing.Point(4, 22);
            this.tabDia.Name = "tabDia";
            this.tabDia.Padding = new System.Windows.Forms.Padding(3);
            this.tabDia.Size = new System.Drawing.Size(425, 477);
            this.tabDia.TabIndex = 1;
            this.tabDia.Text = "Tabela Diária";
            // 
            // TabelaDiaria
            // 
            this.TabelaDiaria.AllowUserToAddRows = false;
            this.TabelaDiaria.AllowUserToDeleteRows = false;
            this.TabelaDiaria.AllowUserToOrderColumns = true;
            this.TabelaDiaria.AllowUserToResizeColumns = false;
            this.TabelaDiaria.AllowUserToResizeRows = false;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black;
            this.TabelaDiaria.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.TabelaDiaria.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TabelaDiaria.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.TabelaDiaria.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.TabelaDiaria.BackgroundColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.TabelaDiaria.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.TabelaDiaria.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.TabelaDiaria.DefaultCellStyle = dataGridViewCellStyle7;
            this.TabelaDiaria.GridColor = System.Drawing.SystemColors.Control;
            this.TabelaDiaria.Location = new System.Drawing.Point(6, 32);
            this.TabelaDiaria.Name = "TabelaDiaria";
            this.TabelaDiaria.Size = new System.Drawing.Size(413, 437);
            this.TabelaDiaria.TabIndex = 2;
            // 
            // btLoadDiaria
            // 
            this.btLoadDiaria.Location = new System.Drawing.Point(115, 5);
            this.btLoadDiaria.Name = "btLoadDiaria";
            this.btLoadDiaria.Size = new System.Drawing.Size(98, 22);
            this.btLoadDiaria.TabIndex = 1;
            this.btLoadDiaria.Text = "Carregar Dados";
            this.btLoadDiaria.UseVisualStyleBackColor = true;
            this.btLoadDiaria.Click += new System.EventHandler(this.btLoadDiaria_Click);
            // 
            // DataDiario_tabela
            // 
            this.DataDiario_tabela.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DataDiario_tabela.Location = new System.Drawing.Point(9, 6);
            this.DataDiario_tabela.Name = "DataDiario_tabela";
            this.DataDiario_tabela.Size = new System.Drawing.Size(100, 20);
            this.DataDiario_tabela.TabIndex = 1;
            // 
            // tabPeriodo
            // 
            this.tabPeriodo.BackColor = System.Drawing.SystemColors.Control;
            this.tabPeriodo.Controls.Add(this.button2);
            this.tabPeriodo.Controls.Add(this.horaInicio_tabela);
            this.tabPeriodo.Controls.Add(this.btLoadPeriodo);
            this.tabPeriodo.Controls.Add(this.TabelaPeriodo);
            this.tabPeriodo.Controls.Add(this.horaFim_tabela);
            this.tabPeriodo.Controls.Add(this.label10);
            this.tabPeriodo.Controls.Add(this.dateFim_tabela);
            this.tabPeriodo.Controls.Add(this.label11);
            this.tabPeriodo.Controls.Add(this.dateInicio_tabela);
            this.tabPeriodo.Location = new System.Drawing.Point(4, 22);
            this.tabPeriodo.Name = "tabPeriodo";
            this.tabPeriodo.Size = new System.Drawing.Size(412, 477);
            this.tabPeriodo.TabIndex = 2;
            this.tabPeriodo.Text = "Tabela de Período";
            // 
            // horaInicio_tabela
            // 
            this.horaInicio_tabela.Location = new System.Drawing.Point(110, 21);
            this.horaInicio_tabela.Mask = "00:00";
            this.horaInicio_tabela.Name = "horaInicio_tabela";
            this.horaInicio_tabela.Size = new System.Drawing.Size(36, 20);
            this.horaInicio_tabela.TabIndex = 11;
            this.horaInicio_tabela.Text = "0800";
            this.horaInicio_tabela.ValidatingType = typeof(System.DateTime);
            // 
            // btLoadPeriodo
            // 
            this.btLoadPeriodo.Location = new System.Drawing.Point(335, 20);
            this.btLoadPeriodo.Name = "btLoadPeriodo";
            this.btLoadPeriodo.Size = new System.Drawing.Size(98, 22);
            this.btLoadPeriodo.TabIndex = 2;
            this.btLoadPeriodo.Text = "Carregar Dados";
            this.btLoadPeriodo.UseVisualStyleBackColor = true;
            this.btLoadPeriodo.Click += new System.EventHandler(this.btLoadPeriodo_Click);
            // 
            // TabelaPeriodo
            // 
            this.TabelaPeriodo.AllowUserToAddRows = false;
            this.TabelaPeriodo.AllowUserToDeleteRows = false;
            this.TabelaPeriodo.AllowUserToOrderColumns = true;
            this.TabelaPeriodo.AllowUserToResizeColumns = false;
            this.TabelaPeriodo.AllowUserToResizeRows = false;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.Black;
            this.TabelaPeriodo.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle8;
            this.TabelaPeriodo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TabelaPeriodo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.TabelaPeriodo.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.TabelaPeriodo.BackgroundColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.TabelaPeriodo.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.TabelaPeriodo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.TabelaPeriodo.DefaultCellStyle = dataGridViewCellStyle10;
            this.TabelaPeriodo.GridColor = System.Drawing.SystemColors.Control;
            this.TabelaPeriodo.Location = new System.Drawing.Point(6, 54);
            this.TabelaPeriodo.Name = "TabelaPeriodo";
            this.TabelaPeriodo.Size = new System.Drawing.Size(403, 416);
            this.TabelaPeriodo.TabIndex = 10;
            // 
            // horaFim_tabela
            // 
            this.horaFim_tabela.Location = new System.Drawing.Point(276, 21);
            this.horaFim_tabela.Mask = "00:00";
            this.horaFim_tabela.Name = "horaFim_tabela";
            this.horaFim_tabela.Size = new System.Drawing.Size(36, 20);
            this.horaFim_tabela.TabIndex = 9;
            this.horaFim_tabela.Text = "0800";
            this.horaFim_tabela.ValidatingType = typeof(System.DateTime);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(171, 5);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(23, 13);
            this.label10.TabIndex = 7;
            this.label10.Text = "Fim";
            // 
            // dateFim_tabela
            // 
            this.dateFim_tabela.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateFim_tabela.Location = new System.Drawing.Point(174, 21);
            this.dateFim_tabela.Name = "dateFim_tabela";
            this.dateFim_tabela.Size = new System.Drawing.Size(96, 20);
            this.dateFim_tabela.TabIndex = 6;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(5, 5);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(34, 13);
            this.label11.TabIndex = 4;
            this.label11.Text = "Início";
            // 
            // dateInicio_tabela
            // 
            this.dateInicio_tabela.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateInicio_tabela.Location = new System.Drawing.Point(8, 21);
            this.dateInicio_tabela.Name = "dateInicio_tabela";
            this.dateInicio_tabela.Size = new System.Drawing.Size(96, 20);
            this.dateInicio_tabela.TabIndex = 3;
            // 
            // panelGraficos
            // 
            this.panelGraficos.Controls.Add(this.tabControl2);
            this.panelGraficos.Location = new System.Drawing.Point(687, 81);
            this.panelGraficos.Name = "panelGraficos";
            this.panelGraficos.Size = new System.Drawing.Size(267, 537);
            this.panelGraficos.TabIndex = 5;
            // 
            // tabControl2
            // 
            this.tabControl2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl2.Controls.Add(this.tabLive);
            this.tabControl2.Controls.Add(this.tabPage1);
            this.tabControl2.Controls.Add(this.tabPage2);
            this.tabControl2.Location = new System.Drawing.Point(19, 16);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(234, 507);
            this.tabControl2.TabIndex = 4;
            // 
            // tabLive
            // 
            this.tabLive.Controls.Add(this.button3);
            this.tabLive.Controls.Add(this.GraficoLive);
            this.tabLive.Controls.Add(this.label12);
            this.tabLive.Controls.Add(this.label13);
            this.tabLive.Controls.Add(this.pSensor2);
            this.tabLive.Controls.Add(this.pSensor1);
            this.tabLive.Location = new System.Drawing.Point(4, 22);
            this.tabLive.Name = "tabLive";
            this.tabLive.Size = new System.Drawing.Size(226, 481);
            this.tabLive.TabIndex = 3;
            this.tabLive.Text = "Gráfico em Tempo Real";
            this.tabLive.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(185, 13);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 19;
            this.button3.Text = "Atualizar";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // GraficoLive
            // 
            this.GraficoLive.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea1.Name = "ChartArea1";
            this.GraficoLive.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.GraficoLive.Legends.Add(legend1);
            this.GraficoLive.Location = new System.Drawing.Point(3, 63);
            this.GraficoLive.Name = "GraficoLive";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.GraficoLive.Series.Add(series1);
            this.GraficoLive.Size = new System.Drawing.Size(220, 411);
            this.GraficoLive.TabIndex = 18;
            this.GraficoLive.Text = "chart1";
            this.GraficoLive.MouseMove += new System.Windows.Forms.MouseEventHandler(this.GraficoLive_MouseMove);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label12.Location = new System.Drawing.Point(93, 27);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(49, 13);
            this.label12.TabIndex = 17;
            this.label12.Text = "Sensor 2";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label13.Location = new System.Drawing.Point(93, 6);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(49, 13);
            this.label13.TabIndex = 15;
            this.label13.Text = "Sensor 1";
            // 
            // pSensor2
            // 
            this.pSensor2.Location = new System.Drawing.Point(62, 31);
            this.pSensor2.Name = "pSensor2";
            this.pSensor2.Size = new System.Drawing.Size(25, 5);
            this.pSensor2.TabIndex = 16;
            // 
            // pSensor1
            // 
            this.pSensor1.Location = new System.Drawing.Point(62, 10);
            this.pSensor1.Name = "pSensor1";
            this.pSensor1.Size = new System.Drawing.Size(25, 5);
            this.pSensor1.TabIndex = 14;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.GraficoDiario);
            this.tabPage1.Controls.Add(this.label14);
            this.tabPage1.Controls.Add(this.label15);
            this.tabPage1.Controls.Add(this.p2Sensor2);
            this.tabPage1.Controls.Add(this.p2Sensor1);
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.DataDiario_grafico);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(492, 481);
            this.tabPage1.TabIndex = 1;
            this.tabPage1.Text = "Gráfico Diário";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // GraficoDiario
            // 
            this.GraficoDiario.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea2.Name = "ChartArea1";
            this.GraficoDiario.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.GraficoDiario.Legends.Add(legend2);
            this.GraficoDiario.Location = new System.Drawing.Point(6, 49);
            this.GraficoDiario.Name = "GraficoDiario";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.GraficoDiario.Series.Add(series2);
            this.GraficoDiario.Size = new System.Drawing.Size(480, 426);
            this.GraficoDiario.TabIndex = 22;
            this.GraficoDiario.Text = "chart1";
            this.GraficoDiario.MouseMove += new System.Windows.Forms.MouseEventHandler(this.GraficoDiario_MouseMove);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label14.Location = new System.Drawing.Point(283, 33);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(49, 13);
            this.label14.TabIndex = 21;
            this.label14.Text = "Sensor 2";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label15.Location = new System.Drawing.Point(283, 12);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(49, 13);
            this.label15.TabIndex = 19;
            this.label15.Text = "Sensor 1";
            // 
            // p2Sensor2
            // 
            this.p2Sensor2.Location = new System.Drawing.Point(252, 37);
            this.p2Sensor2.Name = "p2Sensor2";
            this.p2Sensor2.Size = new System.Drawing.Size(25, 5);
            this.p2Sensor2.TabIndex = 20;
            // 
            // p2Sensor1
            // 
            this.p2Sensor1.Location = new System.Drawing.Point(252, 16);
            this.p2Sensor1.Name = "p2Sensor1";
            this.p2Sensor1.Size = new System.Drawing.Size(25, 5);
            this.p2Sensor1.TabIndex = 18;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(115, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(98, 22);
            this.button1.TabIndex = 1;
            this.button1.Text = "Carregar Dados";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // DataDiario_grafico
            // 
            this.DataDiario_grafico.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DataDiario_grafico.Location = new System.Drawing.Point(9, 6);
            this.DataDiario_grafico.Name = "DataDiario_grafico";
            this.DataDiario_grafico.Size = new System.Drawing.Size(100, 20);
            this.DataDiario_grafico.TabIndex = 1;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.GraficoPeriodo);
            this.tabPage2.Controls.Add(this.label16);
            this.tabPage2.Controls.Add(this.label17);
            this.tabPage2.Controls.Add(this.p3Sensor2);
            this.tabPage2.Controls.Add(this.p3Sensor1);
            this.tabPage2.Controls.Add(this.DataFinalTexto);
            this.tabPage2.Controls.Add(this.DataInicialTexto);
            this.tabPage2.Controls.Add(this.horaInicio_Grafico);
            this.tabPage2.Controls.Add(this.btCarregarPeriodo_Grafico);
            this.tabPage2.Controls.Add(this.horaFim_Grafico);
            this.tabPage2.Controls.Add(this.label18);
            this.tabPage2.Controls.Add(this.dataFim_Grafico);
            this.tabPage2.Controls.Add(this.label19);
            this.tabPage2.Controls.Add(this.dataInicio_Grafico);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Size = new System.Drawing.Size(492, 481);
            this.tabPage2.TabIndex = 2;
            this.tabPage2.Text = "Gráfico de Período";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // GraficoPeriodo
            // 
            this.GraficoPeriodo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea3.Name = "ChartArea1";
            this.GraficoPeriodo.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.GraficoPeriodo.Legends.Add(legend3);
            this.GraficoPeriodo.Location = new System.Drawing.Point(8, 48);
            this.GraficoPeriodo.Name = "GraficoPeriodo";
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            this.GraficoPeriodo.Series.Add(series3);
            this.GraficoPeriodo.Size = new System.Drawing.Size(473, 395);
            this.GraficoPeriodo.TabIndex = 26;
            this.GraficoPeriodo.Text = "chart1";
            this.GraficoPeriodo.MouseMove += new System.Windows.Forms.MouseEventHandler(this.GraficoPeriodo_MouseMove);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label16.Location = new System.Drawing.Point(487, 31);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(49, 13);
            this.label16.TabIndex = 25;
            this.label16.Text = "Sensor 2";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label17.Location = new System.Drawing.Point(487, 10);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(49, 13);
            this.label17.TabIndex = 23;
            this.label17.Text = "Sensor 1";
            // 
            // p3Sensor2
            // 
            this.p3Sensor2.Location = new System.Drawing.Point(456, 35);
            this.p3Sensor2.Name = "p3Sensor2";
            this.p3Sensor2.Size = new System.Drawing.Size(25, 5);
            this.p3Sensor2.TabIndex = 24;
            // 
            // p3Sensor1
            // 
            this.p3Sensor1.Location = new System.Drawing.Point(456, 14);
            this.p3Sensor1.Name = "p3Sensor1";
            this.p3Sensor1.Size = new System.Drawing.Size(25, 5);
            this.p3Sensor1.TabIndex = 22;
            // 
            // DataFinalTexto
            // 
            this.DataFinalTexto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.DataFinalTexto.AutoSize = true;
            this.DataFinalTexto.Location = new System.Drawing.Point(422, 446);
            this.DataFinalTexto.Name = "DataFinalTexto";
            this.DataFinalTexto.Size = new System.Drawing.Size(35, 13);
            this.DataFinalTexto.TabIndex = 14;
            this.DataFinalTexto.Text = "label1";
            // 
            // DataInicialTexto
            // 
            this.DataInicialTexto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.DataInicialTexto.AutoSize = true;
            this.DataInicialTexto.Location = new System.Drawing.Point(28, 446);
            this.DataInicialTexto.Name = "DataInicialTexto";
            this.DataInicialTexto.Size = new System.Drawing.Size(35, 13);
            this.DataInicialTexto.TabIndex = 13;
            this.DataInicialTexto.Text = "label1";
            // 
            // horaInicio_Grafico
            // 
            this.horaInicio_Grafico.Location = new System.Drawing.Point(110, 21);
            this.horaInicio_Grafico.Mask = "00:00";
            this.horaInicio_Grafico.Name = "horaInicio_Grafico";
            this.horaInicio_Grafico.Size = new System.Drawing.Size(36, 20);
            this.horaInicio_Grafico.TabIndex = 11;
            this.horaInicio_Grafico.Text = "0800";
            this.horaInicio_Grafico.ValidatingType = typeof(System.DateTime);
            // 
            // btCarregarPeriodo_Grafico
            // 
            this.btCarregarPeriodo_Grafico.Location = new System.Drawing.Point(335, 20);
            this.btCarregarPeriodo_Grafico.Name = "btCarregarPeriodo_Grafico";
            this.btCarregarPeriodo_Grafico.Size = new System.Drawing.Size(98, 22);
            this.btCarregarPeriodo_Grafico.TabIndex = 2;
            this.btCarregarPeriodo_Grafico.Text = "Carregar Dados";
            this.btCarregarPeriodo_Grafico.UseVisualStyleBackColor = true;
            this.btCarregarPeriodo_Grafico.Click += new System.EventHandler(this.btCarregarPeriodo_Grafico_Click);
            // 
            // horaFim_Grafico
            // 
            this.horaFim_Grafico.Location = new System.Drawing.Point(276, 21);
            this.horaFim_Grafico.Mask = "00:00";
            this.horaFim_Grafico.Name = "horaFim_Grafico";
            this.horaFim_Grafico.Size = new System.Drawing.Size(36, 20);
            this.horaFim_Grafico.TabIndex = 9;
            this.horaFim_Grafico.Text = "0800";
            this.horaFim_Grafico.ValidatingType = typeof(System.DateTime);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(171, 5);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(23, 13);
            this.label18.TabIndex = 7;
            this.label18.Text = "Fim";
            // 
            // dataFim_Grafico
            // 
            this.dataFim_Grafico.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dataFim_Grafico.Location = new System.Drawing.Point(174, 21);
            this.dataFim_Grafico.Name = "dataFim_Grafico";
            this.dataFim_Grafico.Size = new System.Drawing.Size(96, 20);
            this.dataFim_Grafico.TabIndex = 6;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(5, 5);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(34, 13);
            this.label19.TabIndex = 4;
            this.label19.Text = "Início";
            // 
            // dataInicio_Grafico
            // 
            this.dataInicio_Grafico.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dataInicio_Grafico.Location = new System.Drawing.Point(8, 21);
            this.dataInicio_Grafico.Name = "dataInicio_Grafico";
            this.dataInicio_Grafico.Size = new System.Drawing.Size(96, 20);
            this.dataInicio_Grafico.TabIndex = 3;
            // 
            // btConsumo_TabelaDiaria
            // 
            this.btConsumo_TabelaDiaria.Location = new System.Drawing.Point(219, 5);
            this.btConsumo_TabelaDiaria.Name = "btConsumo_TabelaDiaria";
            this.btConsumo_TabelaDiaria.Size = new System.Drawing.Size(105, 22);
            this.btConsumo_TabelaDiaria.TabIndex = 3;
            this.btConsumo_TabelaDiaria.Text = "Calcular Consumo";
            this.btConsumo_TabelaDiaria.UseVisualStyleBackColor = true;
            this.btConsumo_TabelaDiaria.Click += new System.EventHandler(this.btConsumo_TabelaDiaria_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(439, 19);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(105, 22);
            this.button2.TabIndex = 12;
            this.button2.Text = "Calcular Consumo";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1174, 630);
            this.Controls.Add(this.panelTabelas);
            this.Controls.Add(this.panelGraficos);
            this.Controls.Add(this.panelSerial);
            this.Controls.Add(this.Menu);
            this.Controls.Add(this.panel1);
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmPrincipal_FormClosing);
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.Menu.ResumeLayout(false);
            this.panelSerial.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panelTabelas.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabGeral.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.TabelaGeral)).EndInit();
            this.tabDia.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.TabelaDiaria)).EndInit();
            this.tabPeriodo.ResumeLayout(false);
            this.tabPeriodo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TabelaPeriodo)).EndInit();
            this.panelGraficos.ResumeLayout(false);
            this.tabControl2.ResumeLayout(false);
            this.tabLive.ResumeLayout(false);
            this.tabLive.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GraficoLive)).EndInit();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GraficoDiario)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GraficoPeriodo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel Menu;
        private System.Windows.Forms.Button btGraficos;
        private System.Windows.Forms.Button btTabelas;
        private System.Windows.Forms.Button btSerial;
        private System.Windows.Forms.Panel panelSerial;
        private System.Windows.Forms.RichTextBox debugSerial;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btReload;
        private System.Windows.Forms.ComboBox boxHandshake;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox boxStopbits;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox boxParity;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox boxDatabits;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox boxBaudrate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox boxPort;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btOpen;
        private System.Windows.Forms.Panel panelTabelas;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabGeral;
        private System.Windows.Forms.Button btAtualizarTabelaGeral;
        private System.Windows.Forms.DataGridView TabelaGeral;
        private System.Windows.Forms.TabPage tabDia;
        private System.Windows.Forms.DataGridView TabelaDiaria;
        private System.Windows.Forms.Button btLoadDiaria;
        private System.Windows.Forms.DateTimePicker DataDiario_tabela;
        private System.Windows.Forms.TabPage tabPeriodo;
        private System.Windows.Forms.MaskedTextBox horaInicio_tabela;
        private System.Windows.Forms.Button btLoadPeriodo;
        private System.Windows.Forms.DataGridView TabelaPeriodo;
        private System.Windows.Forms.MaskedTextBox horaFim_tabela;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DateTimePicker dateFim_tabela;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DateTimePicker dateInicio_tabela;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panelGraficos;
        private System.Windows.Forms.TabControl tabControl2;
        private System.Windows.Forms.TabPage tabLive;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Panel pSensor2;
        private System.Windows.Forms.Panel pSensor1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Panel p2Sensor2;
        private System.Windows.Forms.Panel p2Sensor1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DateTimePicker DataDiario_grafico;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Panel p3Sensor2;
        private System.Windows.Forms.Panel p3Sensor1;
        private System.Windows.Forms.Label DataFinalTexto;
        private System.Windows.Forms.Label DataInicialTexto;
        private System.Windows.Forms.MaskedTextBox horaInicio_Grafico;
        private System.Windows.Forms.Button btCarregarPeriodo_Grafico;
        private System.Windows.Forms.MaskedTextBox horaFim_Grafico;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.DateTimePicker dataFim_Grafico;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.DateTimePicker dataInicio_Grafico;
        private System.Windows.Forms.DataVisualization.Charting.Chart GraficoLive;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataVisualization.Charting.Chart GraficoDiario;
        private System.Windows.Forms.DataVisualization.Charting.Chart GraficoPeriodo;
        private System.Windows.Forms.Button btConsumo_TabelaDiaria;
        private System.Windows.Forms.Button button2;
    }
}

