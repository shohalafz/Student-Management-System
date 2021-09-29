<%@ Page Title="" Language="C#" MasterPageFile="~/SMS.Master" AutoEventWireup="true" CodeBehind="Library.aspx.cs" Inherits="Student_Management_System.Library" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1>This is Libray Page</h1>

    <div style="background-color: azure">

        <asp:RadioButtonList ID="rbi_book_AEUD" runat="server" RepeatDirection="Horizontal" OnSelectedIndexChanged="rbi_book_AEUD_SelectedIndexChanged" AutoPostBack="true">
            <asp:ListItem Text="ADD" Value="1" Selected="true"></asp:ListItem>
            <asp:ListItem Text="EDIT" Value="2"></asp:ListItem>
            <asp:ListItem Text="DELETE" Value="3"></asp:ListItem>
        </asp:RadioButtonList>

    </div>
    <div>
        <table border="0" class="tb_book">
            <tr>
                <td id="table_Add" class="tb_book_AED">
                    <div runat="server" id="divBookAdd">
                        <table border="1">
                            <tr>
                                <td colspan="2">
                                <h1>Add Book Inventory</h1>
                            </td>
                                </tr>
                            <tr>
                                <td class="tdbi_1">Book Id
                                </td>
                                <td class="tdbi_2">
                                    <asp:TextBox ID="txt_bookid" CssClass="txtbox" runat="server"></asp:TextBox>


                                </td>

                            </tr>
                            <tr>
                                <td class="tdbi_1">Book Name
                                </td>
                                <td class="tdbi_2">
                                    <asp:TextBox ID="txt_bookname" CssClass="txtbox" runat="server"></asp:TextBox>

                                </td>
                            </tr>

                            <tr>
                                <td class="tdbi_1">Book Publisher Name
                                </td>
                                <td class="tdbi_2">
                                    <asp:TextBox ID="txt_bookpupname" CssClass="txtbox" runat="server"></asp:TextBox>
                                </td>
                            </tr>

                            <tr>
                                <td class="tdbi_1">Book Published Year:
                                </td>
                                <td class="tdbi_2">
                                    <asp:TextBox ID="txt_bookpubyear" CssClass="txtbox" runat="server"></asp:TextBox>
                                </td>
                            </tr>

                            <tr>
                                <td class="tdbi_1">Book Price
                                </td>
                                <td class="tdbi_2">
                                    <asp:TextBox ID="txt_bookprice" CssClass="txtbox" runat="server"></asp:TextBox>
                                </td>
                            </tr>

                            <tr>
                                <td class="tdbi_1">Book Quantity
                                </td>
                                <td class="tdbi_2">
                                    <asp:TextBox ID="txt_bookqty" CssClass="txtbox" runat="server"></asp:TextBox>
                                </td>
                            </tr>
                        </table>
                    </div>
                </td>
                <td id="table_Edit" class="tb_book_AED">
                    <div runat="server" id="divBookEdit">
                        <table border="1">
                            <tr>
                                <td colspan="3">
                                <h1>Edit Book Inventory</h1>
                            </td>
                                </tr>
                            <tr>
                                <td class="tdbi_1">Book ID:
                                </td>
                                <td class="tdbi_2">
                                    <asp:TextBox ID="txtz_edit_bookid" CssClass="txtbox" runat="server"></asp:TextBox>
                                    <asp:Button ID="btn_check" CssClass="btn" runat="server" Text="Check" />
                                </td>
                            </tr>

                            <tr>
                                <td>
                                    <td class="tdbi_1">Book Name
                                    </td>
                                    <td class="tdbi_2">
                                        <asp:TextBox ID="txtz_edit_bookname" CssClass="txtbox" runat="server"></asp:TextBox>
                                    </td>
                                </td>
                            </tr>
                            <tr>
                                <td class="tdbi_1">Book Publisher Name</td>
                                <td class="tdbi_2">
                                    <asp:TextBox ID="txt_edit_pubname" CssClass="txtbox" runat="server"></asp:TextBox>
                                </td>
                            </tr>

                            <tr>
                                <td class="tdbi_1">Book Publisher Year:</td>
                                <td class="tdbi_2">
                                    <asp:TextBox ID="txt_edit_bookpubdate" CssClass="txtbox" runat="server"></asp:TextBox>
                                </td>
                            </tr>

                            <tr>
                                <td class="tdbi_1">Book Price</td>
                                <td class="tdbi_2">
                                    <asp:TextBox ID="txt_edit_bookprice" CssClass="txtbox" runat="server"></asp:TextBox>
                                </td>
                            </tr>

                            <tr>
                                <td class="tdbi_1">Book Quantity</td>
                                <td class="tdbi_2">
                                    <asp:TextBox ID="txt_edit_bookqty" CssClass="txtbox" runat="server"></asp:TextBox>
                                </td>
                            </tr>

                        </table>
                    </div>
                </td>

                <td id="table_delete" class="td_book_AED">
                    <div runat="server" id="divBookDelete">
                        <table border="1">
                            <tr>
                                <td colspan="3">
                                <h1>Delete Book Inventory</h1>
                            </td>
                                </tr>
                            
                            <tr>
                                <td class="tdbi_1">Book ID:
                                </td>
                                <td class="tdbi_2">
                                    <asp:TextBox ID="txt_delete_bookid" CssClass="txtbox" runat="server"></asp:TextBox>
                                    <asp:Button ID="Button1" CssClass="btn" runat="server" Text="Check" />
                                </td>
                            </tr>

                            <tr>
                                <td>
                                    <td class="tdbi_1">Book Name
                                    </td>
                                    <td class="tdbi_2">
                                        <asp:TextBox ID="txt_delete_bookname" CssClass="txtbox" runat="server"></asp:TextBox>
                                    </td>
                                </td>
                            </tr>
                            <tr>
                                <td class="tdbi_1">Book Publisher Name</td>
                                <td class="tdbi_2">
                                    <asp:TextBox ID="txt_delete_bookpubname" CssClass="txtbox" runat="server"></asp:TextBox>
                                </td>
                            </tr>

                            <tr>
                                <td class="tdbi_1">Book Publisher Year:</td>
                                <td class="tdbi_2">
                                    <asp:TextBox ID="txt_delete_bookpubdate" CssClass="txtbox" runat="server"></asp:TextBox>
                                </td>
                            </tr>

                            <tr>
                                <td class="tdbi_1">Book Price</td>
                                <td class="tdbi_2">
                                    <asp:TextBox ID="txt_delete_bookprice" CssClass="txtbox" runat="server"></asp:TextBox>
                                </td>
                            </tr>

                            <tr>
                                <td class="tdbi_1">Book Quantity</td>
                                <td class="tdbi_2">
                                    <asp:TextBox ID="txt_delete_bookqty" CssClass="txtbox" runat="server"></asp:TextBox>
                                </td>
                            </tr>
                        </table>
                    </div>
                </td>
            </tr>
        </table>


    </div>

    <asp:Label ID="lblresult" runat="server"></asp:Label>
    <br />
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:Label ID="lbl_book_result" runat="server"></asp:Label>
    <!--add book add edit delet-->
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <div>
        <asp:Button ID="btn_Add" CssClass="btn" runat="server" Text="ADD" OnClick="btn_Add_Click" />
        <asp:Button ID="btn_Add_Reset" CssClass="btn" runat="server" Text="RESET" />
        <asp:Button ID="btn_Add_Cancel" CssClass="btn" runat="server" Text="CANCEL" />
    </div>
    <!--Edit book add edit delet-->
    <div>
        <asp:Button ID="btn_Update" CssClass="btn" runat="server" Text="UPDATE" OnClick="btn_Update_Click" />
        <asp:Button ID="btn_Update_Reset" CssClass="btn" runat="server" Text="RESET" />
        <asp:Button ID="btn_Update_Cancel" runat="server" Text="CANCEL" />
    </div>
    <!--Delete book add edit delet-->
    <div>
        <asp:Button ID="btn_Delete" CssClass="btn" runat="server" Text="DELETE" OnClick="btn_Delete_Click" />
        <asp:Button ID="btn_Delete_Reset" CssClass="btn" runat="server" Text="RESET" />
        <asp:Button ID="btn_Delete_Cancel" runat="server" Text="CANCEL" />

    </div>

</asp:Content>
