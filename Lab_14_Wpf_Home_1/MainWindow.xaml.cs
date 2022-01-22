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

namespace Lab_14_Wpf_Home_1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public ObservableCollection<Product> product;
        public MainWindow()
        {
            InitializeComponent();
            product = new ObservableCollection<Product>();
            product.Add(new Product()
            {
                ProductName = "Хлеб",
                Price = 50,
                Picture = "Data/bread.jpg",
                Сategory = Сategories.Meal
            });
            product.Add(new Product()
            {
                ProductName = "Телевизор",
                Price = 5000,
                Picture = "Data/tv.jpg",
                Сategory = Сategories.Appliances
            });
            product.Add(new Product()
            {
                ProductName = "Стиральный порошок",
                Price = 10,
                Picture = "Data/povder.jpg",
                Сategory = Сategories.HouseholdСhemicals
            });
            product.Add(new Product()
            {
                ProductName = "Яблоко",
                Price = 15,
                Picture = "Data/apple.jpg",
                Сategory = Сategories.Meal
            });
            lstBox.ItemsSource = product;
        }

    }
}
