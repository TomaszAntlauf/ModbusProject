using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
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

        }

        private void buttonCon_Click(object sender, EventArgs e)
        {
            ip = ipBox.Text;
            port = Int32.Parse(portBox.Text);
            

            modbusClient = new ModbusClient(ip, port);    //Ip-Address and Port of Modbus-TCP-Server
            modbusClient.Connect();
            if (modbusClient.Connected == true)
            {
                labelStan.Text = "Stan: Połączono";
            }

            
        }

        

        private void buttonExecute_Click(object sender, EventArgs e)
        {
            start = Int32.Parse(addBox1.Text);
            licznik = Int32.Parse(addBox2.Text);

            if (functionBox.SelectedItem == "01 Read Coil Status")
            {
                listBox1.DataSource = modbusClient.ReadCoils(start, licznik);
            }
            else if (functionBox.SelectedItem == "02 Read Input Status")
            {
                listBox1.DataSource = modbusClient.ReadDiscreteInputs(start, licznik);
            }
            else if (functionBox.SelectedItem == "03 Read Holding Registers")
            {
                listBox1.DataSource = modbusClient.ReadHoldingRegisters(start, licznik);
            }
            else if (functionBox.SelectedItem == "04 Read Input Registers")
            {
                listBox1.DataSource = modbusClient.ReadInputRegisters(start, licznik);
            }
            else
            {
                listBox1.DataSource = modbusClient.ReadHoldingRegisters(start, licznik);
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
            licznik = Int32.Parse(addBox2.Text);
            
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
    }
}
