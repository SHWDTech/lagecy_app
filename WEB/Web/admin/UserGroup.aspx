<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="UserGroup.aspx.cs" Inherits="Web.UserGroup" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title></title>
    <link rel="stylesheet" type="text/css" href="css/right.css"/>
</head>
<body>
<form id="form1" runat="server">
<table width="100%" cellspacing="0" cellpadding="0" border="0">
  <tr><td style="font-weight:bold;background-image:url(/images/title_bg.jpg);height:28px">
  <img src="/images/go.gif"/>��ǰλ�ã� <span style="font-weight:normal"> [ �û������ ] </span><span style="float:right;margin-right:20px"><img src="images/add.gif" width="10" height="10" onclick="window.location.href='UserGroupAdd.aspx'"/> ���</span></td></tr>
  <tr><td bgcolor="#b1ceef" height="1px"></td></tr>
</table>
<table width="100%" border="0" cellpadding="1" cellspacing="1">    
    <tr><td class="STYLE19" width="64px">&nbsp;������</td><td><asp:TextBox ID="txtName" runat="server"></asp:TextBox>
        <asp:Button ID="btnSubmit" runat="server" Text="����" CssClass="button" OnClick="OnSubmit"/>
        </td></tr>
  <tr><td colspan="2"><table width="100%" border="0" cellpadding="0" cellspacing="1"><tr>
        <td width="5%" class="STYLE10"><input id="chbAll" type="checkbox" /></td>
        <td width="10%"class="STYLE10">����</td>
	    <td width="10%" class="STYLE10">����</td>
	    <td width="15%" class="STYLE10">����</td>
	    <td width="22%" class="STYLE10">����</td></tr>
      <asp:Repeater ID="Repeater" runat="server" onitemcommand="Repeater_ItemCommand" onitemdatabound="Repeater_ItemDataBound">
      <HeaderTemplate>          
      </HeaderTemplate>
      <ItemTemplate>
          <tr><td class="STYLE18"><asp:CheckBox ID="chb" runat="server" /></td>
          <td class="STYLE18"><%#DataBinder.Eval(Container.DataItem, "Name")%></td>
          <td class="STYLE18"><%#DataBinder.Eval(Container.DataItem, "Description")%></td>
          <td class="STYLE18"><%#DataBinder.Eval(Container.DataItem, "Orders")%></td>
          <td class="STYLE18"><img src="/images/del.gif" /><asp:LinkButton ID="lbtnDel" runat="server" CommandName="Del" CommandArgument='<%#DataBinder.Eval(Container.DataItem,"Id")%>'>ɾ��</asp:LinkButton>&nbsp; &nbsp;
          </td></tr>
      </ItemTemplate>
      <FooterTemplate>
      </FooterTemplate>
      </asp:Repeater>
      </table>
     </td>	
   </tr>
   <tr><td height="30" colspan="2"><table width="100%" border="0" cellspacing="0" cellpadding="0">
      <tr><td width="33%"><div align="left"><span class="STYLE22">&nbsp;&nbsp;���� <strong><asp:Literal ID="labCount" runat="server"></asp:Literal></strong> ����¼����ǰ��<strong> <asp:Literal id="labPageIndex" runat="server"></asp:Literal>/<asp:Literal id="labPageCount" runat="server"></asp:Literal></strong> ҳ</span></div></td>
        <td width="67%"><table width="312" border="0" align="right" cellpadding="0" cellspacing="0">
          <tr><td width="49"><div align="center"><asp:ImageButton ID="firstPage" runat="server" ImageUrl="images/first.gif" onclick="firstPage_Click"/></div></td>
            <td width="49"><div align="center"><asp:ImageButton ID="prevPage" runat="server"  ImageUrl="images/back.gif" onclick="prevPage_Click"/></div></td>
            <td width="49"><div align="center"><asp:ImageButton ID="nextPage" runat="server" ImageUrl="images/next.gif" onclick="nextPage_Click"/></div></td>
            <td width="49"><div align="center"><asp:ImageButton ID="lastPage" runat="server" ImageUrl="images/last.gif" onclick="lastPage_Click"/></div></td>
            <td width="37" class="STYLE22"><div align="center">ת��</div></td>
            <td width="34"><div align="center"><asp:TextBox ID="txtPageIndex" runat="server" CssClass="pageIndex"></asp:TextBox>
            </div></td><td width="22" class="STYLE22"><div align="center">ҳ</div></td>
            <td width="35"><asp:ImageButton ID="goPage" runat="server" ImageUrl="images/page_go.gif" onclick="goPage_Click" /></td>
          </tr>
        </table></td>
      </tr>
    </table></td>
  </tr>
  </table>
</form>
</body>
</html>



