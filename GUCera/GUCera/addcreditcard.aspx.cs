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
    public partial class addcreditcard : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string connStr = WebConfigurationManager.ConnectionStrings["GUCera"].ToString();

            //create a new connection
            SqlConnection conn = new SqlConnection(connStr);
            SqlCommand view = new SqlCommand("addCreditCard", conn);
            String sid = SID.Text;
            String number = Number.Text;
            String name = Name.Text;
            String date = Date.Text;
            String cvv = CVV.Text;
            if (Number.Text == "")
            {
                Response.Write("You have to enter the credit card number");
            }
            if (Name.Text == "")
            {
                Response.Write("You have to enter the name");
            }
            if (Date.Text == "")
            {
                Response.Write("You have to enter the date");
            }
            if (CVV.Text == "")
            {
                Response.Write("You have to enter the CVV");
            }
            if (SID.Text == "")
            {
                Response.Write("You have to enter Your ID");
            }
            if (SID.Text != "" && Number.Text != "" && Date.Text != "" && CVV.Text != "" && Name.Text != "")
            {
                view.Parameters.Add(new SqlParameter("@sid", sid));
                view.Parameters.Add(new SqlParameter("@number", number));
                view.Parameters.Add(new SqlParameter("@cardHolderName", name));
                view.Parameters.Add(new SqlParameter("@expiryDate", date));
                view.Parameters.Add(new SqlParameter("@cvv", cvv));
                view.CommandType = CommandType.StoredProcedure;

                conn.Open();
                view.ExecuteNonQuery();

                conn.Close();
                Label l = new Label();
                l.Text = "Credit Card Added successfully";
                form1.Controls.Add(l);
            }
        }

        protected void SUBMIT_Click(object sender, EventArgs e)
        {
            Response.Redirect("student page.aspx");

        }
    }
}