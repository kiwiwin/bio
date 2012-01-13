using System;
using System.Collections;
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
            ProductTable productsTable = new ProductTable(@"Provider=Microsoft.ACE.OleDb.12.0;Data Source=C:\Users\Administrator\bio\bio.Web.Test\testProduct.xlsx;Extended Properties='Excel 12.0;HDR=YES'");
            IEnumerable<Product> products = productsTable.GetAllProducts();
            Assert.AreEqual(4, products.Count());
        }

        [TestMethod]
        public void TestGetProductById()
        {
            ProductTable productsTable = new ProductTable(@"Provider=Microsoft.ACE.OleDb.12.0;Data Source=C:\Users\Administrator\bio\bio.Web.Test\testProduct.xlsx;Extended Properties='Excel 12.0;HDR=YES'");
            Product product = productsTable.GetProductById("0101-100KG");
            //Product product = productsTable.GetAllProducts().First();
            Assert.IsNotNull(product);
            Assert.AreEqual("0101-100KG", product.Id);
            Assert.AreEqual("CITRIC ACID, TRISODIUM SALT, DIHYDRATE", product.EnglishName);
            Assert.AreEqual("柠檬酸三钠,二水", product.ChineseName);
            //Assert.AreEqual(13500, product.Price, 0.1);
            Assert.AreEqual("13500", product.Price);
        }
    }
}
