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
        public ObservableCollection<Participant> Participants = new ObservableCollection<Participant>()
        {
            new Participant {Matricule = 1, Prenom = "Moina", Nom = "Loffhead", Genre = 'F', Niveau = "Professionnel", Email = "mloffhead0@dell.com"},
            new Participant {Matricule = 2, Prenom = "Richard", Nom = "De La Salle", Genre = 'M', Niveau = "Débutant", Email = "rdelasalle1@phoca.cz"},
            new Participant {Matricule = 3, Prenom = "Deina", Nom = "Clemintoni", Genre = 'F', Niveau = "Intermédiaire", Email = "dclemintoni2@independent.co.uk"},
            new Participant {Matricule = 4, Prenom = "Giselbert", Nom = "Wittke", Genre = 'M', Niveau = "Professionnel", Email = "gwittke3@archive.org"},
            new Participant {Matricule = 5, Prenom = "Beatrice", Nom = "Obey", Genre = 'F', Niveau = "Intermédiaire", Email = "bobey4@fc2.com"},
            new Participant {Matricule = 6, Prenom = "Raphaela", Nom = "Dunston", Genre = 'F', Niveau = "Professionnel", Email = "rdunston5@ibm.com"},
            new Participant {Matricule = 7, Prenom = "Joshua", Nom = "Steer", Genre = 'M', Niveau = "Professionnel", Email = "jsteer6@jigsy.com"},
            new Participant {Matricule = 8, Prenom = "Bartie", Nom = "Soeiro", Genre = 'M', Niveau = "Débutant", Email = "bsoeiro7@army.mil"},
            new Participant {Matricule = 9, Prenom = "Merridie", Nom = "MacIlhagga", Genre = 'F', Niveau = "Intermédiaire", Email = "mmacilhagga8@dell.com"},
            new Participant {Matricule = 10, Prenom = "Mickie", Nom = "Walburn", Genre = 'F', Niveau = "Professionnel", Email = "mwalburn9@aol.com"}
        };
        
        public MainWindow()
        {

            InitializeComponent();
            dgParticipants.ItemsSource = Participants;
        }

        private void btnAjoutPart_Click(object sender, RoutedEventArgs e)
        {
            Participant p = (dgParticipants.SelectedItem as Participant);
            Participants.Add(new Participant {Matricule = p.Matricule, Prenom = p.Prenom, Nom = p.Nom, Genre =p.Genre, Niveau = p.Niveau, Email = p.Email});
           
        
        }

        private void btnModifPart_Click(object sender, RoutedEventArgs e)
        {
            if ((dgParticipants.SelectedItem as Participant) != null) { 
                MessageBox.Show("Matricule: " + (dgParticipants.SelectedItem as Participant).Matricule + 
                "\nNom: " + (dgParticipants.SelectedItem as Participant).Nom +
                "\nPrenom: " + (dgParticipants.SelectedItem as Participant).Prenom +
                "\nNiveau: " + (dgParticipants.SelectedItem as Participant).Niveau +
                "\nGenre: " + (dgParticipants.SelectedItem as Participant).Genre);
            }
        }

        private void btnSupprimerPart_Click(object sender, RoutedEventArgs e)
        {
            if ((dgParticipants.SelectedItem as Participant) != null)
            {
                Participants.Remove(dgParticipants.SelectedItem as Participant);
      
            }
            
        }
    }
}
