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
    /// Interaction logic for TinderStart.xaml
    /// </summary>
   
    public partial class TinderStart : Page
    {
        int[] array = new int[] { 0,0,0,0,0,0};
        public TinderStart()
        {
            InitializeComponent();
        }

        public TinderStart(MainWindow mainWindow)
        {
            InitializeComponent();
            main = mainWindow;
        }
        private MainWindow main;


        private void Lactose_Click(object sender, RoutedEventArgs e)
        {
            if (array[0] == 0)
            {
                Lactose.Background = Brushes.Red;
                array[0] = 1;
            } else
            {
                Lactose.Background = Brushes.White;
                array[0] = 0;
            }
        }


        private void InitiateTinder_Click(object sender, RoutedEventArgs e)
        {
            Recommend_Frame.Content = new Tinder1(main);
            budgettb.Visibility = Visibility.Hidden;
            budget_label.Visibility = Visibility.Hidden;
            welcome_label.Visibility = Visibility.Hidden;
            recommended_label.Visibility = Visibility.Hidden;
            dietary_label.Visibility = Visibility.Hidden;
            Lactose.Visibility = Visibility.Hidden;
            Alcohol.Visibility = Visibility.Hidden;
            Pork.Visibility = Visibility.Hidden;
            Gluten.Visibility = Visibility.Hidden;
            Vegan.Visibility = Visibility.Hidden;
            Beef.Visibility = Visibility.Hidden;
            InitiateTinder.Visibility = Visibility.Hidden;
        }

        private void Alcohol_Click(object sender, RoutedEventArgs e)
        {
            if (array[1] == 0)
            {
                Alcohol.Background = Brushes.Red;
                array[1] = 1;
            }
            else
            {
                Alcohol.Background = Brushes.White;
                array[1] = 0;
            }
        }

        private void Pork_Click(object sender, RoutedEventArgs e)
        {
            if (array[2] == 0)
            {
                Pork.Background = Brushes.Red;
                array[2] = 1;
            }
            else
            {
                Pork.Background = Brushes.White;
                array[2] = 0;
            }
        }

        private void Gluten_Click(object sender, RoutedEventArgs e)
        {
            if (array[3] == 0)
            {
                Gluten.Background = Brushes.Red;
                array[3] = 1;
            }
            else
            {
                Gluten.Background = Brushes.White;
                array[3] = 0;
            }
        }

        private void Vegan_Click(object sender, RoutedEventArgs e)
        {
            if (array[4] == 0)
            {
                Vegan.Background = Brushes.Red;
                array[4] = 1;
            }
            else
            {
                Vegan.Background = Brushes.White;
                array[4] = 0;
            }
        }

        private void Beef_Click(object sender, RoutedEventArgs e)
        {
            if (array[5] == 0)
            {
                Beef.Background = Brushes.Red;
                array[5] = 1;
            }
            else
            {
                Beef.Background = Brushes.White;
                array[5] = 0;
            }
        }
    }
}
