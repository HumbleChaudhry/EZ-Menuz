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
    /// Interaction logic for Recommend.xaml
    /// </summary>
    public partial class Recommend : Window
    {
        public Recommend()
        {
            InitializeComponent();
        }

        private void GoBackToMain(object sender, MouseButtonEventArgs e)
        {
            MainWindow objMain = new MainWindow();
            this.Visibility = Visibility.Hidden;
            objMain.Show();
        }
    }
}
