<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="top.aspx.cs" Inherits="Web.admin.top" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/tr/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title></title>
    <link href="/css/admin.css" type="text/css" rel="stylesheet"/>
</head>
<body>
<form ID="top" runat="server">
<table cellspacing="0" cellpadding="0" width="100%" border="0" background="/images/header_bg.jpg">
  <tr>
    <td height="56px" style='background-image:url("/images/header_left.jpg") repeat; width:520px;'><h1 style="color:#FFFFFF; padding-left:10px; letter-spacing:1px">管理后台</h1></td>
    <td style="font-weight: bold; color:#FFFFFF; padding-top:20px" align="center">当前用户：<asp:Literal ID="ltlUserName" runat="server"></asp:Literal>&nbsp;&nbsp; 
    <a style="color:#FFFFFF" href="ChangePwd.aspx" target="main">修改口令</a> &nbsp;&nbsp; 
    <a style="color:#FFFFFF" onclick="if (confirm('确定要退出吗？')) return true; else return false;" href="Login.aspx" target="_top">退出系统</a> 
    </td>
    <td align="right" width="268"><img height="56" src="/images/header_right.jpg" width="268" /></td></tr>
    <tr bgColor="#1c5db6" height="4"><td colspan="3"></td></tr>
 </table>
    </form>
</body>
</html>
