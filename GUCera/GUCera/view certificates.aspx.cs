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
    public partial class view_certificates : System.Web.UI.Page
    {


        protected void SUBMIT_Click(object sender, EventArgs e)
        {
            string connStr = WebConfigurationManager.ConnectionStrings["GUCera"].ToString();

            //create a new connection
            SqlConnection conn = new SqlConnection(connStr);
            SqlCommand view = new SqlCommand("viewCertificate", conn);
            String cid = CID.Text;
            String sid = SID.Text;
            if (CID.Text == "")
            {
                Response.Write("Please write Course ID!/");
            }
            if (SID.Text == "")
            {
                Response.Write("Please write Your ID!/");
            }



            if (CID.Text != "" && SID.Text != "")
            {
                view.Parameters.Add(new SqlParameter("@cid", cid));
                view.Parameters.Add(new SqlParameter("@sid", sid));

                view.CommandType = CommandType.StoredProcedure;

                conn.Open();
                SqlDataAdapter n = new SqlDataAdapter(view);
                DataTable f = new DataTable();
                n.Fill(f);
                GridView1.DataSource = f;
                GridView1.DataBind();
                if (f.Rows.Count == 0)
                {
                    Response.Write("you entered a wrong Input or your certificate is not available yet(Please check your Data!)");

                }
                conn.Close();
                
            }
        }
        protected void viewstupage_Click(object sender, EventArgs e)
        {
            Response.Redirect("student page.aspx");

        }
        protected void Page_Load(object sender, EventArgs e)
        {

        }
    }
}