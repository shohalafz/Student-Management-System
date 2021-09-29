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
    public partial class Library : System.Web.UI.Page
    {
        /**
         * SqlConnection sqlconn = new SqlConnection("Myconnection");
        SqlCommand cmd;
        SqlDataAdapter da;
        DataSet ds;
        string qr;
            **/

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                divBookAdd.Visible = true;
                divBookEdit.Visible = false;
                divBookDelete.Visible = false;
            }

        }

        protected void btn_Add_Click(object sender, EventArgs e)
        {
            string mainconn = ConfigurationManager.ConnectionStrings["Myconnection"].ConnectionString;
            SqlConnection sqlconn = new SqlConnection(mainconn);
            string sqlquery = "Insert into [dbo].[BookRecord] (bookid,bookname,bookpubname,bookpubyear,bookprice,bookquantity,recorddate)" +
                "values(@bookid,@bookname,@bookpubname,@bookpubyear,@bookprice,@bookquantity,@recorddate)";
            sqlconn.Open();
            SqlCommand sqlcomm = new SqlCommand(sqlquery, sqlconn);
            sqlcomm.Parameters.AddWithValue("@bookid", txt_bookid.Text);
            sqlcomm.Parameters.AddWithValue("@bookname", txt_bookname.Text);
            sqlcomm.Parameters.AddWithValue("@bookpubname", txt_bookpupname.Text);
            sqlcomm.Parameters.AddWithValue("@bookpubyear", txt_bookpubyear.Text);
            sqlcomm.Parameters.AddWithValue("@bookprice", txt_bookprice.Text);
            sqlcomm.Parameters.AddWithValue("@bookquantity", txt_bookqty.Text);
            sqlcomm.Parameters.AddWithValue("@recorddate", DateTime.Today.Date.ToShortDateString());
            /**
            sqlcomm.Parameters.AddWithValue("@CourseFees", LabCourseFees.Text);
            sqlcomm.Parameters.AddWithValue("@Firstinstallment", TxtCourseInstallment.Text);
            sqlcomm.Parameters.AddWithValue("@FeesDus", LabDueFees.Text);
            sqlcomm.Parameters.AddWithValue("@Joindate", LitJoindate.Text);
            **/
            int i= sqlcomm.ExecuteNonQuery();
            


            if (i>0)
            {
                lblresult.ForeColor = System.Drawing.Color.Green;
                lblresult.Text = "record inserted successfully";
            }
            else
            {

                lblresult.ForeColor = System.Drawing.Color.Red;
                lblresult.Text = "record not inserted successfully";
            }
            
           /**
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
            **/
            sqlconn.Close();
            Response.Write("alert('Exception ocur')");

        }

        protected void btn_Update_Click(object sender, EventArgs e)
        {
            
        }

        protected void btn_Delete_Cancel_Click(object sender, EventArgs e)
        {

        }

        protected void btn_Delete_Reset_Click(object sender, EventArgs e)
        {

        }

        protected void btn_Add_Reset_Click(object sender, EventArgs e)
        {

        }

        protected void btn_Add_Cancel_Click(object sender, EventArgs e)
        {

        }

        protected void btn_Update_Cancel_Click(object sender, EventArgs e)
        {

        }

        protected void btn_Delete_Reset_Click1(object sender, EventArgs e)
        {

        }

        protected void btn_Delete_Click(object sender, EventArgs e)
        {

        }

        protected void btn_Delete_Cancel_Click1(object sender, EventArgs e)
        {

        }

        protected void rbi_book_AEUD_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (rbi_book_AEUD.Items[0].Selected == true)
            {
                divBookAdd.Visible = true;
                divBookEdit.Visible = false;
                divBookDelete.Visible = false;
            }
            else if (rbi_book_AEUD.Items[1].Selected == true)
            {
                divBookAdd.Visible = false;
                divBookEdit.Visible = true;
                divBookDelete.Visible = false;
            }
            else if (rbi_book_AEUD.Items[2].Selected == true)
            {
                divBookAdd.Visible = false;
                divBookEdit.Visible = false;
                divBookDelete.Visible = true;
            }
        }
    }
}