<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="AdminLeft.ascx.cs" Inherits="Web.SysAdmin.AdminLeft" %>
<style type="text/css">
    A:link
    {
        color: #333333;
        text-decoration: none;
    }
    A:visited
    {
        color: #333333;
        text-decoration: none;
    }
    A:hover
    {
        color: #FF0000;
        text-decoration: none;
    }
</style>
<table id="table1" height="100%" cellspacing="0" cellpadding="0" width="80" border="0">
    <tr>
        <td valign="top" style="width: 99px">
            <asp:TreeView ID="treeview1" runat="server" Font-Size="10pt">
                <Nodes>
                    <asp:TreeNode Text="用户管理" Value="用户管理">
                        <asp:TreeNode Text="添加用户" Value="添加用户" NavigateUrl="AddUser.aspx" Target="framemain">
                        </asp:TreeNode>
                        <asp:TreeNode Text="用户维护" Value="用户维护" NavigateUrl="UserList.aspx" Target="framemain">
                        </asp:TreeNode>
                    </asp:TreeNode>
                    <asp:TreeNode Text="书刊管理" Value="书刊管理">
                        <asp:TreeNode Text="添加书刊" Value="添加书刊" NavigateUrl="AddBook.aspx" Target="framemain">
                        </asp:TreeNode>
                        <asp:TreeNode Text="书刊维护" Value="书刊维护" NavigateUrl="BookList.aspx"  Target="framemain">
                        </asp:TreeNode>
                        <asp:TreeNode Text="高级搜索" Value="书目搜索" NavigateUrl="~/bookmanage/adminbookadvancedsearch.aspx"
                            Target="framemain"></asp:TreeNode>
                    </asp:TreeNode>
                    <asp:TreeNode Text="个人信息" Value="个人信息">
                        <asp:TreeNode Text="修改个人信息" Value="修改个人信息" NavigateUrl="~/SysAdmin/AdminInfo.aspx" Target="framemain">
                        </asp:TreeNode>
                        <asp:TreeNode Text="修改密码" Value="修改密码" NavigateUrl="~/SysAdmin/ModifyPassword.aspx"  Target="framemain">
                        </asp:TreeNode>
                       
                    </asp:TreeNode>
                    <asp:TreeNode Text="注销我的登录" Value="注销我的登录" NavigateUrl="~/login.aspx" >
                    </asp:TreeNode>
                </Nodes>
            </asp:TreeView>
        </td>
    </tr>
</table>
