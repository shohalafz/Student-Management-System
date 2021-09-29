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
    public partial class examonline : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                string mainconn = ConfigurationManager.ConnectionStrings["Myconnection"].ConnectionString;
                SqlConnection sqlconn = new SqlConnection(mainconn);
                string sqlquery = "select * from onlineexam";
                sqlconn.Open();
                SqlCommand sqlcomm = new SqlCommand(sqlquery, sqlconn);
                SqlDataAdapter sdr = new SqlDataAdapter(sqlcomm);
                DataTable dt = new DataTable();
                sdr.Fill(dt);
                Repeater1.DataSource = dt;
                Repeater1.DataBind();

                sqlconn.Close();
            }

        }

        protected void ButSubmit_Click(object sender, EventArgs e)
        {
            foreach(RepeaterItem ri in Repeater1.Items)
            {
                RadioButton rb1 = (RadioButton)ri.FindControl("RadioOption1");
                Label labcorrectans = (Label)ri.FindControl("LabCorrectAns");
                labcorrectans.Visible = true;
                if (rb1.Checked== true)
                {
                    if(rb1.Text.Equals(labcorrectans.Text))
                    {
                        Label UserSelectedoption = (Label)ri.FindControl("LabUserSelectedoption");
                        UserSelectedoption.Text = "The Selected Answer is <b>" + rb1.Text.ToString() + "</b>";
                        UserSelectedoption.ForeColor = System.Drawing.Color.Green;
                    }
                    else
                    {
                        Label WrongAswer = (Label)ri.FindControl("LabUserSelectedoption");
                        WrongAswer.Text = "The Selected Answer is <b>" + rb1.Text.ToString() + "</b> is wrong";
                        WrongAswer.ForeColor = System.Drawing.Color.Red;
                    }
                }
            }
            foreach (RepeaterItem ri in Repeater1.Items)
            {
                RadioButton rb2 = (RadioButton)ri.FindControl("RadioOption2");
                Label labcorrectans = (Label)ri.FindControl("LabCorrectAns");
                labcorrectans.Visible = true;
                if (rb2.Checked == true)
                {
                    if (rb2.Text.Equals(labcorrectans.Text))
                    {
                        Label UserSelectedoption = (Label)ri.FindControl("LabUserSelectedoption");
                        UserSelectedoption.Text = "The Selected Answer is <b>" + rb2.Text.ToString() + "</b>";
                        UserSelectedoption.ForeColor = System.Drawing.Color.Green;
                    }
                    else
                    {
                        Label WrongAswer = (Label)ri.FindControl("LabUserSelectedoption");
                        WrongAswer.Text = "The Selected Answer is <b>" + rb2.Text.ToString() + "</b> is wrong";
                        WrongAswer.ForeColor = System.Drawing.Color.Red;
                    }
                }
            }
            foreach (RepeaterItem ri in Repeater1.Items)
            {
                RadioButton rb3 = (RadioButton)ri.FindControl("RadioOption3");
                Label labcorrectans = (Label)ri.FindControl("LabCorrectAns");
                labcorrectans.Visible = true;
                if (rb3.Checked == true)
                {
                    if (rb3.Text.Equals(labcorrectans.Text))
                    {
                        Label UserSelectedoption = (Label)ri.FindControl("LabUserSelectedoption");
                        UserSelectedoption.Text = "The Selected Answer is <b>" + rb3.Text.ToString() + "</b>";
                        UserSelectedoption.ForeColor = System.Drawing.Color.Green;
                    }
                    else
                    {
                        Label WrongAswer = (Label)ri.FindControl("LabUserSelectedoption");
                        WrongAswer.Text = "The Selected Answer is <b>" + rb3.Text.ToString() + "</b> is wrong";
                        WrongAswer.ForeColor = System.Drawing.Color.Red;
                    }
                }
            }
            foreach (RepeaterItem ri in Repeater1.Items)
            {
                RadioButton rb4 = (RadioButton)ri.FindControl("RadioOption4");
                Label labcorrectans = (Label)ri.FindControl("LabCorrectAns");
                labcorrectans.Visible = true;
                if (rb4.Checked == true)
                {
                    if (rb4.Text.Equals(labcorrectans.Text))
                    {
                        Label UserSelectedoption = (Label)ri.FindControl("LabUserSelectedoption");
                        UserSelectedoption.Text = "The Selected Answer is <b>" + rb4.Text.ToString() + "</b>";
                        UserSelectedoption.ForeColor = System.Drawing.Color.Green;
                    }
                    else
                    {
                        Label WrongAswer = (Label)ri.FindControl("LabUserSelectedoption");
                        WrongAswer.Text = "The Selected Answer is <b>" + rb4.Text.ToString() + "</b> is wrong";
                        WrongAswer.ForeColor = System.Drawing.Color.Red;
                    }
                }
            }
        }
    }
}