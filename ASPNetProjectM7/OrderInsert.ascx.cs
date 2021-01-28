using ASPNetProjectM7.DAL;
using ASPNetProjectM7.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ASPNetProjectM7
{
    public partial class OrderInsert : System.Web.UI.UserControl
    {
        OrderGetWay db = new OrderGetWay();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            OrderTable obj = new OrderTable();
            obj.Id =Convert.ToInt32(TextBox2.Text);
            obj.Categorys = DropDownList1.Text;
            obj.ProductQty = Convert.ToDecimal(TextBox3.Text);
            obj.OrderDate = Convert.ToDateTime(TextBox4.Text);
            obj.TotalAmount = Convert.ToDecimal(TextBox5.Text);
            obj.PaidAmount = Convert.ToDecimal(TextBox6.Text);
            obj.DueAmount = Convert.ToDecimal(TextBox7.Text);
            obj.DeliveryDate = Convert.ToDateTime(TextBox8.Text);

            db.InsertOrder(obj);
            Response.Redirect("~/Customer");
        }
    }
}