using System;
using System.Configuration;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace bio.Web.Test
{
    [TestClass]
    public class ProductTest
    {
        [TestMethod]
        public void TestGetXmlString()
        {
            XElement xml = new XElement("Product",
                new XElement("Id", "0101-100KG"),
                new XElement("EnglishName", "CITRIC ACID, TRISODIUM SALT, DIHYDRATE"),
                new XElement("ChineseName", "柠檬酸三钠,二水"),
                new XElement("Price", "13500")); 

            Product product = ProductTable.Instance.GetProductById("0101-100KG");
            Assert.AreEqual(xml.ToString(), ProductTable.Instance.GetProductXmlString(product));            
        }

        [TestMethod]
        public void TestGetXmlElement()
        {
            XElement xml = new XElement("Product",
                new XElement("Id", "0101-100KG"),
                new XElement("EnglishName", "CITRIC ACID, TRISODIUM SALT, DIHYDRATE"),
                new XElement("ChineseName", "柠檬酸三钠,二水"),
                new XElement("Price", "13500"));

            Product product = ProductTable.Instance.GetProductById("0101-100KG");
            Assert.AreEqual(xml.ToString(), product.GetXmlElement().ToString());
        }
    }
}
