using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace GUCera
{
    public partial class CreatePromo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void Submitt(object sender, EventArgs e)
        {
            //AdminCreatePromocode
            string connStr = WebConfigurationManager.ConnectionStrings["GUCera"].ToString();
            //create a new connection
            SqlConnection conn = new SqlConnection(connStr);

            if (Code1.Text == "" || IssueDate1.Text == "" || ExpiryDate1.Text == "" || Discount1.Text == "" || AdminId1.Text == "")
            {
                Label nocontent = new Label();
                nocontent.Text = "Please Enter Valid inputs";
                nocontent.CssClass = "badge badge-danger";
                form1.Controls.Add(nocontent);
            }

            else
            {
                try
                {
                    String Co = Code1.Text;
                    DateTime Iss = Convert.ToDateTime(IssueDate1.Text);
                    DateTime exp = Convert.ToDateTime(ExpiryDate1.Text);
                    Decimal dis = Convert.ToDecimal(Discount1.Text);
                    int AdId = Int16.Parse(AdminId1.Text);

                    SqlCommand AdminCreatePromocodeproc = new SqlCommand("AdminCreatePromocode", conn);
                    AdminCreatePromocodeproc.CommandType = CommandType.StoredProcedure;

                    AdminCreatePromocodeproc.Parameters.Add(new SqlParameter("@code", Co));
                    AdminCreatePromocodeproc.Parameters.Add(new SqlParameter("@isuueDate", Iss));
                    AdminCreatePromocodeproc.Parameters.Add(new SqlParameter("@expiryDate", exp));
                    AdminCreatePromocodeproc.Parameters.Add(new SqlParameter("@discount", dis));
                    AdminCreatePromocodeproc.Parameters.Add(new SqlParameter("@adminId", AdId));

                    conn.Open();
                    AdminCreatePromocodeproc.ExecuteNonQuery();
                    Label nocontent = new Label();
                    nocontent.Text = "Promocode Created Successfully";
                    nocontent.CssClass = "badge badge-success";
                    form1.Controls.Add(nocontent);
                    conn.Close();
                }

                catch (SqlException d)
                {
                    Label nocontent = new Label();
                    nocontent.Text = "Invalid Action or This Promocode already Exists";
                    nocontent.CssClass = "badge badge-danger";
                    form1.Controls.Add(nocontent);
                }


            }

        }
        protected void AdminPage_Click(object sender, EventArgs e)
        {
            Response.Redirect("Admins.aspx");
        }
    }
}