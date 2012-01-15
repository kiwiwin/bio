using System;
using System.Collections;
using System.Configuration;
using System.Data.Common;
using System.Data.OleDb;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace bio.Web.Test
{
    [TestClass]
    public class ProductTableTest
    {
        [TestMethod]
        public void TestGetAllProdcuts()
        {
            IEnumerable<Product> products = ProductTable.Instance.GetAllProducts();
            Assert.IsNotNull(products);
            Assert.AreEqual(4, products.Count());
        }

        [TestMethod]
        public void TestGetProductById()
        {
            Product product = ProductTable.Instance.GetProductById("0101-100KG");
            Assert.IsNotNull(product);
            Assert.AreEqual("0101-100KG", product.Id);
            Assert.AreEqual("CITRIC ACID, TRISODIUM SALT, DIHYDRATE", product.EnglishName);
            Assert.AreEqual("柠檬酸三钠,二水", product.ChineseName);
            Assert.AreEqual("13500", product.Price);
        }

        [TestMethod]
        public void TestGetProductsByPage()
        {
            List<Product> products = ProductTable.Instance.GetProductsByPage(1, 3);
            Assert.IsNotNull(products);
            Assert.AreEqual(3, products.Count);
            List<Product> products2 = ProductTable.Instance.GetProductsByPage(2, 3);
            Assert.IsNotNull(products);
            Assert.AreEqual(1, products2.Count);
        }


        [TestMethod]
        public void TestGetProductsCount()
        {
            Assert.AreEqual(4, ProductTable.Instance.GetProductsCount());
        }
    }
}
