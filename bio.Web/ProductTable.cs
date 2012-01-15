using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.Common;
using System.Data.OleDb;
using System.Xml.Linq;

namespace bio.Web
{
    public class ProductTable
    {
        private readonly string _connectionString;

        public static ProductTable Instance = new ProductTable(ConfigurationManager.ConnectionStrings["Product"].ConnectionString);

        private ProductTable(string connectionString)
        {
            _connectionString = connectionString;
        }

        public Product GetProductById(string productId)
        {
            Product product = new Product();
            try
            {
                using (DbConnection dbConnection = new OleDbConnection(_connectionString))
                {
                    dbConnection.Open();

                    DbCommand command = dbConnection.CreateCommand();
                    command.CommandText = "SELECT * FROM [Sheet1$] WHERE [货号和包装]='" + productId + "'";

                    List<Product> productList = GetProductListFromDataReader(command.ExecuteReader());
                    product = productList[0];
                }
            }
            catch (Exception ex)
            {
            }

            return product;
        }

        public List<Product> GetAllProducts()
        {
            try
            {
                using (DbConnection dbConnection = new OleDbConnection(_connectionString))
                {
                    dbConnection.Open();

                    DbCommand command = dbConnection.CreateCommand();
                    command.CommandText = "SELECT * FROM [Sheet1$]";

                    var productList = GetProductListFromDataReader(command.ExecuteReader());

                    return productList;
                }
            }
            catch (Exception ex)
            {
                return new List<Product>();
            }
        }

        public List<Product> GetProductsByPage(int pageIndex, int pageSize)
        {
            var productList = new List<Product>();
            try
            {
                using (DbConnection dbConnection = new OleDbConnection(_connectionString))
                {
                    dbConnection.Open();

                    DbCommand command = dbConnection.CreateCommand();
                    String target =
                        " [Sheet1$] WHERE [货号和包装] <> NULL";
                    command.CommandText = "SELECT TOP " + pageSize + " * FROM " + target;
                    if ((pageIndex - 1) * pageSize > 0)
                    {
                        command.CommandText += " AND [货号和包装] NOT IN (SELECT TOP " + (pageSize * (pageIndex - 1)) + " [货号和包装] FROM " + target +
                                               " ORDER BY [货号和包装])";
                    }
                    command.CommandText += " ORDER BY [货号和包装]";

                    productList = GetProductListFromDataReader(command.ExecuteReader());
                }
            }
            catch (Exception ex)
            {
            }
            return productList;
        }


        private List<Product> GetProductListFromDataReader(DbDataReader reader)
        {
            var productList = new List<Product>();
            while (reader.Read())
            {
                var product = new Product();

                try
                {
                    product.Id = (String)reader["货号和包装"] ?? "";
                    product.EnglishName = (String)reader["英文名称"] ?? "";
                    product.ChineseName = (String)reader["中文名"] ?? "";
                    product.Price = reader["2011年人民币价格"].ToString();
                    if (product.Price.Equals(""))
                    {
                        product.Price = "询价";
                    }
                }
                catch (Exception ex)
                {

                }
                productList.Add(product);
            }
            return productList;
        }

        public int GetProductsCount()
        {
            try
            {
                using (DbConnection dbConnection = new OleDbConnection(_connectionString))
                {
                    dbConnection.Open();

                    DbCommand command = dbConnection.CreateCommand();
                    command.CommandText = "SELECT COUNT(*) FROM [Sheet1$]";

                    return (int)command.ExecuteScalar();
                }
            }
            catch (Exception ex)
            {
                return 0;
            }
        }
    }
}