using ASPNetProjectM7.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ASPNetProjectM7
{
    public partial class OrderInfo : System.Web.UI.Page
    {
        OrderGetWay db = new OrderGetWay();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {

                LoadGridView();
            }
        }

        private void LoadGridView()
        {
            var data = db.orderTables().ToList();
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

        protected void GridView1_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            GridView1.PageIndex = e.NewPageIndex;
            LoadGridView();
        }

        protected void GridView1_RowEditing(object sender, GridViewEditEventArgs e)
        {
            GridView1.EditIndex = e.NewEditIndex;
            LoadGridView();
        }

        protected void GridView1_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            GridView1.EditIndex = -1;
            LoadGridView();
        }

        protected void GridView1_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            int OrderId = Convert.ToInt32(GridView1.DataKeys[e.RowIndex].Value);
            int Id = Convert.ToInt32(e.NewValues["Id"].ToString());
            string categorys = e.NewValues["Categorys"].ToString();
            decimal pQty = Convert.ToDecimal(e.NewValues["ProductQty"].ToString());
            DateTime OrderDate = Convert.ToDateTime(e.NewValues["OrderDate"].ToString());
            decimal TotalAmount = Convert.ToDecimal(e.NewValues["TotalAmount"].ToString());
            decimal PaidAmount = Convert.ToDecimal(e.NewValues["PaidAmount"].ToString());
            decimal DueAmount = Convert.ToDecimal(e.NewValues["DueAmount"].ToString());
            DateTime DeliveryDate = Convert.ToDateTime(e.NewValues["DeliveryDate"].ToString());
            db.UpdateOrder(OrderId,Id, categorys, pQty, OrderDate, TotalAmount, PaidAmount, DueAmount, DeliveryDate);
            GridView1.EditIndex = -1;
            LoadGridView();
        }

        protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            int Id = Convert.ToInt32(GridView1.DataKeys[e.RowIndex].Value);
            db.DeleteOrder(Id);

            GridView1.EditIndex = -1;
            LoadGridView();
        }
    }
}