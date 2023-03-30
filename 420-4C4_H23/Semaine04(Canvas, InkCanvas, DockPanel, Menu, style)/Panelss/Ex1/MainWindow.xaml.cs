using System;
using System.Collections.Generic;
using System.Diagnostics;
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
            lbLignes.Items.Add(StackPanelPrincipal.FindResource("strApp1").ToString());
            lbLignes.Items.Add(StackPanelPrincipal.FindResource("strApp2").ToString());
            lbLignes.Items.Add(StackPanelPrincipal.FindResource("strApp3").ToString());
        }

        private void MenuItemSortir_Click(object sender, RoutedEventArgs e)
        {
            //Close();
            //Récupère tout les process
            Process[] runningProcess = Process.GetProcesses();
            for (int i = 0; i < runningProcess.Length; i++)
            {
                //lorsqu'on trouve le nom du projet on le tue
                if (runningProcess[i].ProcessName == "Ex1")
                {
                    runningProcess[i].Kill();
                }
            }
        }

        private void MenuItemNew_Click(object sender, RoutedEventArgs e)
        {
            Process.Start("notepad.exe");
        }

        private void MenuItemDessiner_Clicl(object sender, RoutedEventArgs e)
        {
            Toile toile = new Toile();
            toile.Show();
        }

        private void Canvas_Click(object sender, RoutedEventArgs e)
        {
            Panneau pa = new Panneau();
            pa.Show();

        }

        private void MenuDockPanel_Click(object sender, RoutedEventArgs e)
        {
            Quai quai = new Quai();
            quai.Show();
        }
    }
}
