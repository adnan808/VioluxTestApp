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
    /// Interaction logic for Settings.xaml
    /// </summary>
    public partial class Settings : Window
    {
        public Settings()
        {
            InitializeComponent();

            //Testing Github by adnan    
            try
            {

                string[] arrComPorts = SerialPort.GetPortNames();
                for (int i = 0; i < arrComPorts.Length; i++)
                {
                    cmbESP32Prg.Items.Add(arrComPorts[i]);
                    cmbESP32TestFixture.Items.Add(arrComPorts[i]);
                    cmbMSP430Prg1.Items.Add(arrComPorts[i]);
                    cmbMSP43oPrg2.Items.Add(arrComPorts[i]);
                }
            }
            catch(Exception Exp)
            {
                MessageBox.Show("Could not get a list of COM ports on this machine", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            
        }

        
        private void btnSave_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                string strPath = System.IO.Path.GetDirectoryName(System.Diagnostics.Process.GetCurrentProcess().MainModule.FileName);
                strPath += "\\Settings.txt";

                string strData = cmbESP32TestFixture.SelectedItem.ToString() + Environment.NewLine +
                                 cmbESP32Prg.SelectedItem.ToString() + Environment.NewLine +                                
                                 cmbMSP430Prg1.SelectedItem.ToString() + Environment.NewLine +
                                 cmbMSP43oPrg2.SelectedItem.ToString();

                File.WriteAllText(strPath, strData);
                Close();
            }
            catch (Exception exp)
            {
                MessageBox.Show("Settings Could not be saved due to some issue.", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }

        }

        private void btnCancel_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
