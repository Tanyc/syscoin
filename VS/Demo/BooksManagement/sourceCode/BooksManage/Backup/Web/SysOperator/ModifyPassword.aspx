﻿<%@ Page Language="C#" MasterPageFile="~/SysOperator/OperatorMasterPage.Master" AutoEventWireup="true" CodeBehind="ModifyPassword.aspx.cs" Inherits="Web.SysOperator.ModifyPassword" Title="修改密码 " %>
<%@ Register Src="~/Common/controls/ModifyPassword.ascx"  TagName="changePassword" TagPrefix="uc1" %> 
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
   <uc1:changePassword  id="readerChangPwd" runat="server" />

</asp:Content>
