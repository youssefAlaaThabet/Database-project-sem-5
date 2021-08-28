using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace GUCera
{
    public partial class view_Assignments : System.Web.UI.Page
    {
        protected void submit(object sender, EventArgs e)
        {
            string connStr = WebConfigurationManager.ConnectionStrings["GUCera"].ToString();

            //create a new connection
            SqlConnection conn = new SqlConnection(connStr);
            SqlCommand view = new SqlCommand("viewAssign", conn);
            
            String course = cid.Text;

            String student = sid.Text;
            if (cid.Text == "")
            {
                Response.Write("Please write Course ID!/");
            }
            if (sid.Text == "")
            {
                Response.Write("Please write Your ID!/");
            }


            if (cid.Text != "" && sid.Text != "")
            {
                view.Parameters.Add(new SqlParameter("@courseId", course));
                view.Parameters.Add(new SqlParameter("@Sid", student));

                view.CommandType = CommandType.StoredProcedure;
                conn.Open();
                SqlDataAdapter n = new SqlDataAdapter(view);
                DataTable f = new DataTable();
                n.Fill(f);
                GridView1.DataSource = f;
                if (f.Rows.Count == 0)
                {
                    Response.Write("you either do not have any assignment or you entered a wrong input(please check your Data !)");

                }
                GridView1.DataBind();
                conn.Close();




            }

        }
        protected void Page_Load(object sender, EventArgs e)
        {


        }
        protected void viewstupage_Click(object sender, EventArgs e)
        {
            Response.Redirect("student page.aspx");

        }
    }
}