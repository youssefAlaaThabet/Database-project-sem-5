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
    public partial class viewprofile : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void submit(object sender, EventArgs e)
        {
            string connStr = WebConfigurationManager.ConnectionStrings["GUCera"].ToString();

            //create a new connection
            SqlConnection conn = new SqlConnection(connStr);
            SqlCommand view = new SqlCommand("viewMyProfile", conn);

            String sid = SID.Text;
            if (SID.Text == "")
            {
                Response.Write("You have to enter Your ID");
            }
            else
            {


                view.Parameters.Add(new SqlParameter("@id", sid));

                view.CommandType = CommandType.StoredProcedure;

                conn.Open();
                SqlDataAdapter s = new SqlDataAdapter(view);
                DataTable n = new DataTable();
                
                s.Fill(n);
                GridView1.DataSource = n;
                GridView1.DataBind();
                if (n.Rows.Count == 0) {
                    Response.Write("Wrong ID try a valid ID");
                
                }
                conn.Close();
            }
        }

        protected void SUBMIT_Click(object sender, EventArgs e)
        {
            Response.Redirect("student page.aspx");
        }
    }
}