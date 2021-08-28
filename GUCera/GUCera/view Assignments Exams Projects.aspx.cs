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
    public partial class view_Assigments_Exams_Projects : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ShowstudentsAssigments(object sender, EventArgs e)
        {
            string connStr = WebConfigurationManager.ConnectionStrings["GUCera"].ToString();
            //creater a new connection
            SqlConnection conn = new SqlConnection(connStr);

            String InsID = InstID.Text;
            String CID = cid.Text;

            if (InstID.Text == "")
            {
                Response.Write("Instructor ID can not be empty");
            }
            if (cid.Text == "")
            {
                Response.Write("Course ID can not be empty");
            }
            if (cid.Text != "" && InstID.Text != "")
            {

                SqlCommand SHOWASSIGMENTS = new SqlCommand("InstructorViewAssignmentsStudents", conn);
                SHOWASSIGMENTS.CommandType = CommandType.StoredProcedure;
                SHOWASSIGMENTS.Parameters.Add(new SqlParameter("@instrId", InsID));
                SHOWASSIGMENTS.Parameters.Add(new SqlParameter("@cid", CID));

                conn.Open();
                SqlDataAdapter sda = new SqlDataAdapter(SHOWASSIGMENTS);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                GridView1.DataSource = dt;
                GridView1.DataBind();
                if (dt.Rows.Count == 0)
                {
                    Response.Write("No Assignments available for this Course");
                }

                // SHOWASSIGMENTS.ExecuteNonQuery();
                // Response.Write("Assigments Shown Successfully");
                conn.Close();
            }
        }
        protected void INSTRUCTOR_Click(object sender, EventArgs e)
        {
            Response.Redirect("Instructor.aspx");
        }
    }
}
