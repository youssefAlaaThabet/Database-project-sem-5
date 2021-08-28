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
    public partial class AcceptCou : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }
        protected void Submit(object sender, EventArgs e)
        {
            string connStr = WebConfigurationManager.ConnectionStrings["GUCera"].ToString();
            //create a new connection
            SqlConnection conn = new SqlConnection(connStr);

            if (AdminId.Text == "" && CourseId.Text == "")
            {
                Label nocontent = new Label();
                nocontent.Text = "Please Enter Your Admin ID and the Course Id";
                nocontent.CssClass = "badge badge-danger";
                form1.Controls.Add(nocontent);
            }
            else
            if (AdminId.Text == "" && !(CourseId.Text == ""))
            {
                Label nocontent = new Label();
                nocontent.Text = "Please Enter Your Admin ID";
                nocontent.CssClass = "badge badge-danger";
                form1.Controls.Add(nocontent);
            }
            else
            if (CourseId.Text == "" && !(AdminId.Text == ""))
            {
                Label nocontent = new Label();
                nocontent.Text = "Please Enter The Course Id";
                nocontent.CssClass = "badge badge-danger";
                form1.Controls.Add(nocontent);
            }
            else
            {
                try
                {

                    int Adid = Int16.Parse(AdminId.Text);
                    int Cid = Int16.Parse(CourseId.Text);

                    SqlCommand AdminAcceptCourseproc = new SqlCommand("AdminAcceptRejectCourse", conn);
                    AdminAcceptCourseproc.CommandType = CommandType.StoredProcedure;

                    AdminAcceptCourseproc.Parameters.Add(new SqlParameter("@adminid", Adid));
                    AdminAcceptCourseproc.Parameters.Add(new SqlParameter("@courseId", Cid));

                    conn.Open();
                    AdminAcceptCourseproc.ExecuteNonQuery();
                    Label nocontent = new Label();
                    nocontent.Text = "You Have Accepted the course successfully";
                    nocontent.CssClass = "badge badge-success";
                    form1.Controls.Add(nocontent);
                    conn.Close();
                }
                catch (SqlException s)
                {
                    Label nocontent = new Label();
                    nocontent.Text = "Invalid Action or This Course has been already accepted";
                    nocontent.CssClass = "badge badge-danger";
                    form1.Controls.Add(nocontent);
                }

            }

        }
        protected void AdminPage_Click(object sender, EventArgs e)
        {
            Response.Redirect("Admins.aspx");
        }

        protected void ToUnacceptCourse(object sender, EventArgs e)
        {
            Response.Redirect("NotAcceptedCou.aspx");
        }
    }
}