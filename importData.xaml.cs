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
using System.Windows.Navigation;
using LiveCharts;
using LiveCharts.Wpf;
using LiveCharts.Defaults;

namespace data_report7
{
    /// <summary>
    /// Lógica de interacción para importData.xaml
    /// </summary>
    public partial class importData : Window
    {
        private DataTable info;
        private ArrayList department;

        public string[] Labels { get; set; }
        public Func<double, string> Formatter { get; set; }
        public SeriesCollection SeriesCollection { get; set; }
        //public SeriesCollection PieCollection { get; set; }

        public importData()
        {
            InitializeComponent();
            pieChart.Visibility = Visibility.Hidden;
            lbTittleChart.Visibility=Visibility.Hidden;
            btnBack.Visibility = Visibility.Hidden;
            department = new ArrayList();
        }

        private void btnImportData_Click(object sender, RoutedEventArgs e)
        {
            
            var table = new DataTable();
            OpenFileDialog openFile = new OpenFileDialog();

            if (openFile.ShowDialog() == true)
            {
                if (MessageBox.Show("Está seguro de escoger este documento?", "Guardar documento", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
                {
                    var path = openFile.OpenFile();
                    using StreamReader reader = new StreamReader(path);
                    MessageBox.Show("Documento cargado exitosamente", "Mensaje de información");

                    var read = reader.ReadLine();
                    string[] headers = read.Split(",");
                    table.Columns.Add(headers[0], typeof(string));
                    table.Columns.Add(headers[1], typeof(string));
                    table.Columns.Add(headers[2], typeof(string));
                    table.Columns.Add(headers[3], typeof(string));
                    
                    table.Columns.Add(headers[4].Replace("/","-"), typeof(string));


                    while ((read = reader.ReadLine()) != null)
                     {
                         string[] info = read.Split(",");
                         if (info[0].Length < 3)
                         {
                             table.Rows.Add(info);
                         }

                         bool isThere = false;
                         for (int i = 0; i < department.Count; i++)
                         {
                             string[] showArray = (string[]) department[i];
                             string show = showArray[0];
                             if(show.Equals(info[2]))
                             {
                                 string[] aux = (string[])department[i];
                                 int num = int.Parse(aux[1]) + 1;

                                 string[] aux2 = (string[])department[i];
                                 aux2[1] = num.ToString();
                                 department[i] = aux2;
                                isThere = true; 
                             }
                         }

                         if(!isThere)
                        {
                            string[] dept = {info[2], "1"};
                            department.Add(dept);
                        }
                     }

                    dtgData.DataContext = table.DefaultView;
                    info = table;
                    btnPieChart.IsEnabled = true;

                    cbLetters.Items.Add("Letra");
                    cbLetters.SelectedItem = "Letra";

                    cbLetters.Items.Add("A");
                    cbLetters.Items.Add("B");
                    cbLetters.Items.Add("C");
                    cbLetters.Items.Add("D");
                    cbLetters.Items.Add("E");
                    cbLetters.Items.Add("F");
                    cbLetters.Items.Add("G");
                    cbLetters.Items.Add("H");
                    cbLetters.Items.Add("I");
                    cbLetters.Items.Add("J");
                    cbLetters.Items.Add("K");
                    cbLetters.Items.Add("L");
                    cbLetters.Items.Add("M");
                    cbLetters.Items.Add("N");
                    cbLetters.Items.Add("O");
                    cbLetters.Items.Add("P");
                    cbLetters.Items.Add("Q");
                    cbLetters.Items.Add("R");
                    cbLetters.Items.Add("S");
                    cbLetters.Items.Add("T");
                    cbLetters.Items.Add("U");
                    cbLetters.Items.Add("V");
                    cbLetters.Items.Add("W");
                    cbLetters.Items.Add("X");
                    cbLetters.Items.Add("Y");
                    cbLetters.Items.Add("Z");
                }

                else
                {
                    MessageBox.Show("El documento no fue cargado exitosamente", "Mensaje de información");
                }
            }
        }



        private void cbSelect(object sender, SelectionChangedEventArgs e)
        {
            if (cbLetters.SelectedItem.ToString().Equals("Letra"))
            {
                info.DefaultView.RowFilter = string.Empty;
            }
            else
            {
               info.DefaultView.RowFilter =  "[Nombre Departamento] like '" + cbLetters.SelectedItem.ToString() + "%'";
               dtgData.DataContext = info.DefaultView;
            }
        }

        public SeriesCollection PieCollection { get; set; }

        private void count()
        {
            string[] departmentsNum = new string[department.Count];
            for (int i = 0; i < department.Count; i++)
            {
                string[] aux = (string[])department[i];
                departmentsNum[i] = aux[0];
            }

            double[] municipios = new double[department.Count];
            for (int i = 0; i < department.Count; i++)
            {
                string[] temp = (string[])department[i];
                double quantity = double.Parse(temp[1]);
                municipios[i] = quantity;
            }



            //Func<ChartPoint, string> labelPoint = chartPoint => string.Format("{0} ({1:P})", chartPoint.Y, chartPoint.Participation);
           
                PieCollection = new SeriesCollection
                {
                     new PieSeries
                    {
                    Title = "ANTIOQUIA",
                    Values = new ChartValues<double> (municipios)
                    },

                     new PieSeries
                    {
                    Title = "CHOCÓ",
                    Values = new ChartValues<double> (municipios)
                    },

                    new PieSeries
                    {
                    Title = "VAUPÉS",
                    Values = new ChartValues<double> (municipios)
                    },
                };
                    
          
                    Labels = departmentsNum;
                    Formatter = value => value.ToString("N");

                    DataContext = this;
            
        }


        private void btnPieChart_Click(object sender, RoutedEventArgs e)
        {
            if (MessageBox.Show("Está seguro de visualizar el gráfico?", "Gráfico", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
            {
                MessageBox.Show("Gráfico cargado exitosamente", "Mensaje de información");
                btnImportData.Visibility = Visibility.Hidden;
                btnPieChart.Visibility = Visibility.Hidden;
                cbLetters.Visibility = Visibility.Hidden;
                dtgData.Visibility = Visibility.Hidden;
                lbInformationImport.Visibility = Visibility.Hidden;
                lbInformationFilter.Visibility = Visibility.Hidden;
                pieChart.Visibility = Visibility.Visible;
                lbTittleChart.Visibility = Visibility.Visible;
                lbTittleImport.Visibility = Visibility.Hidden;
                btnBack.Visibility = Visibility.Visible;
                count();
            }
            else 
            {
                MessageBox.Show("El gráfico no fue cargado exitosamente", "Mensaje de información");
            }
            
        }

        private void btnBack_Click(object sender, RoutedEventArgs e)
        {
            if (MessageBox.Show("Está seguro de volver al punto anterior?", "Visualización de datos", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
            {
                MessageBox.Show("Datos cargados exitosamente", "Mensaje de información");
                btnImportData.Visibility = Visibility.Visible;
                btnPieChart.Visibility = Visibility.Visible;
                cbLetters.Visibility = Visibility.Visible;
                dtgData.Visibility = Visibility.Visible;
                lbInformationImport.Visibility = Visibility.Visible;
                lbInformationFilter.Visibility = Visibility.Visible;
                pieChart.Visibility = Visibility.Hidden;
                lbTittleChart.Visibility = Visibility.Hidden;
                lbTittleImport.Visibility = Visibility.Visible;
                btnBack.Visibility = Visibility.Hidden;
            }

            else
            {
                MessageBox.Show("Los datos no fueeron cargados exitosamente", "Mensaje de información");
            }
        }
    }
}
