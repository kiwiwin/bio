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
        private List<Product> _products = new List<Product>();

        public MainPage()
        {
            InitializeComponent();

            ProductServiceSoapClient client = new ProductServiceSoapClient();
            client.GetAllProductsCompleted += GetAllProductsCompleted;
            client.GetAllProductsAsync();
        }


        private void GetAllProductsCompleted(object sender, GetAllProductsCompletedEventArgs e)
        {
            try
            {
                foreach (Product product in e.Result)
                {
                    if (product.ChineseName != null && product.EnglishName != null && product.Price != null)
                    _products.Add(product);
                }
                dataGridProducts.ItemsSource = e.Result;
                dataGridProducts.IsReadOnly = true;
            }
            catch (Exception)
            {
            }
        }

        private void buttonSearchProducts_Click(object sender, RoutedEventArgs e)
        {
            SearchByName();
        }

        private void SearchByName()
        {
            try
            {
                List<Product> result = new List<Product>();
                foreach (Product product in _products)
                {
                    if (product.ChineseName.Contains(textBoxSearchName.Text) ||
                        product.EnglishName.Contains(textBoxSearchName.Text))
                    {
                        result.Add(product);
                    }
                }
                dataGridProducts.IsReadOnly = false;
                dataGridProducts.ItemsSource = result;
                dataGridProducts.IsReadOnly = true;
            }
            catch (Exception ex)
            {
            }
        }

        private void textBoxSearchName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                SearchByName();
            }
        }

    }
}
