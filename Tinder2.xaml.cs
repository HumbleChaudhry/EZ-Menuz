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
    /// Interaction logic for Tinder2.xaml
    /// </summary>
    public partial class Tinder2 : Page
    {
        public Tinder2()
        {
            InitializeComponent();
        }

        public Tinder2(MainWindow mainWindow)
        {
            InitializeComponent();
            main = mainWindow;
        }
        private MainWindow main;

        private void like2_Click(object sender, RoutedEventArgs e)
        {
            Tinder2_Frame.Content = new Tinder3(main);
            like2.Visibility = Visibility.Hidden;
            tinder_pic2.Visibility = Visibility.Hidden;
            dislike2.Visibility = Visibility.Hidden;
        }

        private void dislike2_Click(object sender, RoutedEventArgs e)
        {
            Tinder2_Frame.Content = new Tinder3(main);
            like2.Visibility = Visibility.Hidden;
            tinder_pic2.Visibility = Visibility.Hidden;
            dislike2.Visibility = Visibility.Hidden;
        }
    }
}
