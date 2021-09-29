<%@ Page Title="" Language="C#" MasterPageFile="~/SMS.Master" AutoEventWireup="true" CodeBehind="StudentInformation.aspx.cs" Inherits="Student_Management_System.StudentInformation" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1>This is Student Information Page</h1>
    <from>
        <div style="width: 682px; height: 315px">

            <table style="width: 100%; height: 345px">
                <tr>
                    <td style="width: 278px; background-color: #66CCFF">Roll Number</td>
                    <td style="background-color: #FFCCCC">
                        <br />
                        <asp:TextBox ID="TextBox1" runat="server" Height="20px" style="margin-left: 0px; margin-bottom: 0px" Width="171px"></asp:TextBox>
&nbsp;<asp:Button ID="Button1" runat="server" Text="Search" Width="79px" OnClick="Button1_Click" />
                        <br />
                        <br />
                        <asp:Label ID="Label1" runat="server"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td style="width: 278px; background-color: #66CCFF">Student Name</td>
                    <td style="background-color: #FFCCCC">
                        <asp:TextBox ID="TextBox2" runat="server" Height="20px" style="margin-left: 0px; margin-bottom: 0px" Width="168px"></asp:TextBox>
                        <br />
                    </td>
                </tr>
                <tr>
                    <td style="width: 278px; background-color: #66CCFF">Father Name</td>
                    <td style="background-color: #FFCCCC">
                        <asp:TextBox ID="TextBox3" runat="server" Height="20px" style="margin-left: 0px; margin-bottom: 0px" Width="168px"></asp:TextBox>
                        <br />
                    </td>
                </tr>
                <tr>
                    <td style="width: 278px; background-color: #66CCFF">Mother Name</td>
                    <td style="background-color: #FFCCCC">
                        <asp:TextBox ID="TextBox4" runat="server" Height="20px" style="margin-left: 0px; margin-bottom: 0px" Width="168px"></asp:TextBox>
                        <br />
                    </td>
                </tr>
                <tr>
                    <td colspan="2" style="height: 43px; background-color: #66CCFF">
                        <br />
                        <br />
                        <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Add New" Width="79px" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                        <asp:Button ID="Button3" runat="server" Text="Save" Width="79px" OnClick="Button3_Click" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                        <asp:Button ID="Button4" runat="server" Text="Update" Width="79px" OnClick="Button4_Click" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                        <asp:Button ID="Button5" runat="server" Text="Delete" Width="79px" OnClick="Button5_Click" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                        <asp:Button ID="Button6" runat="server" Text="Cancel" Width="79px" OnClick="Button6_Click" />
                        <br />
                        <br />
                        <asp:Label ID="Label2" runat="server"></asp:Label>
                        <br />
                    </td>
                </tr>
            </table>

        </div></br>

    </from>
</asp:Content>
