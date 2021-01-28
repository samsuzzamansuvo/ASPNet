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
    public partial class CustomerInsert : System.Web.UI.UserControl
    {
        CustomerCls db = new CustomerCls();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnInsert_Click(object sender, EventArgs e)
        {
            string img = Path.GetFileName(FileUpload1.PostedFile.FileName);
            FileUpload1.SaveAs(Server.MapPath("~/Images/") + img);
            CustomerTable obj = new CustomerTable();
            obj.CustomerName = Name.Text;
            obj.Age = age.Text;
            obj.Email = email.Text;
            obj.Address = address.Text;

            obj.ImageUrl = "Images/" + img;
            db.InsertCustomer(obj);
            Response.Redirect("~/Customer");
        }
    }
}