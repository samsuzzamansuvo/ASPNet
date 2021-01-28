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
    public partial class registration : System.Web.UI.Page
    {
        String con = ConfigurationManager.ConnectionStrings["db"].ConnectionString;
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSignup_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection cont = new SqlConnection(con))
                {
                    cont.Open();
                    SqlCommand cmd = new SqlCommand("INSERT INTO Member VALUES (@name, @email, @password, @address, @image)", cont);
                    cmd.CommandType = CommandType.Text;

                    cmd.Parameters.AddWithValue("@name", username.Text.Trim());
                    cmd.Parameters.AddWithValue("@email", email.Text.Trim());
                    cmd.Parameters.AddWithValue("@password", password.Text.Trim());
                    cmd.Parameters.AddWithValue("@address", address.Text.Trim());

                    if (FileUpload1.HasFile)
                    {
                        byte[] imgbyte = FileUpload1.FileBytes;
                        cmd.Parameters.AddWithValue("@image", imgbyte);
                    }

                    cmd.ExecuteNonQuery();
                    lblSuccess.Text = "Data Inserted Successfully!!!";
                    lblError.Text = "";
                }

            }
            catch (Exception ex)
            {

                lblSuccess.Text = "";
                lblError.Text = ex.Message;
            }
            Response.Redirect("~/login.aspx");
        }
    }
}