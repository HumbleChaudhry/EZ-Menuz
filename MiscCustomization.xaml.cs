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
    /// Interaction logic for MiscCustomization.xaml
    /// </summary>
    public partial class MiscCustomization : Window
    {
        private string food = " ";
        private double price = 0;
        public string custom = " ";
        public MiscCustomization()
        {
            InitializeComponent();
        }
        public MiscCustomization(string nam, double pr)
        {
            InitializeComponent();
            food = nam;
            price = pr;
            Food.Text = food;
            Price.Text = price.ToString("0.##");
            FdName = food;
            Pr = price;
        }

        public string FdName
        {
            get { return food; }
            set
            {
                if (value != null)
                {
                    food = value;
                    Food.Text = food;
                }
            }
        }

        public double Pr
        {
            get { return price; }
            set
            {
                price = value;
                Price.Text = price.ToString("0.##");
            }
        }

        private void Food_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (Food == null)
            {
                return;
            }
            else
            {
                Food.Text = food;
            }
        }

        private void Price_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (Price == null)
            {
                return;
            }
            else
            {
                Price.Text = price.ToString("0.##");
            }
        }



        private void AddToCart_Click(object sender, System.EventArgs e)
        {

        }

        protected override void OnDeactivated(EventArgs e)
        {
            base.OnDeactivated(e);
            Hide();
        }

        private void AddToCart_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
        }

        private void Quant_Loaded(object sender, RoutedEventArgs e)
        {

        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
