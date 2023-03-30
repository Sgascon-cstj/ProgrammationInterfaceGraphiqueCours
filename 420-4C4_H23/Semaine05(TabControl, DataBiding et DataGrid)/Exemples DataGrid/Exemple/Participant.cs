using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exemple
{
    public class Participant : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public void NotifyPropertyChanged( string propretyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propretyName));
            }
        }
        private int matricule;
        public int Matricule
        {
            get { return matricule; }
            set
            {
                if (matricule != value)
                {
                    matricule= value;
                    NotifyPropertyChanged("Matricule");
                } 
            }
        }

        private string prenom;
        public string Prenom
        {
            get { return prenom; }
            set
            {
                if (prenom != value)
                {
                    prenom = value;
                    NotifyPropertyChanged("Prenom");
                }
            }
        }
        private string nom;
        public string Nom
        {
            get { return nom; }
            set
            {
                if (nom != value)
                {
                    nom = value;
                    NotifyPropertyChanged("Nom");
                }
            }
        }
        private char genre;
        public char Genre
        {
            get { return genre; }
            set
            {
                if (genre != value)
                {
                    genre = value;
                    NotifyPropertyChanged("Genre");
                }
            }
        }
        private string niveau;
        public string Niveau
        {
            get { return niveau; }
            set
            {
                if (niveau != value)
                {
                    niveau = value;
                    NotifyPropertyChanged("Niveau");
                }
            }
        }
        private string email;
        public string Email
        {
            get { return email; }
            set
            {
                if (email != value)
                {
                    email = value;
                    NotifyPropertyChanged("Email");
                }
            }
        }

       

       
    }
}
