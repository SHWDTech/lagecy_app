<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="StatEdit.aspx.cs" Inherits="Web.admin.StatEdit" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>无标题文档</title>
    <link rel="stylesheet" type="text/css" href="/css/right.css" />
    <meta http-equiv="Content-Type" content="text/html; charset=gb2312" />
    <script type="text/javascript" src="/My97DatePicker/WdatePicker.js"></script>
    <meta name="viewport" content="initial-scale=1.0, user-scalable=no" />
    <script type="text/javascript" src="/js/jquery-1.js"></script>
    <script type="text/javascript" src="http://api.map.baidu.com/api?v=1.4"></script>
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
        var TaskId;
        var maxtimeoutTimes;
        var timeID;
        var Result;
        function RequestCmd(cmdtype, cmdbyte, params, callback) {
            var dev = $('#ddlDevs').val();
            $.get("/action/Cmd.ashx", { action: 1, cmdType: cmdtype, cmdByte: cmdbyte, cmdParam: params, dev: dev, _t: new Date().getTime() }, function (data) {
                var json = eval("(" + data + ")");
                if (json.success) {
                    TaskId = json.data[0].task;
                    callback(true);
                } else {
                    callback(false);
                }
            });
        };

        function StartRequset(cmdtype, cmdbyte, params) {
            RequestCmd(cmdtype, cmdbyte, params, function (addcmd) {
                if (addcmd) {
                    maxtimeoutTimes = 0;
                    chackResponse();
                    $("#gpsResult").empty();
                    $("#gpsResult").append("正在校正经纬度，请耐心等待！");
                }
            });

        };

        function chackResponse() {
            ResponseCmd(TaskId, function (getcmd) {
                if (getcmd) {
                    UpdateData(Result);
                } else {
                    if (maxtimeoutTimes < 20)
                        timeID = setTimeout(function () { chackResponse(); }, 3000);
                }

            });
            maxtimeoutTimes++;
        };

        function ResponseCmd(taskId, callback) {
            $.get("/action/Cmd.ashx", { action: 2, task: taskId, _t: new Date().getTime() }, function (data) {
                var json = eval("(" + data + ")");
                if (json.success) {
                    Result = json.data[0];
                    callback(true);
                }
                else {
                    callback(false);
                }
            });
        };

        function UpdateData(obj) {
            if (obj.coordinate === "null") {
                $("#gpsResult").empty();
                $("#gpsResult").append("获取GPS信息失败，请重试！");
                return;
            }
            $("#txtLocation").val(obj.coordinate);
            $("#gpsResult").empty();
            $("#gpsResult").append("经纬度校正成功！");
        }
    </script>
