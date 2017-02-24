<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DeviceConfigAll.aspx.cs" Inherits="Web.DeviceConfigAll" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link rel="stylesheet" type="text/css" href="css/simple.css" />
    <link rel="stylesheet" type="text/css" href="css/table.css" />
    <script type="text/javascript" src="js/jquery-1.js"></script>
    <script type="text/javascript">
        var isQuesting = false;
        var intervalNum;
        $(document).ready(function () {
            $("#btnReadES").click(function () { RequestCmd(252, 8, "") });
        });

        function RequestCmd(cmdtype, cmdbyte, params) {
            var devId = $("#selDevs").val();
            $.get("action/Cmd.ashx", { action: 1, cmdType: cmdtype, cmdByte: cmdbyte, cmdParam: params, dev: devId, _t: new Date().getTime() }, function (data) {
                var json = eval("(" + data + ")");
                if (json.success) {
                    var timeout = 5000;
                    maxtimeoutTimes = 10;
                    SetTimeout(json.data[0].task, timeout);
                }
                //else {
                //    alert(json.error);
                //}
            });
        }
        var timeID;
        var timeoutTimes = 0;
        var maxtimeoutTimes = 0;
        function SetTimeout(taskId, timeout) {
            ResponseCmd(taskId);
            timeoutTimes++;
            if (timeoutTimes < maxtimeoutTimes) {
                timeID = setTimeout(function () { SetTimeout(taskId, timeout) }, timeout);
            }
            else {
                clearTimeout(timeID);
                timeoutTimes = 0;
                //alert("查询失败");
            }
        }

        function ResponseCmd(taskId) {
            $.get("action/Cmd.ashx", { action: 2, task: taskId, _t: new Date().getTime() }, function (data) {
                var json = eval("(" + data + ")");
                if (json.success) {
                    //alert("任务流水号:" + taskId + "成功");
                    UpdateData(json.data[0]);
                    clearTimeout(timeID);
                }
                //else {
                //    alert(json.error);
                //}
            });
        }
        function UpdateData(obj) {
            if (obj == null) return;
            var cmp = obj.CMPState == 1 ? obj.CMP : "N/A";
            var noise = obj.NoiseState == 1 ? obj.Noise : "N/A";
            var wd = obj.WindDirState == 1 ? obj.WindDir : "N/A";
            var ws = obj.WindSpeedState == 1 ? obj.WindSpeed : "N/A";
            var temp = obj.ESState == 1 ? obj.Temp : "N/A";
            var hum = obj.ESState == 1 ? obj.Humidity : "N/A";
            var state = "";
            if (obj.State == 1)
            {
                state = "命令执行成功!";
            } else if (obj.State == 0)
            {
                state = "命令执行失败!";
            }

            if (state != "")
            {
                alert(state);
                return;
            }

            $("#pm").html(cmp);
            $("#noise").html(noise);
            $("#wd").html(wd);
            $("#ws").html(ws);
            if (temp != "N/A")
            {
                $("#tmp").html(temp - 4.0);
            }
            $("#hum").html(hum);
            $("#updatetime").html(obj.Time);
        }
    </script>
</head>
<body>
    <form id="form1" runat="server">
        <h3>当前工地总体数据实时查询</h3>
        <div>
            <div>
                <p>
                    <input id="txtCycleTime" type="hidden" value="3000" />
                </p>
                <select id="selDevs">
                    <option value="2">1号设备</option>
                    <option value="3" selected>中央商场</option>
                </select>
                <input id="btnReadES" type="button" value="查询实时数据" style="height: 25px; width: 100px" />
                <a href="DeviceConfigSeparate.aspx">转到单项数据查询</a>
                <table id="tbRealData" class="GridTableContent" cellspacing="0" cellpadding="0" border="0" wight="100%" height="75px">
                    <tr class="GTContentTitle">
                        <td>颗粒物浓度(mg/m³)
                        </td>
                        <td>噪音值(db)
                        </td>
                        <td>风向(°)
                        </td>
                        <td>风速(m/s)
                        </td>
                        <td>温度(℃)
                        </td>
                        <td>湿度(%)
                        </td>
                        <td>最后更新时间
                        </td>
                    </tr>
                    <tr>
                        <td id="pm">N/A
                        </td>
                        <td id="noise">N/A
                        </td>
                        <td id="wd">N/A
                        </td>
                        <td id="ws">N/A
                        </td>
                        <td id="tmp">N/A
                        </td>
                        <td id="hum">N/A
                        </td>
                        <td id="updatetime">N/A
                        </td>
                    </tr>
                </table>
            </div>
        </div>
        <div>
            <br />
        </div>
        <div>
            <input type="button" id="StartBgTest" value="开始每秒上传" style="height: 25px; width: 100px" onclick="RequestCmd(252, 77, '')"/>
        </div>
        <%--<div>
            <h3>设备配置命令列表</h3>
        </div>
        <br />
        <div>
            <div style="padding: 5px">
            </div>
            <h4>颗粒物浓度仪测试</h4>
            <div>
                <div style="padding: 5px">
                <input type="button" id="StartBgTest" value="BG测试开始" style="height: 25px; width: 100px" onclick="RequestCmd(252, 79, '')"/>
                <input type="button" id="StopBgTest" value="BG测试停止" style="height: 25px; width: 100px" onclick="RequestCmd(252, 95, '')"/>
                <input type="button" id="BgTestResult" value="BG测试结果" style="height: 25px; width: 100px" onclick="RequestCmd(252, 111, '')"/>
            </div>
            <div style="padding: 5px">
                <input type="button" id="StartSPanTest" value="Span测试开始" style="height: 25px; width: 100px" onclick="RequestCmd(252, 127, '')"/>
                <input type="button" id="StopSpanTest" value="Span测试停止" style="height: 25px; width: 100px" onclick="RequestCmd(252, 143, '')"/>
                <input type="button" id="SpanTestResult" value="Span测试结果" style="height: 25px; width: 100px" onclick="RequestCmd(252, 159, '')"/>
            </div>
            </div>
        </div>
        <div>
            <div style="padding: 5px">
            </div>
            <h4>噪音仪测试</h4>
            <div style="padding: 5px">
                <input type="button" id="SetZ" value="设为Z计权" style="height: 25px; width: 100px" onclick="RequestCmd(252, 125, '')"/>
                <input type="button" id="SetC" value="设为C计权" style="height: 25px; width: 100px" onclick="RequestCmd(252, 141, '')"/>
                <input type="button" id="SetA" value="设为A计权" style="height: 25px; width: 100px" onclick="RequestCmd(252, 157, '')"/>
            </div>
            <div style="padding: 5px">
                <input type="button" id="SetF" value="设为F档" style="height: 25px; width: 100px" onclick="RequestCmd(252, 173, '')"/>
                <input type="button" id="SetS" value="设为S档" style="height: 25px; width: 100px" onclick="RequestCmd(252, 189, '')"/>
                <input type="button" id="SetI" value="设为I档" style="height: 25px; width: 100px" onclick="RequestCmd(252, 205, '')"/>
            </div>
        </div>--%>
    </form>
</body>
</html>
