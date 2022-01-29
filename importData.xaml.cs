using Microsoft.Win32;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
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

namespace data_report7
{
    /// <summary>
    /// Lógica de interacción para importData.xaml
    /// </summary>
    public partial class importData : Window
    {
        private DataTable info;
        private ArrayList department;


        public importData()
        {
            InitializeComponent();
        }

        private void btnImportData_Click(object sender, RoutedEventArgs e)
        {
            department = new ArrayList();
            var table = new DataTable();
            OpenFileDialog openFile = new OpenFileDialog();

            if (openFile.ShowDialog() == true)
            {
                if (MessageBox.Show("Está seguro de escoger este documento?", "Guardar documento", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
                {
                    var path = openFile.OpenFile();
                    using StreamReader reader = new StreamReader(path);
                    MessageBox.Show("Documento cargado exitosamente", "Mensaje de información");
                }

                else {
                    MessageBox.Show("El documento no fue cargado exitosamente", "Mensaje de información");
                }
            }
        }


        private void btnPieChartPage_Click(object sender, RoutedEventArgs e)
        {
            Window pageChart = new pieChart();
            pageChart.ShowDialog();
        }
    }
}
