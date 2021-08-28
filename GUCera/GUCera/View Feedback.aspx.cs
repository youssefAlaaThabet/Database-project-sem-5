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
    public partial class View_Feedback : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void viewfeedback(object sender, EventArgs e)
        {
            string connStr = WebConfigurationManager.ConnectionStrings["GUCera"].ToString();
            //creater a new connection
            SqlConnection conn = new SqlConnection(connStr);

            String InsID = InstID.Text;
            String cid = CID.Text;

            if (InstID.Text == "")
            {
                Response.Write("Instructor ID can not be empty");
            }
            if (CID.Text == "")
            {
                Response.Write("Course ID can not be empty");
            }

            if (InsID != "" && cid != "")
            {
                SqlCommand VIEWFEEDBACK = new SqlCommand("ViewFeedbacksAddedByStudentsOnMyCourse", conn);
                VIEWFEEDBACK.CommandType = CommandType.StoredProcedure;
                VIEWFEEDBACK.Parameters.Add(new SqlParameter("@instrId", InsID));
                VIEWFEEDBACK.Parameters.Add(new SqlParameter("@cid", cid));

                conn.Open();
                SqlDataAdapter sda = new SqlDataAdapter(VIEWFEEDBACK);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                GridView1.DataSource = dt;
                GridView1.DataBind();
                if (dt.Rows.Count == 0)
                {
                    Response.Write("No feedback availble");
                }
                conn.Close();
            }
        }
        protected void INSTRUCTOR_Click(object sender, EventArgs e)
        {
            Response.Redirect("Instructor.aspx");
        }
    }
}