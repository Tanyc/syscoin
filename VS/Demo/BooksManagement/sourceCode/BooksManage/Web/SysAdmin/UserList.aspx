<%@ Page Language="C#" MasterPageFile="~/SysAdmin/sysAdminMasterPage.Master" AutoEventWireup="true"
    CodeBehind="UserList.aspx.cs" Inherits="Web.SysAdmin.UserList" Title="用户维护界面" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:GridView ID="gridviewUserList" runat="server" Width="386px" AutoGenerateColumns="False"
        CellPadding="3" GridLines="Vertical" DataKeyNames="UserID" 
        OnRowDeleting="gridviewUserList_RowDeleting"
        OnRowEditing="gridviewUserList_RowEditing" 
        onrowcancelingedit="gridviewUserList_RowCancelingEdit" 
        onrowupdating="gridviewUserList_RowUpdating" 
        ondatabinding="gridviewUserList_DataBinding" 
        ondatabound="gridviewUserList_DataBound" 
        onrowcommand="gridviewUserList_RowCommand" 
        onrowcreated="gridviewUserList_RowCreated" 
        onrowdatabound="gridviewUserList_RowDataBound" BackColor="White" 
        BorderColor="#999999" BorderStyle="None" BorderWidth="1px" 
        EmptyDataText="Null">
        <FooterStyle BackColor="#CCCCCC" ForeColor="Black" />
        <RowStyle BackColor="#EEEEEE" ForeColor="Black" />
        <Columns>
            <asp:TemplateField HeaderText="用户ID" HeaderStyle-HorizontalAlign="Center" ItemStyle-Wrap="false">
                <EditItemTemplate>
                     <asp:Label ID="lblUserID" runat="server"><%# Eval("userID")%></asp:Label>
                </EditItemTemplate>            
                <ItemTemplate>
                    <asp:Label ID="Label1" runat="server" Text='<%# Bind("userID") %>'></asp:Label>
                </ItemTemplate>

<HeaderStyle HorizontalAlign="Center"></HeaderStyle>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="姓名">
                 <EditItemTemplate>
                    <asp:TextBox ID="txtName" runat="server" Text='<%# Bind("UserName") %>'></asp:TextBox>
                </EditItemTemplate>
                <ItemTemplate>
                    <asp:Label ID="lblName" runat="server"> <%#Eval("UserName")%></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="权限">
                <EditItemTemplate>
                    <asp:HiddenField ID="hdfRole" runat="server" Value='<%# Eval("roleID") %>' />
                    <asp:DropDownList ID="ddlRole" runat="server"  DataSource='<%#getDataSet() %>' DataTextField="roleName" DataValueField="roleID"> </asp:DropDownList>
                </EditItemTemplate>
                <ItemTemplate>
                    <asp:Label  ID="lblRole" runat="server"> </asp:Label>
                </ItemTemplate>
            </asp:TemplateField > 
             <asp:TemplateField HeaderText="性别" ItemStyle-Wrap="false">
                <EditItemTemplate >   
                    <asp:HiddenField ID="hdfGender" runat="server" Value='<%# Eval("userGender") %>' />
                    <asp:DropDownList ID="ddlGender" runat="server"/>               
                </EditItemTemplate>                
                <ItemTemplate>
                    <asp:Label  ID="lblGender" runat="server"> </asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="院系">
                <EditItemTemplate>
                    <asp:TextBox ID="txtDept" runat="server" Text='<%#Bind("userDepartment")%>'></asp:TextBox>
                </EditItemTemplate>
                <ItemTemplate>
                    <asp:Label runat="server"><%#Eval("userDepartment") %></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="住址">
                <EditItemTemplate>
                    <asp:TextBox ID="txtAddress" runat="server" Text='<%# Bind("userAddress") %>'></asp:TextBox>
                </EditItemTemplate>
                <ItemTemplate>
                    <asp:Label ID="Label2" runat="server"><%#Eval("userAddress")%></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:CommandField HeaderText="删除" ShowDeleteButton="True" DeleteText="删除"  
                ButtonType="Link" HeaderStyle-HorizontalAlign="Center" ItemStyle-Wrap="false">
<HeaderStyle HorizontalAlign="Center"></HeaderStyle>
            </asp:CommandField>
            <asp:CommandField HeaderText="编辑" CancelText="取消" EditText="编辑" ShowEditButton="True"
                UpdateText="更新" ButtonType="Button"  HeaderStyle-HorizontalAlign="Justify">
<HeaderStyle HorizontalAlign="Justify"></HeaderStyle>
            </asp:CommandField>
        </Columns>
        <PagerStyle BackColor="#999999" ForeColor="Black" HorizontalAlign="Center" />
        <SelectedRowStyle BackColor="#008A8C" Font-Bold="True" ForeColor="White" />
        <HeaderStyle BackColor="#000084" Font-Bold="True" ForeColor="White" />
        <AlternatingRowStyle BackColor="#DCDCDC" />
    </asp:GridView>
    <asp:Label ID="lblDebugMsg" runat="server" EnableViewState="False" />
</asp:Content>
