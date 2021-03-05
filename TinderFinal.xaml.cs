using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace menu_repo
{
    /// <summary>
    /// Interaction logic for TinderFinal.xaml
    /// </summary>
    public partial class TinderFinal : Page
    {
        public TinderFinal()
        {
            InitializeComponent();
        }

        public TinderFinal(MainWindow mainWindow)
        {
            InitializeComponent();
            main = mainWindow;
        }
        private MainWindow main;

        private void Main_Click(object sender, RoutedEventArgs e)
        {
            if (main != null)
            {
                Menu_main menu = new Menu_main();
                menu.Show();
                main.Close();
            }
        }

        private void AddtoCart_Click(object sender, RoutedEventArgs e)
        {

        }

    }
}