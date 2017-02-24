<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DeviceConfigSeparate.aspx.cs" Inherits="Web.admin.DeviceConfigSeparate" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link rel="stylesheet" type="text/css" href="/css/right.css" />
    <meta http-equiv="Content-Type" content="text/html; charset=gb2312" />
    <script type="text/javascript" src="/My97DatePicker/WdatePicker.js"></script>
    <meta name="viewport" content="initial-scale=1.0, user-scalable=no" />
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
    <link rel="stylesheet" type="text/css" href="/css/table.css" />
    <script type="text/javascript" src="/js/jquery-1.js"></script>
    <script type="text/javascript">
        var OffSetCpm = <%=OffSetCpm%>;
        var OffSetPlusCpm = <%=OffSetPlusCpm%>;
        var OffSetNoise = <%=OffSetNoise%>;
        var OffSetPlusNoise = <%=OffSetPlusNoise%>;
        var isQuesting = false;
        var intervalNum;
        $(document).ready(function () {
        });

        function RequestCmd(cmdtype, cmdbyte, params) {
            var devId = $("#selDevs").val();
            $.get("/action/Cmd.ashx", { action: 1, cmdType: cmdtype, cmdByte: cmdbyte, cmdParam: params, dev: devId, _t: new Date().getTime() }, function (data) {
                var json = eval("(" + data + ")");
                if (json.success) {
                    var timeout = 5000;
                    maxtimeoutTimes = 10;
                    SetTimeout(json.data[0].task, timeout);
                }
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
            }
        }

        function ResponseCmd(taskId) {
            $.get("/action/Cmd.ashx", { action: 2, task: taskId, _t: new Date().getTime() }, function (data) {
                var json = eval("(" + data + ")");
                if (json.success) {
                    UpdateData(json.data[0]);
                    clearTimeout(timeID);
                }
            });
        }
        function UpdateData(obj) {
            if (obj == null) return;
            var cmp = obj.CMPState === "1" ? obj.CMP : "N/A";
            var noise = obj.NoiseState === "1" ? obj.Noise : "N/A";
            var wd = obj.WindDirState === "1" ? obj.WindDir : "N/A";
            var ws = obj.WindSpeedState === "1" ? obj.WindSpeed : "N/A";
            var temp = obj.ESState === "1" ? obj.Temp : "N/A";
            var hum = obj.ESState === "1" ? obj.Humidity : "N/A";

            var state = "";
            if (obj.State === "1") {
                state = "命令执行成功!";
            } else if (obj.State === "0") {
                state = "命令执行失败!";
            }

            if (state !== "") {
                alert(state);
                return;
            }

            if (cmp !== "N/A") {
                $("#pm").html(cmp);                
            }
            if (noise !== "N/A") {
                $("#noise").html(noise);                
            }
            if (wd !== "N/A") {
                $("#wd").html(wd);
            }
            if (ws !== "N/A") {
                $("#ws").html(ws);
            }
            if (temp !== "N/A") {
                $("#tmp").html((temp - 4.0).toString().substring(0, 4));
            }
            if (hum !== "N/A") {
                $("#hum").html(hum);
            }
        }

        function modifyoffset() {
            var offsetcpm = $("#t_offsetcpm").val();
            var offsetpluscpm = $("#t_offsetcpmplus").val();
            var offsetnoise = $("#t_offsetnoise").val();
            var offsetplusnoise = $("#t_offsetnoiseplus").val();
            $.post("/action/Config.ashx", { action: 1, offsetcpm: offsetcpm, offsetpluscpm: offsetpluscpm, offsetnoise: offsetnoise, offsetplusnoise: offsetplusnoise }, function(data) {
                var json = eval("(" + data + ")");
                if (json.success) {
                    alert("修改OFFSET成功。");
                } else {
                    alert(json.error);
                }

            });

        }

        function StartBgTest() {
            var devid = $("#selDevs").val();
            $.post("/action/Cmd.ashx", { action: 1, cmdType: 252, cmdByte: 191, cmdParam: '1', dev: devid }, function(data) {
                var json = eval("(" + data + ")");
                if (json.success) {
                    setTimeout(function() {$.post("/action/Cmd.ashx", { action: 1, cmdType: 252, cmdByte: 79, cmdParam: '', dev: devid });}, 45000);
                    setTimeout(function() {$.post("/action/Cmd.ashx", { action: 1, cmdType: 252, cmdByte: 95, cmdParam: '', dev: devid });}, 105000);
                    setTimeout(function() {$.post("/action/Cmd.ashx", { action: 1, cmdType: 252, cmdByte: 191, cmdParam: '0', dev: devid });}, 120000);
                } else {
                    alert(json.error);
                }

            });

        }

        function StartSpanTest() {
            var devid = $("#selDevs").val();
            $.post("/action/Cmd.ashx", { action: 1, cmdType: 252, cmdByte: 175, cmdParam: '1', dev: devid }, function(data) {
                var json = eval("(" + data + ")");
                if (json.success) {
                    setTimeout(function() {$.post("/action/Cmd.ashx", { action: 1, cmdType: 252, cmdByte: 127, cmdParam: '', dev: devid });}, 45000);
                    setTimeout(function() {$.post("/action/Cmd.ashx", { action: 1, cmdType: 252, cmdByte: 143, cmdParam: '', dev: devid });}, 105000);
                } else {
                    alert(json.error);
                }

            });

        }
    </script>
</head>
<body>
    <form id="form1" runat="server">
        <table style="width: 100%; border: 0; border-spacing: 0; padding: 0;">
            <tr>
                <td style="font-weight: bold; background-image: url('data:image/jpeg;base64,/9j/4AAQSkZJRgABAQEASABIAAD/2wBDAAICAgICAgICAgICAgICAwQDAgIDBAUEBAQEBAUGBQUFBQUFBgYHBwgHBwYJCQoKCQkMDAwMDAwMDAwMDAwMDAz/2wBDAQMDAwUEBQkGBgkNCwkLDQ8ODg4ODw8MDAwMDAwMDAwMDAwMDAwMDAwMDAwMDAwMDAwMDAwMDAwMDAwMDAwMDAz/wAARCAAcAAEDAREAAhEBAxEB/8QAFgABAQEAAAAAAAAAAAAAAAAAAwYJ/8QAHBAAAgICAwAAAAAAAAAAAAAAAAMBExRRUlOS/8QAFgEBAQEAAAAAAAAAAAAAAAAAAQQD/8QAFxEBAQEBAAAAAAAAAAAAAAAAABESAf/aAAwDAQACEQMRAD8A3Vvf3N9SU54zohA7F8oGCpLJbsuyg31//9k=') /*/images/title_bg.jpg*/; height: 28px">
                    <img src="/images/go.gif" />当前位置： <span style="font-weight: normal">[ 设备测试 ] </span></td>
            </tr>
            <tr>
                <td style="background-color: #b1ceef; height: 1px;"></td>
            </tr>
        </table>
        <h3>当前工地单项数据实时查询</h3>
        <div>
            <p>
                <input id="txtCycleTime" type="hidden" value="3000" />
            </p>
            <asp:DropDownList ID="selDevs" runat="server">
            </asp:DropDownList>
            <a href="DeviceConfigAll.aspx">转到整体数据查询</a>
            <table id="tbRealData" class="GridTableContent" style="height: 75px; border: 0; padding: 0; border-spacing: 0;">
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
                </tr>
                <tr>
                    <td id="questpm">
                        <input type="button" onclick="RequestCmd(252, 31, '')" value="更新颗粒物浓度" style="padding: 5px" /></td>
                    <td id="Td1">
                        <input type="button" onclick="RequestCmd(252, 109, '')" value="更新噪音值" style="padding: 5px" /></td>
                    <td id="Td2">
                        <input type="button" onclick="RequestCmd(252, 43, '1')" value="更新风向值" style="padding: 5px" /></td>
                    <td id="Td3">
                        <input type="button" onclick="RequestCmd(252, 42, '1')" value="更新风速值" style="padding: 5px" /></td>
                    <td id="Td4" colspan="2">
                        <input type="button" onclick="RequestCmd(252, 25, '')" value="更新温湿度值" style="padding: 5px" /></td>
                </tr>
            </table>
        </div>
        <div>
            <br />
        </div>
        <h4>颗粒物浓度仪测试</h4>
        <div>
            <div style="padding: 5px">
                <input type="button" value="启动BG测试程序" style="padding: 5px" onclick="StartBgTest()" />
                <span id="countdown"></span>
                <br />
                <input type="button" value="启动SPAN测试程序" style="padding: 5px" onclick="    StartSpanTest()" />
            </div>
        </div>
        <div>
            <div style="padding: 5px">
            </div>
            <h4>噪音仪测试</h4>
            <div style="padding: 5px">
                <input type="button" id="SetZ" value="设为Z计权" style="height: 25px; width: 100px" onclick="RequestCmd(252, 125, '')" />
                <input type="button" id="SetC" value="设为C计权" style="height: 25px; width: 100px" onclick="RequestCmd(252, 141, '')" />
                <input type="button" id="SetA" value="设为A计权" style="height: 25px; width: 100px" onclick="RequestCmd(252, 157, '')" />
            </div>
            <div style="padding: 5px">
                <input type="button" id="SetF" value="设为F档" style="height: 25px; width: 100px" onclick="RequestCmd(252, 173, '')" />
                <input type="button" id="SetS" value="设为S档" style="height: 25px; width: 100px" onclick="RequestCmd(252, 189, '')" />
                <input type="button" id="SetI" value="设为I档" style="height: 25px; width: 100px" onclick="RequestCmd(252, 205, '')" />
            </div>
        </div>
    </form>
</body>
</html>
