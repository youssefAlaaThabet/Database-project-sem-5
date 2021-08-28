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
    public partial class promocodes : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string connStr = WebConfigurationManager.ConnectionStrings["GUCera"].ToString();

            //create a new connection
            SqlConnection conn = new SqlConnection(connStr);
            SqlCommand view = new SqlCommand("viewPromocode", conn);

            String sid = SID.Text;
            if (sid == "")
            {
                Response.Write("You have to write your ID");
            }
            else
            {
                view.Parameters.Add(new SqlParameter("@sid", sid));

                view.CommandType = CommandType.StoredProcedure;

                conn.Open();
                SqlDataAdapter s = new SqlDataAdapter(view);
                DataTable m = new DataTable();
                s.Fill(m);
                GridView1.DataSource = m;
                GridView1.DataBind();
                if (m.Rows.Count == 0)
                {
                    Response.Write("you either do not have a Promocode OR you entered a Wrong Input");
                }
                conn.Close();
            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("student page.aspx");

        }
    }
}