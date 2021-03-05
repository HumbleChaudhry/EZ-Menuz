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
    /// Interaction logic for Food_Menu.xaml
    /// </summary>
    public partial class Food_Menu : Window
    {
        public Food_Menu()
        {
            InitializeComponent();
        }

        private void AppsClick(object sender, RoutedEventArgs e)
        {
            appetizers apps = new appetizers();
            apps.Show();
            this.Hide();
        }

        private void WingsClick(object sender, RoutedEventArgs e)
        {
            wings wing = new wings();
            wing.Show();
            this.Hide();
        }

        private void BrClick(object sender, RoutedEventArgs e)
        {
            burgers_sandwiches brgs = new burgers_sandwiches();
            brgs.Show();
            this.Hide();
        }

        private void WrapsClick(object sender, RoutedEventArgs e)
        {
            wraps wrap = new wraps();
            wrap.Show();
            this.Hide();
        }

        private void GreensClick(object sender, RoutedEventArgs e)
        {
            greens grns = new greens();
            grns.Show();
            this.Hide();
        }

        private void SidesClick(object sender, RoutedEventArgs e)
        {
            sides side = new sides();
            side.Show();
            this.Hide();
        }

        private void DessertsClick(object sender, RoutedEventArgs e)
        {
            salads dessert = new salads();
            dessert.Show();
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
