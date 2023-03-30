using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
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
using LiveCharts;
using LiveCharts.Wpf;

namespace _2_LiveCharts
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public SeriesCollection SC { get; set; }
        //Contiiendra les noms des mois
        public string[] Labels  {get; set;}
        public MainWindow()
        {
            InitializeComponent();
            //Ajouts des valeurs pour les mois ed janvier a mai
            SC = new SeriesCollection()
            {
                new ColumnSeries
                {
                    Title= "Chiffre d'affaire",
                    Values = new ChartValues<double>{14826,21365,29413,50052,78763}
                },
           
            };
            //Ajouter des informations d'une colonne supplémentaire de l'histogramme (Valeur du mois de juin)
            SC[0].Values.Add((double)100254);
            Labels = new []{ "Janvier", "Février", "Mars", "Avril", "Mai", "Juin" };

            SC.Add(
                    new LineSeries
                    {
                        Title = "Marge brute",
                        Values = new ChartValues<double> {6152.79, 8973.3, 12075.52, 22022.88, 36169.8 }
                    }
                
                );

            SC[1].Values.Add((double)45615.15);
            DataContext = this;
        }
    }
}
