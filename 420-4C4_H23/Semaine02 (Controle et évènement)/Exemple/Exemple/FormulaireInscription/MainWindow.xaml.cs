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

namespace FormulaireInscription
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void txtNom_Focus(object sender, RoutedEventArgs e)
        {
            txtNom.Focus();
        }

        private void txtPrenom_GotFocus(object sender, RoutedEventArgs e)
        {
            if (txtNom.Text == "")
            {
                MessageBox.Show("Veuiller saisir le nom", "Erreur", MessageBoxButton.OK, MessageBoxImage.Error);
                txtNom.Focus();
            }
        }

        private void txtEmail_MousseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            txtEmail.Text = "";
            txtEmail.Foreground = Brushes.Black;
        }

        private void txtEmail_LostFocus(object sender, RoutedEventArgs e)
        {
            //Validation du format de l'adress de couriel

            if (!ValiderAdresseCouriel(txtEmail.Text))
            {
                MessageBox.Show("Adresse couriel doit respecter le format \"a@a.a\"", "Erreur", MessageBoxButton.OK, MessageBoxImage.Error);
                
            }
        }

        private bool ValiderAdresseCouriel(string couriel) 
        {
            string[] pg = couriel.Split('@');
           
            if (pg.Length != 2 || pg[0] == "" || pg[1] == "") 
            {
                return false;
            }
            else
            {
                string[] pd = pg[1].Split('.');
                if (pd.Length != 2 || pd[0] == "" || pd[1] == "")
                {
                    return false;
                }            
            
            }

            return true;
        }

        private void BtnCopier_Click(object sender, RoutedEventArgs e)
        {
            if (lsbInit.SelectedItems.Count <= 2 && lsbInit.SelectedItems.Count >= 4)
            {
                MessageBox.Show("Veuiller selectioner entre 2 et 4 éléments", "Erreur", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            else
            {
                foreach (var item in lsbInit.SelectedItems)
                {
                    lsbFin.Items.Add(item.ToString().Split(':')[1]);
                }
            }
        }

        private void BtnVider_Click(object sender, RoutedEventArgs e)
        {
            if (lsbFin.SelectedItems.Count <= 2 && lsbFin.SelectedItems.Count >= 4)
            {
                MessageBox.Show("Veuiller selectioner entre 2 et 4 éléments", "Erreur", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            else
            {
              lsbFin.Items.Clear();
            }
        }

        private void btnValider_Click(object sender, RoutedEventArgs e)
        {
           StringBuilder resumer = new StringBuilder();
            resumer.AppendLine("Prénom et nom: " + txtPrenom.Text + " " + txtNom.Text);
            resumer.AppendLine("Date de naissance: " + cld1.SelectedDate);
            resumer.AppendLine("Email: " + txtEmail.Text);
            
            if (cboRegion.SelectedIndex != -1)
            {
                resumer.AppendLine("Région: " + cboRegion.Text);

            }
            resumer.AppendLine("Statu professionel: ");
            if (chk1.IsChecked == true)
            {
                resumer.AppendLine(chk1.Content.ToString());
            }
            if (chk2.IsChecked == true)
            {
                resumer.AppendLine(chk2.Content.ToString());

            }
            if (chk3.IsChecked == true)
            {
                resumer.AppendLine(chk3.Content.ToString());

            }
            resumer.Append("État matrimoiniale: ").AppendLine();
            if (rdb1.IsChecked == true)
            {
                resumer.AppendLine(rdb1.Content.ToString());
            }
            if (rdb2.IsChecked == true)
            {
                resumer.AppendLine(rdb2.Content.ToString());
            }
            if (rdb3.IsChecked == true)
            {
                resumer.AppendLine(rdb3.Content.ToString());
            }
            resumer.AppendLine("Items sélectionnés: ");
            foreach (var item in lsbFin.Items)
            {
                resumer.AppendLine(item.ToString());
            }
           
            MessageBox.Show(resumer.ToString());
        }

        private void btnAnnuler_Click(object sender, RoutedEventArgs e)
        {
            txtNom.Clear();
            txtPrenom.Clear();
            txtEmail.Clear();
            cboRegion.SelectedIndex= 0;
            chk1.IsChecked = false;
            chk2.IsChecked = false;
            chk3.IsChecked = false;

            rdb1.IsChecked= false;
            rdb2.IsChecked= false;
            rdb3.IsChecked= false;
            
            lsbInit.SelectedItems.Clear();
            lsbFin.Items.Clear();
        }
    }
}
