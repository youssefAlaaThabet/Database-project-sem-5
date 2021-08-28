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
    public partial class Enrollcourse : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string connStr = WebConfigurationManager.ConnectionStrings["GUCera"].ToString();

            //create a new connection
            SqlConnection conn = new SqlConnection(connStr);
            SqlCommand view = new SqlCommand("enrollInCourse", conn);
            String cid = CID.Text;
            String sid = SID.Text;
            String inid = INID.Text;
            if (cid == "")
            {
                Response.Write("Write Course ID");
            }
            if (inid == "")
            {
                Response.Write("Write Instructor ID");
            }
            if (sid == "")
            {
                Response.Write("Write Student ID");
            }
            if (cid != "" && sid != "" && inid != "")
            {
                view.Parameters.Add(new SqlParameter("@sid", sid));
                view.Parameters.Add(new SqlParameter("@cid", cid));
                view.Parameters.Add(new SqlParameter("@instr", inid));
                view.CommandType = CommandType.StoredProcedure;

                conn.Open();
                view.ExecuteNonQuery();

                conn.Close();
                Label l = new Label();
                l.Text = "Enrolled in Course successfully";
                form1.Controls.Add(l);
            }
        }
        protected void SUBMIT_Click(object sender, EventArgs e)
        {
            Response.Redirect("student page.aspx");
        }

        
    }
}