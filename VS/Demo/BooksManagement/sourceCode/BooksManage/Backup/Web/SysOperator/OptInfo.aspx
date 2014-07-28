<%@ Page Language="C#" MasterPageFile="~/SysOperator/OperatorMasterPage.Master" AutoEventWireup="true" CodeBehind="OptInfo.aspx.cs" Inherits="Web.SysOperator.OptInfo" Title="个人信息" %>
<%@ Register Src="~/Common/controls/userDetails.ascx" TagName="baseInfo" TagPrefix="uc1" %> 
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <uc1:baseInfo id="readerInfo" runat="server"/>
</asp:Content>
