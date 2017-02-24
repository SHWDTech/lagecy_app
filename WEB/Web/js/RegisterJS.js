 String.prototype.Trim = function(){return this.replace(/^\s+|\s+$/g,"");}
 String.prototype.Ltrim = function(){return this.replace(/^\s+/g, "");}
 String.prototype.Rtrim = function(){return this.replace(/\s+$/g, "");}

function Check(reg,str)
{
	if(reg.test(str))
	{
		return true;
	}
	else
	{
		return false;
	}
}

var vPablic1 = null;
var vPablic2 = null;
function SubmitCheck()
{
	//校验用户名
	if(document.getElementById("txtUserName").value == "")
	{
		alert("用户名不能为空，请输入。");
		document.getElementById("txtUserName").focus();
		return false;
	}
	else
	{
	    if ((Check(/^[0-9_a-zA-Z]{4,20}$/, document.getElementById("txtUserName").value) == false) &&
		(Check(/\w+([-+.]\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*/, document.getElementById("txtUserName").value) == false))
		{
			alert("用户名格式不正确。");
			document.getElementById("txtUserName").focus();
			return false;
		}
	}

	//校验密码
	if (document.getElementById("txtPwd").value == "")
	{
		alert("密码不能为空，请输入。");
		document.getElementById("txtPwd").focus();
		return false;
	}
	else
	{
	    if (Check(/^[0-9_a-zA-Z]{6,20}$/, document.getElementById("txtPwd").value) == false)
		{
			alert("密码格式不正确，请输入6-20位的英文字母、数字或下划线。");
			document.getElementById("Password").focus();
			return false;
		}
		//不能与帐号重复
		if (document.getElementById("txtPwd").value.Trim() == document.getElementById("txtUserName").value.Trim())
		{
		    alert("为增强密码保密性， 请不要与用户名重复。");
		    document.getElementById("txtPwd").focus();
		    return false;
		}
		//不是相同的数字
		var s = "012345678901234";
		for(var i=0;i<10;i++)
		{
		    if (document.getElementById("txtPwd").value.indexOf(s.substring(i, i + 5)) > 0)
		    {
		        alert("为增强密码保密性，请不要含有连续的数字。");
		        document.getElementById("txtPwd").focus();
		        return false;
		    }
		}
		//不是重复数字或字母
		if (Check(/(\w)\1{2}/, document.getElementById("txtPwd").value) == true)
		{
		    alert("为增强密码保密性，请不要某一数字或某一字母连续出现三次以上。");
		    document.getElementById("txtPwd").focus();
		    return false;
		}
	}
	
	//校验 确认密码
	if (document.getElementById("txtConfirmPwd").value == "")
	{
		alert("确认密码不能为空，请输入。");
		document.getElementById("txtConfirmPwd").focus();
		return false;
	}
	else
	{
	    if (document.getElementById("txtPwd").value != document.getElementById("txtConfirmPwd").value)
		{
			alert("两次密码输入不一致，请重新输入。");
			document.getElementById("txtConfirmPwd").focus();
			return false;
		}
	}
	//校验EMAIL
	if (document.getElementById("txtEmail").value == "") {
		    alert("电子邮箱不能为空，请输入。");
		    document.getElementById("txtEmail").focus();
		    return false;
		}
		else {
		    if (Check(/\w+([-+.]\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*/, document.getElementById("txtEmail").value) == false) {
		        alert("电子邮箱格式不正确，请重新输入。");
		        document.getElementById("txtEmail").focus();
		        return false;
		    }
		    if (Check(/^[0-9_a-zA-Z.@]{4,64}$/, document.getElementById("txtEmail").value) == false) {
		        alert("电子邮箱含有非法字符，请重新输入。");
		        document.getElementById("txtEmail").focus();
		        return false;
		    }
		}


	//校验校验码
		if (document.getElementById("txtValidateCode").value == "")
	{
		alert("验证码不能为空，请输入。");
		document.getElementById("ValidateCode").focus();
		return false;
	}
	else
	{
	    if (document.getElementById("txtValidateCode").value.toUpperCase() != GetCookie("VerifyCode"))
		{
			alert("验证码输入不正确，请重新输入。");
			document.getElementById("txtValidateCode").focus();
			return false;
		}
	}
	//验证手机号
	checkphone();
}

function GetCookie(name)
{
	var arg = name + "=";
	var alen = arg.length;
	var clen = document.cookie.length;
	var i = 0;
	while(i < clen)
	{
		var j = i + alen;
		
		if(document.cookie.substring(i,j) == arg)
		{
			return getCookieVal(j);
		}
		
		i = document.cookie.indexOf(" ",i) + 1;
		
		if(i == 0)
		break;
	}

	return null;
}

function getCookieVal(offset)
{
	var endstr = document.cookie.indexOf(";",offset);
	if(endstr == -1)
	{
		endstr = document.cookie.length;
	}
	
	return unescape(document.cookie.substring(offset, endstr));
}

function startRequest() 
{
	if(document.getElementById("txtUserName").value.Trim() == "")
	{
	    document.getElementById("span_username").innerHTML = "用户名不能为空。";
	    document.getElementById("tr_username").style.display = "";
		return false;
	}
    else
	{
	    if ((Check(/^[0-9_a-zA-Z]{4,20}$/, document.getElementById("txtUserName").value) == false) &&
		(Check(/\w+([-+.]\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*/, document.getElementById("txtUserName").value) == false))
	    {
	        document.getElementById("span_username").innerHTML = "用户名格式不正确。";
	        document.getElementById("tr_username").style.display = "";
		    return false;
		}
	}
	document.getElementById("span_username").innerHTML = "";
	document.getElementById("tr_username").style.display = "none";
    return true;
}
function handleStateChange(msg) 
{
	if (msg == "该用户名已存在！")
	{
		document.getElementById("span_username").innerHTML = "该用户名已存在，请重新输入。";
		document.getElementById("tr_username").style.display = "";
	}
	else
	{
		document.getElementById("tr_username").style.display = "none";
	}
}
function checkemail() {
    if (document.getElementById("txtEmail").value == "") {
        document.getElementById("span_email").innerHTML = "电子邮箱不能为空，请输入。";
        document.getElementById("tr_email").style.display = "";
        return false;
    }
    else {
        if (Check(/\w+([-+.]\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*/, document.getElementById("txtEmail").value) == false) {
            document.getElementById("span_email").innerHTML = "电子邮箱格式不正确，请重新输入。";
            document.getElementById("tr_email").style.display = "";
            return false;
        }
        if (Check(/^[0-9_a-zA-Z.@]{4,64}$/, document.getElementById("txtEmail").value) == false) {
            document.getElementById("span_email").innerHTML = "电子邮箱含有非法字符，请重新输入。";
            document.getElementById("tr_email").style.display = "";
            return false;
        }
    }
    document.getElementById("span_email").innerHTML = "";
    document.getElementById("tr_email").style.display = "none";
    return true;
}
function checkcode() {
    if (document.getElementById("txtValidateCode").value == "") {
        document.getElementById("span_validatecode").innerHTML = "验证码不能为空，请输入。";
        document.getElementById("tr_validatecode").style.display = "";
        return;
    }
    else {
        if (document.getElementById("txtValidateCode").value.toUpperCase() != GetCookie("VerifyCode")) {
            document.getElementById("span_validatecode").innerHTML = "验证码输入不正确，请重新输入。";
            document.getElementById("tr_validatecode").style.display = "";
            return;
        }
    }
    document.getElementById("span_validatecode").innerHTML = "";
    document.getElementById("tr_validatecode").style.display = "none";
}
function ChangeCheckPsd() {
    //校验密码
    if (document.getElementById("txtPwd").value == "") {
        document.getElementById("span_pwd").innerHTML = "密码不能为空，请输入。";
        document.getElementById("tr_pwd").style.display = "";
        return false;
    }
    else {
        if (Check(/^[0-9_a-zA-Z]{6,20}$/, document.getElementById("txtPwd").value) == false) {
            document.getElementById("span_pwd").innerHTML = "密码格式不正确，请输入6-20位的英文字母、数字或下划线。";
            document.getElementById("tr_pwd").style.display = "";
            return false;
        }
        //不是相同的数字
        var s = "012345678901234";
        for (var i = 0; i < 10; i++) {
            if (document.getElementById("txtPwd").value.indexOf(s.substring(i, i + 5)) > 0) {
                document.getElementById("span_pwd").innerHTML = "为增强密码保密性，请不要含有连续的数字。";
                document.getElementById("tr_pwd").style.display = "";
                return false;
            }
        }
        //不是重复数字或字母
        if (Check(/(\w)\1{2}/, document.getElementById("txtPwd").value) == true) {
            document.getElementById("span_pwd").innerHTML = "为增强密码保密性，请不要某一数字或某一字母连续出现三次以上。";
            document.getElementById("tr_pwd").style.display = "";
            return false;
        }
    }
    document.getElementById("span_pwd").innerHTML = "";
    document.getElementById("tr_pwd").style.display = "none";
    return true;
}

function CheckPsd()
{
    //校验密码
    if (document.getElementById("txtPwd").value == "")
	{
	    document.getElementById("span_pwd").innerHTML = "密码不能为空，请输入。";
	    document.getElementById("tr_pwd").style.display = "";
		return false;
	}
	else
	{
	    if (Check(/^[0-9_a-zA-Z]{6,20}$/, document.getElementById("txtPwd").value) == false)
		{
		    document.getElementById("span_pwd").innerHTML = "密码格式不正确，请输入6-20位的英文字母、数字或下划线。";
		    document.getElementById("tr_pwd").style.display = "";
		    return false;
		}
		//不能与帐号重复
		if (document.getElementById("txtPwd").value.Trim() == document.getElementById("txtUserName").value.Trim())
		{
		    document.getElementById("span_pwd").innerHTML = "为增强密码保密性， 请不要与用户名重复。";
		    document.getElementById("tr_pwd").style.display = "";
		    return false;
		}
		//不是相同的数字
		var s = "012345678901234";
		for(var i=0;i<10;i++)
		{
		    if (document.getElementById("txtPwd").value.indexOf(s.substring(i, i + 5)) > 0)
		    {
		        document.getElementById("span_pwd").innerHTML = "为增强密码保密性，请不要含有连续的数字。";
		        document.getElementById("tr_pwd").style.display = "";
		        return false;
		    }
		}
		//不是重复数字或字母
		if (Check(/(\w)\1{2}/, document.getElementById("txtPwd").value) == true)
		{
		    document.getElementById("span_pwd").innerHTML = "为增强密码保密性，请不要某一数字或某一字母连续出现三次以上。";
		    document.getElementById("tr_pwd").style.display = "";
		    return false;
		}
	}
	document.getElementById("span_pwd").innerHTML = "";
	document.getElementById("tr_pwd").style.display = "none";
    return true;
}
function CheckConfirmPsd()
{
    if (document.getElementById("txtConfirmPwd").value == "")
	{
	    document.getElementById("span_comfirmpwd").innerHTML ="确认密码不能为空，请输入。";
	    document.getElementById("tr_comfirmpwd").style.display = "";
		return false;
	}
	else
	{
	    if (document.getElementById("txtPwd").value != document.getElementById("txtConfirmPwd").value)
		{
	        document.getElementById("span_comfirmpwd").innerHTML ="两次密码输入不一致，请重新输入。";
	        document.getElementById("tr_comfirmpwd").style.display = "";
		    return false;
		}
	}
	document.getElementById("span_comfirmpwd").innerHTML ="";
	document.getElementById("tr_comfirmpwd").style.display = "none";
    return true;
}

function checkphone() { 
    var filter = /^1[3|4|5|8][0-9]\d{8}$/;
if (document.getElementById("txtPhone").value == "")
	{
	    document.getElementById("span_phone").innerHTML ="手机号不能为空，请输入。";
	    document.getElementById("tr_phone").style.display = "";
		return false;
	}
	else {
    var mobile = document.getElementById("txtPhone").value;
	    if (!filter.test(mobile)) {
	        document.getElementById("span_phone").innerHTML ="手机号不合法，请重新输入。";
	        document.getElementById("tr_phone").style.display = "";
	        return false;
	    }
	}
	document.getElementById("span_phone").innerHTML ="";
	document.getElementById("tr_phone").style.display = "none";
    return true;
}

function checkDevAddr() {
    var filter = /(^0x|^0X)([0-9_a-zA-Z]){8}$/;
    if (document.getElementById("txtAddr").value == "") {
        document.getElementById("span_devAddr").innerHTML = "设备地址不能为空，请输入。";
        document.getElementById("tr_devAddr").style.display = "";
        return false;
    } else {
        var devAddr = document.getElementById("txtAddr").value;
        if (!filter.test(devAddr)) {
            document.getElementById("span_devAddr").innerHTML = "设备地址不合法，请重新输入。";
            document.getElementById("tr_devAddr").style.display = "";
            return false;
        }
    }
    document.getElementById("span_devAddr").innerHTML = "";
    document.getElementById("tr_devAddr").style.display = "none";
    return true;
}

function checkStatSel() {
    var selIndex = document.getElementById("ddlState").selectedIndex;
    if (selIndex < 0) {
        document.getElementById("span_StatId").innerHTML = "必须选择一个工地。";
        document.getElementById("tr_StatId").style.display = "";
        return false;
    }
    document.getElementById("span_StatId").innerHTML = "";
    document.getElementById("tr_StatId").style.display = "none";
    return true;
}

function checkDevCode() {
    var filter = /^[0-9_a-zA-Z\u4e00-\u9fa5]{0,20}$/;
    if (document.getElementById("txtNo").value == "") {
        document.getElementById("span_No").innerHTML = "设备编号不能为空，请输入。";
        document.getElementById("tr_No").style.display = "";
        return false;
    } else {
        var devNo = document.getElementById("txtNo").value;
        if (!filter.test(devNo)) {
            document.getElementById("span_No").innerHTML = "设备地址不合法，请重新输入。";
            document.getElementById("tr_No").style.display = "";
            return false;
        }
    }
    document.getElementById("span_No").innerHTML = "";
    document.getElementById("tr_No").style.display = "none";
    return true;
}

function checkPreEnd() {
    var inputtime = Date.parse(document.getElementById("txtPreEndTime").value);
    if (document.getElementById("txtPreEndTime").value == "") {
        document.getElementById("span_PreEndTime").innerHTML = "预计结束时间不能为空，请输入。";
        document.getElementById("tr_PreEndTime").style.display = "";
        return false;
    } else if (inputtime < Date.now()) {
        document.getElementById("span_PreEndTime").innerHTML = "预计结束时间不能早于当前时间，请重新输入。";
        document.getElementById("tr_PreEndTime").style.display = "";
        return false;
    }
    document.getElementById("span_PreEndTime").innerHTML = "";
    document.getElementById("tr_PreEndTime").style.display = "none";
    return true;
}

function checkRealEnd() {
    var inputtime = Date.parse(document.getElementById("txtRealEndTime").value);
    if (document.getElementById("txtRealEndTime").value == "") {
        document.getElementById("span_RealEndTime").innerHTML = "预计结束时间不能为空，请输入。";
        document.getElementById("tr_RealEndTime").style.display = "";
        return false;
    } else if (inputtime < Date.now()) {
        document.getElementById("span_RealEndTime").innerHTML = "预计结束时间不能早于当前时间，请重新输入。";
        document.getElementById("tr_RealEndTime").style.display = "";
        return false;
    }
    document.getElementById("span_RealEndTime").innerHTML = "";
    document.getElementById("tr_RealEndTime").style.display = "none";
    return true;
}

function checkStatCode() {
    var filter = /^[0-9_a-zA-Z]{0,20}$/;
    if (document.getElementById("txtStatNo").value == "") {
        document.getElementById("span_StatNo").innerHTML = "检测点编号不能为空，请输入。";
        document.getElementById("tr_StatNo").style.display = "";
        return false;
    } else {
        var statNo = document.getElementById("txtStatNo").value;
        if (!filter.test(statNo)) {
            document.getElementById("span_StatNo").innerHTML = "检测点编号不合法，请重新输入。";
            document.getElementById("tr_StatNo").style.display = "";
            return false;
        }
    }
    document.getElementById("span_StatNo").innerHTML = "";
    document.getElementById("tr_StatNo").style.display = "none";
    return true;
}

function checkStatName() {
    var filter = /^[0-9_a-zA-Z\u4e00-\u9fa5]{0,25}$/;
    if (document.getElementById("txtStatName").value == "") {
        document.getElementById("span_StatName").innerHTML = "检测点名称不能为空，请输入。";
        document.getElementById("tr_StatName").style.display = "";
        return false;
    } else {
        var devNo = document.getElementById("txtStatName").value;
        if (!filter.test(devNo)) {
            document.getElementById("span_StatName").innerHTML = "检测点名称不合法，请重新输入。";
            document.getElementById("tr_StatName").style.display = "";
            return false;
        }
    }
    document.getElementById("span_StatName").innerHTML = "";
    document.getElementById("tr_StatName").style.display = "none";
    return true;
}

function checkChargeMan() {
    var filter = /^[0-9_a-zA-Z\u4e00-\u9fa5]{0,10}$/;
    if (document.getElementById("txtChargeMan").value == "") {
        document.getElementById("span_ChargeMan").innerHTML = "负责人名字不能为空，请输入。";
        document.getElementById("tr_ChargeMan").style.display = "";
        return false;
    } else {
        var devNo = document.getElementById("txtChargeMan").value;
        if (!filter.test(devNo)) {
            document.getElementById("span_ChargeMan").innerHTML = "负责人名字不合法，请重新输入。";
            document.getElementById("tr_ChargeMan").style.display = "";
            return false;
        }
    }
    document.getElementById("span_ChargeMan").innerHTML = "";
    document.getElementById("tr_ChargeMan").style.display = "none";
    return true;
}

function checkDepart() {
    var filter = /^[0-9_a-zA-Z\u4e00-\u9fa5]{0,15}$/;
    if (document.getElementById("txtDept").value == "") {
        document.getElementById("span_Dept").innerHTML = "施工单位名字不能为空，请输入。";
        document.getElementById("tr_Dept").style.display = "";
        return false;
    } else {
        var devNo = document.getElementById("txtDept").value;
        if (!filter.test(devNo)) {
            document.getElementById("span_Dept").innerHTML = "施工单位名字不合法，请重新输入。";
            document.getElementById("tr_Dept").style.display = "";
            return false;
        }
    }
    document.getElementById("span_Dept").innerHTML = "";
    document.getElementById("tr_Dept").style.display = "none";
    return true;
}

function checkAddr() {
    var filter = /^[0-9_a-zA-Z\u4e00-\u9fa5]{0,25}$/;
    if (document.getElementById("txtAddr").value == "") {
        document.getElementById("span_Addr").innerHTML = "施工地址不能为空，请输入。";
        document.getElementById("tr_Addr").style.display = "";
        return false;
    } else {
        var devNo = document.getElementById("txtAddr").value;
        if (!filter.test(devNo)) {
            document.getElementById("span_Addr").innerHTML = "施工地址不合法，请重新输入。";
            document.getElementById("tr_Addr").style.display = "";
            return false;
        }
    }
    document.getElementById("span_Addr").innerHTML = "";
    document.getElementById("tr_Addr").style.display = "none";
    return true;
}

function checkStreet() {
    var filter = /^[0-9_a-zA-Z\u4e00-\u9fa5]{0,10}$/;
    if (document.getElementById("txtStreet").value == "") {
        document.getElementById("span_Street").innerHTML = "街道地址不能为空，请输入。";
        document.getElementById("tr_Street").style.display = "";
        return false;
    } else {
        var devNo = document.getElementById("txtStreet").value;
        if (!filter.test(devNo)) {
            document.getElementById("span_Street").innerHTML = "街道地址不合法，请重新输入。";
            document.getElementById("tr_Street").style.display = "";
            return false;
        }
    }
    document.getElementById("span_Street").innerHTML = "";
    document.getElementById("tr_Street").style.display = "none";
    return true;
}

function checkSquare() {
    var filter = /[^0-9]/;
    if (document.getElementById("txtSquare").value == "") {
        document.getElementById("span_Square").innerHTML = "占地面积不能为空，请输入。";
        document.getElementById("tr_Square").style.display = "";
        return false;
    } else {
        var devNo = document.getElementById("txtSquare").value;
        if (filter.test(devNo)) {
            document.getElementById("span_Square").innerHTML = "占地面积只能是数字，请重新输入。";
            document.getElementById("tr_Square").style.display = "";
            return false;
        }
    }
    document.getElementById("span_Square").innerHTML = "";
    document.getElementById("tr_Square").style.display = "none";
    return true;
}

function checkStartTime() {
    if (document.getElementById("txtStartTime").value == "") {
        document.getElementById("span_StartTime").innerHTML = "工程开始时间不能为空，请输入。";
        document.getElementById("tr_StartTime").style.display = "";
        return false;
    }
    document.getElementById("span_StartTime").innerHTML = "";
    document.getElementById("tr_StartTime").style.display = "none";
    return true;
}

function checkLocation() {
    if (document.getElementById("txtLocation").value == "") {
        document.getElementById("span_Location").innerHTML = "经纬度不能为空，请输入。";
        document.getElementById("tr_Location").style.display = "";
        return false;
    }
    document.getElementById("span_Location").innerHTML = "";
    document.getElementById("span_Location").style.display = "none";
    return true;
}

function checkDnsAddr() {
    var filter = /^[0-9_a-zA-Z]$/;
    if (document.getElementById("txtDnsAddr").value == "") {
        document.getElementById("span_DnsAddr").innerHTML = "DDNS地址不能为空，请输入。";
        document.getElementById("tr_DnsAddr").style.display = "";
        return false;
    }
    else {
        var dnsAddr = document.getElementById("txtDnsAddr").value;
        if ((filter.test(dnsAddr))) {
            document.getElementById("span_DnsAddr").innerHTML = "DDNS地址只能是英文或数字，请重新输入。";
            document.getElementById("tr_DnsAddr").style.display = "";
            return false;
        }
    }
    document.getElementById("span_DnsAddr").innerHTML = "";
    document.getElementById("tr_DnsAddr").style.display = "none";
    return true;
}

function checkUserName() {
    if (document.getElementById("txtUserName").value == "") {
        document.getElementById("span_UserName").innerHTML = "用户名不能为空，请输入。";
        document.getElementById("tr_UserName").style.display = "";
        return false;
    }
    document.getElementById("span_UserName").innerHTML = "";
    document.getElementById("tr_UserName").style.display = "none";
    return true;
}

function checkPassWord() {
    if (document.getElementById("txtPwd").value == "") {
        document.getElementById("span_Pwd").innerHTML = "用户名不能为空，请输入。";
        document.getElementById("tr_Pwd").style.display = "";
        return false;
    }
    document.getElementById("span_Pwd").innerHTML = "";
    document.getElementById("tr_Pwd").style.display = "none";
    return true;
}

function checkDevSel() {
    var selIndex = document.getElementById("ddlDev").selectedIndex;
    if (selIndex < 0) {
        document.getElementById("span_DevId").innerHTML = "必须选择一个监测点。";
        document.getElementById("tr_DevId").style.display = "";
        return false;
    }
    document.getElementById("span_DevId").innerHTML = "";
    document.getElementById("tr_DevId").style.display = "none";
    return true;
}

    function statSubmitCheck() {
        if (!checkStatCode()) return false;
        if (!checkStatName()) return false;
        if (!checkChargeMan()) return false;
        if (!checkphone()) return false;
        if (!checkDepart()) return false;
        if (!checkAddr()) return false;
        if (!checkStreet()) return false;
        if (!checkSquare()) return false;
        if (!checkStartTime()) return false;
        if (!checkLocation()) return false;
        return true;
    }

    function userSubmitCheck() {
        if (!startRequest()) return false;
        if (!CheckPsd()) return false;
        if (!CheckConfirmPsd()) return false;
        if (!checkemail()) return false;
        if (!checkphone()) return false;
        return true;
    }

    function devSubmitCheck() {
        if (!checkDevCode()) return false;
        if (!checkStatSel()) return false;
        if (!checkStartTime()) return false;
        if (!checkPreEnd()) return false;
        if (!checkRealEnd()) return false;
        if (!checkDevAddr()) return false;
        return true;
    }

    function cgeSubmitCheck() {
        if (!ChangeCheckPsd()) return false;
        if (!CheckConfirmPsd()) return false;
        return true;
    }

    function CameraSubmitCheck() {
        if (!checkDnsAddr()) return false;
        if (!checkPassWord()) return false;
        if (!checkDevSel()) return false;
        return true;
    }