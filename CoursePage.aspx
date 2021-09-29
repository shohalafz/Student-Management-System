<%@ Page Title="" Language="C#" MasterPageFile="~/SMS.Master" AutoEventWireup="true" CodeBehind="CoursePage.aspx.cs" Inherits="Student_Management_System.CoursePage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1>This is the CoursePage</h1>
    <div style="background-color:azure; height: 130px; width: 306px;">
    <table border="1">

        <tr>
            <td>Course Name</td>
            <td>
                <asp:TextBox ID="TexCoursename" runat="server"></asp:TextBox></td>
        </tr>
        <tr>
            <td>Course Duration</td>
            <td>
                <asp:TextBox ID="TexDuration" runat="server"></asp:TextBox></td>
        </tr>
        <tr>
            <td>Course Fees</td>
            <td>
                <asp:TextBox ID="TexFees" runat="server"></asp:TextBox></td>
        </tr>
        <tr>
            <td>
                <asp:Button ID="ButCourse" runat="server" Text="Insert New Course" OnClick="ButCourse_Click" /></td>
            <td>
                <asp:Label ID="LabMsg" runat="server" Text="" ForeColor="Green"></asp:Label></td>
        </tr>
    </table>
        </div>
</asp:Content>
