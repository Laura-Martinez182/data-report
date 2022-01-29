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
using System.Windows.Shapes;

namespace data_report7
{
    /// <summary>
    /// Lógica de interacción para importData.xaml
    /// </summary>
    public partial class importData : Window
    {
        public importData()
        {
            InitializeComponent();
        }

        private void btnImportData_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnPieChartPage_Click(object sender, RoutedEventArgs e)
        {
            Window pageChart = new pieChart();
            pageChart.Show();
        }
    }
}
