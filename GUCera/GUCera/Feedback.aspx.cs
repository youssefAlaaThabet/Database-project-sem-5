using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace GUCera
{
    public partial class Feedback : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void SUMBIT_Click(object sender, EventArgs e)
        {
            string connStr = System.Web.Configuration.WebConfigurationManager.ConnectionStrings["GUCera"].ToString();
            //create a new connection
            SqlConnection conn = new SqlConnection(connStr);
            SqlCommand view = new SqlCommand("addFeedback", conn);
            view.CommandType = CommandType.StoredProcedure;

            String cid = CID.Text;
            String sid = SID.Text;
            String comment = Comment.Text;

            if (CID.Text == "")
            {
                Response.Write("Please write Course ID!/");
            }
            if (SID.Text == "")
            {
                Response.Write("Please write Your ID!/");
            }
            if (Comment.Text == "")
            {
                Response.Write("Please write Your Comment!/");
            }
            

            if (CID.Text != "" && SID.Text != "" && Comment.Text != "" )
            {

                view.Parameters.Add(new SqlParameter("@comment", comment));
                view.Parameters.Add(new SqlParameter("@cid", cid));
                view.Parameters.Add(new SqlParameter("@sid", sid));
                conn.Open();
                view.ExecuteNonQuery();
                conn.Close();
                Label message = new Label();
                message.Text = "Feedback Submitted successfully";
                form1.Controls.Add(message);
            }
        }

        protected void SUBMIT_Click(object sender, EventArgs e)
        {
            Response.Redirect("student page.aspx");

        }
    }
}