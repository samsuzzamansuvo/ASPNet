using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Configuration;
using ASPNetProjectM7.Models;
using System.Data.SqlClient;
using System.Data;

namespace ASPNetProjectM7.DAL
{
    public class ProductClsGetWway1
    {
        public static string conStr = ConfigurationManager.ConnectionStrings["db"].ConnectionString;
        public static List<ProductCls> productCls ()
        {
            List<ProductCls> products = new List<ProductCls>();
            using (var con = new SqlConnection(conStr))
            {
                var cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from ProductTable";
                con.Open();
                var rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    ProductCls obj = new ProductCls();
                    obj.Id = Convert.ToInt32(rdr["Id"].ToString());
                    obj.ProductName = rdr["ProductName"].ToString();
                    obj.ProductQTY = Convert.ToDecimal(rdr["ProductQTY"].ToString());
                    obj.Price = Convert.ToDecimal(rdr["Price"].ToString());
                    obj.TotalAmount = Convert.ToDecimal(rdr["TotalAmount"].ToString());
                    obj.ProductImage = rdr["ProductImage"].ToString();
                    products.Add(obj);
                }
            }
            return products;
        }

        public static int InsertProduct(string ProductName, decimal ProductQTY, decimal Price, decimal TotalAmount,string ProductImage)
        {
            int count = 0;
            using (var con = new SqlConnection(conStr))
            {
                var cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "Insert into ProductTable (ProductName,ProductQTY,Price,TotalAmount,ProductImage) " +
                    "values('" + ProductName + "','" + ProductQTY + "','" + Price + "','" + TotalAmount + "','" + ProductImage + "')";
                con.Open();
                count = cmd.ExecuteNonQuery();

            }
            return count;
        }

        public static int UpdateProduct(string ProductName, decimal ProductQTY, decimal Price, decimal TotalAmount, string ProductImage,int Id)
        {
            int count = 0;
            using (var con = new SqlConnection(conStr))
            {
                var cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "Update ProductTable set ProductName='" + ProductName + "',ProductQTY='" + ProductQTY + "',Price='" + Price + "',TotalAmount='" + TotalAmount + "',ProductImage='" + ProductImage + "' where Id = '" + Id + "' ";
                con.Open();
                count = cmd.ExecuteNonQuery();

            }
            return count;
        }


        public static int DeleteProduct( int Id)
        {
            int count = 0;
            using (var con = new SqlConnection(conStr))
            {
                var cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "Delete from ProductTable  where Id = '" + Id + "' ";
                con.Open();
                count = cmd.ExecuteNonQuery();

            }
            return count;
        }
    }
}