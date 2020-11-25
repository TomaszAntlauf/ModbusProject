using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using EasyModbus;

namespace ModbusForm
{
    public partial class Form1 : Form
    {
        public string ip;
        public int port;
        private int start;
        private int licznik;
        public ModbusClient modbusClient;
        double x = 1;
        bool offon = false;
        //private delegate void SafeCallDelegate(bool[] text);
        private delegate void SafeCallDelegate(object obj);
        //CancellationTokenSource cts;
        CancellationTokenSource cts = new CancellationTokenSource();


        public List<ChartData> wynik { get; set; }


        public Form1()
        {
            InitializeComponent();
            functionBox.Items.Add("01 Read Coil Status");
            functionBox.Items.Add("02 Read Input Status");
            functionBox.Items.Add("03 Read Holding Registers");
            functionBox.Items.Add("04 Read Input Registers");

            functionBox2.Items.Add("05 Write Single Coil");
            functionBox2.Items.Add("06 Write Single Register");
            functionBox2.Items.Add("15 Write Multiple Coils");
            functionBox2.Items.Add("16 Write Multiple Registers");
            offon = true;
            

        }

        private async void buttonCon_Click(object sender, EventArgs e)
        {
            ip = ipBox.Text;
            port = Int32.Parse(portBox.Text);

            if (offon == false)
            {
                await Task.Delay(1000);
            }
            else
            {
                modbusClient = new ModbusClient(ip, port);    //Ip-Address and Port of Modbus-TCP-Server
                modbusClient.Connect();
                if (modbusClient.Connected == true)
                {
                    labelStan.Text = "Stan: Połączono";
                }

            }

        }

        

        private void buttonExecute_Click(object sender, EventArgs e)
        {
            start = Int32.Parse(addBox1.Text);
            licznik = Int32.Parse(addBox2.Text);
            //bool[] b;
            //var dict = new ConcurrentDictionary<int, int>();
            //var task = Task.Factory.StartNew(() => CykliczneOdpytanie(ref dict));
            //wynik = new List<ChartData>();
            //ChartData chartDate = new ChartData();




            if (functionBox.SelectedItem == "01 Read Coil Status")
            {
                cts.Cancel();
                cts.Dispose();
                cts = new CancellationTokenSource();
                ThreadPool.QueueUserWorkItem(new WaitCallback(CoilOdczyt),cts.Token);
                //Task.Factory.StartNew(() => CoilOdczyt());
                //Task.Factory.StartNew(() => backgroundWorker1.RunWorkerAsync());
                //listBox1.DataSource = modbusClient.ReadCoils(start, licznik);
                //backgroundWorker1.RunWorkerAsync();
                //Thread.Sleep(1000);

                //for (int i = 0; i < licznik; i++)
                //{
                //    chartDate.IDex = i;
                //    if (bool.Parse(listBox1.Items[i].ToString()) == false)
                //    {
                //        chartDate.Value = 0;
                //    }
                //    else if (bool.Parse(listBox1.Items[i].ToString()) == true)
                //    {
                //        chartDate.Value = 1;
                //    }

                //    wynik.Add(chartDate);
                //}

            }
            else if (functionBox.SelectedItem == "02 Read Input Status")
            {
                cts.Cancel();
                cts.Dispose();
                cts = new CancellationTokenSource();
                listBox1.DataSource = modbusClient.ReadDiscreteInputs(start, licznik);
            }
            else if (functionBox.SelectedItem == "03 Read Holding Registers")
            {
                cts.Cancel();
                cts.Dispose();
                cts = new CancellationTokenSource();
                listBox1.DataSource = modbusClient.ReadHoldingRegisters(start, licznik);
                //for (int i = 0; i < licznik; i++)
                //{
                //    chartDate.IDex = i;
                //    chartDate.Value = int.Parse(listBox1.Items[i].ToString());
                //    wynik.Add(chartDate);
                //}
            }
            else if (functionBox.SelectedItem == "04 Read Input Registers")
            {
                cts.Cancel();
                cts.Dispose();
                cts = new CancellationTokenSource();
                listBox1.DataSource = modbusClient.ReadInputRegisters(start, licznik);
            }
            else
            {
                cts.Cancel();
                cts.Dispose();
                cts = new CancellationTokenSource();
                listBox1.DataSource = modbusClient.ReadHoldingRegisters(start, licznik);
            }


        }

        //private void CoilOdczyt(int st, int licz, ref ListBox listB1)
        //private void CoilOdczyt()
        //{
        //    start = Int32.Parse(addBox1.Text);
        //    licznik = Int32.Parse(addBox2.Text);

        //    if (listBox1.InvokeRequired)
        //    {
        //        var d = new SafeCallDelegate(CoilOdczyt);
        //        listBox1.Invoke(d, new object[] {  });
        //    }
        //    else
        //    {
        //        listBox1.DataSource = modbusClient.ReadCoils(start, licznik);
        //    }
        //    Thread.Sleep(1000);

        //    //listB1.DataSource = modbusClient.ReadCoils(st, licz);
        //    //Thread.Sleep(1000);

        //}

