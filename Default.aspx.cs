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
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Label3.Text = "Mark Attendance for " + DateTime.Now.ToShortDateString();

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
           /** foreach (GridViewRow row in GridView1.Rows)
            {
                RadioButton rbPresent = (RadioButton)row.FindControl("RadioButton1");

                string mainconn = ConfigurationManager.ConnectionStrings["Myconnection"].ConnectionString;
                SqlConnection sqlconn = new SqlConnection(mainconn);
                string sqlquery = "insert into [dbo].[StudentDetail](rollno,studentname,class)" + "values(@rollno,@studentname ,@sclass)";
                sqlconn.Open();
                SqlCommand sqlcomm = new SqlCommand(sqlquery, sqlconn);
                sqlcomm.Parameters.AddWithValue("@rollno", row.Cells[0].Text);
                sqlcomm.Parameters.AddWithValue("@studentname", row.Cells[1].Text);
                //sqlcomm.Parameters.AddWithValue("@dateofclass1", DateTime.Now.ToString());
               // sqlcomm.Parameters.AddWithValue("@attendancestatus", DateTime.Now.ToString());
               // sqlcomm.Parameters.AddWithValue("@status", (rbPresent.Checked ? "True" : "False"));
                sqlcomm.Parameters.AddWithValue("@sclass", DropDownList1.SelectedValue);
                sqlcomm.ExecuteNonQuery();
            } **/
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            foreach (GridViewRow row in GridView1.Rows)
            {
                RadioButton rbPresent = (RadioButton)row.FindControl("RadioButton1");

                string mainconn = ConfigurationManager.ConnectionStrings["Myconnection"].ConnectionString;
                SqlConnection sqlconn = new SqlConnection(mainconn);
                string sqlquery = "insert into [dbo].[StudentAttendance](rollno,studentname,dateofclass,attendancestatus,class)" + "values(@rollno,@studentname ,@dateofclass1 ,@attendancestatus ,@sclass)";
                sqlconn.Open();
                SqlCommand sqlcomm = new SqlCommand(sqlquery, sqlconn);
                sqlcomm.Parameters.AddWithValue("@rollno", row.Cells[0].Text);
                sqlcomm.Parameters.AddWithValue("@studentname", row.Cells[1].Text);
                sqlcomm.Parameters.AddWithValue("@dateofclass1", DateTime.Now.ToString());
                sqlcomm.Parameters.AddWithValue("@attendancestatus", (rbPresent.Checked ? "Present" : "Adsent"));
               // sqlcomm.Parameters.AddWithValue("@status", (rbPresent.Checked ? "True" : "False"));
                sqlcomm.Parameters.AddWithValue("@sclass", DropDownList1.SelectedValue);
                sqlcomm.ExecuteNonQuery();
            }


            Label4.Text = "Attendance Has Been Saved Successfully";
        }
        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }

}