<%@ Page Title="" Language="C#" MasterPageFile="~/SMS.Master" AutoEventWireup="true" CodeBehind="OnlineAdmission.aspx.cs" Inherits="Student_Management_System.OnlineAdmission" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1> This is Online Admission Test Page </h1>

    <from border="1" backgroundcolre="blue">
        <div style="width: 541px; height: 180px">

            <table style="width: 101%; height: 196px;" border="1">
                <tr>
                    <td style="width: 218px">Name </td>
                    <td style="width: 338px">
                        <asp:TextBox ID="TextBox1" runat="server" Height="27px" Width="186px"></asp:TextBox>
                        <br />
                    </td>
                </tr>
                <tr>
                    <td style="width: 218px">Gender </td>
                    <td style="height: 43px; width: 338px;">
                        <asp:DropDownList ID="DropDownList1" runat="server" Height="27px" style="margin-left: 0px" Width="176px">
                            <asp:ListItem>Male</asp:ListItem>
                            <asp:ListItem>Female</asp:ListItem>
                        </asp:DropDownList>
                    </td>
                </tr>
                <tr>
                    <td style="width: 218px">Contact</td>
                    <td style="width: 338px">
                        <asp:TextBox ID="TextBox2" runat="server" Height="27px" Width="186px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td style="width: 218px">Email Address</td>
                    <td style="width: 338px">
                        <asp:TextBox ID="TextBox3" runat="server" Height="27px" Width="186px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td style="width: 218px">City</td>
                    <td style="width: 338px">
                        <asp:TextBox ID="TextBox4" runat="server" Height="27px" Width="186px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td style="width: 218px">&nbsp;</td>
                    <td style="width: 338px">
                        <asp:Button ID="Button1" runat="server" Text="Registration" BorderColor="Blue" OnClick="Button1_Click" />
                        <br />
                        <br />
                        <asp:Label ID="Label1" runat="server"></asp:Label>
                    </td>
                </tr>
            </table>
            <br />
            <br />
            <br />
            <br />
            <br />

        </div>
        </from>
</asp:Content>
