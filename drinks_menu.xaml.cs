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
    /// Interaction logic for drinks_menu.xaml
    /// </summary>
    public partial class drinks_menu : Window
    {
        public drinks_menu()
        {
            InitializeComponent();
        }

        private void PopClick(object sender, RoutedEventArgs e)
        {
            softDrinks pop = new softDrinks();
            pop.Show();
            this.Hide();
        }

        private void JuicesClick(object sender, RoutedEventArgs e)
        {
            juices juice = new juices();
            juice.Show();
            this.Hide();
        }

        private void BeersClick(object sender, RoutedEventArgs e)
        {
            beers beer = new beers();
            beer.Show();
            this.Hide();
        }

        private void WinesClick(object sender, RoutedEventArgs e)
        {
            wines wine = new wines();
            wine.Show();
            this.Hide();
        }

        private void SpiritsClick(object sender, RoutedEventArgs e)
        {
            spirits spirit = new spirits();
            spirit.Show();
            this.Hide();
        }

        private void CocktailsClick(object sender, RoutedEventArgs e)
        {
            cocktails ctails = new cocktails();
            ctails.Show();
            this.Hide();
        }

        private void MainClick(object sender, RoutedEventArgs e)
        {
            Menu_main main = new Menu_main();
            main.Show();
            this.Close();
        }

    }
}
