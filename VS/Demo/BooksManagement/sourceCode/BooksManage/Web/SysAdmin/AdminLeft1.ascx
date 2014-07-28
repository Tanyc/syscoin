<%@ Control Language="C#" AutoEventWireup="true" CodeFile="AdminLeft.ascx.cs" Inherits="Controls_AdminLeft" %>
<style type="text/css">	A:link { COLOR: #333333; TEXT-DECORATION: none }	A:visited { COLOR: #333333; TEXT-DECORATION: none }	A:hover { COLOR: #FF0000; TEXT-DECORATION: none }	</style>
<table id="table1" height="100%" cellspacing="0" cellpadding="0" width="80" border="0"  >
	<tr>
		<td valign="top" style="width: 99px">
<asp:treeview id="treeview1" runat="server" font-size="10pt" >
    <nodes>
        <asp:treenode text="用户管理" value="用户管理">
            <asp:treenode text="添加用户" value="添加用户" navigateurl="AddUser.aspx" target="framemain"></asp:treenode>
            <asp:treenode text="用户维护" value="用户维护" navigateurl="UserList.aspx" target="framemain"></asp:treenode>
        </asp:treenode>
        <asp:treenode text="书刊管理" value="书刊管理">
            <asp:treenode text="添加书刊" value="添加书刊" navigateurl="AddBook.aspx" target="framemain"></asp:treenode>
            <asp:treenode text="书刊维护" value="书刊维护" navigateurl="~/bookmanage/booklists.aspx" target="framemain"></asp:treenode>
            <asp:treenode text="高级搜索" value="书目搜索" navigateurl="~/bookmanage/adminbookadvancedsearch.aspx" target="framemain"></asp:treenode>
        </asp:treenode>
        <asp:treenode text="个人信息" value="修改密码">
            <asp:treenode text="修改密码" value="修改密码" navigateurl="~/modifypassword.aspx" target="framemain"></asp:treenode>
        </asp:treenode>
    </nodes>
</asp:treeview>
</td>
</tr>
</table>
