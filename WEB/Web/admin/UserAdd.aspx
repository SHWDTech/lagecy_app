<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="UserAdd.aspx.cs" Inherits="Web.admin.UserAdd" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>无标题文档</title>
    <link rel="stylesheet" type="text/css" href="/css/right.css" />
    <script type="text/javascript" src="/My97DatePicker/WdatePicker.js"></script>
    <script src="/js/RegisterJS.js?version=20150302" type="text/javascript"></script>
    <link type="text/css" rel="stylesheet" href="/css/register.css" />
    <style type="text/css">
        select {
            height: 22px;
            line-height: 22px;
            text-align: center;
        }
    </style>
    <script type="text/javascript">
        function OnSubmit() {
            if (userSubmitCheck()) {
                document.getElementById("form1").submit();
            }
        }
    </script>
</head>
<body>
    <form id="form1" runat="server">
        <table width="100%" cellspacing="0" cellpadding="0" border="0">
            <tr>
                <td style="font-weight: bold; background-image: url(/images/title_bg.jpg); height: 28px">
                    <img src="/images/go.gif" />当前位置： <span style="font-weight: normal">[ 添加用户 ] </span></td>
            </tr>
            <tr>
                <td bgcolor="#b1ceef" height="1px"></td>
            </tr>
        </table>
        <div>
            <table width="100%" border="0" cellpadding="1" cellspacing="1">
                <tr>
                    <td class="STYLE19" width="64px">用户名：</td>
                    <td>
                        <asp:TextBox ID="txtUserName" runat="server" onblur="this.className='frame';startRequest();" onfocus="this.className='frameB'"></asp:TextBox>
                        <span style="color: Red">(*)</span><span>请使用4-20位英文字母+数字组合</span>
                    </td>
                </tr>
                <tr id="tr_username" style="position: relative; display: none">
                    <td class="STYLE19"></td>
                    <td id="span_username" style="color: red"></td>
                </tr>
                <tr>
                    <td class="STYLE19">密码：</td>
                    <td>
                        <asp:TextBox ID="txtPwd" runat="server" onblur="this.className='frame';CheckPsd();" onfocus="this.className='frameB'"></asp:TextBox>
                        <span style="color: Red">(*)</span><span>为提高安全性，请选用6位及以上字符。</span>
                    </td>
                </tr>
                <tr id="tr_pwd" style="position: relative; display: none">
                    <td class="STYLE19"></td>
                    <td id="span_pwd" style="color: red"></td>
                </tr>
                <tr>
                    <td class="STYLE19">确认密码：</td>
                    <td>
                        <asp:TextBox ID="txtConfirmPwd" runat="server" onblur="this.className='frame';CheckConfirmPsd();" onfocus="this.className='frameB'"></asp:TextBox>
                        <span style="color: Red">(*)</span>
                    </td>
                </tr>
                <tr id="tr_comfirmpwd" style="position: relative; display: none">
                    <td class="STYLE19"></td>
                    <td id="span_comfirmpwd" style="color: red"></td>
                </tr>
                <tr>
                    <td class="STYLE19">邮箱：</td>
                    <td>
                        <asp:TextBox ID="txtEmail" runat="server" onblur="this.className='frame';checkemail();" onfocus="this.className='frameB'"></asp:TextBox>
                        <span style="color: Red">(*)</span><span>用于密码找回，请填写真实邮箱</span>
                    </td>
                </tr>
                <tr id="tr_email" style="position: relative; display: none">
                    <td class="STYLE19"></td>
                    <td id="span_email" style="color: red"></td>
                </tr>
                <tr>
                    <td class="STYLE19">电话：</td>
                    <td>
                        <asp:TextBox ID="txtPhone" runat="server" onblur="this.className='frame';checkphone();" onfocus="this.className='frameB'"></asp:TextBox>
                        <span style="color: Red">(*)</span><span>11位手机号码</span>
                    </td>
                </tr>
                <tr id="tr_phone" style="position: relative; display: none">
                    <td class="STYLE19"></td>
                    <td id="span_phone" style="color: red"></td>
                </tr>
                <tr>
                    <td class="STYLE19">区县：</td>
                    <td>
                        <asp:DropDownList ID="textRemark" runat="server"></asp:DropDownList>
                    </td>
                </tr>
                <tr>
                    <td class="STYLE19">角色：</td>
                    <td>
                        <asp:RadioButton ID="rbtn1" runat="server" Checked="True" GroupName="Role" Text="管理员" />
                        &nbsp;&nbsp;&nbsp;<asp:RadioButton ID="rbtn2" runat="server" GroupName="Role" Text="超级管理员" />
                    </td>
                </tr>
                <tr>
                    <td class="STYLE19"></td>
                    <td>
                        <input type="button" value="新增" onclick="OnSubmit()" style="padding: 5px; margin-right: 45px"/>
                        <input type="button" value="重置" style="padding: 5px; margin-left: 45px" onclick="reset();" />
                    </td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>



