using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;

using bio.ProductService;
using System.Xml.Linq;

namespace bio
{
    public partial class MainPage : UserControl
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void buttonGetAllProducts_Click(object sender, RoutedEventArgs e)
        {
            ProductServiceSoapClient client = new ProductServiceSoapClient();
            client.GetAllProductsCompleted += GetAllProductsCompleted;
            client.GetAllProductsAsync();
        }

        private void GetAllProductsCompleted(object sender, GetAllProductsCompletedEventArgs e)
        {
            try
            {
                if (e.Error == null)
                {
                    IList<Product> products = new List<Product>();
                    foreach (var product in e.Result)
                    {
                        products.Add(product);
                    }
                    dataGridProducts.ItemsSource = products;
                }
            }
            catch (Exception)
            {
            }
        }
    }
}
