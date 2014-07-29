<%@ Page language="c#" Codebehind="我的通讯录管理.aspx.cs" AutoEventWireup="false" Inherits="MyFriend.WebForm1" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN" >
<HTML>
	<HEAD>
		<title>WebForm1</title>
		<meta name="GENERATOR" Content="Microsoft Visual Studio 7.0">
		<meta name="CODE_LANGUAGE" Content="C#">
		<meta name="vs_defaultClientScript" content="JavaScript">
		<meta name="vs_targetSchema" content="http://schemas.microsoft.com/intellisense/ie5">
	</HEAD>
	<body MS_POSITIONING="GridLayout">
		<form id="Form1" method="post" runat="server">
			<asp:DataGrid id="DataGrid1" style="Z-INDEX: 101; LEFT: 45px; POSITION: absolute; TOP: 287px" runat="server" Width="475px" Height="226px" PageSize="5" AllowPaging="True" BorderColor="#E7E7FF" BorderStyle="None" BorderWidth="1px" BackColor="White" CellPadding="3" GridLines="Horizontal">
				<SelectedItemStyle Font-Bold="True" ForeColor="#F7F7F7" BackColor="#738A9C"></SelectedItemStyle>
				<AlternatingItemStyle BackColor="#F7F7F7"></AlternatingItemStyle>
				<ItemStyle ForeColor="#4A3C8C" BackColor="#E7E7FF"></ItemStyle>
				<HeaderStyle Font-Bold="True" ForeColor="#F7F7F7" BackColor="#4A3C8C"></HeaderStyle>
				<FooterStyle ForeColor="#4A3C8C" BackColor="#B5C7DE"></FooterStyle>
				<Columns>
					<asp:ButtonColumn Text="删除" ButtonType="PushButton" CommandName="Delete"></asp:ButtonColumn>
				</Columns>
				<PagerStyle HorizontalAlign="Right" ForeColor="#4A3C8C" BackColor="#E7E7FF" Mode="NumericPages"></PagerStyle>
			</asp:DataGrid>
			<asp:Label id="Label1" style="Z-INDEX: 103; LEFT: 39px; POSITION: absolute; TOP: 108px" runat="server" Width="480px" BackColor="#8080FF" ForeColor="White">我的通讯录管理</asp:Label>
			<asp:Button id="Button2" style="Z-INDEX: 105; LEFT: 228px; POSITION: absolute; TOP: 217px" runat="server" Width="181px" Text="查看通讯录"></asp:Button>
			<asp:TextBox id="TextBox1" style="Z-INDEX: 106; LEFT: 99px; POSITION: absolute; TOP: 142px" runat="server" Width="133px" BorderStyle="Groove"></asp:TextBox>
			<asp:TextBox id="TextBox3" style="Z-INDEX: 107; LEFT: 99px; POSITION: absolute; TOP: 178px" runat="server" Width="133px" BorderStyle="Groove"></asp:TextBox>
			<asp:TextBox id="TextBox2" style="Z-INDEX: 108; LEFT: 336px; POSITION: absolute; TOP: 145px" runat="server" Width="184px" BorderStyle="Groove"></asp:TextBox>
			<asp:TextBox id="TextBox4" style="Z-INDEX: 109; LEFT: 336px; POSITION: absolute; TOP: 175px" runat="server" Width="184px" BorderStyle="Groove"></asp:TextBox>
			<asp:Label id="Label2" style="Z-INDEX: 110; LEFT: 39px; POSITION: absolute; TOP: 145px" runat="server">姓名</asp:Label>
			<asp:Label id="Label3" style="Z-INDEX: 111; LEFT: 255px; POSITION: absolute; TOP: 148px" runat="server">年龄</asp:Label>
			<asp:Label id="Label4" style="Z-INDEX: 112; LEFT: 39px; POSITION: absolute; TOP: 184px" runat="server">电话</asp:Label>
			<asp:Label id="Label5" style="Z-INDEX: 113; LEFT: 252px; POSITION: absolute; TOP: 181px" runat="server">电子邮件</asp:Label>
			<asp:Button id="Button3" style="Z-INDEX: 114; LEFT: 42px; POSITION: absolute; TOP: 217px" runat="server" Width="151px" Text="增加联系人"></asp:Button>
			<asp:Label id="Label6" style="Z-INDEX: 115; LEFT: 48px; POSITION: absolute; TOP: 252px" runat="server" Width="383px"></asp:Label>
		</form>
	</body>
</HTML>
