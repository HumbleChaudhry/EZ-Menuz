using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

        }

        private void OpenWindow(object sender, RoutedEventArgs e)
        {
             nMain.Content = new TinderStart(this);
             Start_Tinder.Visibility = Visibility.Hidden;
             Start_Menu.Visibility = Visibility.Hidden;
             Start_Staff.Visibility = Visibility.Hidden;
            
        }

        private void Start_Tinder_MouseEnter(object sender, MouseEventArgs e)
        {
            Start_Tinder.Background = Brushes.White;
        }

        private void Start_Tinder_MouseLeave(object sender, MouseEventArgs e)
        {
            Start_Tinder.Background = Brushes.Gold;
        }

        private void OpenMenu(object sender, RoutedEventArgs e)
        {
            Menu_main main = new Menu_main();
            main.Show();
            this.Close();
        }
    }
}
