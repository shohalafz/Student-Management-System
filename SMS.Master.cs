using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Student_Management_System
{
    public partial class SMS : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["Adminname"]!=null)
            {
                LabUserLogin.Text = Session["Adminname"].ToString();
            }
            else
            {
                Response.Redirect("HomePage.aspx");
            }
        }

        protected void LnkCourse_Click(object sender, EventArgs e)
        {
            Response.Redirect("CoursePage.aspx");
        }

        protected void LnkTeacher_Click(object sender, EventArgs e)
        {
            Response.Redirect("TutorPage.aspx");
        }

        protected void LnkStudent_Click(object sender, EventArgs e)
        {
            Response.Redirect("StudentPage.aspx");
        }

        protected void LnkLogout_Click(object sender, EventArgs e)
        {
            HttpContext.Current.Session.Abandon();
            Response.Redirect("HomePage.aspx");
        }

        protected void LnkAdmin_Click(object sender, EventArgs e)
        {
            Response.Redirect("AdminPage.aspx");
        }

        protected void LnkAttendance_Click(object sender, EventArgs e)
        {
            Response.Redirect("Default.aspx");
        }

        protected void LnkOnlineExam_Click(object sender, EventArgs e)
        {
            Response.Redirect("examonline.aspx");
        }

        protected void LnkLibrary_Click(object sender, EventArgs e)
        {
            Response.Redirect("Library.aspx");
        }

        protected void LnkEmployee_Click(object sender, EventArgs e)
        {
            Response.Redirect("Employee_Information.aspx");
        }

        protected void LnkInventory_Click(object sender, EventArgs e)
        {
            Response.Redirect("SchoolInventory.aspx");
        }

        protected void LnkSetup_Click(object sender, EventArgs e)
        {
            Response.Redirect("Setup.aspx");
        }

        protected void LnkOnlineAdmission_Click(object sender, EventArgs e)
        {
            Response.Redirect("OnlineAdmission.aspx");
        }

        protected void LnkStudentInformation_Click(object sender, EventArgs e)
        {
            Response.Redirect("StudentInformation.aspx");
        }

        protected void LnkAcademicCalendar_Click(object sender, EventArgs e)
        {
            Response.Redirect("AcademicCalendar.aspx");
        }
    }
}