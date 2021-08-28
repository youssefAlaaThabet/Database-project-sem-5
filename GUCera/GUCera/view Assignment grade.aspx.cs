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
    public partial class view_Assignment_grade : System.Web.UI.Page
    {
        

        protected void Grade_Click(object sender, EventArgs e)
        {
            string connStr = WebConfigurationManager.ConnectionStrings["GUCera"].ToString();

            //create a new connection
            SqlConnection conn = new SqlConnection(connStr);
            SqlCommand view = new SqlCommand("viewAssignGrades", conn);
            String cid = CID.Text;
            String sid =SID.Text;
            String type = Type.Text;
            String number =Number.Text;
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

            if (CID.Text!="" && SID.Text !="" && Type.Text !="" && Number.Text !=""  )
            {
                view.Parameters.Add(new SqlParameter("@assignnumber", number));

                view.Parameters.Add(new SqlParameter("@assignType", type));

                view.Parameters.Add(new SqlParameter("@cid", cid));
                view.Parameters.Add(new SqlParameter("@sid", sid));
                SqlParameter assigngrade = view.Parameters.Add("@assignGrade", SqlDbType.Int);
                assigngrade.Direction = ParameterDirection.Output;
                view.CommandType = CommandType.StoredProcedure;


                conn.Open();
                view.ExecuteNonQuery();
                conn.Close();


                // String s = (assigngrade.Value) + "";

                //Response.Write(s);

                //assigngrade.Value.Equals()

                if (assigngrade.Value.ToString() == "")
                {
                    Response.Write("your Grade is not availabe yet or you entered a wrong input(Please check Your Data or try again later )");
                }
                if(assigngrade.Value.ToString()!="")
                {
                    Label l = new Label();
                    l.Text = "Your Grade is:" + assigngrade.Value + "";
                    form1.Controls.Add(l);
                }
            }
        }
        protected void Page_Load(object sender, EventArgs e)
        {
          
        
        }

        protected void STUDENT_Click(object sender, EventArgs e)
        {
            Response.Redirect("student page.aspx");
        }
    }
    }