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
using System.Text;
using Excel = Microsoft.Office.Interop.Excel;
namespace WindowsFormsApp2
{

    public partial class Form1 : Form
    {
        bool expectationChart;
        private string dataOUT, sendWidth, dataIn;
        public double[,] data;
        public List<string> graph = new List<string>();
        public List<string> regList = new List<string>();
        int limitTemp = 35;
        int chartPosX = 0, chartPosY = 0, chartWidth=0,chartHeight=0;
        const string repos = "D:\\repos\\Device_Control1.1\\";
        public Form1()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            KeyPreview = true;
            
            comboBoxSeries.Items.Add("I(TEC)");
            comboBoxSeries.Items.Add("I(LD)");
            comboBoxSeries.Items.Add("P(BFM)");
            comboBoxSeries.Items.Add("P(ACE)");
            comboBoxSeries.Items.Add("THERM");
            comboBoxSeries.Items.Add("LAMBDA");


            GetRegs(regList);
            foreach (string reg in regList)
            {
                comboBoxRegs.Items.Add(reg);
            }
            comboBoxRegs.Items.Add(regList);

            GetRegValue(regList);//значения регистров



            string[] ports = SerialPort.GetPortNames();
            comboBoxCOM.Items.AddRange(ports);

            btnOpenPort.Enabled = true;
            btnClosePort.Enabled = false;

            chBoxDTR.Checked = false;
            serialPort1.DtrEnable = false;

            chBoxRTS.Checked = false;
            serialPort1.RtsEnable = false;
            btnОтправитьДанные.Enabled = true;
            chBoxWriteLine.Checked = true;
            sendWidth = "Write";

            chBoxAlwaysUpdate.Checked = false;
            chBoxAddNewData.Checked = true;

            saveIntoNewFile.Checked = false;

            timer.Enabled = false;
            chartITEC.ChartAreas[0].AxisX.Title = "Time, s";
            chartITEC.ChartAreas[0].AxisX.Minimum = 0;
            chartITEC.ChartAreas[0].AxisX.LabelStyle.Format = "ss";
            chartITEC.Series[0].XValueType = ChartValueType.DateTime;
            chartITEC.ChartAreas[0].AxisX.Minimum = DateTime.Now.ToOADate();
            chartITEC.ChartAreas[0].AxisX.Maximum = DateTime.Now.AddMinutes(1).ToOADate();
            chartITEC.ChartAreas[0].AxisX.IntervalType = DateTimeIntervalType.Seconds;
            chartITEC.ChartAreas[0].AxisX.Interval = 2;

            
        }
        //СТраница терминала
        private void btnOpenPort_Click(object sender, EventArgs e)
        {
            try
            {
                serialPort1.PortName = comboBoxCOM.Text;
                serialPort1.BaudRate = Convert.ToInt32(comboBoxBaud.Text);
                serialPort1.DataBits = Convert.ToInt32(comboBoxDataBits.Text);
                serialPort1.StopBits = (StopBits)Enum.Parse(typeof(StopBits), comboBoxStopBits.Text);
                serialPort1.Parity = (Parity)Enum.Parse(typeof(Parity), comboBoxParityBits.Text);
                serialPort1.Open();
                progrOpening.Value = 100;
                btnOpenPort.Enabled = false;
                btnClosePort.Enabled = true;
                lblPortStatus.Text = "ON";

            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                btnOpenPort.Enabled = true;
                btnClosePort.Enabled = false;
                lblPortStatus.Text = "OFF";
            }
        }

