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
using MySql.Data.MySqlClient;
using System.Data;
using Mysqlx.Connection;

namespace Exemple
{
    /// <summary>
    /// Logique d'interaction pour UCGestionPart.xaml
    /// </summary>
    public partial class UCGestionPart : UserControl
    {
        public static ObservableCollection<Participant> Participants = new ObservableCollection<Participant>();

        private UCAjoutPart EcrAjoutPart = new UCAjoutPart();

        public UCGestionPart()
        {
            InitializeComponent();
            DataContext = this;

            ConnecterBD();
         
           dgParticpants.ItemsSource = Participants;
        }

        public void ConnecterBD()
        {
            MySqlConnection conn = new MySqlConnection("SERVER=localhost; DATABASE=gestionparticipants; uid=root; PASSWORD=;");

            try
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand("SELECT * FROM participant",conn);
                MySqlDataAdapter adp = new MySqlDataAdapter(cmd);
                
                DataSet ds = new DataSet();
                adp.Fill(ds,"participant");
                var dt = ds.Tables["participant"];
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    Participants.Add(new Participant {
                        Matricule = (int)dt.Rows[i]["Matricule"],
                        Nom= dt.Rows[i]["Nom"].ToString(),
                        Prenom = dt.Rows[i]["Prenom"].ToString(),
                        Genre = char.Parse(dt.Rows[i]["Genre"].ToString()),
                        Niveau= dt.Rows[i]["Niveau"].ToString(),
                        Email= dt.Rows[i]["Email"].ToString()
                    });
                }
                dgParticpants.ItemsSource = Participants;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally { conn.Close(); }
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            
            MainWindow mw = (MainWindow)Application.Current.MainWindow;
            mw.gPrincipal.Children.Remove(mw.ContenuEcran);
            mw.ContenuEcran = EcrAjoutPart;
            Grid.SetRow(mw.ContenuEcran, 1);
            mw.gPrincipal.Children.Add(mw.ContenuEcran);

         
        }

        private void btnModify_Click(object sender, RoutedEventArgs e)
        {
            if (dgParticpants.SelectedItems.Count > 0)
            {
           

                MessageBox.Show("Matricule: " + (dgParticpants.SelectedItem as Participant).Matricule +
                    "\nNom: " + (dgParticpants.SelectedItem as Participant).Nom +
                    "\nPrénom: " + (dgParticpants.SelectedItem as Participant).Prenom +
                    "\nGenre: " + (dgParticpants.SelectedItem as Participant).Genre +
                    "\nGenre: " + (dgParticpants.SelectedItem as Participant).Niveau +
                    "\nEmail: " + (dgParticpants.SelectedItem as Participant).Email
                    );
            }
            //MainWindow.ReecrireFichier();
        }

        private void btnDelete_Click(object sender, RoutedEventArgs e)
        {
            if (dgParticpants.SelectedItem != null)
            {
                Participants.Remove(dgParticpants.SelectedItem as Participant);
            }
            //MainWindow.ReecrireFichier();

        }

        private void BtnListViewUI_Click(object sender, RoutedEventArgs e)
        {
            ListViewUi listViewUi = new ListViewUi();
            listViewUi.Show();
        }

        private void dgParticpants_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            if (dgParticpants.SelectedItems.Count > 0)
            {
                Participant modfieParticipant = (dgParticpants.SelectedItem as Participant);
                ModifierParticipant(modfieParticipant);
            }
        }
        private void ModifierParticipant(Participant modfieParticipant)
        {
            MySqlConnection conn = new MySqlConnection("SERVER=localhost; DATABASE=gestionparticipants; uid=root; PASSWORD=;");

            try
            {
                conn.Open();

                MySqlCommand cmd = new MySqlCommand($"UPDATE participant " +
                    $"SET Nom='{modfieParticipant.Nom}', Prenom='{modfieParticipant.Prenom}', Genre='{modfieParticipant.Genre}', Niveau='{modfieParticipant.Niveau}', Email='{modfieParticipant.Email}'" +
                    $" WHERE Matricule='{modfieParticipant.Matricule}';"
                   , conn);
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
