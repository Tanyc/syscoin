<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="login.aspx.cs" Inherits="Web.login" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head id="Head1"  runat="server">
    <title>图书管理系统</title>
     <style type="text/css">
        div.RoundedCorner{background: #BAD4F7; width:350px;}
        b.rtop, b.rbottom{display:block;background: #FFF}
        b.rtop b, b.rbottom b{display:block;height: 1px;overflow: hidden; background: #BAD4F7}
        b.r1{margin: 0 5px}
        b.r2{margin: 0 3px}
        b.r3{margin: 0 2px}
        b.rtop b.r4, b.rbottom b.r4{margin: 0 1px;height: 2px}
        table.content{border:0px;height:100px; font-family:Tahoma; font-size:9.5pt;color:#363A36;}
    </style>

</head>
<body leftmargin=0 rightmargin=0 topmargin=0>
    <form id="form1" runat="server" defaultbutton="imgBtnLogin">
    <div align="center"><br /><br /><br /><br /><br /><br /><br /><div class="RoundedCorner">
    <b class="rtop"><b class="r1"></b><b class="r2"></b><b class="r3"></b><b class="r4"></b></b>
                <table class="content" style="FONT-SIZE: 12px; FONT-FAMILY: Tahoma; BORDER-COLLAPSE: collapse; " cellspacing="0" cellpadding="1" width=350 align="center"
				 border="1" bgColor="#ffffff" bordercolor="#BAD4F7">
				<tr height=40>
					<td colspan="3" align="center">	<br />					
						<font color=#4D2600><h4>图书管理系统登陆</h4></font>
					</td>
				</tr>							
				<tr>
					<td height="30" align="center" style="width: 83px">帐 &nbsp;号：</td>
					<td height="30"><div align="left">						
							<asp:TextBox id="txtUserID" runat="server" MaxLength="20" Width="150px"></asp:TextBox>   
                        </div>                   
                       </td>
                       <td>
                           <div align="left"> <asp:CheckBox ID="cbxRemeberUser" runat="server" Text="记住用户名" Checked="true" /> 
                           <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtUserID"
                            ErrorMessage="不能为空！"></asp:RequiredFieldValidator></div>
                       </td>
				</tr>
				<tr>
					<td align="center" height="30" style="width: 83px">密 &nbsp;码：</td>
					<td height="30"><div align="left">
						<asp:TextBox id="txtPwd"  runat="server" MaxLength="20" TextMode="Password" Width="150px"></asp:TextBox>
                       </div>
                    </td>
                    <td>
                      <div align="center">
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="txtPwd"
                            ErrorMessage="不能为空！"></asp:RequiredFieldValidator>
                      </div>
                    </td>
				</tr>
				
				<tr height=50>
					<td align=center colspan="3">
                        <asp:Label ID="lblMessage" runat="server" ForeColor="red"></asp:Label><br />
						<asp:ImageButton ID="imgBtnLogin" runat="server" ImageUrl="~/Images/Login.GIF" 
                            OnClick="imgBtnLogin_Click" Height="20px" />
					</td>
				</tr>
			</table>
          <b class="rbottom"><b class="r4"></b><b class="r3"></b><b class="r2"></b><b class="r1"></b></b>
    </div>
    </div>
    </form>
    
    
    
</body>




</html>
