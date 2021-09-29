using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace Student_Management_System
{
    public partial class OnlineAdmission : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string mainconn = ConfigurationManager.ConnectionStrings["Myconnection"].ConnectionString;
            SqlConnection sqlconn = new SqlConnection(mainconn);
            String query = "insert into [dbo].[OnlineAdmission] (uname,gender,contact,gmail,city)"+ "values(@uname,@gender,@contact,@gmail,@city)";
            //  String mycon = "Data Source=VIKAS-PC\\SQLEXPRESS; Initial Catalog=RegistrationFormData; Integrated Security=true";
            // SqlConnection con = new SqlConnection(mycon);
            sqlconn.Open();
            //cmd.Connection = sqlconn;
            SqlCommand sqlcomm = new SqlCommand(query, sqlconn);

            sqlcomm.Parameters.AddWithValue("@uname", TextBox1.Text);
            sqlcomm.Parameters.AddWithValue("@gender", DropDownList1.Text);
            sqlcomm.Parameters.AddWithValue("@contact", TextBox2.Text);
            sqlcomm.Parameters.AddWithValue("@gmail", TextBox3.Text);
            sqlcomm.Parameters.AddWithValue("@city", TextBox4.Text);

            sqlcomm.ExecuteNonQuery();
            Label1.Text= "New Registration Successfully Saved";
           
        }
    }
}