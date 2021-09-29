<%@ Page Title="" Language="C#" MasterPageFile="~/SMS.Master" AutoEventWireup="true" CodeBehind="AcademicCalendar.aspx.cs" Inherits="Student_Management_System.AcademicCalendar" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1>School Academic Calendar</h1>
    <div>

        <asp:Calendar ID="Calendar1" runat="server" BackColor="#66FFFF" NextMonthText="Next" PrevMonthText="Previous" ShowGridLines="True">
            <SelectedDayStyle BackColor="#FF9999" />
            <TitleStyle BackColor="#00CC66" />
        </asp:Calendar>
        <br />
        <asp:Button ID="Button1" runat="server" Text="Submit After Select Date" />
        <br />
        <br />
        <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
        <br />
        <br />
        <h1>><marquee direction="left"> Notic: Tomorrow School Off Due To Govt. Holiday</marquee></h1>


    </div>

</asp:Content>
