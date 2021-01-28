using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ASPNetProjectM7
{
    public partial class login : System.Web.UI.Page
    {
        string con = ConfigurationManager.ConnectionStrings["db"].ToString();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            var cont = new SqlConnection(con);
            cont.Open();
            string query = "SELECT * FROM Member WHERE email = '" + email.Text + "' and password = '" + password.Text + "'";

            SqlCommand cmd = new SqlCommand(query, cont);
            SqlDataReader sdr = cmd.ExecuteReader();

            if (email.Text == "" || password.Text == "")
            {
                Response.Write("Feild Empty");
            }
            else
            {
                if (sdr.HasRows == true)
                {
                    Response.Redirect("~/dashboard.aspx");
                }
                else
                {
                    Response.Write("Incorrect Email or Password");
                }
            }
            Response.Redirect("~/dashboard.aspx");
        }
    }
}