<%@ Page Title="" Language="C#" MasterPageFile="~/SMS.Master" AutoEventWireup="true" CodeBehind="TutorPage.aspx.cs" Inherits="Student_Management_System.TutorPage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1>This is Tutor Page.....</h1>
    <div style="background-color:azure; height: 236px; width: 285px;">
        <table border="1">
            <tr>
                <td>Tutor Name</td>
                <td>
                    <asp:TextBox ID="TxtTutorname" runat="server"></asp:TextBox></td>
            </tr>
            <tr>
                <td>Email</td>
                <td>
                    <asp:TextBox ID="TxtEmail" runat="server"></asp:TextBox></td>
            </tr>
            <tr>
                <td>
                    Tutor Phone
                </td>
                <td>
                    <asp:TextBox ID="TxtPhone" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>Tutor Course</td>
                <td>
                    <asp:DropDownList ID="DDLCourse" runat="server" DataSourceID="SqlDataSource1" AppendDataBoundItems="true" DataTextField="Cname" DataValueField="Cname">
                        <asp:ListItem Value="0" Text="--Select Courses--"></asp:ListItem>
                    </asp:DropDownList>
                    <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:StudentManagementSystemConnectionString %>" SelectCommand="SELECT [Cname] FROM [Coursetable]"></asp:SqlDataSource>
            </tr>
            <tr>
                <td>Qualification</td>
                <td>
                    <asp:TextBox ID="TxtQualification" runat="server"></asp:TextBox></td>
            </tr>
            <tr>
                <td>Join Date</td>
                <td>
                    <asp:Label ID="LitJoindate" runat="server" Text="Label"></asp:Label></td>
            </tr>
            <tr>
                <td><asp:Button ID="ButTutor" runat="server" Text="Insert" OnClick="ButTutor_Click" /></td>
                <td>
                    <asp:Label ID="Labmsg" runat="server" Text="" ForeColor="Green"></asp:Label></td>

            </tr>
            
        </table>

    </div>
</asp:Content>
