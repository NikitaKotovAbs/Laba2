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
using laba1.LabaDataSetTableAdapters;
namespace laba1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ProductsTableAdapter products = new ProductsTableAdapter();
        CategoryTableAdapter category = new CategoryTableAdapter();
        Stock_balanceTableAdapter stokBalance = new Stock_balanceTableAdapter();

        public MainWindow()
        {
            InitializeComponent();
            lolka.ItemsSource = products.GetData();
            categoryCombobox.ItemsSource = category.GetData();
            stokPriceCombobox.ItemsSource = stokBalance.GetData();
            stokPriceCombobox.DisplayMemberPath = "Quantity";
            categoryCombobox.DisplayMemberPath = "denomination";
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Window1 window = new Window1();
            window.Show();
            this.Close();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            products.InsertQuery(name.Text, int.Parse(size.Text), int.Parse(price.Text), stokPriceCombobox.SelectedIndex+1, categoryCombobox.SelectedIndex + 1);
            lolka.ItemsSource = products.GetData();
        }

        private void InsertTextbox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
} 
