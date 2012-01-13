using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.OleDb;

namespace bio.Web
{
    public class ProductTable
    {
        private readonly string _connectionString;

        public ProductTable(string connectionString)
        {
            _connectionString = connectionString;
        }

        public Product GetProductById(string productId)
        {
            Product product = new Product();
            try
            {
                using (DbConnection conn = new OleDbConnection(_connectionString))
                {
                    conn.Open();
                    
                    DbCommand command = conn.CreateCommand();
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
                using (DbConnection conn = new OleDbConnection(_connectionString))
                {
                    conn.Open();

                    DbCommand command = conn.CreateCommand();
                    command.CommandText = "select * from [Sheet1$]";

                    var productList = GetProductListFromDataReader(command.ExecuteReader());

                    return productList;
                }
            }
            catch (Exception ex)
            {
                return new List<Product>();
            }
        }

        private List<Product> GetProductListFromDataReader(DbDataReader reader)
        {
            var productList = new List<Product>();
            while (reader.Read())
            {
                var product = new Product();

                try
                {
                    product.Id = (String)reader["货号和包装"];
                    product.EnglishName = (String)reader["英文名称"];
                    product.ChineseName = (String)reader["中文名"];
                    //product.Price = (double)reader["2011年人民币价格"];
                    product.Price = reader["2011年人民币价格"].ToString();
                }
                catch (Exception ex)
                {

                }
                productList.Add(product);
            }
            return productList;
        }
    }
}