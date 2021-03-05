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
    /// Interaction logic for Tinder4.xaml
    /// </summary>
    public partial class Tinder4 : Page
    {
        public Tinder4()
        {
            InitializeComponent();
        }

        public Tinder4(MainWindow mainWindow)
        {
            InitializeComponent();
            main = mainWindow;
        }
        private MainWindow main;

        private void like4_Click(object sender, RoutedEventArgs e)
        {
            Tinder4_Frame.Content = new Tinder5(main);
            like4.Visibility = Visibility.Hidden;
            tinder_pic4.Visibility = Visibility.Hidden;
            dislike4.Visibility = Visibility.Hidden;
        }

        private void dislike4_Click(object sender, RoutedEventArgs e)
        {
            Tinder4_Frame.Content = new Tinder5(main);
            like4.Visibility = Visibility.Hidden;
            tinder_pic4.Visibility = Visibility.Hidden;
            dislike4.Visibility = Visibility.Hidden;
        }
    }
}
