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
    /// Interaction logic for Menu_main.xaml
    /// </summary>
    public partial class Menu_main : Window
    {
        public Menu_main()
        {
            InitializeComponent();
        }

        private void FoodsClick(object sender, RoutedEventArgs e)
        {
            Food_Menu foods = new Food_Menu();
            foods.Show();
            this.Hide();
        }

        private void DrinksClick(object sender, RoutedEventArgs e)
        {
            drinks_menu drinks = new drinks_menu();
            drinks.Show();
            this.Hide();
        }

        private void CallStaff(object sender, RoutedEventArgs e)
        {
            CallStaff custom4 = new CallStaff();
            custom4.Show();
            this.Hide();
        }

        private void CartClick(object sender, RoutedEventArgs e)
        {
            Cart carts = new Cart();
            carts.Show();
            this.Hide();
        }
    }
}
