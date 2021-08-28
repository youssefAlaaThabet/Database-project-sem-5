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
    public partial class Define_Assigments : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void DefineAssigmentforcourse(object sender, EventArgs e)
        {
            string connStr = WebConfigurationManager.ConnectionStrings["GUCera"].ToString();
            //creater a new connection
            SqlConnection conn = new SqlConnection(connStr);


            String InstID = InstID2.Text;
            String cid = courseID2.Text;
            String Assignum = Assigmentnum.Text;
            String Assigtype = AssigmentType.Text;
            String assigmentfullgrade = fullgrade.Text;
            String assigmentweight = weight.Text;
            String assigmentdeadline = deadline.Text;
            String assigmentcontent = content.Text;

            if (InstID2.Text == "")
            {
                Response.Write("Instructor ID can not be empty");
            }
            if (courseID2.Text == "")
            {
                Response.Write("Course ID can not be empty");
            }
            if (Assigmentnum.Text == "")
            {
                Response.Write("Assigment number can not be empty");
            }
            if (Assigtype == "")
            {
                Response.Write("Assigment Type can not be empty");
            }
            if (fullgrade.Text == "")
            {
                Response.Write("Full Grade can not be empty");
            }
            if (weight.Text == "")
            {
                Response.Write("Course Weight can not be empty");
            }
            if (deadline.Text == "")
            {
                Response.Write("Deadline can not be empty");
            }
            if (content.Text == "")
            {
                Response.Write("Course Content can not be empty");
            }
            if (InstID2.Text != "" && courseID2.Text != "" && Assigmentnum.Text != "" && Assigtype != "" && fullgrade.Text != ""
              && weight.Text != "" && deadline.Text != "" && content.Text != "")
            {
                try
                {
                    SqlCommand DefineAssigment = new SqlCommand("DefineAssignmentOfCourseOfCertianType", conn);
                    DefineAssigment.CommandType = CommandType.StoredProcedure;
                    DefineAssigment.Parameters.Add(new SqlParameter("@instId", InstID));
                    DefineAssigment.Parameters.Add(new SqlParameter("@cid", cid));
                    DefineAssigment.Parameters.Add(new SqlParameter("@number", Assignum));
                    DefineAssigment.Parameters.Add(new SqlParameter("@type", Assigtype));
                    DefineAssigment.Parameters.Add(new SqlParameter("@fullGrade", assigmentfullgrade));
                    DefineAssigment.Parameters.Add(new SqlParameter("@weight", assigmentweight));
                    DefineAssigment.Parameters.Add(new SqlParameter("@deadline", assigmentdeadline));
                    DefineAssigment.Parameters.Add(new SqlParameter("@content", assigmentcontent));




                    conn.Open();
                    DefineAssigment.ExecuteNonQuery();
                    Response.Write("Assignment added to course");
                    conn.Close();
                }
                catch (SqlException s)
                {
                    Response.Write("Assignment already exits");
                }
            }
        }
        protected void INSTRUCTOR_Click(object sender, EventArgs e)
        {
            Response.Redirect("Instructor.aspx");
        }
    }
}