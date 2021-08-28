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
    public partial class submit_Assignment : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void submitass_Click(object sender, EventArgs e)
        {
            string connStr = WebConfigurationManager.ConnectionStrings["GUCera"].ToString();

            //create a new connection
            SqlConnection conn = new SqlConnection(connStr);
            SqlCommand view = new SqlCommand("submitAssign", conn);
            view.CommandType = CommandType.StoredProcedure;

            String cid = CID.Text;
            String sid = SID.Text;
            String type = Type.Text;
            String number = Number.Text;
            if (CID.Text == "")
            {
                Response.Write("Please write Course ID!/");
            }
            if (SID.Text == "")
            {
                Response.Write("Please write Your ID!/");
            }
            if (Type.Text == "")
            {
                Response.Write("Please write Assignment Type!/");
            }
            if (Number.Text == "")
            {
                Response.Write("Please write Assignment Number!/");
            }

            if (CID.Text != "" && SID.Text != "" && Type.Text != "" && Number.Text != "")
            {
                try
                {

                    view.Parameters.Add(new SqlParameter("@assignType", type));
                    view.Parameters.Add(new SqlParameter("@assignnumber", sid));
                    view.Parameters.Add(new SqlParameter("@sid", sid));
                    view.Parameters.Add(new SqlParameter("@cid", cid));
                    conn.Open();
                    view.ExecuteNonQuery();
                    conn.Close();
                    Label message = new Label();
                    message.Text = "Assignment Submitted successfully";
                    form1.Controls.Add(message);
                }
                catch (SqlException s)
                {
                    Response.Write("You can not submit the same assignment more than one time");
                }

            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("student page.aspx");

        }
    }
}