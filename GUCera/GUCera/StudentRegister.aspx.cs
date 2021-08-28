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
    public partial class Register : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void register3(object sender, EventArgs e)
        {
            string connStr = System.Web.Configuration.WebConfigurationManager.ConnectionStrings["GUCera"].ToString();
            //create a new connection
            SqlConnection conn = new SqlConnection(connStr);
            String firstname = firstName1.Text;
            String lastname = lastName1.Text;
            String password = password1.Text;
            String email = email1.Text;
            String address = address1.Text;
            int gender = Int16.Parse(gender1.SelectedValue);
            if (firstname == "")
            {
                Response.Write("PLease write Your Firstname!/");

            }
            if (lastname == "")
            {
                Response.Write("PLease write Your Lastname!/");


            }
            if (password == "")
            {
                Response.Write("PLease write Your Password!/");

            }
            if (email == "")
            {
                Response.Write("PLease write Your Email!/");

            }
            if (address == "")
            {
                Response.Write("PLease write Your Address!/");

            }
            if (firstname != "" && lastname != "" && password != "" && email != "" && address != "")
            {
                try
                {

                    SqlCommand studentregisterproc = new SqlCommand("studentRegister", conn);
                studentregisterproc.CommandType = CommandType.StoredProcedure;
                studentregisterproc.Parameters.Add(new SqlParameter("@first_name", firstname));
                studentregisterproc.Parameters.Add(new SqlParameter("@last_name", lastname));
                studentregisterproc.Parameters.Add(new SqlParameter("@password", password));
                studentregisterproc.Parameters.Add(new SqlParameter("@email", email));
                studentregisterproc.Parameters.Add(new SqlParameter("@gender", gender));
                studentregisterproc.Parameters.Add(new SqlParameter("@address", address));
                conn.Open();
                  studentregisterproc.ExecuteNonQuery();
                    Response.Redirect("login.aspx");

                }
                catch (SqlException s)
                {
                    Response.Write("Already used Email Please write a different one ");
                }
                conn.Close();


            }
        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
    
}