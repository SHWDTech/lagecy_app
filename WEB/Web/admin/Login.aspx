<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="Web.admin.Login" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml" >
<head id="Head1" runat="server">
<title></title>
<style type="text/css">
body
{
	margin:0;
	padding:0;
	font-size:12px;
	font-family:Arial;
}
.login {	
    height: 21px;
    width: 70px;
    background-color: Transparent;
    background-image: url(/images/bluelogin.gif); 
    background-position: right center;
    background-repeat: no-repeat
}

.td_class{
	height:36px;
	width:120px;
	padding-top:4px;
	text-decoration: none; 
}
td img,td input { vertical-align:middle;}  
#login_top{ background: #7DC8FC repeat-x ; width:100%; height:120px;}
</style>
<script type="text/javascript">
    if (window != top) top.location.href = location.href; 
    function change() {
        var m = document.getElementById("img");
        m.src = m.src + '?';
    }
 </script>
</head>
<body>
<form id="form1" runat="server" autocomplete="off">
<div id="login_top">
<br/>
<span  style="height:80px;display:block;margin:1px 1px;text-align:center;line-height:80px; font-size:36px; font-weight:bolder;font-family:Verdana">
    上海建设工程颗粒物与噪声在线监控管理后台</span></div>
<table width="600" border="0" align="center" cellpadding="0" cellspacing="0" >
  <tr>
    <td width="221"><table width="95%" border="0" cellpadding="0" cellspacing="0">
      
      <tr>
        <td><table width="100%" border="0" cellpadding="0" cellspacing="0">
          <tr>
            <td align="center"><img src="/images/ico13.gif" width="107" height="97" /></td>
          </tr>
          
        </table></td>
        <td><img src="/images/line01.gif" width="5" height="292" /></td>
      </tr>
    </table></td>
    <td height="292px"><table width="100%" border="0" cellspacing="0" cellpadding="0">
      <tr>
        <td align="right" class="td_class">用户名：<br /></td>
        <td >
         <asp:TextBox ID="txtUserName" runat="server" MaxLength="16" TabIndex="1"  Width="120px"></asp:TextBox>&nbsp; &nbsp; 
            <asp:Label ID="lbName" runat="server"  ForeColor="Red"></asp:Label></td>
      </tr>
      <tr>
        <td align="right" class="td_class">密　码：</td>
        <td><asp:TextBox ID="txtPwd" runat="server" MaxLength="16" TabIndex="2" TextMode="Password"  Width="120px"></asp:TextBox>&nbsp; &nbsp; 
            <asp:Label ID="lbPwd" runat="server"  ForeColor="Red"></asp:Label>
        </td>
      </tr>
      <tr>
        <td align="right" class="td_class">验证码：</td>
        <td><asp:TextBox ID="txtVerify" runat="server" MaxLength="4" TabIndex="3" 
                Width="50px"></asp:TextBox>
            <img  id="img" src="/VerifyImage.ashx" onclick="change()"/>
				<asp:Label ID="lbVerify" runat="server"  ForeColor="Red"></asp:Label>
		</td>
      </tr>
      <tr>
       	<td align="right" height="64px" class="td_class"></td>
		<td align="left"> <asp:Button ID="btnLogin" runat="server" CssClass="login" OnClick="UserLogin" BorderStyle="None"  tabindex="4"/>
			</td>
      </tr>
    </table></td>
  </tr>
</table>
</form>
</body>
</html>