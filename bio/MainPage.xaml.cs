using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
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
        private List<Product> _allProducts = new List<Product>();

        public MainPage()
        {
            InitializeComponent();

            ProductServiceSoapClient client = new ProductServiceSoapClient();
            client.GetAllProductsCompleted += GetAllProductsCompleted;
            client.GetAllProductsAsync();
        }

        private void GetAllProductsCompleted(object sender, GetAllProductsCompletedEventArgs e)
        {
            foreach (var product in e.Result)
            {
                if (product.ChineseName != null && product.EnglishName != null
                    && product.Id != null && product.Price != null)
                    _allProducts.Add(product);
            }

            UpdateProductsView(_allProducts);
        }

        private void UpdateProductsView(List<Product> products)
        {
            PagedCollectionView productPaged = new PagedCollectionView(products);

            dataGridProducts.ItemsSource = productPaged;
            dataPagerProduct.Source = productPaged;

            labelItemCount.Content = "共 " + products.Count + " 项";
        }

        private void buttonSearchProducts_Click(object sender, RoutedEventArgs e)
        {
            SearchByName(textBoxSearchName.Text);
        }

        private void textBoxSearchName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                SearchByName(textBoxSearchName.Text);
            }
        }

        private int CompareProductId(Product lhs, Product rhs)
        {
            return lhs.Id.CompareTo(rhs.Id);
        }

        private void SearchByName(String name)
        {
            List<Product> products = new List<Product>();
            foreach (var product in _allProducts)
            {
                if (product.ChineseName == null || product.EnglishName == null) continue;
                if (product.ChineseName.Contains(name) ||
                    product.EnglishName.Contains(name))
                {
                    products.Add(product);
                }
            }

            //products.Sort(CompareProductId);

            UpdateProductsView(products);
            //PagedCollectionView pagedCollectionView = new PagedCollectionView(products);
            //dataGridProducts.ItemsSource = pagedCollectionView;
            //dataPagerProduct.Source = pagedCollectionView;
        }
    }
}
