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

namespace Exemple
{
    /// <summary>
    /// Logique d'interaction pour InputDialog.xaml
    /// </summary>
    public partial class InputDialog : Window
    {
        public InputDialog(string titre, string question, string ReponseParDefault = "")
        {
            InitializeComponent();
            lblQuestion.Content = question;
            txtReponse.Text = ReponseParDefault;
            Title = titre;
        }

        private void btnDialogOk_Click(object sender, RoutedEventArgs e)
        {
            DialogResult = true;
        }

        private void Window_ContentRendered(object sender, EventArgs e)
        {
            txtReponse.SelectAll();
            txtReponse.Focus();
        }
        public string Reponse
        {
            get { return txtReponse.Text; }
        }

    }        
}
