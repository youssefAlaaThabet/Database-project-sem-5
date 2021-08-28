

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
    public partial class Instructor_ADD_Course : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void addcourse_Click(object sender, EventArgs e)
        {
            string connStr = WebConfigurationManager.ConnectionStrings["GUCera"].ToString();
            //creater a new connection
            SqlConnection conn = new SqlConnection(connStr);

            //int credithours = Int16.Parse(addedcoursecredithours.Text);
            //String coursename = addedcoursename.Text;
            //Decimal courseprice = Convert.ToDecimal(addedcourseprice.Text);
            //int InstID = Int16.Parse(instructorid.Text);

            String credithours = addedcoursecredithours.Text;
            String coursename = addedcoursename.Text;
            String courseprice = addedcourseprice.Text;
            String InstID = instructorid.Text;

            if (addedcoursecredithours.Text == "")
            {
                Response.Write("Course Credit Hours can not be empty");
            }
            if (addedcoursename.Text == "")
            {
                Response.Write("Course Name can not be empty");
            }
            if (addedcourseprice.Text == "")
            {
                Response.Write("Course Price can not be empty");
            }
            if (instructorid.Text == "")
            {
                Response.Write("Instructor ID can not be empty");
            }

            if (addedcoursecredithours.Text != "" && coursename != "" && courseprice != "" && InstID != "")
            {
                try
                {
                    SqlCommand ADDCOURSE = new SqlCommand("InstAddCourse", conn);
                    ADDCOURSE.CommandType = CommandType.StoredProcedure;
                    ADDCOURSE.Parameters.Add(new SqlParameter("@creditHours", credithours));
                    ADDCOURSE.Parameters.Add(new SqlParameter("@name", coursename));
                    ADDCOURSE.Parameters.Add(new SqlParameter("@price", courseprice));
                    ADDCOURSE.Parameters.Add(new SqlParameter("@instructorId", InstID));



                    conn.Open();
                    ADDCOURSE.ExecuteNonQuery();
                    Response.Write("Course added successfully");
                    conn.Close();
                }
                catch (SqlException s)
                {
                    Response.Write("Course Name already Exits");
                }
            }
        }
        protected void INSTRUCTOR_Click(object sender, EventArgs e)
        {
            Response.Redirect("Instructor.aspx");
        }


    }
}