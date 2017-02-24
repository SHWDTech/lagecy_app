<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="StatAdd.aspx.cs" Inherits="Web.admin.StatAdd" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>无标题文档</title>
    <link rel="stylesheet" type="text/css" href="/css/right.css" />
    <meta http-equiv="Content-Type" content="text/html; charset=gb2312" />
    <script type="text/javascript" src="/My97DatePicker/WdatePicker.js"></script>
    <meta name="viewport" content="initial-scale=1.0, user-scalable=no" />
    <script type="text/javascript" src="http://api.map.baidu.com/api?v=1.4"></script>
    <link type="text/css" rel="stylesheet" href="/css/register.css" />
    <script src="/js/RegisterJS.js?version=20150302" type="text/javascript"></script>
    <script type="text/javascript" src="/js/jquery-1.js"></script>
    <style type="text/css">
        #container {
            width: 100%;
            height: 400px;
        }

        select {
            height: 22px;
            line-height: 22px;
            text-align: center;
        }
    </style>
    <script type="text/javascript">
        function OnSubmit() {
            if (statSubmitCheck()) {
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
                    <img src="/images/go.gif" />当前位置： <span style="font-weight: normal">[ 新增检测点 ] </span></td>
            </tr>
            <tr>
                <td bgcolor="#b1ceef" height="1px"></td>
            </tr>
        </table>
        <div>
            <div style="float: left; width: 550px">
                <table width="100%" border="0" cellpadding="1" cellspacing="1">
                    <tr>
                        <td class="STYLE19" width="100px">检测点编号：</td>
                        <td>
                            <asp:TextBox ID="txtStatNo" runat="server" onblur="this.className='frame';checkStatCode();" onfocus="this.className='frameB'"></asp:TextBox>
                            <span style="color: Red">(*)</span> <span>必须为20个字符以内的英文或数字。</span>
                        </td>
                    </tr>
                    <tr id="tr_StatNo" style="position: relative; display: none">
                        <td class="STYLE19"></td>
                        <td id="span_StatNo" style="color: red"></td>
                    </tr>
                    <tr>
                        <td class="STYLE19">检测点名称：</td>
                        <td>
                            <asp:TextBox ID="txtStatName" runat="server" onblur="this.className='frame';checkStatName();" onfocus="this.className='frameB'"></asp:TextBox>
                            <span style="color: Red">(*)</span> <span>必须为25个字符以内的中文、英文或数字。</span>
                        </td>
                    </tr>
                    <tr id="tr_StatName" style="position: relative; display: none">
                        <td class="STYLE19"></td>
                        <td id="span_StatName" style="color: red"></td>
                    </tr>
                    <tr>
                        <td class="STYLE19">工地负责人：</td>
                        <td>
                            <asp:TextBox ID="txtChargeMan" runat="server" onblur="this.className='frame';checkChargeMan();" onfocus="this.className='frameB'"></asp:TextBox>
                            <span style="color: Red">(*)</span> <span>必须为10个字符以内的中文、英文或数字。</span>
                        </td>
                    </tr>
                    <tr id="tr_ChargeMan" style="position: relative; display: none">
                        <td class="STYLE19"></td>
                        <td id="span_ChargeMan" style="color: red"></td>
                    </tr>
                    <tr>
                        <td class="STYLE19">联系电话：</td>
                        <td>
                            <asp:TextBox ID="txtPhone" runat="server" onblur="this.className='frame';checkphone();" onfocus="this.className='frameB'"></asp:TextBox>
                            <span style="color: Red">(*)</span> <span>11位手机号码。</span>
                        </td>
                    </tr>
                    <tr id="tr_phone" style="position: relative; display: none">
                        <td class="STYLE19"></td>
                        <td id="span_phone" style="color: red"></td>
                    </tr>
                    <tr>
                        <td class="STYLE19">施工单位：</td>
                        <td>
                            <asp:TextBox ID="txtDept" runat="server" onblur="this.className='frame';checkDepart();" onfocus="this.className='frameB'"></asp:TextBox>
                            <span style="color: Red">(*)</span> <span>必须为15个字符以内的中文、英文或数字。</span>
                        </td>
                    </tr>
                    <tr id="tr_Dept" style="position: relative; display: none">
                        <td class="STYLE19"></td>
                        <td id="span_Dept" style="color: red"></td>
                    </tr>
                    <tr>
                        <td class="STYLE19">施工地址：</td>
                        <td>
                            <asp:TextBox ID="txtAddr" runat="server" onblur="this.className='frame';checkAddr();" onfocus="this.className='frameB'"></asp:TextBox>
                            <span style="color: Red">(*)</span> <span>必须为25个字符以内的中文、英文或数字。</span>
                        </td>
                    </tr>
                    <tr id="tr_Addr" style="position: relative; display: none">
                        <td class="STYLE19"></td>
                        <td id="span_Addr" style="color: red"></td>
                    </tr>
                    <tr>
                        <td class="STYLE19">所属区县：</td>
                        <td>
                            <asp:DropDownList ID="ddlCountry" runat="server">
                            </asp:DropDownList>
                            <span style="color: Red">(*)</span>
                        </td>
                    </tr>
                    <tr>
                        <td class="STYLE19">所属街道：</td>
                        <td>
                            <asp:TextBox ID="txtStreet" runat="server" onblur="this.className='frame';checkStreet();" onfocus="this.className='frameB'"></asp:TextBox>
                            <span style="color: Red">(*)</span> <span>必须为10个字符以内的中文、英文或数字。</span>
                        </td>
                    </tr>
                    <tr id="tr_Street" style="position: relative; display: none">
                        <td class="STYLE19"></td>
                        <td id="span_Street" style="color: red"></td>
                    </tr>
                    <tr>
                        <td class="STYLE19">占地面积：</td>
                        <td>
                            <asp:TextBox ID="txtSquare" runat="server" onblur="this.className='frame';checkSquare();" onfocus="this.className='frameB'"></asp:TextBox>
                            <span style="color: Red">(*)</span>
                        </td>
                    </tr>
                    <tr id="tr_Square" style="position: relative; display: none">
                        <td class="STYLE19"></td>
                        <td id="span_Square" style="color: red"></td>
                    </tr>
                    <tr>
                        <td class="STYLE19">工程开始时间：</td>
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
                        <td class="STYLE19">施工进展：</td>
                        <td>
                            <asp:DropDownList ID="ddlStage" runat="server">
                                <asp:ListItem Value="0">基础</asp:ListItem>
                                <asp:ListItem Value="1">结构</asp:ListItem>
                                <asp:ListItem Value="2">完工</asp:ListItem>
                            </asp:DropDownList>
                            <span style="color: Red">(*)</span>
                        </td>
                    </tr>
                    <tr>
                        <td class="STYLE19">经纬度：</td>
                        <td>
                            <asp:TextBox ID="txtLocation" runat="server" onblur="this.className='frame';checkLocation();" onfocus="this.className='frameB'"></asp:TextBox>
                            <span style="color: Red">(*)</span><span>值用;号隔开，可在右方地图上直接点击设置。</span></td>
                    </tr>
                    <tr id="tr_Location" style="position: relative; display: none">
                        <td class="STYLE19"></td>
                        <td id="span_Location" style="color: red"></td>
                    </tr>
                    <tr>
                        <td class="STYLE19">施工进展：</td>
                        <td>
                            <asp:DropDownList ID="ddlAlarmType" runat="server"></asp:DropDownList>
                        </td>
                    </tr>
                    <tr>
                        <td class="STYLE19"></td>
                        <td>
                            <input type="button" style="padding: 5px; margin-right: 20px" value="提交" onclick="OnSubmit()" />
                            <input type="button" style="padding: 5px; margin-left: 20px" value="重置" /></td>
                    </tr>
                </table>
            </div>
            <div style="float: left; margin-left: 10px; width: 500px">
                <div id="container"></div>
            </div>
        </div>
    </form>
</body>
<script type="text/javascript">
    var map = new BMap.Map("container");
    map.centerAndZoom("上海", 9);
    map.addControl(new BMap.NavigationControl({ anchor: BMAP_ANCHOR_TOP_RIGHT }));  //右上角，仅包含平移和缩放按钮
    map.enableScrollWheelZoom();    //启用滚轮放大缩小，默认禁用
    map.enableContinuousZoom();    //启用地图惯性拖拽，默认禁用
    map.addEventListener("click", function (e) {
        this.clearOverlays();
        this.closeInfoWindow();
        var marker = new BMap.Marker(e.point);        // 创建标注
        this.addOverlay(marker);                     // 将标注添加到地图中
        document.getElementById("txtLocation").value = e.point.lng.toString() + ";" + e.point.lat.toString();
    });

</script>
</html>
