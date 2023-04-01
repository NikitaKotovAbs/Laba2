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
using System.Xml.Linq;

namespace laba1
{
    /// <summary>
    /// Логика взаимодействия для Window1.xaml
    /// </summary>
    
    public partial class Window1 : Window
    {
        ProductsTableAdapter products = new ProductsTableAdapter();
        CategoryTableAdapter category = new CategoryTableAdapter();
        public Window1()
        {
            InitializeComponent();
            lolka2.ItemsSource = category.GetData();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Window2 window = new Window2();
            window.Show();
            this.Close();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MainWindow window = new MainWindow();
            window.Show();
            this.Close();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            category.InsertQuery(Txbx.Text);
             lolka2.ItemsSource = category.GetData();
        }
    }
}
