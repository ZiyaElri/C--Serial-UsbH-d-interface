using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;
using LibUsbDotNet;
using LibUsbDotNet.Main;
using System.Security.Cryptography.X509Certificates;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SerialConnect1
{
    public partial class Form1 : Form
    {
        private string gelenVeri;
        string gidenVeri;

        public Form1()
        {
            InitializeComponent();
            Control.CheckForIllegalCrossThreadCalls = false;
    }
        public static UsbDevice MyUsbDevice;
        public static UsbDeviceFinder MyUsbFinder = new UsbDeviceFinder(1155, 22352);
        UsbEndpointReader reader;

        private void OnRxEndPointData(object sender, EndpointDataEventArgs e)
        {
            Action<string> Action = addToTextBox;
            this.BeginInvoke(Action, (Encoding.Default.GetString(e.Buffer, 0, e.Count)));
        }

        private void addToTextBox(string input)
        {
            textBox2.Text += input.Substring(0);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1.ReadOnly = false;
            string[] ports = SerialPort.GetPortNames();

            foreach (string port in ports)
            {
                comboBoxSerialPort.Items.Add(port);
            }

            comboBoxBaudrate.SelectedIndex = 11;
            buttonConnect.Enabled = true;
            buttonRead.Enabled = false;
            buttonClear.Enabled = false;

            serialPort1.DataReceived += new SerialDataReceivedEventHandler(serialPort1_DataReceived);
        }

        private void buttonConnect_Click(object sender, EventArgs e)
        {
            if (comboBoxSerialPort.Text.Trim().Length == 0)
            {
                MessageBox.Show("Port seçiniz ve tekrar deneyiniz.", Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (comboBoxBaudrate.Text.Trim().Length == 0)
            {
                MessageBox.Show("Baudrate seçiniz ve tekrar deneyiniz.", Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            serialPort1.PortName = comboBoxSerialPort.Text;
            serialPort1.BaudRate =Convert.ToInt32(comboBoxBaudrate.Text);
            serialPort1.Parity = Parity.Even;
            serialPort1.StopBits = StopBits.One;
            serialPort1.DataBits = 8;

            try
            {
                if (serialPort1.IsOpen)
                {
                    MessageBox.Show("Port açık.", Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    serialPort1.Open();
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show("Bağlantı yapılamadı.", Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (serialPort1.IsOpen)
            {
                buttonConnect.Enabled = false;
                buttonDisConnect.Enabled = true;
                buttonRead.Enabled = true;
                buttonClear.Enabled = true;
            }
        }

        private void buttonDisConnect_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                serialPort1.Close();
                buttonConnect.Enabled = true;
                buttonDisConnect.Enabled = false;
                buttonRead.Enabled = false;
                buttonClear.Enabled = false;
            }
        }

        private void buttonUniqueId_Click(object sender, EventArgs e)
        {
            textBox1.Text += gelenVeri;
        }

        public delegate void sakla(String s);
        public void textBoxYaz(String s)
        {
            textBox1.Text += s;
            Console.WriteLine(textBox1.Text);
        }

        private void serialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
             String gelenVeri = serialPort1.ReadExisting();
             textBox1.Invoke(new sakla(textBoxYaz), gelenVeri);
            
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
        }

        private void buttonUsbHıd_Click(object sender, EventArgs e)
        {
           
            try
            {
                MyUsbDevice = UsbDevice.OpenUsbDevice(MyUsbFinder);
                if (MyUsbDevice == null) throw new Exception("Device Not Found.");
                IUsbDevice wholeUsbDevice = MyUsbDevice as IUsbDevice;
                if (!ReferenceEquals(wholeUsbDevice, null))
                {
                    wholeUsbDevice.SetConfiguration(1);
                    wholeUsbDevice.ClaimInterface(0);
                }
                reader = MyUsbDevice.OpenEndpointReader(ReadEndpointID.Ep01);
                reader.DataReceived += (OnRxEndPointData);
                reader.DataReceivedEnabled = true;
                reader.GetType();
                Console.WriteLine(reader + "veri tipi");
                MessageBox.Show("olduuu");
            }
            catch
            {
                MessageBox.Show("error");
            }
            
        }

        private void buttonWrite_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                gidenVeri = textBox1.Text;
                serialPort1.WriteLine(gidenVeri);
            }
        }
    }
}
