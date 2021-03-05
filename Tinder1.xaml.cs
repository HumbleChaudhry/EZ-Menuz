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
    /// Interaction logic for Tinder1.xaml
    /// </summary>
    
    
    public partial class Tinder1 : Page
    {
        public Tinder1()
        {
            InitializeComponent();
        }

        public Tinder1(MainWindow mainWindow)
        {
            InitializeComponent();
            main = mainWindow;
        }
        private MainWindow main;

        private void like1_Click(object sender, RoutedEventArgs e)
        {
            Tinder1_Frame.Content = new Tinder2(main);
            like1.Visibility = Visibility.Hidden;
            tinder_pic1.Visibility = Visibility.Hidden;
            dislike1.Visibility = Visibility.Hidden;
        }

        private void dislike1_Click(object sender, RoutedEventArgs e)
        {
            Tinder1_Frame.Content = new Tinder2(main);
            like1.Visibility = Visibility.Hidden;
            tinder_pic1.Visibility = Visibility.Hidden;
            dislike1.Visibility = Visibility.Hidden;
        }
    }
}
