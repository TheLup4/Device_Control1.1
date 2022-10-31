using System;
using System.Collections.Generic;
using System.IO;
using System.Diagnostics;
using System.Windows.Forms;
using System.IO.Ports;
using System.Drawing;
using System.Windows.Forms.DataVisualization.Charting;
using System.Linq;
using System.Threading.Tasks;

namespace WindowsFormsApp2
{

    public partial class Form1 : Form
    {
        bool expectationChart;
        private string dataOUT, sendWidth, dataIn;
        public double[,] data;
        public List<string> graphY = new List<string>();
        public List<string> regList = new List<string>();
        int limitTemp = 35;
        int chartPosX = 0, chartPosY = 0, chartWidth=0,chartHeight=0;
        public Form1()
        {
            InitializeComponent();
            ClientSize = new Size(1125, 550);
            StartPosition = FormStartPosition.CenterScreen;
            
            //Красивое движение графиков (Выбор и развертка)

           /* chartITEC.Click+= async (s, a) =>
                {
                    while (!expectationChart && chartITEC.Location.X > 5 && chartITEC.Location.Y>5)
                    {

                        if (chartPosX==0)
                        {
                            chartPosX = chartITEC.Location.X;
                            chartPosY = chartITEC.Location.Y;

                        }
                        await Task.Delay(1);
                        expectationChart = true;
                        chartITEC.Location = new Point(chartITEC.Location.X - chartITEC.Location.X/20-1, chartITEC.Location.Y - chartITEC.Location.Y / 10 - 1);
                        
                        expectationChart = false;
                        
                    }
                    chartITEC.Size = new Size(Width = 850, Height = 380);
                };
            chartITEC.DoubleClick += async (s, a) =>
                {
                    chartITEC.Size = new Size(Width = 200, Height = 100);
                    while (!expectationChart && chartITEC.Location.X <= chartPosX&& chartITEC.Location.Y <= chartPosY)
                    {
                        expectationChart = true;
                        await Task.Delay(1);
                        chartITEC.Location = new Point(chartITEC.Location.X+(chartPosX- chartITEC.Location.X)/10+1, chartITEC.Location.Y + (chartPosY - chartITEC.Location.Y) / 10 + 1);
                        expectationChart = false;
                    }

                    
                };
            //конец*/
        }
        private void Form1_Load(object sender, EventArgs e)
        {
           ClientSize = new Size(1125, 550);
            KeyPreview = true;
           
            chartITEC.ChartAreas[0].AxisX.Title = "Time, s";
            chartITEC.ChartAreas[0].AxisX.Minimum = 0;
            string path1 = @"C:\Files\RegData.txt";
            string path2 = @"C:\Files\RegNames.txt";

            GetRegs(regList);
            foreach (string reg in regList)
            {
                comboBox2.Items.Add(reg);
            }
            comboBox2.Items.Add(regList);

            GetRegValue(regList);//значения регистров



            string[] ports = SerialPort.GetPortNames();
            comboBoxCOM.Items.AddRange(ports);

            btnОткрытьПорт.Enabled = true;
            btnЗакрытьПорт.Enabled = false;

            chBoxDTR.Checked = false;
            serialPort1.DtrEnable = false;

            chBoxRTS.Checked = false;
            serialPort1.RtsEnable = false;
            btnОтправитьДанные.Enabled = true;
            chBoxWrite.Checked = true;
            chBoxWriteLine.Checked = false;
            sendWidth = "Write";

            chBoxОбновлятьВсегда.Checked = false;
            chBoxДобавлятьНовыеДанные.Checked = true;

            //Настройка графика 1
            timer.Enabled = false;
            chartITEC.ChartAreas[0].AxisX.LabelStyle.Format = "H:mm:ss";
            chartITEC.Series[0].XValueType = ChartValueType.DateTime;
            chartITEC.ChartAreas[0].AxisX.Minimum = DateTime.Now.ToOADate();
            chartITEC.ChartAreas[0].AxisX.IntervalType = DateTimeIntervalType.Seconds;
            chartITEC.ChartAreas[0].AxisX.Interval = 5;
        }
        //СТраница терминала
        private void btnОткрытьПорт_Click(object sender, EventArgs e)
        {
            try
            {
                serialPort1.PortName = comboBoxCOM.Text;
                serialPort1.BaudRate = Convert.ToInt32(comboBoxBaud.Text);
                serialPort1.DataBits = Convert.ToInt32(comboBoxDataBits.Text);
                serialPort1.StopBits = (StopBits)Enum.Parse(typeof(StopBits), comboBoxStopBits.Text);
                serialPort1.Parity = (Parity)Enum.Parse(typeof(Parity), comboBoxParityBits.Text);
                serialPort1.Open();
                progrОткрытие.Value = 100;
                btnОткрытьПорт.Enabled = false;
                btnЗакрытьПорт.Enabled = true;
                lblСтатусПорта.Text = "ON";

            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                btnОткрытьПорт.Enabled = true;
                btnЗакрытьПорт.Enabled = false;
                lblСтатусПорта.Text = "OFF";
            }
        }

