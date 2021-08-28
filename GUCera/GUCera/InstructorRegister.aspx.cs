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
    public partial class InstructorRegister : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void register4(object sender, EventArgs e)
        {
            string connStr = System.Web.Configuration.WebConfigurationManager.ConnectionStrings["GUCera"].ToString();
            //create a new connection
            SqlConnection conn = new SqlConnection(connStr);
            String firstname = firstName2.Text;
            String lastname = lastName2.Text;
            String password = password2.Text;
            String email = email2.Text;
            String address = address2.Text;
            int gender = Int16.Parse(gender2.SelectedValue);
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
                    SqlCommand instructorregisterproc = new SqlCommand("InstructorRegister", conn);
                instructorregisterproc.CommandType = CommandType.StoredProcedure;
                instructorregisterproc.Parameters.Add(new SqlParameter("@first_name", firstname));
                instructorregisterproc.Parameters.Add(new SqlParameter("@last_name", lastname));
                instructorregisterproc.Parameters.Add(new SqlParameter("@password", password));
                instructorregisterproc.Parameters.Add(new SqlParameter("@email", email));
                instructorregisterproc.Parameters.Add(new SqlParameter("@gender", gender));
                instructorregisterproc.Parameters.Add(new SqlParameter("@address", address));
                conn.Open(); 
                
                    instructorregisterproc.ExecuteNonQuery();
                    Response.Redirect("login.aspx");

                }
                catch (SqlException s)
                {
                    Response.Write("Already used Email Please write a different one ");
                }
                conn.Close();


            }
        }
    }
}