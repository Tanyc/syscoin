<%@ Page Language="C#" MasterPageFile="~/Reader/ReaderMasterPage.Master" AutoEventWireup="true"
    CodeBehind="BorrowInfo.aspx.cs" Inherits="Web.Reader.BorrowInfo" Title="图书借阅记录" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table width="100%" border="1">
        <tr>
            <td align="center" style="height: 25px">
                我 的 书 刊 借 阅 信 息
            </td>
        </tr>
        <tr  id="TrGrid" runat="server" >
            <td width="100%" >
                <asp:GridView ID="gvBorrowBookList" runat="server" Width="755px" AutoGenerateColumns="False"
                    CellPadding="4" ForeColor="#333333" GridLines="None" 
                    OnRowDataBound="gvBorrowBookList_RowDataBound">
                    <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                    <Columns>
                        <asp:BoundField DataField="bookName" HeaderText="题名" />
                        <asp:BoundField DataField="beginDate" HeaderText="借阅日期" />
                        <asp:TemplateField HeaderText="应归还日期">
                            <EditItemTemplate>
                                <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                            </EditItemTemplate>
                            <ItemTemplate>
                                <asp:Label ID="lblEndDate" runat="server"></asp:Label>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:BoundField DataField="publish" HeaderText="出版社" />
                    </Columns>
                    <RowStyle BackColor="#EFF3FB" />
                    <EditRowStyle BackColor="#2461BF" />
                    <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
                    <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
                    <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                    <AlternatingRowStyle BackColor="White" />
                </asp:GridView>
            </td>
            
        </tr>
        <tr  id="TrMsg" runat="server">
            <td align="center"  >
               <asp:Label ID="lblMsgNoBorrow" runat="server" ForeColor="Red" ></asp:Label>
            </td>
        </tr>
    </table>
</asp:Content>
