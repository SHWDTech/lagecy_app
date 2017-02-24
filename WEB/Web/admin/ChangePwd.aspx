<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ChangePwd.aspx.cs" Inherits="Web.admin.ChangePwd" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>无标题文档</title>
    <link rel="stylesheet" type="text/css" href="/css/right.css" />
    <script type="text/javascript" src="/My97DatePicker/WdatePicker.js"></script>
    <link type="text/css" rel="stylesheet" href="/css/register.css" />
    <script src="/js/RegisterJS.js?var=2015030201" type="text/javascript"></script>
    <style type="text/css">
        select {
            height: 22px;
            line-height: 22px;
            text-align: center;
        }
    </style>
    <script type="text/javascript">
        function OnSubmit() {
            if (cgeSubmitCheck()) {
                document.getElementById("form1").submit();
            }
        };
    </script>
</head>
<body>
    <form id="form1" runat="server">
        <table width="100%" cellspacing="0" cellpadding="0" border="0">
            <tr>
                <td style="font-weight: bold; background-image: url(/images/title_bg.jpg); height: 28px">
                    <img src="/images/go.gif" />当前位置： <span style="font-weight: normal">[ 修改口令 ] </span></td>
            </tr>
            <tr>
                <td bgcolor="#b1ceef" height="1px"></td>
            </tr>
        </table>
        <div>
            <table width="100%" border="0" cellpadding="1" cellspacing="1">
                <tr>
                    <td class="STYLE19" width="100px">选择用户：</td>
                    <td>
                        <asp:DropDownList ID="Users" runat="server"></asp:DropDownList></td>
                </tr>
                <tr>
                    <td class="STYLE19" width="100px">当前密码：</td>
                    <td>
                        <asp:TextBox ID="txtCurPwd" runat="server" TextMode="Password"></asp:TextBox>
                        <span><font color="red">(*)</font>输入当前用户密码。</span>
                    </td>
                </tr>
                <tr>
                    <td class="STYLE19" width="100px">输入新密码：</td>
                    <td>
                        <asp:TextBox ID="txtPwd" runat="server" onblur="this.className='frame';ChangeCheckPsd();" onfocus="this.className='frameB'" TextMode="Password"></asp:TextBox>
                        <span><font color="red">(*)</font>为提高安全性，请选用6位及以上字符。</span>
                    </td>
                </tr>
                <tr id="tr_pwd" style="position: relative; display: none">
                    <td class="STYLE19"></td>
                    <td id="span_pwd" style="color: red"></td>
                </tr>
                <tr>
                    <td class="STYLE19">确认密码：</td>
                    <td>
                        <asp:TextBox ID="txtConfirmPwd" runat="server" onblur="this.className='frame';CheckConfirmPsd();" onfocus="this.className='frameB'" TextMode="Password"></asp:TextBox>
                        <span><font color="red">(*)</font></span>
                    </td>
                </tr>
                <tr id="tr_comfirmpwd" style="position: relative; display: none">
                    <td class="STYLE19"></td>
                    <td id="span_comfirmpwd" style="color: red"></td>
                </tr>
                <tr height="32px">
                    <td class="STYLE19"></td>
                    <td>
                        <input type="button" value="提交" onclick="OnSubmit()" style="padding: 5px; margin-right: 15px" />
                        <input type="button" value="重置" style="padding: 5px; margin-left: 15px" onclick="reset();" /></td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
