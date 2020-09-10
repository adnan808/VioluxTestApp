using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace VioluxTestApp
{
    /// <summary>
    /// Interaction logic for HardwareSimulator.xaml
    /// </summary>
    public partial class HardwareSimulator : Window
    {
        SerialPort _serialPort;
        string strComPort = "";
        public HardwareSimulator()
        {
            InitializeComponent();

            string strPath = System.IO.Path.GetDirectoryName(System.Diagnostics.Process.GetCurrentProcess().MainModule.FileName);
            strPath += "\\Settings.txt";

            string[] arrPorts = File.ReadAllLines(strPath);
            if (arrPorts.Length > 1)
            {
                strComPort = arrPorts[1];
            }

        }

        private void HandleCheck(object sender, RoutedEventArgs e)
        {
            btnDoorStatus.Content= "Close";
        }

        private void HandleUnchecked(object sender, RoutedEventArgs e)
        {
            btnDoorStatus.Content = "Open";
        }

        private void btnConnect_Checked(object sender, RoutedEventArgs e)
        {
            btnConnect.Content = "Disconnect";
            GetDeviceModel();


        }

        private void btnConnect_Unchecked(object sender, RoutedEventArgs e)
        {
            btnConnect.Content = "Connect";

           

        }

        void sp_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            try
            {
                string data = _serialPort.ReadLine();

                //This might crash and we need to handle the UI Thread
                txtResponse.Text = data;
                txtResponse.Text += Environment.NewLine;
            }
            catch (Exception Exp)
            {
                MessageBox.Show("Oops something went wrong. Here is the exception text: " + Environment.NewLine + Environment.NewLine + Exp.ToString());

            }

        }

        public void GetDeviceModel()
        {
            try
            {
                
                byte[] buffer = new byte[7];

                buffer[0] = 0; //Magic Byte
                buffer[1] = 0; //Magic Byte 
                buffer[2] = 11; // Message Id:  Device Model
                buffer[3] = 1; //Command Type 1 For Get 2 for Set 3 for Current
                buffer[4] = 0; //Arg 1
                buffer[5] = 0; //arg 2
                buffer[6] = CalculateCheckSum(buffer);



                _serialPort = new SerialPort(strComPort, 19200, Parity.None, 8, StopBits.One);
                _serialPort.Handshake = Handshake.None;
                _serialPort.DataReceived += new SerialDataReceivedEventHandler(sp_DataReceived);
                _serialPort.ReadTimeout = 500;
                _serialPort.WriteTimeout = 500;
                _serialPort.Open();


                if (!_serialPort.IsOpen)
                    _serialPort.Open();

                _serialPort.Write(buffer, 0, 7);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error opening/writing to serial port :: " + ex.Message, "Error!");
            }
        }

        public byte CalculateCheckSum(byte[] buffer)
        {
            byte iChkSum = 0;
            for (int i = 2; i < 6; i++)
            {
                iChkSum += buffer[i];
            }

            return iChkSum;
        }
    }
}
