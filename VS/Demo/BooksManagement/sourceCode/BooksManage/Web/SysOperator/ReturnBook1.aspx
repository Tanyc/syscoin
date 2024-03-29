﻿<%@ Page Language="C#" MasterPageFile="~/SysOperator/OperatorMasterPage.master" AutoEventWireup="true"
    CodeFile="ReturnBook.aspx.cs" Inherits="SysOperator_ReturnBook" Title="returnBook Page" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <table align="left" cellpadding="0" border="0">
        <tr>
            <td colspan="2" align="center">
                还书操作
            </td>
        </tr>
        <tr>
            <td colspan="2">
                请输入图书编号：
            </td>
        </tr>
        <tr>
            <td colspan="2">
                <asp:TextBox ID="txtBookID" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td style="width: 64px; height: 25px">
                <asp:ImageButton ID="imgbtnReturn" ImageUrl="~/Images/ReturnBook.GIF" runat="server"
                    OnClick="imgbtnReturn_Click" />
            </td>
            <td style="height: 25px">
                <asp:ImageButton ID="ImageReset" ImageUrl="~/Images/RESET.GIF" runat="server" OnClick="ImageReset_Click" />
            </td>
        </tr>
        <tr>
            <td colspan="2">
                <asp:Label ID="lblMsg" runat="server" Visible="False" ForeColor="Red"></asp:Label>
            </td>
        </tr>
    </table>
</asp:Content>
