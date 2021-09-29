using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Net;
using System.Net.Mail;

namespace Student_Management_System
{
    public partial class StudentPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            LitJoindate.Text = DateTime.Now.ToString();
        }

        protected void ButStudent_Click(object sender, EventArgs e)
        {
            string mainconn = ConfigurationManager.ConnectionStrings["Myconnection"].ConnectionString;
            SqlConnection sqlconn = new SqlConnection(mainconn);
            string sqlquery = "Insert into [dbo].[student] (Stfname,Stlname,StFathername,StFatherPhone,StEmail,Stphone,Coursejoin,CourseFees,Firstinstallment,FeesDus,Joindate)" +
                "values(@Stfname,@Stlname,@StFathername,@StFatherPhone,@StEmail,@Stphone,@Coursejoin,@CourseFees,@Firstinstallment,@FeesDus,@Joindate)";
            sqlconn.Open();
            SqlCommand sqlcomm = new SqlCommand(sqlquery, sqlconn);
            sqlcomm.Parameters.AddWithValue("@Stfname", TxtStFname.Text);
            sqlcomm.Parameters.AddWithValue("@Stlname", TxtStLname.Text);
            sqlcomm.Parameters.AddWithValue("@StFathername", TxtFatherName.Text);
            sqlcomm.Parameters.AddWithValue("@StFatherPhone", TxtFatherPhone.Text);
            sqlcomm.Parameters.AddWithValue("@StEmail", TxtStEmail.Text);
            sqlcomm.Parameters.AddWithValue("@Stphone", TxtPhone.Text);
            sqlcomm.Parameters.AddWithValue("@Coursejoin", DDLCourseName.SelectedItem.Text);
            sqlcomm.Parameters.AddWithValue("@CourseFees", LabCourseFees.Text);
            sqlcomm.Parameters.AddWithValue("@Firstinstallment", TxtCourseInstallment.Text);
            sqlcomm.Parameters.AddWithValue("@FeesDus", LabDueFees.Text);
            sqlcomm.Parameters.AddWithValue("@Joindate", LitJoindate.Text);
            sqlcomm.ExecuteNonQuery();
            Labmsg.Text = "The Student" + TxtStFname.Text + "Is Saved Successfully....</br> The Fee Recipt has been send to email" + TxtStEmail.Text;
            MailMessage mm = new MailMessage("shohalafzal86@gmail.com", TxtStEmail.Text);
            mm.Subject = "Recipt Details....";
            mm.Body = "The Course name" + DDLCourseName.SelectedItem.Text + "You Have Joined and The Total Course Fee is " + LabCourseFees.Text + " and the instalment is " + TxtCourseInstallment.Text + " <br/> The balance is " + LabDueFees.Text + " <br/><h3 style='color:red'>Note:The Certificat will not be Issued until the balance amount is clear...!</h3>";
            mm.IsBodyHtml = true;

            SmtpClient smtp = new SmtpClient();
            smtp.Host = "smtp.gmail.com";
            smtp.Port = 587;
            smtp.EnableSsl = true;

            NetworkCredential nc = new NetworkCredential("shohalafzal86@gmail.com", "Admin@123");
            smtp.UseDefaultCredentials = true;
            smtp.Credentials = nc;
            smtp.Send(mm);
            sqlconn.Close();

        
      


}

        protected void DDLCourseName_SelectedIndexChanged(object sender, EventArgs e)
        {
            string mainconn = ConfigurationManager.ConnectionStrings["Myconnection"].ConnectionString;
            SqlConnection sqlconn = new SqlConnection(mainconn);
            string sqlquery = "select * from [dbo].[Coursetable] where Cname=@Cname";
            sqlconn.Open();
            SqlCommand sqlcomm = new SqlCommand(sqlquery, sqlconn);
            sqlcomm.Parameters.AddWithValue("@Cname", DDLCourseName.SelectedItem.Text);
            SqlDataReader sdr = sqlcomm.ExecuteReader();
            while(sdr.Read()){

                LabCourseFees.Text = sdr["Cfees"].ToString();
            }
            sqlconn.Close();
        }

        protected void TxtCourseInstallment_TextChanged(object sender, EventArgs e)
        {
            int balance = Convert.ToInt32(LabCourseFees.Text) - Convert.ToInt32(TxtCourseInstallment.Text);
            LabDueFees.Text = balance.ToString();
        }
    }
}