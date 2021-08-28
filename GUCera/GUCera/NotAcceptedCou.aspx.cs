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
    public partial class NotAcceptedCou : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string connStr = WebConfigurationManager.ConnectionStrings["GUCera"].ToString();
            //create a new connection
            SqlConnection conn = new SqlConnection(connStr);


            //AdminViewAllCourses
            SqlCommand NotAcceptedCoursesproc = new SqlCommand("AdminViewNonAcceptedCourses", conn);
            NotAcceptedCoursesproc.CommandType = CommandType.StoredProcedure;

            conn.Open();
            NotAcceptedCoursesproc.ExecuteNonQuery();
            SqlDataAdapter sda = new SqlDataAdapter(NotAcceptedCoursesproc);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            GridView2.DataSource = dt;
            GridView2.DataBind();
            conn.Close();

            if (dt.Rows.Count == 0)
            {
                Label nocontent = new Label();
                nocontent.Text = "No UnAccepted Courses";
                nocontent.CssClass = "badge badge-danger";
                form1.Controls.Add(nocontent);
            }
        }
        protected void AdminPage_Click(object sender, EventArgs e)
        {
            Response.Redirect("Admins.aspx");
        }
        protected void ToAcceptCourse(object sender, EventArgs e)
        {
            Response.Redirect("AcceptCou.aspx");
        }
    }
}