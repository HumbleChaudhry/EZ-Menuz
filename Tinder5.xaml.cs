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
    /// Interaction logic for Tinder5.xaml
    /// </summary>
    public partial class Tinder5 : Page
    {
        public Tinder5()
        {
            InitializeComponent();
        }

        public Tinder5(MainWindow mainWindow)
        {
            InitializeComponent();
            main = mainWindow;
        }
        private MainWindow main;

        private void like5_Click(object sender, RoutedEventArgs e)
        {
            Tinder5_Frame.Content = new TinderFinal(main);
            like5.Visibility = Visibility.Hidden;
            tinder_pic5.Visibility = Visibility.Hidden;
            dislike5.Visibility = Visibility.Hidden;

        }

        private void dislike5_Click(object sender, RoutedEventArgs e)
        {
            Tinder5_Frame.Content = new TinderFinal(main);
            like5.Visibility = Visibility.Hidden;
            tinder_pic5.Visibility = Visibility.Hidden;
            dislike5.Visibility = Visibility.Hidden;
        }

    }
}
