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
    public partial class Employee_Information : System.Web.UI.Page
    {
        static String resumelink;

        static Int32 employeeid;
        protected void Page_Load(object sender, EventArgs e)
        {

        }


        protected void Button1_Click(object sender, EventArgs e)
        {
            if (EmployeeDetails()) { 

            //string mainconn = ConfigurationManager.ConnectionStrings["Myconnection"].ConnectionString;
            String query = "insert into [dbo].[EmployeeDetails](employeeid,ename,address,emailaddress,mobilenumber,resumefile) values(" + employeeid + ",'" + TextBox1.Text + "','" + TextBox2.Text + "','" + TextBox3.Text + "','" + TextBox4.Text + "','" + resumelink + "')";
            String mainconn = "Data Source=SHOHAL\\SQLEXPRESS; Initial Catalog=StudentManagementSystem; Integrated Security=true";
            SqlConnection sqlconn = new SqlConnection(mainconn);
            sqlconn.Open();
            SqlCommand cmd = new SqlCommand(query, sqlconn);
            cmd.CommandText = query;
            cmd.Connection = sqlconn;
            cmd.ExecuteNonQuery();
            //object employeeid = null;
            Label2.Text = "Your Application ID is " + employeeid.ToString() + " for Further Reference .Thanks For Apply For The Post: Developer. We will Reach at You Soon.";
            TextBox1.Text = "";
            TextBox2.Text = "";
            TextBox3.Text = "";
            TextBox4.Text = "";
            }

        }

        private Boolean EmployeeDetails()
        {
            Boolean resumesaved = false;
            // object FileUpload1 = null;
            if (FileUpload1.HasFile == true)
            {
                if (FileUpload1.PostedFile.ContentType.ToLower().Contains("pdf"))
                {
                    getemployeeid();
                    FileUpload1.SaveAs(Server.MapPath("~/EmployeeDetails/") + employeeid + ".pdf");

                    resumelink = "EmployeeDetails/" + employeeid + ".pdf";
                    resumesaved = true;
                    Label3.Text = "";
                }
                else
                {
                    Label3.Text = "Upload Resume in PDF Format Only";
                }

            }
            else
            {
                Label3.Text = "Kindly Upload Resume Before Apply in PDF Format";
            }


            return resumesaved;
        }
        public void getemployeeid()
        {
            String mainconn = "Data Source=SHOHAL\\SQLEXPRESS; Initial Catalog=StudentManagementSystem; Integrated Security=true";
            String query = "select employeeid from [dbo].[EmployeeDetails]";
            SqlConnection sqlconn = new SqlConnection(mainconn);
            sqlconn.Open();
            SqlCommand cmd = new SqlCommand(query,sqlconn);
            cmd.CommandText = query;
            cmd.Connection = sqlconn;
            cmd.ExecuteNonQuery();
            //String query = "select employeeid from [dbo].[EmployeeDetails]";
            //SqlCommand cmd = new SqlCommand();
           // cmd.CommandText = myquery;
           // cmd.Connection = scon;
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            DataSet ds = new DataSet();
            da.Fill(ds);
            sqlconn.Close();
            if (ds.Tables[0].Rows.Count < 1)
            {
                int employeeid = 1001;

            }
            else
            {



                String mainconn1 = "Data Source=SHOHAL\\SQLEXPRESS\\SQLEXPRESS;Initial Catalog=StudentManagementSystem;Integrated Security=True";
                SqlConnection sqlconn1 = new SqlConnection(mainconn1);
                String query1 = "select max(employeeid) from [dbo].[EmployeeDetails]";
                SqlCommand cmd1 = new SqlCommand(query1, sqlconn1);
                cmd1.CommandText = query1;
                cmd1.Connection = sqlconn;
                SqlDataAdapter da1 = new SqlDataAdapter();
                da1.SelectCommand = cmd1;
                DataSet ds1 = new DataSet();
                da1.Fill(ds1);
                employeeid = Convert.ToInt32(ds1.Tables[0].Rows[0][0].ToString());
                employeeid = employeeid + 1;
                sqlconn1.Close();
            }

        }
    }
}