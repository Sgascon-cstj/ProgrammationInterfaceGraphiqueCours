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

namespace Exemples
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            TabItem nouvelleOnglet = new TabItem();
            nouvelleOnglet.Header = "Onglet 4";
            nouvelleOnglet.Content = new TextBlock() { Text = "Texte de l'onglet ajouté dynamiquement" };
            MonTabControl.Items.Add(nouvelleOnglet);
            horloge.Background = Brushes.BlueViolet;
            horloge.Foreground = Brushes.Gold;
            horloge.Text = DateTime.Now.ToString();

            //Faire le binding entre le textebox txtValue et le Label lblValue
            Binding liaison = new Binding("Text");
            liaison.Source = txtValue;
            lblValue.SetBinding(Label.ContentProperty, liaison);

            Binding liaison2 = new Binding("Content")
            {
                Source = btnAccept
            };
            txtTextBtn.SetBinding(TextBox.TextProperty, liaison2);
          

        }
    }
}
