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
    public partial class TutorPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            LitJoindate.Text = DateTime.Now.ToString();
        }

        protected void ButTutor_Click(object sender, EventArgs e)
        {
            string mainconn = ConfigurationManager.ConnectionStrings["Myconnection"].ConnectionString;
            SqlConnection sqlconn = new SqlConnection(mainconn);
            string sqlquery = "Insert into [dbo].[tutor](Tname,Temail,Tphone,Tcourse,Tqualification,Joindate) values(@Tname,@Temail,@Tphone,@Tcourse,@Tqualification,@Joindate)";
            SqlCommand sqlcomm = new SqlCommand(sqlquery, sqlconn);
            sqlconn.Open();
            sqlcomm.Parameters.AddWithValue("@Tname", TxtTutorname.Text);
            sqlcomm.Parameters.AddWithValue("@Temail", TxtEmail.Text);
            sqlcomm.Parameters.AddWithValue("@Tphone", TxtPhone.Text);
            sqlcomm.Parameters.AddWithValue("@Tcourse", DDLCourse.SelectedItem.Text);
            sqlcomm.Parameters.AddWithValue("@Tqualification", TxtQualification.Text);
            sqlcomm.Parameters.AddWithValue("@Joindate", LitJoindate.Text);

            sqlcomm.ExecuteNonQuery();
            Labmsg.Text = "The Tutor" + TxtTutorname.Text + "Is Saved Successfully.....!";
            TxtTutorname.Text = "";
            TxtEmail.Text = "";
            TxtPhone.Text = "";
            TxtQualification.Text = "";
            sqlconn.Close();
        }
    }
}