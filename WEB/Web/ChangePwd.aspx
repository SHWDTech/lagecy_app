<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ChangePwd.aspx.cs" Inherits="Web.ChangePwd" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
   <title></title>
   <link href="/css/admin.css" rel="stylesheet" type="text/css" />
   <script type="text/javascript">
       function Validate() {
           var newpwd = document.getElementById("txtNewPwd").value;
           if (newpwd.indexOf("@") !== -1 || newpwd.indexOf("#") !== -1) {
               alert("新密码不能包含@、#等特殊符合！");
               document.getElementById("txtNewPwd").focus();
               return false;
           }
       }
</script>
</head>
<body>
<form id="form1" runat="server">
<table width="100%" cellspacing="0" cellpadding="0"  border="0">
  <tr height="28px">
    <td background="images/title_bg1.jpg" style="font-weight:bold;"><img src="images/go.gif"/> &nbsp;&nbsp;当前位置： <span style="font-weight:normal"> [ 修改密码 ] </span></td></tr>
  <tr>
    <td bgcolor="#b1ceef" height="1px"></td></tr>
  <tr height="20px">
    <td background="images/shadow_bg.jpg"></td></tr></table>
<table cellspacing="1" cellpadding="1" width="100%" align="center" border="0" bgcolor="#F2F6FB">
  <tr>
    <td align="right" width="100"  class="STYLE7">用户名：</td>
    <td> <asp:Literal ID="ltlUserName" runat="server"></asp:Literal></td></tr>
  <tr>
    <td align="right">旧密码：</td>
    <td><asp:TextBox ID="txtPwd" runat="server" TextMode="Password"></asp:TextBox>
        <asp:Label ID="lbPwd" runat="server"  ForeColor="Red"></asp:Label></td></tr>
  <tr>
    <td align="right">新密码：</td>
    <td><asp:TextBox ID="txtNewPwd" runat="server" TextMode="Password"></asp:TextBox>
        <asp:Label ID="lbNewPwd" runat="server"  ForeColor="Red"></asp:Label></td></tr>
  <tr>
    <td align="right">确认密码：</td>
    <td><asp:TextBox ID="txtRepeatPwd" runat="server" TextMode="Password"></asp:TextBox></td></tr>
  <tr>
    <td  colspan="2" align="center" class="STYLE7"></td>
    <td><asp:Button ID="btnSubmit" runat="server"  CssClass="button"  Text="提交"
                    OnClientClick="return Validate(); return false;" onclick="btnSubmit_Click"/>&nbsp;&nbsp;
        <asp:Button ID="btnReset" runat="server" Text="重置" CssClass="button"/>
       </td></tr>
    </table> 
</form>
</body>
</html>