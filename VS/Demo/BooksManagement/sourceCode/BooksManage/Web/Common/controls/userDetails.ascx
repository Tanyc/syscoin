﻿<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="userDetails.ascx.cs" Inherits="Web.Common.controls.userDetails" %>

<table>
    <tr>
        <td>证件编号：</td>
        <td><asp:Label ID="lblID" runat="server"></asp:Label></td>
        <td>姓名：</td>
        <td><asp:Label ID="lblName" runat="server"></asp:Label></td>
    </tr>
  <tr>
      <td>性别：</td>
      <td><asp:Label ID="lblGender" runat="server"></asp:Label></td>
      <td>权限：</td>
      <td><asp:Label ID="lblPower" runat="server"></asp:Label></td>
  </tr>


  <tr>
      <td>所在院系：</td>
      <td><asp:TextBox ID="txtDept" runat="server"></asp:TextBox></td>
      <td>住址：</td>
      <td><asp:TextBox ID="txtAddress" runat="server"></asp:TextBox></td>
  </tr>
  
  <tr>
      <td>联系电话：</td>
      <td><asp:TextBox ID="txtPhone" runat="server"></asp:TextBox></td>
      
  </tr>
  <tr>
    <td colspan="4"  align="center">
        <asp:ImageButton ID="imgUpdate" runat="server" Height="16px" 
             ImageUrl="~/Images/Update.GIF" Width="59px" 
            onclick="imgUpdate_Click" />
    </td>
  </tr>

        

</table>