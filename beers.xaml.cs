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
    /// Interaction logic for beers.xaml
    /// </summary>
    public partial class beers : Window
    {
        public beers()
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

        private void Corona_Click(object sender, RoutedEventArgs e)
        {
            string name = "Corona";
            double price = 10.51;
            MiscCustomization custom2 = new MiscCustomization(name, price);
            custom2.Show();
        }
        private void CoronaL_Click(object sender, RoutedEventArgs e)
        {

        }

        private void BudL_Click(object sender, RoutedEventArgs e)
        {

        }
        private void Bud_Click(object sender, RoutedEventArgs e)
        {

        }

        private void YL_Click(object sender, RoutedEventArgs e)
        {

        }
        private void Michel_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
