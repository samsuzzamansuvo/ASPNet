using ASPNetProjectM7.DAL;
using ASPNetProjectM7.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ASPNetProjectM7
{
    public partial class ProductInsert : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {


            string img = Path.GetFileName(FileUpload1.PostedFile.FileName);
            FileUpload1.SaveAs(Server.MapPath("~/Images/") + img);
            ProductCls obj = new ProductCls();
            obj.ProductName = TextBox1.Text;
            obj.ProductQTY = Convert.ToDecimal(TextBox2.Text);
            obj.Price = Convert.ToDecimal(TextBox3.Text);
            obj.TotalAmount = Convert.ToDecimal(TextBox4.Text);

            obj.ProductImage = "Images/" + img;
            ProductClsGetWway1.InsertProduct(obj.ProductName, obj.ProductQTY, obj.Price, obj.TotalAmount, obj.ProductImage);

            Response.Redirect("~/Product1");
        }
    }
}