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

namespace Ex1
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            btnEffaceArriere.Content = "\u2190";
        }

        private void BtnGras_Click(object sender, RoutedEventArgs e)
        {
            txtText.FontWeight = FontWeights.Bold;
        }

        private void TxtText_TextChange(object sender, TextChangedEventArgs e)
        {

        }

        private void BtnItalique_Click(object sender, RoutedEventArgs e)
        {
           txtText.FontStyle= FontStyles.Italic;
        }

        private void BtnEffacerClick(object sender, RoutedEventArgs e)
        {
            txtText.Text = txtText.Text.Substring(txtText.Text.Length - 1, txtText.Text.Length);
        }

        private void BtnVider_Click(object sender, RoutedEventArgs e)
        {
            txtText.Clear();
        }
    }
}
