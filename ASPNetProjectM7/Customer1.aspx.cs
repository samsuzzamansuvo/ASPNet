using ASPNetProjectM7.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ASPNetProjectM7
{
    public partial class Customer1 : System.Web.UI.Page
    {
        CustomerCls db = new CustomerCls();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {

                LoadGridView();
            }
        }

        private void LoadGridView()
        {
            var data = db.customerTables().ToList();
            if (data.Count > 0)
            {
                GridView1.DataSource = data;
            }
            else
            {
                GridView1.DataSource = null;
            }
            GridView1.DataBind();
        }

        protected void Unnamed1_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            GridView1.PageIndex = e.NewPageIndex;
            LoadGridView();
        }

        protected void Unnamed1_RowEditing(object sender, GridViewEditEventArgs e)
        {
            GridView1.EditIndex = e.NewEditIndex;
            LoadGridView();
        }

        protected void Unnamed1_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            GridView1.EditIndex = -1;
            LoadGridView();
        }

        protected void Unnamed1_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            int Id = Convert.ToInt32(GridView1.DataKeys[e.RowIndex].Value);
            string name = e.NewValues["CustomerName"].ToString();
            string age = e.NewValues["Age"].ToString();
            string email = e.NewValues["Email"].ToString();
            string address = e.NewValues["Address"].ToString();
            string imgurl = e.NewValues["ImageUrl"].ToString();
            db.UpdateCustomer(Id, name, age, email, address, imgurl);
            GridView1.EditIndex = -1;
            LoadGridView();
        }

        protected void Unnamed1_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            int Id = Convert.ToInt32(GridView1.DataKeys[e.RowIndex].Value);
            db.DeleteCustomer(Id);

            GridView1.EditIndex = -1;
            LoadGridView();
        }
    }
}