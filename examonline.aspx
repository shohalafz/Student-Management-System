<%@ Page Title="" Language="C#" MasterPageFile="~/SMS.Master" AutoEventWireup="true" CodeBehind="examonline.aspx.cs" Inherits="Student_Management_System.examonline" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1>This is OnlineExam Page</h1>

    <table border="1" style="width: 49%; background-color: #FFFF99; height: 125px;">
        </hr>
        <asp:repeater ID="Repeater1" runat="server">
           <ItemTemPlate>

               <tr>
                   <td>
                       <%#Eval("Qid") %> : <%#Eval("Question") %>
                   </td>
               </tr>
               <tr>
                   <td>
                       <asp:RadioButton ID="RadioOption1" runat="server" text='<%#Eval("option1") %>' GroupName="rdexam"></asp:RadioButton>
                       <asp:RadioButton ID="RadioOption2" runat="server" text='<%#Eval("option2") %>' GroupName="rdexam"></asp:RadioButton>
                       <asp:RadioButton ID="RadioOption3" runat="server" text='<%#Eval("option3") %>' GroupName="rdexam"></asp:RadioButton>
                       <asp:RadioButton ID="RadioOption4" runat="server" text='<%#Eval("option4") %>' GroupName="rdexam"></asp:RadioButton>
                       <br />
                       <asp:Label ID="LabCorrectAns" runat="server" Text='<%#Eval("Correctans") %>' Visible="false"></asp:Label>
                   </td>
               </tr>
               <tr>
                   <td>
                       <asp:Label ID="LabUserSelectedoption" runat="server" Text=""></asp:Label>
                   </td>
               </tr>
           </ItemTemPlate>
            
        </asp:repeater>
        <asp:Button ID="ButSubmit" runat="server" Text="Submit" Height="43px" OnClick="ButSubmit_Click" Width="199px" />
        </table>
</asp:Content>
