using laba1.LabaDataSetTableAdapters;
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
using System.Windows.Shapes;

namespace laba1
{
    /// <summary>
    /// Логика взаимодействия для Window2.xaml
    /// </summary>
    public partial class Window2 : Window
    {
        Stock_balanceTableAdapter stock_balance = new Stock_balanceTableAdapter();
        ProductsTableAdapter products = new ProductsTableAdapter();
        public Window2()
        {
            InitializeComponent();
            lolka3.ItemsSource = stock_balance.GetData();
           /* Txbx3Combobox.ItemsSource = stock_balance.GetData();*/

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Window1 window = new Window1();
            window.Show();
            this.Close();
        }

        private void Button4_Click(object sender, RoutedEventArgs e)
        {
            stock_balance.InsertQuery(int.Parse(Txbx3.Text), Txbx4.Text);
            lolka3.ItemsSource = stock_balance.GetData();
        }
    }
}
