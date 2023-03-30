﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exemple
{
    public class Participant : INotifyPropertyChanged
    {
        private int _matricule;
        public int Matricule
        {
            get { return _matricule; }
            set
            {
                if (this._matricule != value)
                {
                    this._matricule = value;
                    this.NotifyPropertyChanged(nameof(Matricule));
                }
            }
        }
        private string _prenom;
        public string Prenom
        {
            get { return _prenom; }
            set
            {
                if (this._prenom != value)
                {
                    this._prenom = value;
                    this.NotifyPropertyChanged(nameof(Prenom));
                }
            }
        }
        private string _nom;
        public string Nom
        {
            get { return _nom; }
            set
            {
                if (this._nom != value)
                {
                    this._nom = value;
                    this.NotifyPropertyChanged(nameof(Nom));
                }
            }
        }
        private char _genre;
        public char Genre
        {
            get { return _genre; }
            set
            {
                if (this._genre != value)
                {
                    this._genre = value;
                    this.NotifyPropertyChanged(nameof(Genre));
                }
            }
        }
        private string _niveau;
        public string Niveau
        {
            get { return _niveau; }
            set
            {
                if (this._niveau != value)
                {
                    this._niveau = value;
                    this.NotifyPropertyChanged(nameof(Niveau));
                }
            }
        }

        private string _email;
        public string Email
        {
            get { return _email; }
            set
            {
                if (this._email != value)
                {
                    this._email = value;
                    this.NotifyPropertyChanged(nameof(Email));
                }
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        public void NotifyPropertyChanged(string propertyName)
        {
            if (this.PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
