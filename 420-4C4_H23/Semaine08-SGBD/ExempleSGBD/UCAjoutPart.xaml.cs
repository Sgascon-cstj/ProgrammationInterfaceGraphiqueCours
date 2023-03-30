using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
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
            Participant newParticipant = new Participant
            {
                Matricule = Convert.ToInt32(tbMatricule.Text),
                Nom = tbNom.Text,
                Prenom = tbPrenom.Text,
                Email = tbEmail.Text,
                Genre = Convert.ToChar(cbGenre.Text),
                Niveau = cbNiveau.Text
            };
            UCGestionPart.Participants.Add(newParticipant);

            InsererNouvPartBd(newParticipant);

            

            //Après avoir ajouter en bd
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

            //MainWindow.ReecrireFichier();

        }

        private void InsererNouvPartBd(Participant newParticipant)
        {
            MySqlConnection conn = new MySqlConnection("SERVER=localhost; DATABASE=gestionparticipants; uid=root; PASSWORD=;");

            try
            {
                conn.Open();
                
                MySqlCommand cmd = new MySqlCommand(
                    $"INSERT INTO participant (Matricule, Nom, Prenom, Genre, Niveau, Email) VALUES(" +
                    $"'{newParticipant.Matricule}'," +
                    $"'{newParticipant.Nom}'," +
                    $"'{newParticipant.Prenom}'," +
                    $"'{newParticipant.Genre}'," +
                    $"'{newParticipant.Niveau}'," +
                    $"'{newParticipant.Email}');", conn);
              cmd.ExecuteNonQuery();
              
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally { conn.Close(); }
        }
    }
}