</head>
<body>
    <form id="form1" runat="server">
        <table style="border: 0; padding: 0; border-spacing: 0; width: 100%;">
            <tr>
                <td style="font-weight: bold; background-image: url('data:image/jpeg;base64,/9j/4AAQSkZJRgABAQEASABIAAD/2wBDAAICAgICAgICAgICAgICAwQDAgIDBAUEBAQEBAUGBQUFBQUFBgYHBwgHBwYJCQoKCQkMDAwMDAwMDAwMDAwMDAz/2wBDAQMDAwUEBQkGBgkNCwkLDQ8ODg4ODw8MDAwMDAwMDAwMDAwMDAwMDAwMDAwMDAwMDAwMDAwMDAwMDAwMDAwMDAz/wAARCAAcAAEDAREAAhEBAxEB/8QAFgABAQEAAAAAAAAAAAAAAAAAAwYJ/8QAHBAAAgICAwAAAAAAAAAAAAAAAAMBExRRUlOS/8QAFgEBAQEAAAAAAAAAAAAAAAAAAQQD/8QAFxEBAQEBAAAAAAAAAAAAAAAAABESAf/aAAwDAQACEQMRAD8A3Vvf3N9SU54zohA7F8oGCpLJbsuyg31//9k=') /*/images/title_bg.jpg*/; height: 28px">
                    <img alt="" src="/images/go.gif" />当前位置： <span style="font-weight: normal">[ 编辑检测点 ] </span></td>
            </tr>
            <tr>
                <td style="background-color: #b1ceef; height: 1px;"></td>
            </tr>
        </table>
        <div>
            <div style="float: left; width: 350px">
                <table style="border: 0; padding: 0; border-spacing: 0;">
                    <tr>
                        <td class="STYLE19" width="72px">检测点编号：</td>
                        <td>
                            <asp:TextBox ID="txtNo" runat="server"></asp:TextBox></td>
                    </tr>
                    <tr>
                        <td class="STYLE19">检测点名称：</td>
                        <td>
                            <asp:TextBox ID="txtName" runat="server" ReadOnly="true"></asp:TextBox></td>
                    </tr>
                    <tr>
                        <td class="STYLE19">工地负责人：</td>
                        <td>
                            <asp:TextBox ID="txtChargeMan" runat="server"></asp:TextBox></td>
                    </tr>
                    <tr>
                        <td class="STYLE19">联系电话：</td>
                        <td>
                            <asp:TextBox ID="txtMobile" runat="server"></asp:TextBox></td>
                    </tr>
                    <tr>
                        <td class="STYLE19">施工单位：</td>
                        <td>
                            <asp:TextBox ID="txtDept" runat="server"></asp:TextBox></td>
                    </tr>
                    <tr>
                        <td class="STYLE19">施工地址：</td>
                        <td>
                            <asp:TextBox ID="txtAddr" runat="server"></asp:TextBox></td>
                    </tr>
                    <tr>
                        <td class="STYLE19">所属区县：</td>
                        <td>
                            <asp:DropDownList ID="ddlCountry" runat="server">
                            </asp:DropDownList>
                        </td>
                    </tr>
                    <tr>
                        <td class="STYLE19">所属街镇：</td>
                        <td>
                            <asp:TextBox ID="txtStreet" runat="server"></asp:TextBox></td>
                    </tr>
                    <tr>
                        <td class="STYLE19">占地面积：</td>
                        <td>
                            <asp:TextBox ID="txtSquare" runat="server"></asp:TextBox></td>
                    </tr>
                    <tr>
                        <td class="STYLE19">工程开始时间：</td>
                        <td>
                            <asp:TextBox ID="txtStartTime" runat="server" onclick="WdatePicker({dateFmt:'yyyy-MM-dd'})" CssClass="Wdate"></asp:TextBox></td>
                    </tr>
                    <tr>
                        <td class="STYLE19">施工进展：</td>
                        <td>
                            <asp:DropDownList ID="ddlStage" runat="server">
                                <asp:ListItem Value="0">基础</asp:ListItem>
                                <asp:ListItem Value="1">结构</asp:ListItem>
                                <asp:ListItem Value="2">完工</asp:ListItem>
                            </asp:DropDownList></td>
                    </tr>
                    <tr>
                        <td class="STYLE19">经纬度：</td>
                        <td>
                            <asp:TextBox ID="txtLocation" runat="server"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td class="STYLE19"></td>
                        <td>
                            <asp:DropDownList ID="ddlDevs" runat="server">
                            </asp:DropDownList>
                            <span id="gpsResult" style="color: red"></span>
                        </td>
                    </tr>
                    <tr>
                        <td class="STYLE19">报警类型：</td>
                        <td>
                            <asp:DropDownList ID="ddlAlarmType" runat="server">
                            </asp:DropDownList></td>
                    </tr>
                    <tr style="height: 32px;">
                        <td class="STYLE19">
                            <asp:Button ID="btnSubmit" runat="server" Text="提交" Style="padding: 5px" CssClass="button" OnClick="OnSubmit" />
                        </td>
                        <td>
                            <input id="btnReset" type="button" value="重置" style="padding: 5px; margin-left: 30px;" onclick="reset();" />
                            <input id="btnGetGps" type="button" value="获取经纬度" style="padding: 5px; margin-left: 30px;" onclick="StartRequset(251, 47, '')" />
                        </td>
                    </tr>
                </table>
                <asp:HiddenField ID="HiddenId" runat="server" />
            </div>
            <div style="float: left; margin-left: 10px; width: 800px">
                <div id="container"></div>
            </div>
        </div>
    </form>
</body>
<script type="text/javascript">
    var map = new BMap.Map("container");
    var str = document.getElementById("txtLocation").value.split(';');
    var point = new BMap.Point(Number(str[0]), Number(str[1]));
    map.centerAndZoom(point, 20);
    var marker = new BMap.Marker(point);
    map.addOverlay(marker);
    //map.addControl(new BMap.NavigationControl({ anchor: BMAP_ANCHOR_TOP_RIGHT }));  //右上角，仅包含平移和缩放按钮
    map.enableScrollWheelZoom();    //启用滚轮放大缩小，默认禁用
    map.enableContinuousZoom();    //启用地图惯性拖拽，默认禁用
    map.addEventListener("click", function (e) {
        this.clearOverlays();
        this.closeInfoWindow();
        var marker = new window.BMap.Marker(e.point);        // 创建标注
        this.addOverlay(marker);                     // 将标注添加到地图中
        document.getElementById("txtLocation").value = e.point.lng.toString() + ";" + e.point.lat.toString();
    });

</script>
</html>
