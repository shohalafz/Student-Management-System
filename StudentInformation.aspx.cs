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
    public partial class StudentInformation : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Button3.Enabled = false;
            Button4.Enabled = false;
            Button5.Enabled = false;
            Button6.Enabled = false;
            TextBox2.Enabled = false;
            TextBox3.Enabled = false;
            TextBox4.Enabled = false;
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            TextBox1.Enabled = true;
            TextBox2.Enabled = true;
            TextBox3.Enabled = true;
            TextBox4.Enabled = true;
            Button1.Enabled = false;
            Button2.Enabled = false;
            Button3.Enabled = true;
            Button6.Enabled = true;
            Button1.Enabled = false;
            Label2.Text = "New Blank Form Has Been Added.";
            Label1.Text = "";
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            string mainconn = ConfigurationManager.ConnectionStrings["Myconnection"].ConnectionString;
            SqlConnection sqlconn = new SqlConnection(mainconn);
            String query = "insert into [dbo].[StudentInformation] (rollno,sname,fathername,mothername)"+" values(@rollno,@sname,@fathername,@mothername)";
            //  String mycon = "Data Source=VIKAS-PC\\SQLEXPRESS; Initial Catalog=RegistrationFormData; Integrated Security=true";
            // SqlConnection con = new SqlConnection(mycon);
            sqlconn.Open();
            //cmd.Connection = sqlconn;
            SqlCommand sqlcomm = new SqlCommand(query, sqlconn);

            sqlcomm.Parameters.AddWithValue("@rollno", TextBox1.Text);
            //sqlcomm.Parameters.AddWithValue("@gender", DropDownList1.Text);
            sqlcomm.Parameters.AddWithValue("@sname", TextBox2.Text);
            sqlcomm.Parameters.AddWithValue("@fathername", TextBox3.Text);
            sqlcomm.Parameters.AddWithValue("@mothername", TextBox4.Text);

            sqlcomm.ExecuteNonQuery();
            Button1.Enabled = true;
            Button2.Enabled = true;
            Button6.Enabled = false;
            TextBox1.Text = "";
            TextBox2.Text = "";
            TextBox3.Text = "";
            TextBox4.Text = "";
            TextBox2.Enabled = false;
            TextBox3.Enabled = false;
            TextBox4.Enabled = false;
            Label2.Text = "Data Has Been Saved Successfully";
            Label1.Text = "";
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            string mainconn = ConfigurationManager.ConnectionStrings["Myconnection"].ConnectionString;
            SqlConnection sqlconn = new SqlConnection(mainconn);
            String query = "Update [dbo].[StudentInformation] set sname='" + TextBox2.Text + "', fathername='" + TextBox3.Text + "', mothername='" + TextBox4.Text + "' where rollno=" + TextBox1.Text;
            //  String mycon = "Data Source=VIKAS-PC\\SQLEXPRESS; Initial Catalog=RegistrationFormData; Integrated Security=true";
            // SqlConnection con = new SqlConnection(mycon);
            sqlconn.Open();
            //cmd.Connection = sqlconn;
            SqlCommand sqlcomm = new SqlCommand(query, sqlconn);

            sqlcomm.Parameters.AddWithValue("@rollno", TextBox1.Text);
            //sqlcomm.Parameters.AddWithValue("@gender", DropDownList1.Text);
            sqlcomm.Parameters.AddWithValue("@sname", TextBox2.Text);
            sqlcomm.Parameters.AddWithValue("@fathername", TextBox3.Text);
            sqlcomm.Parameters.AddWithValue("@mothername", TextBox4.Text);

            sqlcomm.ExecuteNonQuery();
            Label1.Text = "";
            Label2.Text = "Particular Record Has Been Updated Successfully : Roll Number " + TextBox1.Text;
            Button1.Enabled = true;
            Button2.Enabled = true;
            Button3.Enabled = false;
            Button4.Enabled = false;
            Button5.Enabled = false;
            Button6.Enabled = false;
            TextBox1.Text = "";
            TextBox2.Text = "";
            TextBox3.Text = "";
            TextBox4.Text = "";
            TextBox2.Enabled = false;
            TextBox3.Enabled = false;
            TextBox4.Enabled = false;
        }

        protected void Button5_Click(object sender, EventArgs e)
        {
            string mainconn = ConfigurationManager.ConnectionStrings["Myconnection"].ConnectionString;
            SqlConnection sqlconn = new SqlConnection(mainconn);
            String query = "delete from [dbo].[StudentInformation] (rollno,sname,fathername,mothername)"+" values(@rollno,@sname,@fathername,@mothername)";
            //  String mycon = "Data Source=VIKAS-PC\\SQLEXPRESS; Initial Catalog=RegistrationFormData; Integrated Security=true";
            // SqlConnection con = new SqlConnection(mycon);
            sqlconn.Open();
            //cmd.Connection = sqlconn;
            SqlCommand sqlcomm = new SqlCommand(query, sqlconn);

            sqlcomm.Parameters.AddWithValue("@rollno", TextBox1.Text);
            //sqlcomm.Parameters.AddWithValue("@gender", DropDownList1.Text);
            sqlcomm.Parameters.AddWithValue("@sname", TextBox2.Text);
            sqlcomm.Parameters.AddWithValue("@fathername", TextBox3.Text);
            sqlcomm.Parameters.AddWithValue("@mothername", TextBox4.Text);

            sqlcomm.ExecuteNonQuery();
            Label1.Text = "";
            Label2.Text = "Particular Record Has Been Deleted Successfully : Roll Number " + TextBox1.Text;
            Button1.Enabled = true;
            Button2.Enabled = true;
            Button3.Enabled = false;
            Button4.Enabled = false;
            Button5.Enabled = false;
            Button6.Enabled = false;
            TextBox1.Text = "";
            TextBox2.Text = "";
            TextBox3.Text = "";
            TextBox4.Text = "";
            TextBox2.Enabled = false;
            TextBox3.Enabled = false;
            TextBox4.Enabled = false;
        }

        protected void Button6_Click(object sender, EventArgs e)
        {
            Button1.Enabled = true;
            Button2.Enabled = true;
            Button3.Enabled = false;
            Button4.Enabled = false;
            Button5.Enabled = false;
            Button6.Enabled = false;
            TextBox1.Text = "";
            TextBox2.Text = "";
            TextBox3.Text = "";
            TextBox4.Text = "";
            TextBox2.Enabled = false;
            TextBox3.Enabled = false;
            TextBox4.Enabled = false;
            Label2.Text = "Operation Has Been Cancelled Successfully";
            Label1.Text = "";
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string mainconn = ConfigurationManager.ConnectionStrings["Myconnection"].ConnectionString;
            SqlConnection sqlconn = new SqlConnection(mainconn);
            String query = "Select * from [dbo].[StudentInformation]" ;
            //  String mycon = "Data Source=VIKAS-PC\\SQLEXPRESS; Initial Catalog=RegistrationFormData; Integrated Security=true";
            // SqlConnection con = new SqlConnection(mycon);
            sqlconn.Open();
            //cmd.Connection = sqlconn;
            SqlCommand sqlcomm = new SqlCommand(query, sqlconn);

           /**
            * sqlcomm.Parameters.AddWithValue("@rollno", TextBox1.Text);
            //sqlcomm.Parameters.AddWithValue("@gender", DropDownList1.Text);
            sqlcomm.Parameters.AddWithValue("@sname", TextBox2.Text);
            sqlcomm.Parameters.AddWithValue("@fathername", TextBox3.Text);
            sqlcomm.Parameters.AddWithValue("@mothername", TextBox4.Text);
           **/

            sqlcomm.ExecuteNonQuery();
            
             SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = sqlcomm;
            DataSet ds = new DataSet();
            da.Fill(ds);
            if (ds.Tables[0].Rows.Count > 0)
            {
                Label1.Text = "Roll Number Found Successfully";
                Label2.Text = "";
                TextBox2.Text = ds.Tables[0].Rows[0]["sname"].ToString();
                TextBox3.Text = ds.Tables[0].Rows[0]["fathername"].ToString();
                TextBox4.Text = ds.Tables[0].Rows[0]["mothername"].ToString();
                Button4.Enabled = true;
                Button5.Enabled = true;
                Button6.Enabled = true;
                TextBox2.Enabled = true;
                TextBox3.Enabled = true;
                TextBox4.Enabled = true;
                Button2.Enabled = false;
            }
            else
            {
                Label1.Text = "No Particular Searched Roll Number Found";
                Label2.Text = "";

            }
            sqlconn.Close();

        }
    }
}