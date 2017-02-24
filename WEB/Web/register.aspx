<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="register.aspx.cs" Inherits="Web.register" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title></title>
    <link type="text/css" rel="stylesheet" href="css/register.css" />
    <script src="js/RegisterJS.js" type="text/javascript"></script>
    <script type="text/javascript">
    function change() {
        var m = document.getElementById("img");
        m.src = m.src + '?';
    }
    function failure() {
        document.getElementById("failure").style.display = "block";
    }
    
    var opts = <%=zCountry %>;
    function init(){
        var obj = document.getElementById("selCountry");
        if (opts==null) return;
        for(var i=0;i<opts.length;i++){
            obj.options.add(new Option(opts[i].Val, opts[i].Key));
        }
    }
    window.onload=init;
    
    function setCountry(val){
        document.getElementById("txtCountry").value=val;
    }
    </script>
</head>
<body>
<div id="wrap">
<div class="header">
</div>
<div class="main">
<img width="880" height="6" src="images/gb/register3-mainTop.gif" style="display: block" />
<form id="form1" name="form1" runat="server" method="post">
    <div class="centerBg">
    <div class="part1 float-left">
    <h1>用户注册</h1>
    <p>
    <label>用户名：</label>
    <input id="txtUserName" class="frame-grey" type="text" maxlength="20" value="您可用常用邮箱做用户名" onblur="this.className='frame';startRequest();" onfocus="if(this.value=='您可用常用邮箱做用户名'){this.value='';this.className='frameB';}" style="outline:none;" name="txtUserName">
    <span><font color="red">(*)</font>请使用4-20位英文字母+数字组合</span>
    </p>
    <div id="tr_username" style="position:relative;display:none">
    <span id="span_username" class="myspan"></span>
    </div>
    <p>
    <label>密码：</label>
    <input id="txtPwd" class="frame" type="password" onfocus="this.className='frameB'" style="outline:none;" onblur="this.className='frame';CheckPsd();" name="txtPwd">
    <span><font color="red">(*)</font>为提高安全性，请选用6位及以上字符</span>
    </p>
    <div id="tr_pwd" style="position:relative;display:none">
    <span id="span_pwd" class="myspan"></span>
    </div>
    <p>
    <label>确认密码：</label>
    <input id="txtConfirmPwd" class="frame" type="password" onblur="this.className='frame';CheckConfirmPsd();" onfocus="this.className='frameB'" style="outline:none;" name="txtConfirmPwd">
    <span><font color="red">(*)</font></span>
    </p>
     <div id="tr_comfirmpwd" style="position:relative;display:none">
    <span id="span_comfirmpwd" class="myspan"></span>
    </div>
    <p>
    <label>您的邮箱：</label>
    <input id="txtEmail" class="frame" type="text" onblur="this.className='frame';checkemail();" onfocus="this.className='frameB'" style="outline:none;" name="txtEmail">
    <span><font color="red">(*)</font>用于密码找回，请填写真实邮箱</span>
    </p>
    <div id="tr_email" style="position:relative;display:none">
    <span id="span_email" class="myspan"></span>
    </div>
    <p>
    <label>您的手机：</label>
    <input id="txtPhone" class="frame" type="text" maxlength="11" onblur="this.className='frame';checkphone();" onfocus="this.className='frameB'" style="outline:none;" name="txtPhone">
    <span><font color="red">(*)</font>11位手机号码</span>
    </p>
    <div id="tr_phone" style="position:relative;display:none">
    <span id="span_phone" class="myspan"></span>
    </div>
    <p>
    <label>管辖区县：</label><select id="selCountry" name="selCountry" onchange="setCountry(this.value)"></select>
    </p>
    <div id="tr_country" style="position:relative;display:none"><input id="txtCountry" name="txtCountry" type="hidden" /></div>
    <p>
    <label>验证码：</label>
    <input id="txtValidateCode" class="frame-vld" type="text" onblur="this.className='frame-vld';checkcode();" onfocus="this.className='frameBv'" style="outline:none;" name="txtValidateCode">
    <img id="img" src="VerifyImage.ashx" onclick="change()"/>
    </p>
    <div id="tr_validatecode" style="position:relative;display:none">
    <span id="span_validatecode" class="myspan"></span>
    </div>

    <p class="checkboxP">
    <a class="register" href="javascript:form1.submit();" onclick="return SubmitCheck();"></a>
    </p>
    </div>

<div class="boundary float-left" style="height:440px"></div>
 <div class="part2 float-right">
 <div style="width:100%;margin:0 auto; margin:100px 0 0 50px"><img src="images/ico13.gif" width="107" height="97"/></div>
</div>
</div>
    </form>
     <img style="display: block" src="images/gb/register3-mainBottom.gif" width="880" height="8" />
    </div>
    <div class="footer"></div>
    </div>
</body>
</html>
