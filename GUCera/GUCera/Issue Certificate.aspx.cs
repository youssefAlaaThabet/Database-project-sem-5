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
    public partial class Issue_Certificate : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void issuecertificate(object sender, EventArgs e)
        {
            string connStr = WebConfigurationManager.ConnectionStrings["GUCera"].ToString();
            //creater a new connection
            SqlConnection conn = new SqlConnection(connStr);

            String CID = cid.Text;
            String SID = sid.Text;
            String InstID = instid.Text;
            String IssueDate = issuedate.Text;

            if (cid.Text == "")
            {
                Response.Write("Course ID can not be empty");
            }
            if (sid.Text == "")
            {
                Response.Write("Student ID can not be empty");
            }
            if (instid.Text == "")
            {
                Response.Write("Instructor ID can not be empty");
            }
            if (issuedate.Text == "")
            {
                Response.Write("Issue Date can not be empty");
            }
            if (CID != "" && SID != "" && InstID != "" && IssueDate != "")
            {
                try
                {
                    SqlCommand ISSUECERTIFICATE = new SqlCommand("InstructorIssueCertificateToStudent", conn);
                    ISSUECERTIFICATE.CommandType = CommandType.StoredProcedure;
                    ISSUECERTIFICATE.Parameters.Add(new SqlParameter("@cid", CID));
                    ISSUECERTIFICATE.Parameters.Add(new SqlParameter("@sid", SID));
                    ISSUECERTIFICATE.Parameters.Add(new SqlParameter("@insId", InstID));
                    ISSUECERTIFICATE.Parameters.Add(new SqlParameter("@issueDate", IssueDate));



                    conn.Open();
                    ISSUECERTIFICATE.ExecuteNonQuery();
                    Response.Write("Issued Certificate Successfully");
                    conn.Close();
                }
                catch (SqlException s)
                {
                    Response.Write("Certificate already Issued");
                }
            }
        }
        protected void INSTRUCTOR_Click(object sender, EventArgs e)
        {
            Response.Redirect("Instructor.aspx");
        }
    }
}



