using System;
using System.Collections;
using System.Configuration;
using System.Data.Common;
using System.Data.OleDb;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace bio.Web.Test
{
    [TestClass]
    public class ProductTableTest
    {
        [TestMethod]
        public void TestGetAllProdcuts()
        {
            ProductTable productsTable = new ProductTable(ConfigurationManager.ConnectionStrings["ProductTableTest"].ConnectionString);
            IEnumerable<Product> products = productsTable.GetAllProducts();
            Assert.IsNotNull(products);
            Assert.AreEqual(4, products.Count());
        }

        [TestMethod]
        public void TestGetProductById()
        {
            ProductTable productsTable = new ProductTable(ConfigurationManager.ConnectionStrings["ProductTableTest"].ConnectionString);
            Product product = productsTable.GetProductById("0101-100KG");
            Assert.IsNotNull(product);
            Assert.AreEqual("0101-100KG", product.Id);
            Assert.AreEqual("CITRIC ACID, TRISODIUM SALT, DIHYDRATE", product.EnglishName);
            Assert.AreEqual("柠檬酸三钠,二水", product.ChineseName);
            Assert.AreEqual("13500", product.Price);
        }
    }
}
