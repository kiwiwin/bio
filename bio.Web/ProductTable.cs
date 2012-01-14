﻿using System;
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

        public String GetProductXmlString(Product product)
        {
            return product.GetXmlString();
        }

        public String GetAllProductsXmlString()
        {
            List<Product> productsList = GetAllProducts();
            XElement products = new XElement("Products");
            foreach (Product p in productsList)
            {
                products.Add(p.GetXmlElement());
            }

            return products.ToString();
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
                    product.Price = reader["2011年人民币价格"].ToString();
                    if(product.Price.Equals(""))
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
    }
}