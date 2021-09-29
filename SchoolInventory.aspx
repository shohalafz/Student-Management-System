<%@ Page Title="" Language="C#" MasterPageFile="~/SMS.Master" AutoEventWireup="true" CodeBehind="SchoolInventory.aspx.cs" Inherits="Student_Management_System.SchoolInventory" %>

<%@ Register Assembly="System.Web.DataVisualization, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35" Namespace="System.Web.UI.DataVisualization.Charting" TagPrefix="asp" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1>This is School Inventory Page</h1>
    <div>
        <asp:Chart ID="Chart1" runat="server" DataSourceID="SqlDataSource1" Width="399px">
            <Series>
                <asp:Series Name="Series1" ChartType="Pie" XValueMember="productname" YValueMembers="qty" IsXValueIndexed="True" Legend="Legend1" IsValueShownAsLabel="True"></asp:Series>
            </Series>
            <ChartAreas>
                <asp:ChartArea Name="ChartArea1"></asp:ChartArea>
            </ChartAreas>
            <Legends>
                <asp:Legend Name="Legend1" Title="Stocked product">
                </asp:Legend>
            </Legends>
            <Titles>
                <asp:Title Font="Microsoft Sans Serif, 14pt" Name="Title1" Text="Inventory Details (Stock Product)">
                </asp:Title>
            </Titles>
        </asp:Chart>
        <br />
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:StudentManagementSystemConnectionString6 %>" SelectCommand="SELECT * FROM [SchoolInventory]"></asp:SqlDataSource>
    </div>

</asp:Content>
