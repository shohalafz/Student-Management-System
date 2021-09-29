using System;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Web.UI.WebControls;

namespace Student_Management_System
{
    public partial class AdminPage1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ButSubmit_Click(object sender, EventArgs e)
        {
            string mainconn = ConfigurationManager.ConnectionStrings["Myconnection"].ConnectionString;
            SqlConnection sqlconn = new SqlConnection(mainconn);
            string sqlquery = "select * from " + DropDownList1.SelectedValue;
            sqlconn.Open();
            SqlCommand sqlcomm = new SqlCommand(sqlquery, sqlconn);
            SqlDataAdapter sda = new SqlDataAdapter(sqlcomm);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (DropDownList1.SelectedItem.Value == "Coursetable")
            {
                GdCourse.Visible = true;
                GdStudent.Visible = false;
                GdTutor.Visible = false;
                GdCourse.DataSource = dt;
                GdCourse.DataBind();
            }
            else if (DropDownList1.SelectedItem.Value == "student")
            {
                GdStudent.Visible = true;
                GdCourse.Visible = false;
                GdTutor.Visible = false;
                GdStudent.DataSource = dt;
                GdStudent.DataBind();
            }
            else
            {
                GdTutor.Visible = true;
                GdStudent.Visible = false;
                GdCourse.Visible = false;

                GdTutor.DataSource = dt;
                GdTutor.DataBind();
            }
            sqlconn.Close();

        }

        protected void GdCourse_RowCancelingEdit(object sender, System.Web.UI.WebControls.GridViewCancelEditEventArgs e)
        {
            GdCourse.EditIndex = -1;
        }

        protected void GdCourse_RowUpdating(object sender, System.Web.UI.WebControls.GridViewUpdateEventArgs e)
        {
            GridViewRow row = GdCourse.Rows[e.RowIndex];
            int courseid = Convert.ToInt32(GdCourse.DataKeys[e.RowIndex].Values[0]);
            string cname = (row.Cells[2].Controls[0] as TextBox).Text;
            string Duration = (row.Cells[3].Controls[0] as TextBox).Text;
            string Fees = (row.Cells[3].Controls[0] as TextBox).Text;
            string mainconn = ConfigurationManager.ConnectionStrings["Myconnection"].ConnectionString;
            SqlConnection sqlconn = new SqlConnection(mainconn);
            string sqlquery = "update Coursetable set Cname=@Cname,Duration=@Duration,Cfees=@Cfees where cid=@cid";
            sqlconn.Open();
            SqlCommand sqlcomm = new SqlCommand(sqlquery, sqlconn);
            sqlcomm.Parameters.AddWithValue("@cid", courseid);
            sqlcomm.Parameters.AddWithValue("@Cname", cname);
            sqlcomm.Parameters.AddWithValue("@Duration", Duration);
            sqlcomm.Parameters.AddWithValue("@Cfees", Fees);
            sqlcomm.ExecuteNonQuery();
            sqlconn.Close();
            //pore korbo



        }

        protected void GdCourse_RowEditing(object sender, GridViewEditEventArgs e)
        {
            GdCourse.EditIndex = e.NewEditIndex;
        }

        protected void GdCourse_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            int courseid = Convert.ToInt32(GdCourse.DataKeys[e.RowIndex].Value);

            string mainconn = ConfigurationManager.ConnectionStrings["Myconnection"].ConnectionString;
            SqlConnection sqlconn = new SqlConnection(mainconn);
            string sqlquery = "delete from Coursetable where cid=@cid ";

            sqlconn.Open();
            SqlCommand sqlcomm = new SqlCommand(sqlquery, sqlconn);
            sqlcomm.Parameters.AddWithValue("@cid", courseid);
            sqlcomm.ExecuteNonQuery();
            sqlconn.Close();
        }

        protected void GdStudent_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {

        }

        protected void GdStudent_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {

        }

        protected void GdStudent_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {

        }

        protected void GdStudent_RowEditing(object sender, GridViewEditEventArgs e)
        {

        }

    }
    }
