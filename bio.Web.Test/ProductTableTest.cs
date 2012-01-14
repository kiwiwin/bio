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
        public void TestGetProductXmlString()
        {
            String xmlString = "<Product>\r\n  <Id>0101-100KG</Id>\r\n  <EnglishName>CITRIC ACID, TRISODIUM SALT, DIHYDRATE</EnglishName>\r\n  <ChineseName>柠檬酸三钠,二水</ChineseName>\r\n  <Price>13500</Price>\r\n</Product>";
            Product product = ProductTable.Instance.GetProductById("0101-100KG");
            Assert.AreEqual(xmlString, ProductTable.Instance.GetProductXmlString(product));
        }

        [TestMethod]
        public void TestGetProductListXmlString()
        {
            XElement productsXml = new XElement("Products",
                new XElement("Product",
                    new XElement("Id", "0101-100KG"),
                    new XElement("EnglishName", "CITRIC ACID, TRISODIUM SALT, DIHYDRATE"),
                    new XElement("ChineseName", "柠檬酸三钠,二水"),
                    new XElement("Price", "13500")),
                new XElement("Product",
                    new XElement("Id", "0101-50KG"),
                    new XElement("EnglishName", "CITRIC ACID, TRISODIUM SALT, DIHYDRATE"),
                    new XElement("ChineseName", "柠檬酸三钠,二水"),
                    new XElement("Price", "9497")),
                new XElement("Product",
                    new XElement("Id", "0101-12KG"),
                    new XElement("EnglishName", "CITRIC ACID, TRISODIUM SALT, DIHYDRATE"),
                    new XElement("ChineseName", "柠檬酸三钠,二水"),
                    new XElement("Price", "3404")),
                new XElement("Product",
                    new XElement("Id", "0101-1KG"),
                    new XElement("EnglishName", "CITRIC ACID, TRISODIUM SALT, DIHYDRATE"),
                    new XElement("ChineseName", "柠檬酸三钠,二水"),
                    new XElement("Price", "询价"))
                    );
            
            List<Product> products = ProductTable.Instance.GetAllProducts();
            String resultString = ProductTable.Instance.GetAllProductsXmlString();
            Assert.AreEqual(productsXml.ToString(), resultString);
        }
    }
}
