using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace Exemple
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public UserControl ContenuEcran { get; set; }
        public UCGestionPart GestPart =  new UCGestionPart();
        public UserControl ContenueEcran2 { get; set; }
        public UCIconPart UcIcon = new UCIconPart();
        public MainWindow()
        {
            InitializeComponent();

            ContenuEcran = GestPart;
            //Préciser l'emplacement ou charger le usercontrole dans la grid de MainWindows
            Grid.SetRow(ContenuEcran, 0);
            Grid.SetColumn(ContenuEcran, 0);

           //Ajouter ContenueÉcran comme l'enfant de la grid principale
           gPrincipal.Children.Add(ContenuEcran);

            ContenueEcran2 = UcIcon;
            Grid.SetRow(ContenueEcran2, 0);
            Grid.SetColumn(ContenueEcran2, 1);
            gPrincipal.Children.Add(ContenueEcran2);

        }

        public static void ReecrireFichier()
        {
            string json = JsonConvert.SerializeObject(UCGestionPart.Participants);
            System.IO.File.WriteAllText("fParticipants.json",json);
        }


    }
}
