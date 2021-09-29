<%@ Page Title="" Language="C#" MasterPageFile="~/SMS.Master" AutoEventWireup="true" CodeBehind="StudentPage.aspx.cs" Inherits="Student_Management_System.StudentPage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1> This is Student Page</h1>
    <div style="background-color:azure; height: 348px; width: 290px;">
        <table border="1">

            <tr>
                <td>Student First Name</td>
                <td>
                    <asp:TextBox ID="TxtStFname" runat="server"></asp:TextBox></td>
            </tr>
            <tr>
                <td>Student Last Name</td>
                <td>
                    <asp:TextBox ID="TxtStLname" runat="server"></asp:TextBox></td>
            </tr>
            <tr>
                <td>Student Father Name</td>
                <td>
                    <asp:TextBox ID="TxtFatherName" runat="server"></asp:TextBox></td>
            </tr>
            <tr>
                <td>Father Phone</td>
                <td>
                    <asp:TextBox ID="TxtFatherPhone" runat="server"></asp:TextBox></td>
            </tr>
            <tr>
                <td>Email</td>
                <td>
                    <asp:TextBox ID="TxtStEmail" runat="server"></asp:TextBox></td>
            </tr>
            <tr>
                <td>Phone</td>
                <td>
                    <asp:TextBox ID="TxtPhone" runat="server"></asp:TextBox></td>
            </tr>
            <tr>
                <td>Course Name</td>
                <td>
                    <asp:DropDownList ID="DDLCourseName" runat="server" AutoPostBack="True" AppendDataBoundItems="true" DataSourceID="SqlDataSource1" DataTextField="Cname" DataValueField="Cname" OnSelectedIndexChanged="DDLCourseName_SelectedIndexChanged">
                        <asp:ListItem Value="0" Text="---Select Course"></asp:ListItem>
                    </asp:DropDownList>
                    <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:StudentManagementSystemConnectionString2 %>" SelectCommand="SELECT [Cname] FROM [Coursetable]"></asp:SqlDataSource>
                </td>
            </tr>
            <tr>
                <td>Course Fees</td>

                <td>
                    <asp:Label ID="LabCourseFees" runat="server" Text=""></asp:Label></td>
            </tr>
            <tr>
                <td>Installment</td>
                <td>
                    <asp:TextBox ID="TxtCourseInstallment" runat="server" AutoPostBack="true" OnTextChanged="TxtCourseInstallment_TextChanged"></asp:TextBox></td>
            </tr>
            <tr>
                <td>Fee Due</td>
                <td>
                    <asp:Label ID="LabDueFees" runat="server" Text=""></asp:Label></td>
            </tr>
            <tr>
                <td>Join Date</td>
                <td>
                    <asp:Literal ID="LitJoindate" runat="server"></asp:Literal></td>
            </tr>

            <tr>
                <td>
                    <asp:Button ID="ButStudent" runat="server" Text="Insert Recoured" OnClick="ButStudent_Click" /></td>
                <td>
                    <asp:Label ID="Labmsg" runat="server" Text="" ForeColor="Green"></asp:Label></td>
            </tr>
        </table>
    </div>
</asp:Content>