        private void btnClosePort_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                serialPort1.Close();
                progrOpening.Value = 0;
                btnOpenPort.Enabled = true;
                btnClosePort.Enabled = false;
                lblPortStatus.Text = "OFF";
            }
        }
        private void btnSendData_Click(object sender, EventArgs e)
        {

            if (serialPort1.IsOpen)
            {
                dataOUT = txtBoxInputData.Text;

                if (sendWidth == "WriteLine")
                {
                    dataOUT += "\r";
                }
                
                var buffer = Encoding.ASCII.GetBytes(dataOUT);
                serialPort1.Write(buffer, 0, buffer.Length);

            }
        }
        private void btnStartMeasure_Click(object sender, EventArgs e)
        {

            if (comboBoxSeries.SelectedIndex > -1)
            {
                timer.Enabled = true;
                try
                {
                    dataOUT = "mon\r";
                    serialPort1.Write(dataOUT);


                }
                catch (Exception err)
                {

                    MessageBox.Show(err.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
                MessageBox.Show("Выберите график!");
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
            if (txtBoxInputData.Text != "")
            {
                txtBoxInputData.Text = "";
            }
        }



        private void txtBoxВводДанных_KeyDown(object sender, KeyEventArgs e)
        {
            if (chBoxИспользEnter.Checked == true)
            {
                if (e.KeyCode == Keys.Enter)
                {
                    dataOUT = txtBoxInputData.Text;
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


        private void serialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            try
            {
                dataIn = serialPort1.ReadLine();
                this.Invoke(new EventHandler(ShowData));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                
            }
           
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

            if (chBoxAlwaysUpdate.Checked)
            {
                txtInputData.Text = dataIn;
                File.WriteAllText(repos+"TERMINAL.txt", txtInputData.Text);
            }
            else if (chBoxAddNewData.Checked)
            {
                txtInputData.Text += dataIn;
                File.WriteAllText(repos+"TERMINAL.txt", txtInputData.Text);
            }
            dataIn = dataIn.Replace(',', ' ');
            dataIn = dataIn.Replace('.', ',');
            
                graph.Add(dataIn);
            graph.RemoveAll(s => s == "");

            if (graph.Count != 0)
            {
                if (graph[graph.Count - 1].Contains("asecm> mon") 
                    || graph[graph.Count - 1].Contains("mon") 
                    || graph[graph.Count - 1].Contains("asecm>"))
                {
                    graph.Remove(graph[graph.Count - 1]);
                }
            }

            if (graph.Count != 0&&graph[graph.Count - 1].Any(c => char.IsLetter(c)))
                {
                    graph.Remove(graph[graph.Count - 1]);
                }
                if (graph.Count != 0&&graph[graph.Count - 1].Contains('/'))
                {
                    graph[graph.Count - 1] = graph[graph.Count - 1]
                        .Remove(graph[graph.Count - 1].Length - 2);
                }
            if (graph.Count != 0)
            {
                for (int j = 0; j < 6; j++)
                {
                    string[] arr = graph[graph.Count - 1].Split(' ');
                    try
                    {
                        if (arr.Length > 2)
                            masZnach[j] = double.Parse(arr[j]);
                    }
                    catch (Exception ex) {
                        foreach (var item in masZnach)
                        {
                            Console.WriteLine(item);
                        }
                        
                        MessageBox.Show(ex.Message);
                    }
                }
            }

            ITEC.Add(masZnach[0]);
            ILD.Add(masZnach[1]);
            PBFM.Add(masZnach[2]);
            PACE.Add(masZnach[3]);
            THERM.Add(masZnach[4]);
            LAMBDA.Add(masZnach[5]);
        }

        int countSeconds=0;

        private void timer_Tick(object sender, EventArgs e)
        {
            DateTime timeNow = DateTime.Now;
            if (ITEC.Count != 0)
            {
                if (comboBoxSeries.SelectedItem=="I(TEC)")
                    chartITEC.Series[0].Points.AddXY(timeNow, ITEC[ITEC.Count - 1]);
                if (comboBoxSeries.SelectedItem == "I(LD)")
                    chartITEC.Series[1].Points.AddXY(timeNow, ILD[ILD.Count - 1]);
                if (comboBoxSeries.SelectedItem == "P(BFM)")
                    chartITEC.Series[2].Points.AddXY(timeNow, PBFM[PBFM.Count - 1]);
                if (comboBoxSeries.SelectedItem == "P(ACE)")
                    chartITEC.Series[3].Points.AddXY(timeNow, PACE[PACE.Count - 1]);
                if (comboBoxSeries.SelectedItem == "THERM")
                    chartITEC.Series[4].Points.AddXY(timeNow, THERM[THERM.Count - 1]);
                if (comboBoxSeries.SelectedItem == "LAMBDA")
                    chartITEC.Series[5].Points.AddXY(timeNow, LAMBDA[LAMBDA.Count - 1]);
                countSeconds++;
            }
            if (countSeconds == 60)
            {
                countSeconds = 0;
                chartITEC.ChartAreas[0].AxisX.Minimum = DateTime.Now.ToOADate();
                chartITEC.ChartAreas[0].AxisX.Maximum = DateTime.Now.AddMinutes(1).ToOADate();
                chartITEC.ChartAreas[0].AxisX.IntervalType = DateTimeIntervalType.Seconds;
                chartITEC.ChartAreas[0].AxisX.Interval = 2;
            }
        }
        private void comboBoxSeries_SelectedIndexChanged(object sender, EventArgs e)
        {
            countSeconds = 0;
            chartITEC.ChartAreas[0].AxisX.Minimum = DateTime.Now.ToOADate();
            chartITEC.ChartAreas[0].AxisX.Maximum = DateTime.Now.AddMinutes(1).ToOADate();
            chartITEC.ChartAreas[0].AxisX.IntervalType = DateTimeIntervalType.Seconds;
            chartITEC.ChartAreas[0].AxisX.Interval = 2;
        }


        private void btnStopMeasure_Click(object sender, EventArgs e)
        {
                timer.Enabled = false;
                try
                {
                    dataOUT = "/"+"\r";
                    serialPort1.Write(dataOUT);


                }
                catch (Exception err)
                {

                    MessageBox.Show(err.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
        }

        private void comboBoxRegs_SelectedIndexChanged(object sender, EventArgs e)
        {
            List <string> regs = new List<string>();
            GetRegs(regs);
            List <string> regValue = new List<string>();
            GetRegValue(regValue);
            int index = regs.IndexOf(comboBoxRegs.SelectedItem.ToString());
            textBoxGetRegValue.Text = regValue[index];
        }

        private void btnAcceptRegChanges_Click(object sender, EventArgs e)
        {
            try
            {
                List<string> regs = new List<string>();
                GetRegs(regs);
                List<string> regValue = new List<string>();
                GetRegValue(regValue);
                int index = regs.IndexOf(comboBoxRegs.SelectedItem.ToString());
                dataIn = textBoxSetRegValue.Text;

                serialPort1.Write("reg" + index.ToString() + "=" + dataIn + "\r");
                regValue[regs.IndexOf(comboBoxRegs.SelectedItem.ToString())] = dataIn;
                StreamWriter writer = new StreamWriter(repos+"RegValues.txt");
                for (int i = 0; regValue.Count > i; i++)
                {
                    writer.WriteLine(regValue[i].ToString());
                }
                writer.Close();
            }
            catch { }

        }

        private void btnSaveIntoExcel_Click(object sender, EventArgs e)
        {
            int fileNom = 1;
            while (File.Exists(repos+"DATA" + fileNom.ToString() + ".xlsx"))
                fileNom++;
            if (ITEC.Count != 0 && !saveIntoNewFile.Checked)
            {
                Excel.Application app = new Excel.Application
                {
                    //Отобразить Excel
                    Visible = true,
                    SheetsInNewWorkbook = 1
                };
                Excel.Workbook workBook = app.Workbooks.Open(repos+"DATA" + (fileNom-1).ToString() + ".xlsx");
                Excel.Worksheet sheet = (Excel.Worksheet)app.Worksheets.get_Item(1);
                

                int j = 1; // счетчик столбиков в экселе

                for (int i = 1; i < ITEC.Count; i++)
                {
                    sheet.Cells[i, 1] = String.Format(ITEC[i - 1].ToString(), i, j);
                    sheet.Cells[i, 2] = String.Format(ILD[i - 1].ToString(), i, j);
                    sheet.Cells[i, 3] = String.Format(PBFM[i - 1].ToString(), i, j);
                    sheet.Cells[i, 4] = String.Format(PACE[i - 1].ToString(), i, j);
                    sheet.Cells[i, 5] = String.Format(THERM[i - 1].ToString(), i, j);
                    sheet.Cells[i, 6] = String.Format(LAMBDA[i - 1].ToString(), i, j);
                }

                    app.Quit();
            }

            if (saveIntoNewFile.Checked)
            {
                Excel.Application app = new Excel.Application
                {
                    //Отобразить Excel
                    Visible = true,
                    SheetsInNewWorkbook = 1
                };
                Excel.Workbook workBook = app.Workbooks.Add(Type.Missing);
                Excel.Worksheet sheet = (Excel.Worksheet)app.Worksheets.get_Item(1);
                sheet.Name = "DATA" + (fileNom - 1).ToString();

                int j = 1; // счетчик столбиков в экселе

                for (int i = 1; i < ITEC.Count; i++)
                {
                    sheet.Cells[i, 1] = String.Format(ITEC[i - 1].ToString(), i, j);
                    sheet.Cells[i, 2] = String.Format(ILD[i - 1].ToString(), i, j);
                    sheet.Cells[i, 3] = String.Format(PBFM[i - 1].ToString(), i, j);
                    sheet.Cells[i, 4] = String.Format(PACE[i - 1].ToString(), i, j);
                    sheet.Cells[i, 5] = String.Format(THERM[i - 1].ToString(), i, j);
                    sheet.Cells[i, 6] = String.Format(LAMBDA[i - 1].ToString(), i, j);
                }
                app.Application.ActiveWorkbook.SaveAs(repos+"DATA" + fileNom.ToString() + ".xlsx", Type.Missing,
Type.Missing, Type.Missing, Type.Missing, Type.Missing, Excel.XlSaveAsAccessMode.xlNoChange,
Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing);
                app.Quit();

            }

        }



        private void chBoxAlwaysUpdate_CheckedChanged(object sender, EventArgs e)//alw update
        {
            if (chBoxAlwaysUpdate.Checked)
            {
                chBoxAlwaysUpdate.Checked = true;
                chBoxAddNewData.Checked = false;
            }
            else { chBoxAddNewData.Checked = true; }
        }

        private void chBoxAddNewData_CheckedChanged(object sender, EventArgs e)
        {

            if (chBoxAddNewData.Checked)
            {
                chBoxAlwaysUpdate.Checked = false;
                chBoxAddNewData.Checked = true;
            }
            else { chBoxAlwaysUpdate.Checked = true; }
        }

        private void btnClearOutWindow_Click(object sender, EventArgs e)
        {
            if (txtInputData.Text != "")
            {
                txtInputData.Text = "";
            }
            File.Delete(@"D:\repos\TERMINAL.txt");


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
            StreamReader reader = new StreamReader(repos+"RegValues.txt");
            string line;
            while ((line = reader.ReadLine()) != null)
            {
               regs.Add(line);
            }

            reader.Close();
            return regs;
        }


        }
}
