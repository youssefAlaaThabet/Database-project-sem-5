using System;
using System.Data;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace GUCera
{
    public partial class login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void Register1(object sender, EventArgs e)
        {
            Response.Redirect("StudentRegister.aspx");


        }
        protected void Register2(object sender, EventArgs e)
        {
            Response.Redirect("InstructorRegister.aspx");


        }




        protected void Login(object sender, EventArgs e)
        {
            string connStr = WebConfigurationManager.ConnectionStrings["GUCera"].ToString();
            //create a new connection
            SqlConnection conn = new SqlConnection(connStr);


            String id = Username.Text;
            String pass = Password.Text;
            if (Username.Text == "")
            {
                Response.Write("Please write Your Username!/");
            }
            if (Password.Text == "")
            {
                Response.Write("Please write Your Password!/");
            }

            if (Username.Text != "" && Password.Text !="")
            {
                Response.Write("Please write Your ID!/");

                SqlCommand loginproc = new SqlCommand("userLogin", conn);
                loginproc.Parameters.Add(new SqlParameter("@id", id));
                loginproc.Parameters.Add(new SqlParameter("@password", pass));
                SqlParameter success = loginproc.Parameters.Add("@success", SqlDbType.Int);
                SqlParameter type = loginproc.Parameters.Add("@type", SqlDbType.Int);
                loginproc.CommandType = CommandType.StoredProcedure;

                success.Direction = ParameterDirection.Output;
                type.Direction = ParameterDirection.Output;
                conn.Open();
                loginproc.ExecuteNonQuery();
                conn.Close();

                if (success.Value.ToString() == "1")
                {

                    if (type.Value.ToString() == "2")
                    {
                        Session["user"] = id;
                        Response.Redirect("student page.aspx");


                    }
                    if (type.Value.ToString() == "0")
                    {
                        Session["user"] = id;
                        Response.Redirect("Instructor.aspx");
                    }
                    if (type.Value.ToString() == "1")
                    {
                        Session["user"] = id;

                        Response.Redirect("Admins.aspx");

                    }
                }
                if (success.Value.ToString() == "0")
                {
                    Response.Write("Wrong Username or password Please check  your Data and try again");
                }
            }
        }
        
    }
}