<%@ Page Language="C#" MasterPageFile="~/SysAdmin/sysAdminMasterPage.Master" AutoEventWireup="true"
    CodeBehind="BookList.aspx.cs" Inherits="Web.SysAdmin.BookList" Title="图书列表" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:GridView ID="GridviewBookList" runat="server"  DataKeyNames="bookID" AutoGenerateColumns="False" OnRowDeleting="GridviewBookList_RowDeleting"
        Width="291px" BackColor="White" BorderColor="#999999" BorderStyle="None" BorderWidth="1px"
        CellPadding="3" GridLines="Vertical">
        <FooterStyle BackColor="#CCCCCC" ForeColor="Black" />
        <RowStyle BackColor="#EEEEEE" ForeColor="Black" />
        <Columns>
            <asp:BoundField HeaderText="题名" DataField="bookName"  ItemStyle-Wrap="false"/>
            <asp:BoundField HeaderText="作者" DataField="author" ItemStyle-Wrap="false"/>
            <asp:BoundField HeaderText="出版社" DataField="publish" ItemStyle-Wrap="false"/>
            <asp:CommandField HeaderText="删除" DeleteText="删除" ShowDeleteButton="True" >
                <ItemStyle Wrap="False" />
            </asp:CommandField>
            <asp:HyperLinkField HeaderText="详细" DataNavigateUrlFields="bookID" DataNavigateUrlFormatString="ModifyBook.aspx?bookID={0}"
                Text="详细..."  ItemStyle-Wrap="false" >
<ItemStyle Wrap="False"></ItemStyle>
            </asp:HyperLinkField>
        </Columns>
        <PagerStyle BackColor="#999999" ForeColor="Black" HorizontalAlign="Center" />
        <SelectedRowStyle BackColor="#008A8C" Font-Bold="True" ForeColor="White" />
        <HeaderStyle BackColor="#000084" Font-Bold="True" ForeColor="White" />
        <AlternatingRowStyle BackColor="#DCDCDC" />
    </asp:GridView>
</asp:Content>
