using System;
using System.Collections.Generic;
using System.IO;
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
    /// Interaction logic for Home.xaml
    /// </summary>
    public partial class Home : Window
    {
        public Home()
        {
            //Please
            InitializeComponent();
        }

        private void btnHWSim_Click(object sender, RoutedEventArgs e)
        {
            string strPath = System.IO.Path.GetDirectoryName(System.Diagnostics.Process.GetCurrentProcess().MainModule.FileName);
            strPath += "\\Settings.txt";

            if (File.Exists(strPath))
            {
                HardwareSimulator HWSim = new HardwareSimulator();
                HWSim.ShowDialog();
            }
            else
            {
                MessageBox.Show("Please save configuration for COM ports from the Settings Menu", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void btnTestFix_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnAgingSim_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnCmdLine_Click(object sender, RoutedEventArgs e)
        {
            CommandLine cmdLine = new CommandLine();
            cmdLine.ShowDialog();

        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {

            Settings Config = new Settings();
            Config.ShowDialog();
        }
    }
}
