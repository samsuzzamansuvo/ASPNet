using ASPNetProjectM7.DAL;
using ASPNetProjectM7.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ASPNetProjectM7
{
    public partial class dashboard : System.Web.UI.MasterPage
    {
        string conStr = ConfigurationManager.ConnectionStrings["db"].ConnectionString;
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            using (var con = new SqlConnection(conStr))
            {
                var cmd = con.CreateCommand();
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.CommandText = "Select * From ProductTable";
                con.Open();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                con.Close();
                List<ProductCls> list = new List<ProductCls>();
                if (dt.Rows.Count > 0)
                {
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        ProductCls obj = new ProductCls();
                        obj.Id = Convert.ToInt32(dt.Rows[i]["Id"].ToString());
                        obj.ProductName = dt.Rows[i]["ProductName"].ToString();
                        obj.Price = Convert.ToDecimal(dt.Rows[i]["Price"].ToString());
                        obj.TotalAmount = Convert.ToDecimal(dt.Rows[i]["TotalAmount"].ToString());
                        obj.ProductImage = dt.Rows[i]["ProductImage"].ToString();
                        list.Add(obj);
                    }
                    Session["ReportData"] = list;
                    Response.Redirect("ProductReportViewer.aspx");
                }
            }
        }
    }
}