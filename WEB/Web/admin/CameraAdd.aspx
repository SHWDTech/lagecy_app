<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CameraAdd.aspx.cs" Inherits="Web.admin.CameraAdd" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>无标题文档</title>
    <link rel="stylesheet" type="text/css" href="/css/right.css" />
    <script type="text/javascript" src="/My97DatePicker/WdatePicker.js"></script>
    <script src="/js/RegisterJS.js?version=2015030202" type="text/javascript"></script>
    <link type="text/css" rel="stylesheet" href="/css/register.css" />
    <script type="text/javascript" src="/js/jquery-1.js"></script>
    <style type="text/css">
        select {
            height: 22px;
            line-height: 22px;
            text-align: center;
        }
    </style>
    <script type="text/javascript">
        function OnSubmit() {
            if (CameraSubmitCheck()) {
                document.getElementById("form1").submit();
            }
        };
    </script>
</head>
<body>
    <form id="form1" runat="server">
        <table width="100%" cellspacing="0" cellpadding="0" border="0">
            <tr>
                <td style="font-weight: bold; background-image: url('data:image/jpeg;base64,/9j/4AAQSkZJRgABAQEASABIAAD/2wBDAAICAgICAgICAgICAgICAwQDAgIDBAUEBAQEBAUGBQUFBQUFBgYHBwgHBwYJCQoKCQkMDAwMDAwMDAwMDAwMDAz/2wBDAQMDAwUEBQkGBgkNCwkLDQ8ODg4ODw8MDAwMDAwMDAwMDAwMDAwMDAwMDAwMDAwMDAwMDAwMDAwMDAwMDAwMDAz/wAARCAAcAAEDAREAAhEBAxEB/8QAFgABAQEAAAAAAAAAAAAAAAAAAwYJ/8QAHBAAAgICAwAAAAAAAAAAAAAAAAMBExRRUlOS/8QAFgEBAQEAAAAAAAAAAAAAAAAAAQQD/8QAFxEBAQEBAAAAAAAAAAAAAAAAABESAf/aAAwDAQACEQMRAD8A3Vvf3N9SU54zohA7F8oGCpLJbsuyg31//9k=') /*/images/title_bg.jpg*/; height: 28px">
                    <img alt="" src="/images/go.gif" />当前位置： <span style="font-weight: normal">[ 新增摄像头 ] </span></td>
            </tr>
            <tr>
                <td bgcolor="#b1ceef" height="1px"></td>
            </tr>
        </table>
        <div>
            <table width="100%" border="0" cellpadding="1" cellspacing="1">
                <tr>
                    <td class="STYLE19" width="100px">DDNS地址：</td>
                    <td>
                        <asp:TextBox ID="txtDnsAddr" runat="server" onblur="this.className='frame';checkDnsAddr();" onfocus="this.className='frameB'"></asp:TextBox>
                        <span style="color: Red">(*)</span> <span>必须为20个字符以内的汉字、英文或数字。</span>
                    </td>
                </tr>
                <tr id="tr_DnsAddr" style="position: relative; display: none">
                    <td class="STYLE19"></td>
                    <td id="span_DnsAddr" style="color: red"></td>
                </tr>
                <tr>
                    <td class="STYLE19" width="100px">登录用户名：</td>
                    <td>
                        <asp:TextBox ID="txtUserName" runat="server" onblur="this.className='frame';checkUserName();" onfocus="this.className='frameB'"></asp:TextBox>
                        <span style="color:Red">(*)</span>
                    </td>
                </tr>
                <tr id="tr_UserName" style="position: relative; display: none;">
                    <td class="STYLE19"></td>
                    <td id="span_UserName" style="color:Red;"></td>
                </tr>
                <tr>
                    <td class="STYLE19" width="100px">登录密码：</td>
                    <td>
                        <asp:TextBox ID="txtPwd" runat="server" onblur="this.className='frame';checkPassWord();" onfocus="this.className='frameB'"></asp:TextBox>
                        <span style="color:Red">(*)</span>
                    </td>
                </tr>
                <tr id="tr_Pwd" style="position: relative; display: none;">
                    <td class="STYLE19"></td>
                    <td id="span_Pwd" style="color:Red;"></td>
                </tr>
                <tr>
                    <td class="STYLE19">绑定设备：</td>
                    <td>
                        <asp:DropDownList ID="ddlState" runat="server" OnSelectedIndexChanged="GetDevs" AutoPostBack="True"></asp:DropDownList>
                        <asp:DropDownList ID="ddlDev" runat="server" onblur="this.className='frame';checkDevSel();" onfocus="this.className='frameB'"></asp:DropDownList>
                        <span style="color: Red">(*)</span> <span>必须选择一个监测设备。</span>
                    </td>
                </tr>
                <tr id="tr_DevId" style="position: relative; display: none">
                    <td class="STYLE19"></td>
                    <td id="span_DevId" style="color: red"></td>
                </tr>
                <tr style="height:32px;">
                    <td class="STYLE19"></td>
                    <td>
                        <input type="button" value="提交" style="padding: 5px; margin-right: 45px" onclick="OnSubmit()" />
                        <input type="button" value="重置" style="padding: 5px; margin-left: 45px" onclick="reset();" />
                    </td>
                </tr>
            </table>

        </div>
    </form>
</body>
</html>
