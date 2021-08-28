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
    public partial class student_page : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void viewAssign(object sender, EventArgs e)
        {
           
            Response.Redirect("view Assignments.aspx");


        }
        protected void submitAssign(object sender, EventArgs e)
        {
            
            Response.Redirect("submit Assignment.aspx");

        }
        protected void viewAssignGrades(object sender, EventArgs e)
        {
           
            Response.Redirect("view Assignment grade.aspx");

        }
        protected void addFeedback(object sender, EventArgs e)
        {
           
            Response.Redirect("Feedback.aspx");

        }
        protected void viewCertificate(object sender, EventArgs e)
        {
           
            Response.Redirect("view certificates.aspx");

        }

        protected void viewprofile(object sender, EventArgs e)
        {
            Response.Redirect("viewprofile.aspx");
        }

        protected void viewcourses(object sender, EventArgs e)
        {
            Response.Redirect("viewcourses.aspx");
        }

        protected void EnrollCourse(object sender, EventArgs e)
        {
            Response.Redirect("Enrollcourse.aspx");
        }

        protected void addcreditcard(object sender, EventArgs e)
        {
            Response.Redirect("addcreditcard.aspx");
        }

        protected void promocodes(object sender, EventArgs e)
        {
            Response.Redirect("promocodes.aspx");
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
