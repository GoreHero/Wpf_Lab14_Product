using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace Wpf_Lab14_Product
{
    public partial class MainWindow: Window
    {
        public ObservableCollection<Product> products;
        public MainWindow()
        {
            InitializeComponent();
            products = new ObservableCollection<Product>();
            products.Add(new Product()
            {
                ProductName = "Напиток",
                ProductCost = "125,00 руб",
                LinkPath = "Data/kola.jpg",
                Appointment = false,
            });
            products.Add(new Product()
            {
                ProductName = "Xbox",
                ProductCost = "25 000,00 руб",
                LinkPath = "Data/xbox.jpg",
                Appointment = true,
            });
            products.Add(new Product()
            {
                ProductName = "Булки",
                ProductCost = "35,00 руб",
                LinkPath = "Data/bulka.jpg",
                Appointment = false,
            });
            products.Add(new Product()
            {
                ProductName = "Торт",
                ProductCost = "540,00 руб",
                LinkPath = "Data/cake.jpg",
                Appointment = true,
            });
            products.Add(new Product()
            {
                ProductName = "Фарш",
                ProductCost = "1 500,00 руб",
                LinkPath = "Data/farsh.jpg",
                Appointment = false,
            });
            lstBox.ItemsSource = products;

        }
    }

}
