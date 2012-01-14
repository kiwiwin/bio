using System.Xml.Linq;

namespace bio.Web
{
    public class Product
    {
        public string Id;
        public string EnglishName;
        public string ChineseName;
        public string Price;

        public string GetXmlString()
        {
            return GetXmlElement().ToString();
        }

        public XElement GetXmlElement()
        {
            XElement productXml = new XElement("Product",
                                               new XElement("Id", Id),
                                               new XElement("EnglishName", EnglishName),
                                               new XElement("ChineseName", ChineseName),
                                               new XElement("Price", Price));
            return productXml;
        }
    }
}