using System;
using System.Collections.Generic;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace VioluxTestApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class CommandLine : Window
    {

        SerialPort _serialPort;
        public CommandLine()
        {
            InitializeComponent();
            _serialPort = new SerialPort("COM1", 19200, Parity.None, 8, StopBits.One);
            _serialPort.Handshake = Handshake.None;
            _serialPort.DataReceived += new SerialDataReceivedEventHandler(sp_DataReceived);
            _serialPort.ReadTimeout = 500;
            _serialPort.WriteTimeout = 500;
            _serialPort.Open();
        }

        private void lstCommands_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            
      

            try
            {
                byte[] buffer = new byte[6];

                string strSelected = (lstCommands.SelectedItem as ListBoxItem).Content.ToString();
                if (strSelected== "Ballast Power On")
                {
                    buffer[0] = 0; //Magic Byte
                    buffer[1] = 0; //Magic Byte 
                    buffer[2] = 1; // Message Id
                    buffer[3] = 2; //Arg1  - Command Type 2 for SET
                    buffer[4] = 0; //Arg 2
                    buffer[5] = 3;

                    if (!_serialPort.IsOpen)
                        _serialPort.Open();

                    _serialPort.Write(buffer,0,6);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error opening/writing to serial port :: " + ex.Message, "Error!");
            }
        }

        void sp_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            
            string data = _serialPort.ReadLine();

            //This might crash and we need to handle the UI Thread
            txtResponse.Text = data;
            
        }
    }
}
