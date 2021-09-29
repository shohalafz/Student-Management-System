<%@ Page Title="" Language="C#" MasterPageFile="~/SMS.Master" AutoEventWireup="true" CodeBehind="Employee_Information.aspx.cs" Inherits="Student_Management_System.Employee_Information" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1>This is School Employee Information Page</h1>
    <table border="1" style="width: 39%; height: 214px; background-color: #FFFF99">
        <tr>
            <td style="width: 214px">Your Name</td>
            <td>
                <asp:TextBox ID="TextBox1" runat="server" ></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td style="width: 214px">Address</td>
            <td>
                <asp:TextBox ID="TextBox2" runat="server" ></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td style="width: 214px">Email Address</td>
            <td>
                <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td style="width: 214px">Mobile Number</td>
            <td>
                <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td style="width: 214px">Upload Rusume (PDF format only)</td>
            <td>
                <asp:FileUpload ID="FileUpload1" runat="server" />
                <br />
                <asp:Label ID="Label3" runat="server" ForeColor="Red" Text="Label"></asp:Label>
            </td>
        </tr>
        <tr>
            <td style="width: 214px">&nbsp;</td>
            <td>
                <asp:Button ID="Button1" runat="server" BackColor="#FF6666" OnClick="Button1_Click" Text="Submit" />
            </td>
        </tr>
    </table>
    <div>

        <asp:Label ID="Label2" runat="server" Font-Bold="True" Text="Label"></asp:Label>
        <br />

        <asp:Label ID="Label1" runat="server" Text="View_Download"></asp:Label>
        <br />
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" BackColor="#DEBA84" BorderColor="#DEBA84" BorderStyle="None" BorderWidth="1px" CellPadding="3" CellSpacing="2" DataSourceID="SqlDataSource1" Height="228px" Width="769px">
            <Columns>
                <asp:BoundField DataField="employeeid" HeaderText="Employee ID" SortExpression="employeeid">
                <ItemStyle HorizontalAlign="Center" />
                </asp:BoundField>
                <asp:BoundField DataField="ename" HeaderText="Employee Name" SortExpression="ename">
                <ItemStyle HorizontalAlign="Center" />
                </asp:BoundField>
                <asp:BoundField DataField="address" HeaderText="Employee Address" SortExpression="address">
                <ItemStyle HorizontalAlign="Center" />
                </asp:BoundField>
                <asp:BoundField DataField="emailaddress" HeaderText="Email Address" SortExpression="emailaddress">
                <ItemStyle HorizontalAlign="Center" />
                </asp:BoundField>
                <asp:BoundField DataField="mobilenumber" HeaderText="Mobile Number" SortExpression="mobilenumber">
                <ItemStyle HorizontalAlign="Center" />
                </asp:BoundField>
                <asp:HyperLinkField DataNavigateUrlFields="resumefile" Target="_blank" HeaderText="Resume (PDF)" Text="View and Download" />
            </Columns>
            <FooterStyle BackColor="#F7DFB5" ForeColor="#8C4510" />
            <HeaderStyle BackColor="#A55129" Font-Bold="True" ForeColor="White" />
            <PagerStyle ForeColor="#8C4510" HorizontalAlign="Center" />
            <RowStyle BackColor="#FFF7E7" ForeColor="#8C4510" />
            <SelectedRowStyle BackColor="#738A9C" Font-Bold="True" ForeColor="White" />
            <SortedAscendingCellStyle BackColor="#FFF1D4" />
            <SortedAscendingHeaderStyle BackColor="#B95C30" />
            <SortedDescendingCellStyle BackColor="#F1E5CE" />
            <SortedDescendingHeaderStyle BackColor="#93451F" />
        </asp:GridView>
        <br />
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:StudentManagementSystemConnectionString5 %>" SelectCommand="SELECT * FROM [EmployeeDetails]"></asp:SqlDataSource>
    </div>

</asp:Content>
