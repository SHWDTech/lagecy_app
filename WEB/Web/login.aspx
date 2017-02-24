<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="login.aspx.cs" Inherits="Web.login" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title></title>
    <link type="text/css" rel="stylesheet" href="css/register.css" />
    <script type="text/javascript">
    function change() {
        var m = document.getElementById("img");
        m.src = m.src + '?';
    }
    function failure() {
        document.getElementById("failure").style.display = "block";
    }
 </script>
</head>
<body>
<div id="wrap">
<div class="header">
<span style="height:80px;display:block;margin:1px 1px;text-align:center;line-height:80px; font-size:36px; font-weight:bolder;font-family:Verdana">
    上海建设工程颗粒物与噪声在线监控管理平台</span>
</div>
<div class="main">
<img width="880" height="6" src="images/gb/register3-mainTop.gif" style="display: block" />
    <form id="form1" runat="server" action="login.aspx" method="post">
    <div class="centerBg">
<div class="part3 float-left">
<div style="width:100%;margin:0 auto; margin:100px 0 0 50px"><img src="images/ico13.gif" width="107" height="97"/></div>
</div>

<div class="boundary float-left" style="height: 330px"></div>
 <div class="part4">
    <h1>用户登录</h1>
    <p><label>用户名：</label><input type="text" value="" id="username" name="username" class="frame" /></p>
    <div class="clear"></div>
    <p><label>密码：</label><input type="password" value="" id="pwd" name="pwd" class="frame" /></p>
    <div class="clear"></div>
     <p><label>验证码：</label><input type="text" value="" id="verify" name="verify" class="frame2" /><img id="img" src="VerifyImage.ashx" onclick="change()"/></p>
    <div class="clear"></div>
    <div id="failure" class="fail_box" style="display:none"><span>登录失败，系统没有此用户名或用户密码错误。请您注意区分大小写,重新输入正确的用户名和密码登录！</span></div>
    <div class="clear"></div>
    <div class="bnts"><input type="submit" id="submittext" class="login" value=""/> 
    </div>
</div>
</div>
    </form>
     <img style="display: block" src="images/gb/register3-mainBottom.gif" width="880" height="8" />
    </div>
    <div class="footer"></div>
    </div>
</body>
</html>
