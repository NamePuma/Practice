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

namespace PractikaOleshki
{
    /// <summary>
    /// Логика взаимодействия для PageWithProduct.xaml
    /// </summary>
    public partial class PageWithProduct : Page
    {
        private ConnectionWithBase connection;
        public ObservableCollection<Product> Products { get; set; }
        public ObservableCollection<fk_order_manufacrure> fk_Order_Manufacrures { get; set; }
        public PageWithProduct()
        {
            InitializeComponent();
            connection = new ConnectionWithBase();
           
            Products = new ObservableCollection<Product>(connection.Products.ToList());
            DataContext = this;
            autoAddInComboBox();
        }
        private void TextChangedSearch(object sender, TextChangedEventArgs e)
        {
            Filter();
        }
        private void Filter()
        {
            string text = textBoxForSearch.Text.Trim();
            var combo = comboBoxManufactiry.SelectedItem as fk_order_manufacrure;
            var view = CollectionViewSource.GetDefaultView(ShowProduct.ItemsSource);
            if (view == null) { return; }
            view.Filter = new Predicate<object>(o =>
            {
                Product product = o as Product;
                if (product == null) { return false; }

                bool isValue = true;

                if (text.Length >= 0)
                {
                    isValue = product.fk_order_name.name.IndexOf(text) > -1 || product.Description.IndexOf(text) > -1;
                }
                if (combo != null)
                {
                    if (combo.manufacture != "Все производители")
                    {
                        isValue = isValue && product.fk_order_manufacrure.manufacture == combo.manufacture;
                    }
                }
                return isValue;
            });
        }
        private void autoAddInComboBox()
        {

            fk_Order_Manufacrures = new ObservableCollection<fk_order_manufacrure>(connection.fk_order_manufacrure.ToList())
            {
                new fk_order_manufacrure { manufacture = "Все производители" }
            };


        }

        private void comboBoxManufactiry_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Filter();
        }
    }
}
