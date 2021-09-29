<%@ Page Title="" Language="C#" MasterPageFile="~/SMS.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Student_Management_System.Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">


    <h1>This is Attendance Page</h1>


    <table border="1" style="width: 49%; background-color: #FFFF99; height: 125px;">

        <tr>
            <td style="height: 54px; width: 205px">Select Class</td>
            <td style="height: 54px">
                <asp:DropDownList ID="DropDownList1" runat="server" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged" AutoPostBack="true" DataSourceID="SqlDataSource1" DataTextField="class" DataValueField="class">
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td style="width: 205px; height: 49px"></td>
            <td style="height: 49px">
                <asp:Button ID="Button1" runat="server" BackColor="#FF9900" Text="Mark Attendance" OnClick="Button1_Click" />
            </td>
        </tr>

    </table>


    <asp:Label ID="Label3" runat="server"></asp:Label>
    <br />
    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" CellPadding="4" DataSourceID="SqlDataSource2" ForeColor="#333333">
        <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
        <Columns>
            <asp:BoundField DataField="rollno" HeaderText="Roll Number" SortExpression="rollno">
                <ItemStyle HorizontalAlign="Center" />
            </asp:BoundField>
            <asp:BoundField DataField="studentname" HeaderText="Student Name" SortExpression="studentname">
                <ItemStyle HorizontalAlign="Center" />
            </asp:BoundField>
            <asp:TemplateField HeaderText="Mark Attendance">
                <ItemTemplate>
                    <asp:RadioButton ID="RadioButton1" runat="server" Checked="True" GroupName="g1" Text="Present" />
                    <asp:RadioButton ID="RadioButton2" runat="server" GroupName="g1" Text="Absent" />
                </ItemTemplate>
            </asp:TemplateField>
        </Columns>
        <EditRowStyle BackColor="#999999" />
        <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
        <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
        <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
        <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
        <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
        <SortedAscendingCellStyle BackColor="#E9E7E2" />
        <SortedAscendingHeaderStyle BackColor="#506C8C" />
        <SortedDescendingCellStyle BackColor="#FFFDF8" />
        <SortedDescendingHeaderStyle BackColor="#6F8DAE" />
    </asp:GridView>
    <asp:Button ID="Button2" runat="server" BackColor="#999966" OnClick="Button2_Click" Text="Save Attendance" />
    <br />
    <br />
    <asp:Label ID="Label4" runat="server"></asp:Label>
    <br />
    <br />
    <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:StudentManagementSystemConnectionString3 %>" SelectCommand="SELECT DISTINCT [class] FROM [StudentDetail]"></asp:SqlDataSource>
    <br />
    <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:StudentManagementSystemConnectionString4 %>" SelectCommand="SELECT [rollno], [studentname] FROM [StudentDetail] WHERE ([class] = @class)">
        <SelectParameters>
            <asp:ControlParameter ControlID="DropDownList1" Name="class" PropertyName="SelectedValue" Type="String" />
        </SelectParameters>
    </asp:SqlDataSource>


</asp:Content>
