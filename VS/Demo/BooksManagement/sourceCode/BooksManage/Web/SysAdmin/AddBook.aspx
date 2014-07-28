﻿<%@ Page Language="C#" MasterPageFile="~/SysAdmin/sysAdminMasterPage.Master" AutoEventWireup="true" CodeBehind="AddBook.aspx.cs" Inherits="Web.SysAdmin.AddBook" Title="添加图书" %>
<%@ Register Src="~/SysAdmin/AdminLeft.ascx" TagName="adminleft" TagPrefix="uc1" %> 

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

  <div>
    
    <table style="FONT-SIZE: 12px; FONT-FAMILY: Tahoma; BORDER-COLLAPSE: collapse; " width="400" border="1" borderColor="#2c6ed5" cellspacing="0" cellpadding="0" align="left
    " id="TABLE1" language="javascript" onclick="return TABLE1_onclick()">
				<tr>
					<td align="center" colspan="2">
						<font size="5" face="隶书">添加图书</font>
					</td>
				</tr>
				
								<tr>
									<td>
										ISBN号：
									</td>
									<td >
										<asp:TextBox id="txtISBN" runat="server" Width="192px"></asp:TextBox>*
										<asp:RequiredFieldValidator id="RequiredFieldValidator2" runat="server" ErrorMessage="此项不能为空" ControlToValidate="txtISBN"></asp:RequiredFieldValidator><BR>
										<asp:RegularExpressionValidator id="RegularExpressionValidator1" runat="server" ErrorMessage="输入有误，请重输" ValidationExpression="\d{1,}\-\d{1,}\-\d{1,}\-\d{1,}" ControlToValidate="txtISBN"></asp:RegularExpressionValidator></td>
								</tr>
								<tr>
									<td>
										书名：
									</td>
									<td>
										<asp:TextBox id="txtName" runat="server" Width="193px"></asp:TextBox>*
										<asp:RequiredFieldValidator id="RequiredFieldValidator1" runat="server" ErrorMessage="此项不能为空" ControlToValidate="txtName"></asp:RequiredFieldValidator>
									</td>
								</tr>
									<tr>
									<td style="height: 23px">
										索取号：
									</td>
									<td style="height: 23px">
										<asp:TextBox id="txtIndex" runat="server" Width="192px"></asp:TextBox>*
										<asp:RequiredFieldValidator id="RequiredFieldValidator6" runat="server" ControlToValidate="txtIndex" ErrorMessage="此项不能为空"></asp:RequiredFieldValidator></td>
								</tr>
								
								<tr>
									<td>
										图书类型：
									</td>
									<td>
                                        <asp:RadioButtonList ID="rblClassify" runat="server" Font-Size="9pt" RepeatDirection="Horizontal">
                                            <asp:ListItem Value="0" Selected="True">社会科学</asp:ListItem>
                                            <asp:ListItem Value="1">自然科学</asp:ListItem>
                                            <asp:ListItem Value="2">综合性图书</asp:ListItem>
                                            <asp:ListItem Value="3">哲学</asp:ListItem>
                                        </asp:RadioButtonList></td>
								</tr>
								
								
								
								
								
								
								
								
								<tr>
									<td>
										作者名：
									</td>
									<td>
										<asp:TextBox id="txtAuthor" runat="server" Width="192px"></asp:TextBox>*
										<asp:RequiredFieldValidator id="RequiredFieldValidator3" runat="server" ErrorMessage="此项不能为空" ControlToValidate="txtAuthor"></asp:RequiredFieldValidator></td>
								</tr>
								<tr>
									<td>
										出版社：
									</td>
									<td>
										<asp:TextBox id="txtPublish" runat="server" Width="192px"></asp:TextBox>*
										<asp:RequiredFieldValidator id="RequiredFieldValidator4" runat="server" ErrorMessage="此项不能为空" ControlToValidate="txtPublish"></asp:RequiredFieldValidator></td>
								</tr>
									<tr>
									<td>
										定价(元)：
									</td>
									<td>
										<asp:TextBox id="txtPrice" runat="server" Width="192px"></asp:TextBox>*
										<asp:RequiredFieldValidator id="RequiredFieldValidator7" runat="server" ErrorMessage="此项不能为空" ControlToValidate="txtPrice"></asp:RequiredFieldValidator><BR>
										<asp:RegularExpressionValidator id="RegularExpressionValidator" runat="server" ErrorMessage="输入有误，请重输" ValidationExpression="(\d{1,}\.\d*)|(\d{1,})" ControlToValidate="txtPrice"></asp:RegularExpressionValidator></td>
								</tr>
								<tr>
									<td>
										出版时间：
									</td>
									<td>
                                        <asp:DropDownList ID="ddlYear" runat="server">
                                        </asp:DropDownList>年
                                        <asp:DropDownList ID="ddlMonth" runat="server">
                                        </asp:DropDownList>月
                                        <asp:DropDownList ID="ddlDay" runat="server">
                                        </asp:DropDownList>日</td>
								</tr>
								
								<tr>
									<td>
										主题词：
									</td>
									<td >
										<asp:TextBox id="txtSubject" runat="server" Width="192px"></asp:TextBox>*
											<asp:RequiredFieldValidator id="RequiredFieldValidator5" runat="server" ControlToValidate="txtSubject" ErrorMessage="此项不能为空"></asp:RequiredFieldValidator></td>
								</tr>
								
											
							
														
								
								<tr>
									<td>
										说明：
									</td>
									<td>
										<asp:TextBox id="txtDescription" runat="server" Width="337px" 
                                            TextMode="MultiLine" Height="64px"></asp:TextBox>
									</td>
									
								</tr>
								
							
				<tr>
					<td colspan=2 align=center>						
                        <asp:Label ID="lblMessage" runat="server" ForeColor="Red"></asp:Label><br />                        
                        <asp:ImageButton ID="imgBtnAdd" runat="server" ImageUrl="~/Images/ADD.GIF" OnClick="imgBtnAdd_Click" />
                        &nbsp; &nbsp; &nbsp; &nbsp;&nbsp;
                        <asp:ImageButton ID="imgBtnReturn" runat="server" ImageUrl="~/Images/RETURN.GIF" /></td>
				</tr>
			</table>
    </div>


</asp:Content>