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
    /// Interaction logic for Tinder3.xaml
    /// </summary>
    public partial class Tinder3 : Page
    {
        public Tinder3()
        {
            InitializeComponent();
        }

        public Tinder3(MainWindow mainWindow)
        {
            InitializeComponent();
            main = mainWindow;
        }
        private MainWindow main;

        private void dislike3_Click(object sender, RoutedEventArgs e)
        {
            Tinder3_Frame.Content = new Tinder4(main);
            like3.Visibility = Visibility.Hidden;
            tinder_pic3.Visibility = Visibility.Hidden;
            dislike3.Visibility = Visibility.Hidden;
        }

        private void like3_Click(object sender, RoutedEventArgs e)
        {
            Tinder3_Frame.Content = new Tinder4(main);
            like3.Visibility = Visibility.Hidden;
            tinder_pic3.Visibility = Visibility.Hidden;
            dislike3.Visibility = Visibility.Hidden;
        }
    }
}
