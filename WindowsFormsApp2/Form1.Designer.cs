
namespace WindowsFormsApp2
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.txtInputData = new System.Windows.Forms.RichTextBox();
            this.groupBox10 = new System.Windows.Forms.GroupBox();
            this.groupBox11 = new System.Windows.Forms.GroupBox();
            this.lblОбъёмВхДанных = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox13 = new System.Windows.Forms.GroupBox();
            this.chBoxAddNewData = new System.Windows.Forms.CheckBox();
            this.chBoxAlwaysUpdate = new System.Windows.Forms.CheckBox();
            this.btnОчиститьОкноВывода = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.lblОбъёмИсхДанных = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.chBoxИспользEnter = new System.Windows.Forms.CheckBox();
            this.chBoxWriteLine = new System.Windows.Forms.CheckBox();
            this.btnОтправитьДанные = new System.Windows.Forms.Button();
            this.btnОчиститьОкноВвода = new System.Windows.Forms.Button();
            this.txtBoxInputData = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chBoxRTS = new System.Windows.Forms.CheckBox();
            this.chBoxDTR = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBoxParityBits = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBoxStopBits = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.comboBoxDataBits = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.comboBoxBaud = new System.Windows.Forms.ComboBox();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.lblPortStatus = new System.Windows.Forms.Label();
            this.comboBoxCOM = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.progrOpening = new System.Windows.Forms.ProgressBar();
            this.btnClosePort = new System.Windows.Forms.Button();
            this.btnOpenPort = new System.Windows.Forms.Button();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.btnSaveIntoExcel = new System.Windows.Forms.Button();
            this.btnStopMeasure = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.textBoxSetRegValue = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxSeries = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.textBoxGetRegValue = new System.Windows.Forms.TextBox();
            this.comboBoxRegs = new System.Windows.Forms.ComboBox();
            this.btnAcceptRegChanges = new System.Windows.Forms.Button();
            this.chartITEC = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage2.SuspendLayout();
            this.groupBox9.SuspendLayout();
            this.groupBox10.SuspendLayout();
            this.groupBox11.SuspendLayout();
            this.groupBox13.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartITEC)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // serialPort1
            // 
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // timer
            // 
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBox9);
            this.tabPage2.Controls.Add(this.groupBox3);
            this.tabPage2.Controls.Add(this.groupBox1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage2.Size = new System.Drawing.Size(1440, 566);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Терминал";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox9
            // 
            this.groupBox9.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox9.Controls.Add(this.txtInputData);
            this.groupBox9.Controls.Add(this.groupBox10);
            this.groupBox9.Location = new System.Drawing.Point(588, 4);
            this.groupBox9.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox9.Size = new System.Drawing.Size(524, 445);
            this.groupBox9.TabIndex = 18;
            this.groupBox9.TabStop = false;
            this.groupBox9.Text = "Receiver Control";
            // 
            // txtInputData
            // 
            this.txtInputData.Location = new System.Drawing.Point(4, 15);
            this.txtInputData.Margin = new System.Windows.Forms.Padding(2);
            this.txtInputData.Name = "txtInputData";
            this.txtInputData.Size = new System.Drawing.Size(516, 226);
            this.txtInputData.TabIndex = 17;
            this.txtInputData.Text = "";
            // 
            // groupBox10
            // 
            this.groupBox10.Controls.Add(this.groupBox11);
            this.groupBox10.Controls.Add(this.groupBox13);
            this.groupBox10.Controls.Add(this.btnОчиститьОкноВывода);
            this.groupBox10.Location = new System.Drawing.Point(72, 244);
            this.groupBox10.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox10.Name = "groupBox10";
            this.groupBox10.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox10.Size = new System.Drawing.Size(386, 197);
            this.groupBox10.TabIndex = 15;
            this.groupBox10.TabStop = false;
            // 
            // groupBox11
            // 
            this.groupBox11.Controls.Add(this.lblОбъёмВхДанных);
            this.groupBox11.Controls.Add(this.label10);
            this.groupBox11.Location = new System.Drawing.Point(29, 116);
            this.groupBox11.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox11.Name = "groupBox11";
            this.groupBox11.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox11.Size = new System.Drawing.Size(350, 61);
            this.groupBox11.TabIndex = 16;
            this.groupBox11.TabStop = false;
            // 
            // lblОбъёмВхДанных
            // 
            this.lblОбъёмВхДанных.AutoSize = true;
            this.lblОбъёмВхДанных.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblОбъёмВхДанных.Location = new System.Drawing.Point(211, 24);
            this.lblОбъёмВхДанных.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblОбъёмВхДанных.Name = "lblОбъёмВхДанных";
            this.lblОбъёмВхДанных.Size = new System.Drawing.Size(24, 17);
            this.lblОбъёмВхДанных.TabIndex = 1;
            this.lblОбъёмВхДанных.Text = "00";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label10.Location = new System.Drawing.Point(90, 24);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(124, 17);
            this.label10.TabIndex = 0;
            this.label10.Text = "Data OUT Length:";
            // 
            // groupBox13
            // 
            this.groupBox13.Controls.Add(this.chBoxAddNewData);
            this.groupBox13.Controls.Add(this.chBoxAlwaysUpdate);
            this.groupBox13.Location = new System.Drawing.Point(193, 17);
            this.groupBox13.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox13.Name = "groupBox13";
            this.groupBox13.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox13.Size = new System.Drawing.Size(115, 84);
            this.groupBox13.TabIndex = 14;
            this.groupBox13.TabStop = false;
            // 
            // chBoxAddNewData
            // 
            this.chBoxAddNewData.AutoSize = true;
            this.chBoxAddNewData.Location = new System.Drawing.Point(5, 46);
            this.chBoxAddNewData.Margin = new System.Windows.Forms.Padding(2);
            this.chBoxAddNewData.Name = "chBoxAddNewData";
            this.chBoxAddNewData.Size = new System.Drawing.Size(106, 17);
            this.chBoxAddNewData.TabIndex = 1;
            this.chBoxAddNewData.Text = "Add To Old Data";
            this.chBoxAddNewData.UseVisualStyleBackColor = true;
            this.chBoxAddNewData.CheckedChanged += new System.EventHandler(this.chBoxAddNewData_CheckedChanged);
            // 
            // chBoxAlwaysUpdate
            // 
            this.chBoxAlwaysUpdate.AutoSize = true;
            this.chBoxAlwaysUpdate.Location = new System.Drawing.Point(5, 24);
            this.chBoxAlwaysUpdate.Margin = new System.Windows.Forms.Padding(2);
            this.chBoxAlwaysUpdate.Name = "chBoxAlwaysUpdate";
            this.chBoxAlwaysUpdate.Size = new System.Drawing.Size(97, 17);
            this.chBoxAlwaysUpdate.TabIndex = 0;
            this.chBoxAlwaysUpdate.Text = "Always Update";
            this.chBoxAlwaysUpdate.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.chBoxAlwaysUpdate.UseVisualStyleBackColor = true;
            this.chBoxAlwaysUpdate.CheckedChanged += new System.EventHandler(this.chBoxAlwaysUpdate_CheckedChanged);
            // 
            // btnОчиститьОкноВывода
            // 
            this.btnОчиститьОкноВывода.Location = new System.Drawing.Point(41, 17);
            this.btnОчиститьОкноВывода.Margin = new System.Windows.Forms.Padding(2);
            this.btnОчиститьОкноВывода.Name = "btnОчиститьОкноВывода";
            this.btnОчиститьОкноВывода.Size = new System.Drawing.Size(100, 84);
            this.btnОчиститьОкноВывода.TabIndex = 13;
            this.btnОчиститьОкноВывода.Text = "Clear Data IN";
            this.btnОчиститьОкноВывода.UseVisualStyleBackColor = true;
            this.btnОчиститьОкноВывода.Click += new System.EventHandler(this.btnClearOutWindow_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.groupBox4);
            this.groupBox3.Controls.Add(this.txtBoxInputData);
            this.groupBox3.Location = new System.Drawing.Point(216, 4);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox3.Size = new System.Drawing.Size(368, 344);
            this.groupBox3.TabIndex = 17;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Transmitter Control";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.groupBox7);
            this.groupBox4.Controls.Add(this.groupBox5);
            this.groupBox4.Controls.Add(this.btnОтправитьДанные);
            this.groupBox4.Controls.Add(this.btnОчиститьОкноВвода);
            this.groupBox4.Location = new System.Drawing.Point(4, 147);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox4.Size = new System.Drawing.Size(358, 192);
            this.groupBox4.TabIndex = 14;
            this.groupBox4.TabStop = false;
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.lblОбъёмИсхДанных);
            this.groupBox7.Controls.Add(this.label6);
            this.groupBox7.Location = new System.Drawing.Point(4, 116);
            this.groupBox7.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox7.Size = new System.Drawing.Size(350, 61);
            this.groupBox7.TabIndex = 16;
            this.groupBox7.TabStop = false;
            // 
            // lblОбъёмИсхДанных
            // 
            this.lblОбъёмИсхДанных.AutoSize = true;
            this.lblОбъёмИсхДанных.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblОбъёмИсхДанных.Location = new System.Drawing.Point(211, 24);
            this.lblОбъёмИсхДанных.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblОбъёмИсхДанных.Name = "lblОбъёмИсхДанных";
            this.lblОбъёмИсхДанных.Size = new System.Drawing.Size(24, 17);
            this.lblОбъёмИсхДанных.TabIndex = 1;
            this.lblОбъёмИсхДанных.Text = "00";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label6.Location = new System.Drawing.Point(90, 24);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(107, 17);
            this.label6.TabIndex = 0;
            this.label6.Text = "Data IN Length:";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.chBoxИспользEnter);
            this.groupBox5.Controls.Add(this.chBoxWriteLine);
            this.groupBox5.Location = new System.Drawing.Point(121, 10);
            this.groupBox5.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox5.Size = new System.Drawing.Size(232, 84);
            this.groupBox5.TabIndex = 14;
            this.groupBox5.TabStop = false;
            // 
            // chBoxИспользEnter
            // 
            this.chBoxИспользEnter.AutoSize = true;
            this.chBoxИспользEnter.Location = new System.Drawing.Point(74, 16);
            this.chBoxИспользEnter.Margin = new System.Windows.Forms.Padding(2);
            this.chBoxИспользEnter.Name = "chBoxИспользEnter";
            this.chBoxИспользEnter.Size = new System.Drawing.Size(81, 17);
            this.chBoxИспользEnter.TabIndex = 1;
            this.chBoxИспользEnter.Text = "Using Enter";
            this.chBoxИспользEnter.UseVisualStyleBackColor = true;
            // 
            // chBoxWriteLine
            // 
            this.chBoxWriteLine.AutoSize = true;
            this.chBoxWriteLine.Location = new System.Drawing.Point(74, 37);
            this.chBoxWriteLine.Margin = new System.Windows.Forms.Padding(2);
            this.chBoxWriteLine.Name = "chBoxWriteLine";
            this.chBoxWriteLine.Size = new System.Drawing.Size(71, 17);
            this.chBoxWriteLine.TabIndex = 0;
            this.chBoxWriteLine.Text = "WriteLine";
            this.chBoxWriteLine.UseVisualStyleBackColor = true;
            // 
            // btnОтправитьДанные
            // 
            this.btnОтправитьДанные.Location = new System.Drawing.Point(4, 10);
            this.btnОтправитьДанные.Margin = new System.Windows.Forms.Padding(2);
            this.btnОтправитьДанные.Name = "btnОтправитьДанные";
            this.btnОтправитьДанные.Size = new System.Drawing.Size(100, 33);
            this.btnОтправитьДанные.TabIndex = 11;
            this.btnОтправитьДанные.Text = "Send Data";
            this.btnОтправитьДанные.UseVisualStyleBackColor = true;
            this.btnОтправитьДанные.Click += new System.EventHandler(this.btnSendData_Click);
            // 
            // btnОчиститьОкноВвода
            // 
            this.btnОчиститьОкноВвода.Location = new System.Drawing.Point(4, 48);
            this.btnОчиститьОкноВвода.Margin = new System.Windows.Forms.Padding(2);
            this.btnОчиститьОкноВвода.Name = "btnОчиститьОкноВвода";
            this.btnОчиститьОкноВвода.Size = new System.Drawing.Size(100, 33);
            this.btnОчиститьОкноВвода.TabIndex = 13;
            this.btnОчиститьОкноВвода.Text = "Clear Data OUT";
            this.btnОчиститьОкноВвода.UseVisualStyleBackColor = true;
            this.btnОчиститьОкноВвода.Click += new System.EventHandler(this.btnОчиститьОкноВвода_Click);
            // 
            // txtBoxInputData
            // 
            this.txtBoxInputData.Location = new System.Drawing.Point(4, 15);
            this.txtBoxInputData.Margin = new System.Windows.Forms.Padding(2);
            this.txtBoxInputData.Multiline = true;
            this.txtBoxInputData.Name = "txtBoxInputData";
            this.txtBoxInputData.Size = new System.Drawing.Size(360, 126);
            this.txtBoxInputData.TabIndex = 12;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.chBoxRTS);
            this.groupBox1.Controls.Add(this.chBoxDTR);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.comboBoxParityBits);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.comboBoxStopBits);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.comboBoxDataBits);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.comboBoxBaud);
            this.groupBox1.Location = new System.Drawing.Point(2, 4);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(209, 219);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "CP Control";
            // 
            // chBoxRTS
            // 
            this.chBoxRTS.AutoSize = true;
            this.chBoxRTS.Location = new System.Drawing.Point(108, 163);
            this.chBoxRTS.Margin = new System.Windows.Forms.Padding(2);
            this.chBoxRTS.Name = "chBoxRTS";
            this.chBoxRTS.Size = new System.Drawing.Size(93, 17);
            this.chBoxRTS.TabIndex = 11;
            this.chBoxRTS.Text = "RTS ENABLE";
            this.chBoxRTS.UseVisualStyleBackColor = true;
            this.chBoxRTS.CheckedChanged += new System.EventHandler(this.chBoxRTS_CheckedChanged);
            // 
            // chBoxDTR
            // 
            this.chBoxDTR.AutoSize = true;
            this.chBoxDTR.Location = new System.Drawing.Point(11, 163);
            this.chBoxDTR.Margin = new System.Windows.Forms.Padding(2);
            this.chBoxDTR.Name = "chBoxDTR";
            this.chBoxDTR.Size = new System.Drawing.Size(94, 17);
            this.chBoxDTR.TabIndex = 10;
            this.chBoxDTR.Text = "DTR ENABLE";
            this.chBoxDTR.UseVisualStyleBackColor = true;
            this.chBoxDTR.CheckedChanged += new System.EventHandler(this.chBoxDTR_CheckedChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 128);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Parity Bits";
            // 
            // comboBoxParityBits
            // 
            this.comboBoxParityBits.FormattingEnabled = true;
            this.comboBoxParityBits.Location = new System.Drawing.Point(70, 124);
            this.comboBoxParityBits.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxParityBits.Name = "comboBoxParityBits";
            this.comboBoxParityBits.Size = new System.Drawing.Size(126, 21);
            this.comboBoxParityBits.TabIndex = 8;
            this.comboBoxParityBits.Text = "None";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 102);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Stop Bits";
            // 
            // comboBoxStopBits
            // 
            this.comboBoxStopBits.FormattingEnabled = true;
            this.comboBoxStopBits.Items.AddRange(new object[] {
            "One",
            "Two"});
            this.comboBoxStopBits.Location = new System.Drawing.Point(70, 99);
            this.comboBoxStopBits.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxStopBits.Name = "comboBoxStopBits";
            this.comboBoxStopBits.Size = new System.Drawing.Size(126, 21);
            this.comboBoxStopBits.TabIndex = 6;
            this.comboBoxStopBits.Text = "One";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(9, 77);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 13);
            this.label7.TabIndex = 5;
            this.label7.Text = "Data Bits";
            // 
            // comboBoxDataBits
            // 
            this.comboBoxDataBits.FormattingEnabled = true;
            this.comboBoxDataBits.Items.AddRange(new object[] {
            "5",
            "6",
            "7",
            "8"});
            this.comboBoxDataBits.Location = new System.Drawing.Point(70, 75);
            this.comboBoxDataBits.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxDataBits.Name = "comboBoxDataBits";
            this.comboBoxDataBits.Size = new System.Drawing.Size(126, 21);
            this.comboBoxDataBits.TabIndex = 4;
            this.comboBoxDataBits.Text = "8";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(9, 53);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(58, 13);
            this.label8.TabIndex = 3;
            this.label8.Text = "Baud Rate";
            // 
            // comboBoxBaud
            // 
            this.comboBoxBaud.FormattingEnabled = true;
            this.comboBoxBaud.Items.AddRange(new object[] {
            "2400",
            "4800",
            "9600",
            "14400",
            "19200",
            "38400",
            "57600",
            "115200"});
            this.comboBoxBaud.Location = new System.Drawing.Point(70, 50);
            this.comboBoxBaud.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxBaud.Name = "comboBoxBaud";
            this.comboBoxBaud.Size = new System.Drawing.Size(126, 21);
            this.comboBoxBaud.TabIndex = 2;
            this.comboBoxBaud.Text = "115200";
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.groupBox6);
            this.tabPage1.Controls.Add(this.chartITEC);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage1.Size = new System.Drawing.Size(1440, 566);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "График";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox2.Controls.Add(this.groupBox8);
            this.groupBox2.Controls.Add(this.comboBoxCOM);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.progrOpening);
            this.groupBox2.Controls.Add(this.btnClosePort);
            this.groupBox2.Controls.Add(this.btnOpenPort);
            this.groupBox2.Location = new System.Drawing.Point(4, 433);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(197, 123);
            this.groupBox2.TabIndex = 37;
            this.groupBox2.TabStop = false;
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.lblPortStatus);
            this.groupBox8.Location = new System.Drawing.Point(80, 32);
            this.groupBox8.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox8.Size = new System.Drawing.Size(113, 64);
            this.groupBox8.TabIndex = 14;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "COM Статус";
            // 
            // lblPortStatus
            // 
            this.lblPortStatus.AutoSize = true;
            this.lblPortStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblPortStatus.Location = new System.Drawing.Point(32, 27);
            this.lblPortStatus.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPortStatus.Name = "lblPortStatus";
            this.lblPortStatus.Size = new System.Drawing.Size(41, 20);
            this.lblPortStatus.TabIndex = 0;
            this.lblPortStatus.Text = "OFF";
            // 
            // comboBoxCOM
            // 
            this.comboBoxCOM.FormattingEnabled = true;
            this.comboBoxCOM.Location = new System.Drawing.Point(67, 10);
            this.comboBoxCOM.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxCOM.Name = "comboBoxCOM";
            this.comboBoxCOM.Size = new System.Drawing.Size(126, 21);
            this.comboBoxCOM.TabIndex = 35;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(5, 13);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(50, 13);
            this.label9.TabIndex = 36;
            this.label9.Text = "Com Port";
            // 
            // progrOpening
            // 
            this.progrOpening.Location = new System.Drawing.Point(5, 100);
            this.progrOpening.Margin = new System.Windows.Forms.Padding(2);
            this.progrOpening.Name = "progrOpening";
            this.progrOpening.Size = new System.Drawing.Size(188, 19);
            this.progrOpening.TabIndex = 2;
            // 
            // btnClosePort
            // 
            this.btnClosePort.Location = new System.Drawing.Point(5, 67);
            this.btnClosePort.Margin = new System.Windows.Forms.Padding(2);
            this.btnClosePort.Name = "btnClosePort";
            this.btnClosePort.Size = new System.Drawing.Size(71, 29);
            this.btnClosePort.TabIndex = 1;
            this.btnClosePort.Text = "Закрыть";
            this.btnClosePort.UseVisualStyleBackColor = true;
            this.btnClosePort.Click += new System.EventHandler(this.btnClosePort_Click);
            // 
            // btnOpenPort
            // 
            this.btnOpenPort.Location = new System.Drawing.Point(4, 33);
            this.btnOpenPort.Margin = new System.Windows.Forms.Padding(2);
            this.btnOpenPort.Name = "btnOpenPort";
            this.btnOpenPort.Size = new System.Drawing.Size(72, 30);
            this.btnOpenPort.TabIndex = 0;
            this.btnOpenPort.Text = "Открыть";
            this.btnOpenPort.UseVisualStyleBackColor = true;
            this.btnOpenPort.Click += new System.EventHandler(this.btnOpenPort_Click);
            // 
            // groupBox6
            // 
            this.groupBox6.AutoSize = true;
            this.groupBox6.Controls.Add(this.btnSaveIntoExcel);
            this.groupBox6.Controls.Add(this.btnStopMeasure);
            this.groupBox6.Controls.Add(this.label12);
            this.groupBox6.Controls.Add(this.textBoxSetRegValue);
            this.groupBox6.Controls.Add(this.label11);
            this.groupBox6.Controls.Add(this.label2);
            this.groupBox6.Controls.Add(this.comboBoxSeries);
            this.groupBox6.Controls.Add(this.label3);
            this.groupBox6.Controls.Add(this.button1);
            this.groupBox6.Controls.Add(this.textBoxGetRegValue);
            this.groupBox6.Controls.Add(this.comboBoxRegs);
            this.groupBox6.Controls.Add(this.btnAcceptRegChanges);
            this.groupBox6.Location = new System.Drawing.Point(2, 2);
            this.groupBox6.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox6.Size = new System.Drawing.Size(256, 382);
            this.groupBox6.TabIndex = 34;
            this.groupBox6.TabStop = false;
            // 
            // btnSaveIntoExcel
            // 
            this.btnSaveIntoExcel.Location = new System.Drawing.Point(57, 265);
            this.btnSaveIntoExcel.Name = "btnSaveIntoExcel";
            this.btnSaveIntoExcel.Size = new System.Drawing.Size(138, 45);
            this.btnSaveIntoExcel.TabIndex = 43;
            this.btnSaveIntoExcel.Text = "Сохранить в Excel";
            this.btnSaveIntoExcel.UseVisualStyleBackColor = true;
            this.btnSaveIntoExcel.Click += new System.EventHandler(this.btnSaveIntoExcel_Click);
            // 
            // btnStopMeasure
            // 
            this.btnStopMeasure.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnStopMeasure.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnStopMeasure.Location = new System.Drawing.Point(57, 315);
            this.btnStopMeasure.Margin = new System.Windows.Forms.Padding(2);
            this.btnStopMeasure.Name = "btnStopMeasure";
            this.btnStopMeasure.Size = new System.Drawing.Size(138, 50);
            this.btnStopMeasure.TabIndex = 40;
            this.btnStopMeasure.Text = "Остановить измерения";
            this.btnStopMeasure.UseVisualStyleBackColor = true;
            this.btnStopMeasure.Click += new System.EventHandler(this.btnStopMeasure_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(149, 178);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(85, 13);
            this.label12.TabIndex = 42;
            this.label12.Text = "Треб. значение";
            // 
            // textBoxSetRegValue
            // 
            this.textBoxSetRegValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxSetRegValue.Location = new System.Drawing.Point(145, 193);
            this.textBoxSetRegValue.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxSetRegValue.Name = "textBoxSetRegValue";
            this.textBoxSetRegValue.Size = new System.Drawing.Size(89, 21);
            this.textBoxSetRegValue.TabIndex = 41;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(17, 178);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(79, 13);
            this.label11.TabIndex = 40;
            this.label11.Text = "Тек. значение";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(47, 69);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(152, 13);
            this.label2.TabIndex = 39;
            this.label2.Text = "Выбор выводимого графика";
            // 
            // comboBoxSeries
            // 
            this.comboBoxSeries.FormattingEnabled = true;
            this.comboBoxSeries.Location = new System.Drawing.Point(57, 84);
            this.comboBoxSeries.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxSeries.Name = "comboBoxSeries";
            this.comboBoxSeries.Size = new System.Drawing.Size(138, 21);
            this.comboBoxSeries.TabIndex = 38;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(63, 134);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 13);
            this.label3.TabIndex = 24;
            this.label3.Text = "Настройка параметров";
            // 
            // button1
            // 
            this.button1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button1.Location = new System.Drawing.Point(57, 17);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(138, 50);
            this.button1.TabIndex = 33;
            this.button1.Text = "Начать измерения";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btnStartMeasure_Click);
            // 
            // textBoxGetRegValue
            // 
            this.textBoxGetRegValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxGetRegValue.Location = new System.Drawing.Point(20, 193);
            this.textBoxGetRegValue.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxGetRegValue.Name = "textBoxGetRegValue";
            this.textBoxGetRegValue.Size = new System.Drawing.Size(89, 21);
            this.textBoxGetRegValue.TabIndex = 22;
            // 
            // comboBoxRegs
            // 
            this.comboBoxRegs.FormattingEnabled = true;
            this.comboBoxRegs.Location = new System.Drawing.Point(57, 149);
            this.comboBoxRegs.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxRegs.Name = "comboBoxRegs";
            this.comboBoxRegs.Size = new System.Drawing.Size(138, 21);
            this.comboBoxRegs.TabIndex = 23;
            this.comboBoxRegs.SelectedIndexChanged += new System.EventHandler(this.comboBoxRegs_SelectedIndexChanged);
            // 
            // btnAcceptRegChanges
            // 
            this.btnAcceptRegChanges.Location = new System.Drawing.Point(57, 218);
            this.btnAcceptRegChanges.Margin = new System.Windows.Forms.Padding(2);
            this.btnAcceptRegChanges.Name = "btnAcceptRegChanges";
            this.btnAcceptRegChanges.Size = new System.Drawing.Size(138, 42);
            this.btnAcceptRegChanges.TabIndex = 25;
            this.btnAcceptRegChanges.Text = "Принять изменения";
            this.btnAcceptRegChanges.UseVisualStyleBackColor = true;
            this.btnAcceptRegChanges.Click += new System.EventHandler(this.btnAcceptRegChanges_Click);
            // 
            // chartITEC
            // 
            this.chartITEC.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea1.Name = "ChartArea1";
            this.chartITEC.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartITEC.Legends.Add(legend1);
            this.chartITEC.Location = new System.Drawing.Point(258, 22);
            this.chartITEC.Margin = new System.Windows.Forms.Padding(2);
            this.chartITEC.Name = "chartITEC";
            series1.BackImageTransparentColor = System.Drawing.Color.Transparent;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Legend = "Legend1";
            series1.Name = "I(TEC)";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.Legend = "Legend1";
            series2.Name = "I(LD)";
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series3.Legend = "Legend1";
            series3.Name = "P(BFM)";
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series4.Legend = "Legend1";
            series4.Name = "P(ACE)";
            series5.ChartArea = "ChartArea1";
            series5.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series5.Legend = "Legend1";
            series5.Name = "THERM";
            series6.ChartArea = "ChartArea1";
            series6.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series6.Legend = "Legend1";
            series6.Name = "LAMBDA";
            this.chartITEC.Series.Add(series1);
            this.chartITEC.Series.Add(series2);
            this.chartITEC.Series.Add(series3);
            this.chartITEC.Series.Add(series4);
            this.chartITEC.Series.Add(series5);
            this.chartITEC.Series.Add(series6);
            this.chartITEC.Size = new System.Drawing.Size(1156, 533);
            this.chartITEC.TabIndex = 27;
            this.chartITEC.Text = "chartITEC";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(211, 37);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.MinimumSize = new System.Drawing.Size(112, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 13);
            this.label1.TabIndex = 15;
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(-2, -2);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1448, 592);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(1440, 566);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "tabPage3";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1436, 589);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MinimumSize = new System.Drawing.Size(1452, 628);
            this.Name = "Form1";
            this.Text = "Device Control";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabPage2.ResumeLayout(false);
            this.groupBox9.ResumeLayout(false);
            this.groupBox10.ResumeLayout(false);
            this.groupBox11.ResumeLayout(false);
            this.groupBox11.PerformLayout();
            this.groupBox13.ResumeLayout(false);
            this.groupBox13.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox8.ResumeLayout(false);
            this.groupBox8.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartITEC)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox groupBox9;
        private System.Windows.Forms.RichTextBox txtInputData;
        private System.Windows.Forms.GroupBox groupBox10;
        private System.Windows.Forms.GroupBox groupBox11;
        private System.Windows.Forms.Label lblОбъёмВхДанных;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox groupBox13;
        private System.Windows.Forms.CheckBox chBoxAddNewData;
        private System.Windows.Forms.CheckBox chBoxAlwaysUpdate;
        private System.Windows.Forms.Button btnОчиститьОкноВывода;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.Label lblОбъёмИсхДанных;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox chBoxWriteLine;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.CheckBox chBoxИспользEnter;
        private System.Windows.Forms.Button btnОтправитьДанные;
        private System.Windows.Forms.Button btnОчиститьОкноВвода;
        private System.Windows.Forms.TextBox txtBoxInputData;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox chBoxRTS;
        private System.Windows.Forms.CheckBox chBoxDTR;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBoxParityBits;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBoxStopBits;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox comboBoxDataBits;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox comboBoxBaud;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartITEC;
        private System.Windows.Forms.Button btnAcceptRegChanges;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBoxRegs;
        private System.Windows.Forms.TextBox textBoxGetRegValue;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox comboBoxCOM;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.Label lblPortStatus;
        private System.Windows.Forms.ProgressBar progrOpening;
        private System.Windows.Forms.Button btnClosePort;
        private System.Windows.Forms.Button btnOpenPort;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxSeries;
        private System.Windows.Forms.Button btnStopMeasure;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox textBoxSetRegValue;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button btnSaveIntoExcel;
    }
}

