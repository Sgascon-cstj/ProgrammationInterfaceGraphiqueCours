using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection.Emit;
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
using System.Windows.Threading;

namespace Ex_TabControl_Binding
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private OpenFileDialog openFile;
        public MainWindow()
        {
            InitializeComponent();

            TabItem nouvelOnglet = new TabItem();

            nouvelOnglet.Header = "Onglet 4";
            nouvelOnglet.Content = new TextBlock() { Text="Texte De l'onglet ajouté dynamique" };
            
            TabControl.Items.Add(nouvelOnglet);

            horloge.Background = Brushes.BlueViolet;
            horloge.Foreground = Brushes.Gold;



            //Remplisage Dynamique du textBlock horloge
            DispatcherTimer timer = new DispatcherTimer();
            timer.Interval = TimeSpan.FromSeconds(1);
            timer.Start();
            timer.Tick += Timer_Tick;
            
           
            

            //Binding liaison = new Binding("Text");
            //liaison.Source = txtValue;
            //lblValue.SetBinding(Label.ContentProperty, liaison);

            Binding btnBinding= new Binding("Content");
            btnBinding.Source = btnAccept;
            txtTextBtn.SetBinding(TextBox.TextProperty, btnBinding);
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            horloge.Text = DateTime.Now.ToString();
        }

        private void btnOuvrir_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            
            openFileDialog.InitialDirectory = Directory.GetCurrentDirectory();
            openFileDialog.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
            openFile = openFileDialog;
            if (openFileDialog.ShowDialog() == true)
            {
                txtFile.Text = File.ReadAllText(openFileDialog.FileName);
                tbChemin.Text = openFileDialog.FileName.ToString();
            }
        }

        private void btnsave_Click(object sender, RoutedEventArgs e)
        {
            if (openFile != null)
            {
                string saveText = txtFile.Text;
                File.WriteAllText(openFile.FileName, saveText);
                MessageBox.Show("Fichier a bien ete sauvegarder");

            }
        }

        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            if (openFile != null)
            {
                openFile.Reset();
                txtFile.Text = "";
                tbChemin.Text = "";
                MessageBox.Show("Fichier a bien été fermer");
            }
            else
            {
                MessageBox.Show("Aucun fichier n'est ouvert", "Error", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }
    }
}
