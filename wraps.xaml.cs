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
    /// Interaction logic for wraps.xaml
    /// </summary>
    public partial class wraps : Window
    {
        public wraps()
        {
            InitializeComponent();
        }

        private void GoBack(object sender, RoutedEventArgs e)
        {
            Food_Menu food = new Food_Menu();
            food.Show();
            this.Close();
        }

        private void GoMain(object sender, RoutedEventArgs e)
        {
            Menu_main main = new Menu_main();
            main.Show();
            this.Close();
        }

        private void Chicken_Cesar_Wrap_Click(object sender, RoutedEventArgs e)
        {
            string name = "Chicken Caesar Wrap";
            double price = 15.59;
            MiscCustomization custom3 = new MiscCustomization(name, price);
            custom3.Show();
        }
    }
}
