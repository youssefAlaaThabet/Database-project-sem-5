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
    public partial class Instructor : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void gotoaddcourse(object sender, EventArgs e)
        {
            Response.Redirect("Instructor ADD Course.aspx");
        }

        protected void gotodefineassignments(object sender, EventArgs e)
        {
            Response.Redirect("Define Assignments.aspx");
        }

        protected void gotoviewassignments(object sender, EventArgs e)
        {
            Response.Redirect("View Assignments Exams Projects.aspx");
        }

        protected void gotogradeassignments(object sender, EventArgs e)
        {
            Response.Redirect("InstructorGradeStudent.aspx");
        }

        protected void gotoviewfeedback(object sender, EventArgs e)
        {
            Response.Redirect("View Feedback.aspx");
        }

        protected void gotoissuecertificate(object sender, EventArgs e)
        {
            Response.Redirect("Issue Certificate.aspx");
        }
        protected void AddMobile(object sender, EventArgs e)
        {
            string connStr = WebConfigurationManager.ConnectionStrings["GUCera"].ToString();
            SqlConnection conn = new SqlConnection(connStr);

            //@ID 
            //@mobile_number   
            if (Mobile.Text == "" || Id.Text == "")
            {
                Response.Write("Enter A Valid Mobile Number");
            }
            else
            {
                try
                {
                    Int64 mob = Int64.Parse(Mobile.Text);
                    int id = int.Parse(Id.Text);

                    SqlCommand AddMobileproc = new SqlCommand("AddMobile", conn);
                    AddMobileproc.CommandType = CommandType.StoredProcedure;

                    AddMobileproc.Parameters.Add(new SqlParameter("@mobile_number", mob));
                    AddMobileproc.Parameters.Add(new SqlParameter("@ID", id));

                    conn.Open();
                    AddMobileproc.ExecuteNonQuery();
                    conn.Close();

                    Response.Write(mob + " is Added, ");
                    Response.Write("Mobile Number is Added Successfully");
                }
                catch (SqlException s)
                {
                    Response.Write("Invalid Action, Either the number is repeated or the ID is Wrong");
                }
            }

        }
    }
}