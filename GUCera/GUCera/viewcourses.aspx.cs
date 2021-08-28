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
    public partial class viewcourses : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string connStr = WebConfigurationManager.ConnectionStrings["GUCera"].ToString();

            //create a new connection
            SqlConnection conn = new SqlConnection(connStr);
            SqlCommand view = new SqlCommand("availableCourses", conn);


            view.CommandType = CommandType.StoredProcedure;

            conn.Open();
            SqlDataAdapter s = new SqlDataAdapter(view);
            DataTable m = new DataTable();
            s.Fill(m);
            GridView2.DataSource = m;
            GridView2.DataBind();
            if (m.Rows.Count == 0)
            {
                Response.Write("No Available Courses");
            }
            conn.Close();
        }
        protected void SUBMIT_Click(object sender, EventArgs e)
        {
            Response.Redirect("student page.aspx");
        }

        
    }
}