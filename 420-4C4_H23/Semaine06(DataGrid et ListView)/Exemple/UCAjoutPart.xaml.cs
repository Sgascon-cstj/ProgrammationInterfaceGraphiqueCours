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

namespace Exemple
{
    /// <summary>
    /// Logique d'interaction pour UCAjoutPart.xaml
    /// </summary>
    public partial class UCAjoutPart : UserControl
    {
        public UCAjoutPart()
        {
            InitializeComponent();
        }

        private void Click_Valider(object sender, RoutedEventArgs e)
        {
            UCGestionPart.Participants.Add(new Participant {Matricule = Convert.ToInt32(tbMatricule.Text),
                Nom = tbNom.Text,
                Prenom = tbPrenom.Text,
                Email = tbEmail.Text,
                Genre = Convert.ToChar(cbGenre.Text),
                Niveau = cbNiveau.Text });

            MessageBox.Show("Ajout effectué avec succes");

            //Remplacer le UC par le mw.GestPart
            MainWindow mw = (MainWindow)Application.Current.MainWindow;
            mw.gPrincipal.Children.Remove(mw.ContenuEcran);
            mw.ContenuEcran = mw.GestPart;
            Grid.SetRow(mw.ContenuEcran, 1);
            mw.gPrincipal.Children.Add(mw.ContenuEcran);

            tbMatricule.Clear();
            tbNom.Clear();
            tbEmail.Clear();
            tbPrenom.Clear();
            cbGenre.SelectedIndex = -1;
            cbNiveau.SelectedIndex = -1;

        }
    }
}
