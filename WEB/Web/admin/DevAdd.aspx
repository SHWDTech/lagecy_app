<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DevAdd.aspx.cs" Inherits="Web.admin.DevAdd" %>

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
            if (devSubmitCheck()) {
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
                    <img alt="" src="/images/go.gif" />当前位置： <span style="font-weight: normal">[ 新增设备 ] </span></td>
            </tr>
            <tr>
                <td bgcolor="#b1ceef" height="1px"></td>
            </tr>
        </table>
        <div>
            <table width="100%" border="0" cellpadding="1" cellspacing="1">
                <tr>
                    <td class="STYLE19" width="100px">设备编号：</td>
                    <td>
                        <asp:TextBox ID="txtNo" runat="server" onblur="this.className='frame';checkDevCode();" onfocus="this.className='frameB'"></asp:TextBox>
                        <span style="color: Red">(*)</span> <span>必须为20个字符以内的汉字、英文或数字。</span>
                    </td>
                </tr>
                <tr id="tr_No" style="position: relative; display: none">
                    <td class="STYLE19"></td>
                    <td id="span_No" style="color: red"></td>
                </tr>
                <tr>
                    <td class="STYLE19">检测点编号：</td>
                    <td>
                        <asp:DropDownList ID="ddlCountry" runat="server" OnSelectedIndexChanged="GetStat" AutoPostBack="True"></asp:DropDownList>
                        <asp:DropDownList ID="ddlState" runat="server" onblur="this.className='frame';checkStatSel();" onfocus="this.className='frameB'"></asp:DropDownList>
                        <span style="color: Red">(*)</span> <span>必须选择一个监测点。</span>
                    </td>
                </tr>
                <tr id="tr_StatId" style="position: relative; display: none">
                    <td class="STYLE19"></td>
                    <td id="span_StatId" style="color: red"></td>
                </tr>
                <tr>
                    <td class="STYLE19">安装时间：</td>
                    <td>
                        <asp:TextBox ID="txtStartTime" runat="server" onclick="WdatePicker({dateFmt:'yyyy-MM-dd'})" CssClass="Wdate" onblur="this.className='frame';checkStartTime();" onfocus="this.className='frameB'"></asp:TextBox>
                        <span style="color: Red">(*)</span>
                    </td>
                </tr>
                <tr id="tr_StartTime" style="position: relative; display: none">
                    <td class="STYLE19"></td>
                    <td id="span_StartTime" style="color: red"></td>
                </tr>
                <tr>
                    <td class="STYLE19">预计结束时间：</td>
                    <td>
                        <asp:TextBox ID="txtPreEndTime" runat="server" onclick="WdatePicker({dateFmt:'yyyy-MM-dd'})" CssClass="Wdate" onblur="this.className='frame';checkPreEnd();" onfocus="this.className='frameB'"></asp:TextBox>
                        <span style="color: Red">(*)</span>
                    </td>
                </tr>
                <tr id="tr_PreEndTime" style="position: relative; display: none">
                    <td class="STYLE19"></td>
                    <td id="span_PreEndTime" style="color: red"></td>
                </tr>
                <tr>
                    <td class="STYLE19">实际结束时间：</td>
                    <td>
                        <asp:TextBox ID="txtRealEndTime" runat="server" onclick="WdatePicker({dateFmt:'yyyy-MM-dd'})" CssClass="Wdate" onblur="this.className='frame';checkRealEnd();" onfocus="this.className='frameB'"></asp:TextBox>
                        <span style="color: Red">(*)</span>
                    </td>
                </tr>
                <tr id="tr_RealEndTime" style="position: relative; display: none">
                    <td class="STYLE19"></td>
                    <td id="span_RealEndTime" style="color: red"></td>
                </tr>
                <tr>
                    <td class="STYLE19">设备启动：</td>
                    <td>
                        <asp:RadioButton ID="rbtn1" runat="server" Text="是" Checked="True" GroupName="DevStatus" />
                        <asp:RadioButton ID="rbtn2" runat="server" Text="否" GroupName="DevStatus" /></td>
                </tr>
                <tr>
                    <td class="STYLE19">视频地址：</td>
                    <td>
                        <asp:TextBox ID="txtVideoURL" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                    <td class="STYLE19">地址码：</td>
                    <td>
                        <asp:TextBox ID="txtAddr" runat="server" onblur="this.className='frame';checkDevAddr();" onfocus="this.className='frameB'"></asp:TextBox>
                        <span style="color: Red">(*)</span> <span>16进制数据,格式为：（0x00000001)。</span></td>
                </tr>
                <tr id="tr_devAddr" style="position: relative; display: none">
                    <td class="STYLE19"></td>
                    <td id="span_devAddr" style="color: red"></td>
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
