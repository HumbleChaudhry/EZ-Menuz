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
using System.Windows.Shapes;

namespace menu_repo
{
    /// <summary>
    /// Interaction logic for softDrinks.xaml
    /// </summary>
    public partial class softDrinks : Window
    {
        public softDrinks()
        {
            InitializeComponent();
        }

        private void GoBack(object sender, RoutedEventArgs e)
        {
            drinks_menu drinks = new drinks_menu();
            drinks.Show();
            this.Close();
        }

        private void GoMain(object sender, RoutedEventArgs e)
        {
            Menu_main main = new Menu_main();
            main.Show();
            this.Close();
        }
    }
}
