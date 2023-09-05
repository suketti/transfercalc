using System;
using System.Collections.Generic;
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

namespace transfercalc
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnCalcClick(object sender, RoutedEventArgs e)
        {
            var conversions = new Dictionary<string, double>()
            {
                {"GBps", 1000 },
                {"MBps", 8 },
                {"KBps", 0.008},
                {"Mbps", 1 },
                {"Tb", 1000000 },
                {"Gb", 1000 },
                {"Mb", 1 },
            };

            int capacity = Convert.ToInt32(txtCapacity.Text);
            int transferSpeed = Convert.ToInt32(sliTransferSpeed.Value);
            double calc = capacity * conversions[cbCapacity.Text] / (transferSpeed * conversions[cbTransfer.Text]);
            lblTime.Content = calc.ToString("0.00") + " sec";


            
        }
    }
}