        private void btnЗакрытьПорт_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                serialPort1.Close();
                progrОткрытие.Value = 0;
                btnОткрытьПорт.Enabled = true;
                btnЗакрытьПорт.Enabled = false;
                lblСтатусПорта.Text = "OFF";
            }
        }

        private void btnОтправитьДанные_Click(object sender, EventArgs e)
        {
            serialPort1.DiscardInBuffer();
            serialPort1.DiscardOutBuffer();
            if (serialPort1.IsOpen)
            {
                dataOUT = txtBoxВводДанных.Text;
                if (sendWidth == "WriteLine")
                {
                    serialPort1.WriteLine(dataOUT);
                }
                else if (sendWidth == "Write")
                {
                    serialPort1.Write(dataOUT);
                }

            }
        }

        private void chBoxDTR_CheckedChanged(object sender, EventArgs e)
        {
            if (chBoxDTR.Checked)
            {
                serialPort1.DtrEnable = true;
                MessageBox.Show("DTR Enable", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else { serialPort1.DtrEnable = false; }
        }

        private void chBoxRTS_CheckedChanged(object sender, EventArgs e)
        {

            if (chBoxRTS.Checked)
            {
                serialPort1.RtsEnable = true;
                MessageBox.Show("RTS Enable", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else { serialPort1.RtsEnable = false; }
        }

        private void btnОчиститьОкноВвода_Click(object sender, EventArgs e)
        {
            if (txtBoxВводДанных.Text != "")
            {
                txtBoxВводДанных.Text = "";
            }
        }

        private void txtBoxВводДанных_TextChanged(object sender, EventArgs e)
        {

        }


        private void txtBoxВводДанных_KeyDown(object sender, KeyEventArgs e)
        {
            if (chBoxИспользEnter.Checked == true)
            {
                if (e.KeyCode == Keys.Enter)
                {
                    dataOUT = txtBoxВводДанных.Text;
                    if (sendWidth == "Write")
                    {
                        serialPort1.WriteLine(dataOUT);
                    }
                    else if (sendWidth == "WriteLine")
                    {
                        serialPort1.Write(dataOUT);
                    }
                }
            }
        }

        private void chBoxWriteLine_CheckedChanged(object sender, EventArgs e)
        {
            if (chBoxWriteLine.Checked)
            {
                sendWidth = "WriteLine";
                chBoxWrite.Checked = false;
                chBoxWriteLine.Checked = true;
            }
        }

        private void chBoxWrite_CheckedChanged(object sender, EventArgs e)
        {
            if (chBoxWrite.Checked)
            {
                sendWidth = "Write";
                chBoxWrite.Checked = true;
                chBoxWriteLine.Checked = false;
            }
        }

        private void serialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            dataIn = serialPort1.ReadLine();
            this.Invoke(new EventHandler(ShowData));
        }
        private List<double> ITEC = new List<double>();
        private List<double> ILD= new List<double>();
        private List<double> PBFM = new List<double>();
        private List<double> PACE = new List<double>();
        private List<double> THERM = new List<double>();
        private List<double> LAMBDA = new List<double>();
        private double[] masZnach = new double[6];
        private void ShowData(object sender, EventArgs e)
        {
            int dataINLength = dataIn.Length;
            
            lblОбъёмВхДанных.Text = string.Format("{0:00}", dataINLength);

            if (chBoxОбновлятьВсегда.Checked)
            {
                txtВходящиеДанные.Text = dataIn;
                File.WriteAllText(@"C:\Files\TERMINAL.txt", txtВходящиеДанные.Text);
            }
            else if (chBoxДобавлятьНовыеДанные.Checked)
            {
                txtВходящиеДанные.Text += dataIn;
                File.WriteAllText(@"C:\Files\TERMINAL.txt", txtВходящиеДанные.Text);
            }
            dataIn = dataIn.Replace(',', ' ');
            dataIn = dataIn.Replace('.', ',');
            
                graphY.Add(dataIn);
            graphY.RemoveAll(s => s == "");
            if (graphY.Count != 0)
            {
                if (graphY[graphY.Count - 1].Contains("asecm> mon") 
                    || graphY[graphY.Count - 1].Contains("mon") 
                    || graphY[graphY.Count - 1].Contains("asecm>"))
                {
                    graphY.Remove(graphY[graphY.Count - 1]);
                }
            }

            if (graphY.Count != 0&&graphY[graphY.Count - 1].Any(c => char.IsLetter(c)))
                {
                    graphY.Remove(graphY[graphY.Count - 1]);
                }
                if (graphY.Count != 0&&graphY[graphY.Count - 1].Contains('/'))
                {
                    graphY[graphY.Count - 1] = graphY[graphY.Count - 1]
                        .Remove(graphY[graphY.Count - 1].Length - 2);
                }
            if (graphY.Count != 0)
            {
                for (int j = 0; j < 6; j++)
                {
                    string[] arr = graphY[graphY.Count - 1].Split(' ');
                    if (arr.Length > 2)
                        masZnach[j] = double.Parse(arr[j]);
                }
            }

            ITEC.Add(masZnach[0]);
            ILD.Add(masZnach[1]);
            PBFM.Add(masZnach[2]);
            PACE.Add(masZnach[3]);
            THERM.Add(masZnach[4]);
            LAMBDA.Add(masZnach[5]);

        }

        

        private void timer_Tick(object sender, EventArgs e)
        {
            DateTime timeNow = DateTime.Now;
            if (ITEC.Count != 0)
            {
                chartITEC.Series[0].Points.AddXY(timeNow, ITEC[ITEC.Count - 1]);
                chartILD.Series[0].Points.AddXY(timeNow, ILD[ILD.Count - 1]);
                chart3.Series[0].Points.AddXY(timeNow, PBFM[PBFM.Count - 1]);
                chart4.Series[0].Points.AddXY(timeNow, PACE[PACE.Count - 1]);
                chart5.Series[0].Points.AddXY(timeNow, THERM[THERM.Count - 1]);
                chart6.Series[0].Points.AddXY(timeNow, LAMBDA[LAMBDA.Count - 1]);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer.Enabled=true;
        }

        private void chBoxОбновлятьВсегда_CheckedChanged(object sender, EventArgs e)//alw update
        {
            if (chBoxОбновлятьВсегда.Checked)
            {
                chBoxОбновлятьВсегда.Checked = true;
                chBoxДобавлятьНовыеДанные.Checked = false;
            }
            else { chBoxДобавлятьНовыеДанные.Checked = true; }
        }

        private void chBoxДобавлятьНовыеДанные_CheckedChanged(object sender, EventArgs e)
        {

            if (chBoxДобавлятьНовыеДанные.Checked)
            {
                chBoxОбновлятьВсегда.Checked = false;
                chBoxДобавлятьНовыеДанные.Checked = true;
            }
            else { chBoxОбновлятьВсегда.Checked = true; }
        }

        private void btnОчиститьОкноВывода_Click(object sender, EventArgs e)
        {
            if (txtВходящиеДанные.Text != "")
            {
                txtВходящиеДанные.Text = "";
            }
            File.Delete(@"C:\Files\TERMINAL.txt");


        }
        private List<string> GetRegs(List<string> regs)
        {
            regs.Add("Monitoring time [s]");
            regs.Add("DAC0 setup value []");
            regs.Add("TEC temperature setup value [C]");
            regs.Add("LD current MAX [mA]");
            regs.Add("LD current loop gain");
            regs.Add("LD current loop saturation level");
            regs.Add("PUMP power level [mW]");
            regs.Add("PUMP power loop P gain");
            regs.Add("PUMP power loop I gain");
            regs.Add("PUMP control strategy (2: LD CURR, 3: ASE POW)");
            regs.Add("Filter");
            regs.Add("I saturation");
            regs.Add("PD ASE Load Gain (Resp * Coupl_Factor)");
            regs.Add("PD BFM Load Gain (Resp )");
            regs.Add("PD ASE OpAmp Gain (R28)");
            regs.Add("PD BFM OpAmp Gain (R30)");
            regs.Add("Current reg Gain(mA/V)");
            regs.Add("Main thermistor A factor");
            regs.Add("Main thermistor B factor");
            regs.Add("Main thermistor C factor");
            regs.Add("Main thermistor R value");
            regs.Add("Aux thermistor A factor");
            regs.Add("Aux thermistor B factor");
            regs.Add("Aux thermistor C factor");
            regs.Add("Aux thermistor R value");
            regs.Add("ASE thermal proportional factor");
            regs.Add("ASE thermal offset");
            regs.Add("ASE thermal square factor");
            regs.Add("PWM max value");
            regs.Add("Therm PID P");
            regs.Add("Therm PID I");
            regs.Add("Therm PID D");
            regs.Add("Therm PID D period");
            regs.Add("K_OTR");
            regs.Add("K_OTR_M");
            regs.Add("K_POL");
            regs.Add("K_POL_M");
            regs.Add("Switch settings");
            regs.Add("Relay POL");
            regs.Add("Relay OTR");
            regs.Add("I Ki");
            regs.Add("PI Kp");
            regs.Add("PI Ki");
            regs.Add("PID Kp");
            regs.Add("PID Ki");
            regs.Add("PID Kd");
            return regs;
        }

        private List<string> GetRegValue(List<string> regs)
        {
            regs.Add("1");
            regs.Add("3071");
            regs.Add("10");
            regs.Add("0");
            regs.Add("20");
            regs.Add("64");
            regs.Add("35");
            regs.Add("35");
            regs.Add("0.03");
            regs.Add("2");
            regs.Add("1000");
            regs.Add("500");
            regs.Add("11.5");
            regs.Add("9.5");
            regs.Add("5.05");
            regs.Add("10");
            regs.Add("135");
            regs.Add("0.001129");
            regs.Add("0.000234");
            regs.Add("0");
            regs.Add("13500");
            regs.Add("0.001030");
            regs.Add("0.000238");
            regs.Add("0");
            regs.Add("10000");
            regs.Add("0");
            regs.Add("0");
            regs.Add("0");
            regs.Add("130");
            regs.Add("0.001");
            regs.Add("0.005");
            regs.Add("0.001");
            regs.Add("100");
            regs.Add("0.05");
            regs.Add("0.01");
            regs.Add("0.05");
            regs.Add("0.01");
            regs.Add("1");
            regs.Add("0.005");
            regs.Add("0.005");
            regs.Add("0.001");
            regs.Add("0.001");
            regs.Add("0.0001");
            regs.Add("0.001");
            regs.Add("0.005");
            regs.Add("0.001");


            return regs;
        }


        }
}
