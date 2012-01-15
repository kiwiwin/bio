using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace bio.Web.Service
{
    /// <summary>
    /// Summary description for ProductService
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class ProductService : System.Web.Services.WebService
    {

        [WebMethod]
        public List<Product> GetAllProducts()
        {
            return ProductTable.Instance.GetAllProducts();
        }

        [WebMethod]
        public List<Product> GetProductsByPage(int pageIndex, int pageSize)
        {
            return ProductTable.Instance.GetProductsByPage(pageIndex, pageSize);
        }

        [WebMethod]
        public int GetProductsCount()
        {
            return ProductTable.Instance.GetProductsCount();
        }
    }
}
