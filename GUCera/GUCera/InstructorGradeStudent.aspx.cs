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
    public partial class InstructorGradeStudent : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void SubmitGrade(object sender, EventArgs e)
        {
            string connStr = WebConfigurationManager.ConnectionStrings["GUCera"].ToString();
            //creater a new connection
            SqlConnection conn = new SqlConnection(connStr);

            String InsID = InstID.Text;
            String StuID = StudentID.Text;
            String cid = CourseID.Text;
            String Assigmentnum = AssigmentNumber.Text;
            String type = AssigmentType.Text;
            String StudentGrade = Grade.Text;

            if (InstID.Text == "")
            {
                Response.Write("Instructor ID can not be empty");
            }
            if (StudentID.Text == "")
            {
                Response.Write("Student ID can not be empty");
            }
            if (CourseID.Text == "")
            {
                Response.Write("Course ID can not be empty");
            }
            if (AssigmentNumber.Text == "")
            {
                Response.Write("Assigment Number can not be empty");
            }
            if (AssigmentType.Text == "")
            {
                Response.Write("Assigment Type can not be empty");
            }
            if (Grade.Text == "")
            {
                Response.Write("Student Grade can not be empty");
            }
            if (InsID != "" && StuID != "" && cid != "" && Assigmentnum != "" && type != "" && StudentGrade != "")
            {
                SqlCommand ADDGRADE = new SqlCommand("InstructorgradeAssignmentOfAStudent", conn);
                ADDGRADE.CommandType = CommandType.StoredProcedure;
                ADDGRADE.Parameters.Add(new SqlParameter("@instrId", InsID));
                ADDGRADE.Parameters.Add(new SqlParameter("@sid", StuID));
                ADDGRADE.Parameters.Add(new SqlParameter("@cid", cid));
                ADDGRADE.Parameters.Add(new SqlParameter("@assignmentNumber", Assigmentnum));
                ADDGRADE.Parameters.Add(new SqlParameter("@type", type));
                ADDGRADE.Parameters.Add(new SqlParameter("@grade", StudentGrade));



                conn.Open();
                ADDGRADE.ExecuteNonQuery();
                Response.Write("Grade ADDED Successfully");
                conn.Close();
            }
        }
        protected void INSTRUCTOR_Click(object sender, EventArgs e)
        {
            Response.Redirect("Instructor.aspx");
        }
    }
}