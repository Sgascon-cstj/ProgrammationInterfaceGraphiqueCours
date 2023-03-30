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
using System.Windows.Shapes;

namespace Tic_Tac_Toe
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private int NumeroCoup { get; set; }


        public MainWindow()
        {
            InitializeComponent();
            NumeroCoup= 1;
        }

        private void btn_Click(object sender, RoutedEventArgs e)
        {
            if ((sender as Button).Content != "")
            {
                    MessageBox.Show("impossible de jouer");
                return;
            }
            if (NumeroCoup % 2 == 0)
            {
                (sender as Button).Content = "O";
                (sender as Button).Content = "O";
                (sender as Button).Style = (Style)FindResource("ButtonBackgroundO");

                bool g = verifierGagner("O");
                tb1.Text = "Joueur X";
                tb1.Foreground = Brushes.LightGreen;
                if (g)
                {
                    MessageBox.Show("O gagner");
                    this.Close();
                }
               
            }
            else
            {
                (sender as Button).Content = "X";
                bool g = verifierGagner("X");
                (sender as Button).Style = (Style)FindResource("ButtonBackgroundX");
                tb1.Foreground = Brushes.LightSalmon;

                tb1.Text = "Joueur O";
                if (g)
                {
                    MessageBox.Show("X gagner");
                    this.Close();
                }
            }
      

            if (NumeroCoup > 9 && verifierGagner("O") == false && verifierGagner("X") == false)
            {
                MessageBox.Show("Égalité!");
                this.Close();
            }
            NumeroCoup++;

        }

        private bool verifierGagner(string joueur)
        {
            bool gagner = false;

            // Vérifier les lignes horizontales
            if (btn1.Content == btn2.Content && btn2.Content == btn3.Content && btn3.Content.ToString() == joueur)
            {
                gagner = true;
            }

            // Vérifier les lignes verticales
            else
            if (btn1.Content == btn4.Content && btn4.Content == btn7.Content && btn7.Content.ToString() == joueur)
            {
                gagner = true;

            }

            // Vérifier la diagonale principale
            else
            if (btn1.Content == btn5.Content && btn5.Content == btn9.Content && btn9.Content.ToString() == joueur)
            {
                gagner = true;

            }
            // Vérifier la diagonale secondaire
            else
            if (btn3.Content == btn5.Content && btn5.Content == btn7.Content && btn7.Content.ToString() == joueur)
            {
                gagner = true;

            }
            return gagner;
        }

        private void MenuItemReinitialiser_Click(object sender, RoutedEventArgs e)
        {
            btn1.Content = "";
            btn2.Content = "";
            btn3.Content = "";
            btn4.Content = "";
            btn5.Content = "";
            btn6.Content = "";
            btn7.Content = "";
            btn8.Content = "";
            btn9.Content = "";
        }

        private void MenuItemQuitter_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
