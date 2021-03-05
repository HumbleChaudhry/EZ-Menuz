using System;
using System.IO;
using System.Linq;
using System.Windows;
using System.Windows.Input;
using System.Windows.Controls;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;


namespace menu_repo
{


    public partial class Cart : Window
    {

        private string foodname = " ";
        private double pricefood = 0;
        private string quant = " ";

        private StringItems _CartItems;
        public StringItems CartItems
        {
            get
            {
                if (_CartItems == null)
                {
                    _CartItems = new StringItems();
                }
                return _CartItems;
            }
        }
        public double cartTotal = 0;

        public Cart()
        {
            InitializeComponent();

        }

        public class StringItem
        {
            public string Name { get; set; }
            public double Price { get; set; }
            public string Quantity { get; set; }

            public StringItem(string name, double price, string quantity)
            {
                Name = name;
                Price = price;
                Quantity = quantity;
            }
        }
        public class StringItems : ObservableCollection<StringItem>
        {
            public new void Add(StringItem stritem)
            {
                base.Add(stritem);
            }

            public new void Remove(StringItem stritem)
            {
                base.Remove(stritem);
            }
        }

        public Cart(string nam, double pr, string q)
        {
            InitializeComponent();
            foodname = nam;
            pricefood = pr;
            quant = q;

            FoodN = foodname;
            PrN = pricefood;
            QuantN = quant;


            StringItem strItem = new StringItem(name: FoodN, price: PrN, quantity: QuantN);

            CartItems.Add(strItem);
            CartTotal.Text = GetTotal();

        }

        public string FoodN
        {
            get { return foodname; }

            set
            {
                if (value != null)
                {
                    foodname = value;
                }
            }
        }

        public double PrN
        {
            get { return pricefood; }

            set
            {
                if (value != 0)
                {
                    pricefood = value;
                }
            }
        }

        public string QuantN
        {
            get { return quant; }

            set
            {
                if (value != null)
                {
                    quant = value;
                }
            }
        }

        private string GetTotal()
        {
            cartTotal = 0;

            foreach (var item in CartItems)
                cartTotal += item.Price;



            return cartTotal.ToString("C2");
        }



        private void CheckOut_Click(object sender, RoutedEventArgs e)
        {
            string cost;

            cost = GetTotal();


            string message = $"Total Item Count: {CartItems.Count}" + Environment.NewLine +
                                   $"Total Cost: {cost}" + Environment.NewLine +
                                   Environment.NewLine +
                                   $"Would you like to place your order?";


            string caption = "Form Closing";
            var result = MessageBox.Show(message, caption,
                                         MessageBoxButton.YesNo,
                                         MessageBoxImage.Question);

            if (result == MessageBoxResult.No)
                e.Handled = true;

            if (result == MessageBoxResult.Yes)
            {
                MessageBox.Show("Your order has been placed.");
                CartItems.Clear();
                CartTotal.Text = "0";
                Menu_main main = new Menu_main();
                main.Show();
                this.Close();

            }
        }

        private void Payment_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