        private void CoilOdczyt(object obj)
        { 
            CancellationToken token = (CancellationToken)obj;
            start = Int32.Parse(addBox1.Text);
            licznik = Int32.Parse(addBox2.Text);
            while (true)
            {
                if (token.IsCancellationRequested) 
                { 
                    break; 
                }
                else 
                {
                    //listBox1.DataSource = modbusClient.ReadCoils(start, licznik);
                    if (listBox1.InvokeRequired)
                    {
                        var d = new SafeCallDelegate(CoilOdczyt);
                        listBox1.Invoke(d, new object[] { obj });
                    }
                    else
                    {
                        listBox1.DataSource = modbusClient.ReadCoils(start, licznik);
                    }
                    Thread.Sleep(1000);
                }
            }
        }
        private void buttonDis_Click(object sender, EventArgs e)
        {
            modbusClient.Disconnect();
            labelStan.Text = "Stan: Brak połączenia";
        }

        private void textBoxBool_Click(object sender, EventArgs e)
        {
            if (x % 2 == 0) {
                textBoxBool.Text = "TRUE";
                x++;
            }
            else
            {
                textBoxBool.Text = "FALSE";
                x++;
            }
            
        }

        private void buttonPrepBool_Click(object sender, EventArgs e)
        {
            listBox2.Items.Add(textBoxBool.Text);
        }

        private void buttonPrepInt_Click(object sender, EventArgs e)
        {
            if(int.TryParse(textBoxInt.Text,out int output))
            {
                listBox2.Items.Add(textBoxInt.Text);
            }
        }

        private void buttonClearAll_Click(object sender, EventArgs e)
        {
            listBox2.Items.Clear();    
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            //listBox2.Items.Remove(listBox2.SelectedItem);
            if (listBox2.TopIndex != listBox2.SelectedIndex)
            {
                listBox2.TopIndex = listBox2.SelectedIndex;
            }
            /*for (int i = (listBox2.SelectedIndex - 1); i >= 0; i--)
            {
                listBox2.Items.RemoveAt(i);  
            }*/
            
            listBox2.Items.RemoveAt(listBox2.SelectedIndex);
            listBox2.ClearSelected();
        }

        private void buttonWExecute_Click(object sender, EventArgs e)
        {
            start = Int32.Parse(addBox3.Text);
            
            
            if (functionBox2.SelectedItem == "05 Write Single Coil")
            {
                modbusClient.WriteSingleCoil(start, bool.Parse(listBox2.Items[0].ToString()));
                /*if (listBox2.Text == "TRUE")
                {
                 modbusClient.WriteSingleCoil(start, true);
                }
                if (listBox2.Text == "FALSE")
                {
                    modbusClient.WriteSingleCoil(start, false);
                }
                */
                //modbusClient.WriteSingleCoil(start, bool.Parse(lista[0]));

            }
            else if (functionBox2.SelectedItem == "06 Write Single Register")
            {
                modbusClient.WriteSingleRegister(start, int.Parse(listBox2.Items[0].ToString()));
            }
            else if (functionBox2.SelectedItem == "15 Write Multiple Coils")
            {
                bool[] tab;
                int l = 0;
                int j = 0;
                foreach(string b in listBox2.Items)
                {
                    l++;
                }
                tab = new bool[l];
                foreach (string b in listBox2.Items)
                {
                    tab[j]= bool.Parse(b);
                    j++;
                }

                modbusClient.WriteMultipleCoils(start, tab);
            }
            else if (functionBox2.SelectedItem == "16 Write Multiple Registers")
            {
                int[] tab;
                int l = 0;
                int j = 0;
                foreach (string b in listBox2.Items)
                {
                    l++;
                }
                tab = new int[l];
                foreach (string b in listBox2.Items)
                {
                    tab[j] = int.Parse(b);
                    j++;
                }

                modbusClient.WriteMultipleRegisters(start, tab);
            }
            else
            {
                int[] tab;
                int l = 0;
                int j = 0;
                foreach (string b in listBox2.Items)
                {
                    l++;
                }
                tab = new int[l];
                foreach (string b in listBox2.Items)
                {
                    tab[j] = int.Parse(b);
                    j++;
                }

                modbusClient.WriteMultipleRegisters(start, tab);
            }
        }

        private void buttonCrt_Click(object sender, EventArgs e)
        {
            //Form2 child = new Form2();
            //child.Show();
            start = Int32.Parse(addBox1.Text);
            licznik = Int32.Parse(addBox2.Text);

            chartD.Series["values"].Points.Clear();

            //wynik = new List<ChartData>();
            ChartData chartDate = new ChartData();

            for (int i = start; i < licznik; i++)
            {
                chartDate.IDex = i;

                if (bool.TryParse(listBox1.Items[i].ToString(), out bool output))
                {
                    if (bool.Parse(listBox1.Items[i].ToString()) == false)
                    {
                        chartDate.Value = 0;
                    }
                    else if (bool.Parse(listBox1.Items[i].ToString()) == true)
                    {
                        chartDate.Value = 1;
                    }
                }
                else
                {
                    chartDate.Value = int.Parse(listBox1.Items[i].ToString());
                }


                //wynik.Add(chartDate);
                chartD.Series["values"].Points.AddXY(chartDate.IDex, chartDate.Value);
            }


            //foreach (ChartData ch in wynik) 
            //{
            //    chartD.Series["values"].Points.AddXY(ch.IDex, ch.Value);
            //}

        }

        //private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        //{
        //    //while (true)
        //    //{
        //        start = Int32.Parse(addBox1.Text);
        //        licznik = Int32.Parse(addBox2.Text);
        //        listBox1.DataSource = modbusClient.ReadCoils(start, licznik);
        //        Thread.Sleep(1000);
        //    //}
        //}

        //private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        //{
        //    listBox1.Text = e.Result.ToString();
        //}
    }



    public class ChartData
    {
        //public DateTime Day { get; set; }
        public int IDex { get; set; }
        public int Value { get; set; }
    }
}
