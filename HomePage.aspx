<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="HomePage.aspx.cs" Inherits="Student_Management_System.HomePage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body style="background-image:url('Images/School.jpg')">
    <form id="form1" runat="server">
        <div>
            <center>
                <h1><marquee direction="left"> Student Management System</marquee></h1>
                <h2>asp.net C# Project</h2>
                <div style="background-color:azure;height:117px; width:237px;"
                    <table border="1">
                <tr>
                    <td> User Id</td>&nbsp;&nbsp;&nbsp; <asp:TextBox ID="TxtAdminId" runat="server"></asp:TextBox>Password</td>
                    <td><asp:TextBox ID="TxtPwdAdmin" runat="server" TextMode="Password"></asp:TextBox><asp:Button ID="ButLogin" runat="server" Text="Login" Height="25px" OnClick="ButLogin_Click1">
                            </asp:Button></td>
                            <td><asp:Label ID="Labmsg" runat="server" Text="" ForeColor="Red"></asp:Label></td>
                </tr>
                       
                    

                    
                         </table>
                    </div>
            </center>
        </div>
    </form>
</body>
</html>
