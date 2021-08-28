using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace GUCera
{
    public partial class Admins : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ListallCourses(object sender, EventArgs e)
        {

            Response.Redirect("ListAllCou.aspx");


        }
        protected void NotAcceptedCourses(object sender, EventArgs e)
        {
            Response.Redirect("NotAcceptedCou.aspx");
        }
        protected void AcceptCourses(object sender, EventArgs e)
        {
            Response.Redirect("AcceptCou.aspx");
        }
        protected void CreateNewPromocode(object sender, EventArgs e)
        {
            Response.Redirect("CreatePromo.aspx");
        }
        protected void IssuePromocodeToStudent(object sender, EventArgs e)
        {
            Response.Redirect("IssuePromo.aspx");
        }

        protected void AddMobile(object sender, EventArgs e)
        {

            string connStr = WebConfigurationManager.ConnectionStrings["GUCera"].ToString();
            SqlConnection conn = new SqlConnection(connStr);

            //@ID 
            //@mobile_number   
            if (Mobile.Text == "" || Id.Text == "")
            {
                Label nocontent = new Label();
                nocontent.Text = "Invalid ID or Mobile Number, Please Enter A Valid Inputs";
                nocontent.CssClass = "badge badge-danger";
                form1.Controls.Add(nocontent);
            }
            else
            {
                try
                {
                    Int64 mob = Int64.Parse(Mobile.Text);
                    int id = int.Parse(Id.Text);

                    SqlCommand AddMobileproc = new SqlCommand("AddMobile", conn);
                    AddMobileproc.CommandType = CommandType.StoredProcedure;

                    AddMobileproc.Parameters.Add(new SqlParameter("@mobile_number", mob));
                    AddMobileproc.Parameters.Add(new SqlParameter("@ID", id));

                    conn.Open();
                    AddMobileproc.ExecuteNonQuery();
                    conn.Close();

                    Label nocontent = new Label();
                    nocontent.Text = mob + " is Added," + "Mobile Number is Added Successfully";
                    nocontent.CssClass = "badge badge-success";
                    form1.Controls.Add(nocontent); 
                }
                catch (SqlException s)
                {
                    Label nocontent = new Label();
                    nocontent.Text = "Invalid Action, Either the number is repeated or the ID is Wrong";
                    nocontent.CssClass = "badge badge-danger";
                    form1.Controls.Add(nocontent);
                }
            }

        }
    }
}