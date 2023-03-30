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
    /// Logique d'interaction pour UCGestionPart.xaml
    /// </summary>
    public partial class UCGestionPart : UserControl
    {
        public static ObservableCollection<Participant> Participants = new ObservableCollection<Participant>();

        private UCAjoutPart EcrAjoutPart = new UCAjoutPart();
        public UCGestionPart()
        {
            InitializeComponent();
            Participants.Add(new Participant { Matricule = 1, Prenom = "Moina", Nom = "Loffhead", Genre = 'F', Niveau = "Professionnel", Email = "mloffhead0@dell.com" });
            Participants.Add(new Participant { Matricule = 2, Prenom = "Richard", Nom = "De La Salle", Genre = 'M', Niveau = "Débutant", Email = "rdelasalle1@phoca.cz" });
            Participants.Add(new Participant { Matricule = 3, Prenom = "Deina", Nom = "Clemintoni", Genre = 'F', Niveau = "Intermédiaire", Email = "dclemintoni2@independent.co.uk" });
            Participants.Add(new Participant { Matricule = 4, Prenom = "Giselbert", Nom = "Wittke", Genre = 'M', Niveau = "Professionnel", Email = "gwittke3@archive.org" });
            Participants.Add(new Participant { Matricule = 5, Prenom = "Beatrice", Nom = "Obey", Genre = 'F', Niveau = "Intermédiaire", Email = "bobey4@fc2.com" });
            Participants.Add(new Participant { Matricule = 6, Prenom = "Raphaela", Nom = "Dunston", Genre = 'F', Niveau = "Professionnel", Email = "rdunston5@ibm.com" });
            Participants.Add(new Participant { Matricule = 7, Prenom = "Joshua", Nom = "Steer", Genre = 'M', Niveau = "Professionnel", Email = "jsteer6@jigsy.com" });
            Participants.Add(new Participant { Matricule = 8, Prenom = "Bartie", Nom = "Soeiro", Genre = 'M', Niveau = "Débutant", Email = "bsoeiro7@army.mil" });
            Participants.Add(new Participant { Matricule = 9, Prenom = "Merridie", Nom = "MacIlhagga", Genre = 'F', Niveau = "Intermédiaire", Email = "mmacilhagga8@dell.com" });
            Participants.Add(new Participant { Matricule = 10, Prenom = "Mickie", Nom = "Walburn", Genre = 'F', Niveau = "Professionnel", Email = "mwalburn9@aol.com" });

            dgParticpants.ItemsSource = Participants;
        }
        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            //Participants.Add(new Participant { Matricule = 11, Prenom = "Olivier", Nom = "Nadeau", Genre = 'M', Niveau = "Expert", Email = "2148279@cstj.qc.ca" });
            MainWindow mw = (MainWindow)Application.Current.MainWindow;
            mw.gPrincipal.Children.Remove(mw.ContenuEcran);
            mw.ContenuEcran = EcrAjoutPart;
            Grid.SetRow(mw.ContenuEcran, 1);
            mw.gPrincipal.Children.Add(mw.ContenuEcran);

            //InputDialog inputDialog0 = new InputDialog("Ajout du matricule", "Veuillez saisir le matricule", "000000");
            //int matriculeAj = 0;
            //if (inputDialog0.ShowDialog() == true)
            //{
            //    matriculeAj = int.Parse(inputDialog0.Reponse);
            //}
            ////-------------------------------------

            //InputDialog inputDialog1 = new InputDialog("Ajout du prenom", "Veuillez saisir le prenom", "Jean");
            //string prenom = "";
            //if (inputDialog1.ShowDialog() == true)
            //{
            //    prenom = inputDialog1.Reponse;
            //}
            ////-------------------------------------

            //InputDialog inputDialog2 = new InputDialog("Ajout du nom", "Veuillez saisir le nom", "Gascon");
            //string nom = "";
            //if (inputDialog2.ShowDialog() == true)
            //{
            //    nom = inputDialog2.Reponse;
            //}
            ////-------------------------------------

            //InputDialog inputDialog3 = new InputDialog("Ajout du genre", "Veuillez saisir le genre", "M ou F ou autre");
            //char genre = ' ';
            //if (inputDialog3.ShowDialog() == true)
            //{
            //    genre = char.Parse(inputDialog3.Reponse);
            //}
            ////-------------------------------------

            //InputDialog inputDialog4 = new InputDialog("Ajout le niveau", "Veuillez saisir le niveau", "professionel");
            //string niveau = "";
            //if (inputDialog4.ShowDialog() == true)
            //{
            //    niveau = inputDialog4.Reponse;
            //}
            ////-------------------------------------

            //InputDialog inputDialog5 = new InputDialog("Ajout le mail", "Veuillez saisir le mail", "222@cstj.qc.ca");
            //string email = "";
            //if (inputDialog5.ShowDialog() == true)
            //{
            //    email = inputDialog5.Reponse;
            //}

            //Participant pNew = new Participant { Matricule = matriculeAj, Prenom = prenom, Nom = nom, Email = email, Genre = genre, Niveau = niveau };
            //Participants.Add(pNew);
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
        }

        private void btnDelete_Click(object sender, RoutedEventArgs e)
        {
            if (dgParticpants.SelectedItem != null)
            {
                Participants.Remove(dgParticpants.SelectedItem as Participant);
            }
        }

        private void BtnListViewUI_Click(object sender, RoutedEventArgs e)
        {
            ListViewUi listViewUi = new ListViewUi();
            listViewUi.Show();
        }
    }
}
