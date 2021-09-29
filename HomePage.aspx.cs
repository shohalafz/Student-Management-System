using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Student_Management_System
{
    public partial class HomePage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        /**protected void ButLogin_Click(object sender, EventArgs e)
        {
            if(TxtAdminId.Text=="Admin" && TxtPwdAdmin.Text=="Admin123")
            {
                Session["Adminname"] = "Welcome" + TxtAdminId.Text;
                Response.Redirect("AdminPage.aspx");
            }
            else
            {
                Labmsg.Text = "Failed Login Frtails....";
            }
        }**/

        protected void ButLogin_Click1(object sender, EventArgs e)
        {
            {
                if (TxtAdminId.Text == "Admin" && TxtPwdAdmin.Text == "Admin123")
                {
                    Session["Adminname"] = "Welcome" + TxtAdminId.Text;
                    Response.Redirect("AdminPage.aspx");
                }
                else
                {
                    Labmsg.Text = "Failed Login Frtails....";
                }
            }
        }
    }
}