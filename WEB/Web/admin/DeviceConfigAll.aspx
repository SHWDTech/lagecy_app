<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DeviceConfigAll.aspx.cs" Inherits="Web.admin.DeviceConfigAll" %>

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
        var isQuesting = false;
        var intervalNum;
        var TaskId;
        var Result;
        var timeID;
        var timeout;
        var maxtimeoutTimes;
        var autoquery = false;
        var autotimeID;

        function switQueryState() {
            if (!autoquery) {
                StartRequset(252, 8, "");
                setTimeout(function() { autoQueryData(); }, 60000);
                $("#btnAutoReadES").val("关闭自动实时查询");
                autoquery = true;
            }else if (autoquery) {
                clearTimeout(autotimeID);
                $("#btnAutoReadES").val("开启自动实时查询");
                autoquery = false;
            }
        }

        function autoQueryData() {
            StartRequset(252, 8, "");
            autotimeID = setTimeout(function() { autoQueryData(); }, 60000);
        }

        function loadCurDevState() {
            var devId = $("#selDevs").val();
            $.get("/action/StatisMin.ashx", { action: 2, devId: devId }, function (data) {
                var json = eval("(" + data + ")");
                if (!json.success) return;
                UpdateData(json.data[0]);
            });

        }

        $(document).ready(function () {
            $("#btnReadES").click(function () { StartRequset(252, 8, "") });
        });

        function StartRequset(cmdtype, cmdbyte, params) {
            RequestCmd(cmdtype, cmdbyte, params,function(addcmd) {
                if (addcmd) {
                    maxtimeoutTimes = 0;
                    chackResponse();
                }
            });
            
        }

        function chackResponse() {
            ResponseCmd(TaskId, function(getcmd) {
                if (getcmd) {
                    UpdateData(Result);
                } else {
                    if (maxtimeoutTimes < 20)
                    timeID = setTimeout(function () { chackResponse(); }, 3000);
                }

            });
            maxtimeoutTimes++;
        }

        function RequestCmd(cmdtype, cmdbyte, params, callback) {
                var devId = $("#selDevs").val();
                $.get("/action/Cmd.ashx", { action: 1, cmdType: cmdtype, cmdByte: cmdbyte, cmdParam: params, dev: devId, _t: new Date().getTime() }, function(data) {
                    var json = eval("(" + data + ")");
                    if (json.success) {
                        TaskId = json.data[0].task;
                        callback(true);
                    } else {
                        callback(false);
                    }
                });
        }

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
            if (obj.State === "1")
            {
                state = "命令执行成功!";
            } else if (obj.State === 0)
            {
                state = "命令执行失败!";
            }

            if (state !== "")
            {
                alert(state);
                return;
            }

            if (cmp !== "N/A") {
                $("#pm").html(cmp);                
            }
            if (noise !== "N/A") {
                $("#noise").html(noise);                
            }
            $("#wd").html(wd);
            $("#ws").html(ws);
            if (temp !== "N/A")
            {
                $("#tmp").html((temp - 4.0).toString().substring(0, 4));
            }
            $("#hum").html(hum);
            $("#updatetime").html(obj.Time);
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

        function waitforok() {
            ResponseCmd(TaskId, function(getcmd) {
                if (getcmd) {
                    BeginTest();
                } else {
                    if (maxtimeoutTimes < 20)
                        timeID = setTimeout(function () { waitforok(); }, 3000);
                }

            });
            maxtimeoutTimes++;
        }

        function BeginTest() {
            var devId = $("#selDevs").val();
            $.post("/action/Cmd.ashx", { action: 1, cmdType: 252, cmdByte: 23, cmdParam: '0', dev: devId });
            $.post("/action/Cmd.ashx", { action: 1, cmdType: 252, cmdByte: 63, cmdParam: '', dev: devId });
            setTimeout(function() {$.post("/action/Cmd.ashx", { action: 1, cmdType: 252, cmdByte: 127, cmdParam: '', dev: devId });}, 45000);
            setTimeout(function () { $.post("/action/Cmd.ashx", { action: 1, cmdType: 252, cmdByte: 143, cmdParam: '', dev: devId }); }, 105000);
            setTimeout(function () { $.post("/action/Cmd.ashx", { action: 1, cmdType: 252, cmdByte: 23, cmdParam: '60', dev: devId }); }, 125000);
        }

        function StartSpanTest() {
            RequestCmd(252, 175, '1',function(addcmd) {
                if (addcmd) {
                    maxtimeoutTimes = 0;
                    waitforok();
                }
            });
        }
    </script>
</head>
<body>
    <form id="form1" runat="server">
        <table style="width: 100%; border-spacing: 0; border: 0; padding: 0;">
            <tr>
                <td style="font-weight: bold; background-image: url('data:image/jpeg;base64,/9j/4AAQSkZJRgABAQEASABIAAD/2wBDAAICAgICAgICAgICAgICAwQDAgIDBAUEBAQEBAUGBQUFBQUFBgYHBwgHBwYJCQoKCQkMDAwMDAwMDAwMDAwMDAz/2wBDAQMDAwUEBQkGBgkNCwkLDQ8ODg4ODw8MDAwMDAwMDAwMDAwMDAwMDAwMDAwMDAwMDAwMDAwMDAwMDAwMDAwMDAz/wAARCAAcAAEDAREAAhEBAxEB/8QAFgABAQEAAAAAAAAAAAAAAAAAAwYJ/8QAHBAAAgICAwAAAAAAAAAAAAAAAAMBExRRUlOS/8QAFgEBAQEAAAAAAAAAAAAAAAAAAQQD/8QAFxEBAQEBAAAAAAAAAAAAAAAAABESAf/aAAwDAQACEQMRAD8A3Vvf3N9SU54zohA7F8oGCpLJbsuyg31//9k=') /*/images/title_bg.jpg*/; height: 28px">
                    <img alt="" src="/images/go.gif" />当前位置： <span style="font-weight: normal">[ 设备测试 ] </span></td>
            </tr>
            <tr>
                <td style="background-color: #b1ceef; height: 1px;"></td>
            </tr>
        </table>
        <h3>当前工地总体数据实时查询</h3>
        <div>
            <div>
                <p>
                    <input id="txtCycleTime" type="hidden" value="3000" />
                </p>
                <asp:DropDownList ID="selDevs" runat="server">
                </asp:DropDownList>
                <input id="btnReadES" type="button" value="查询实时数据" style="padding: 5px" />
                <input id="btnAutoReadES" type="button" value="开启自动实时查询" style="padding: 5px" onclick="switQueryState()"/>
                <a href="DeviceConfigSeparate.aspx">转到单项数据查询</a>
                <table id="tbRealData" class="GridTableContent" style="border: 0; border-spacing: 0; padding: 0; height: 75px;">
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
            <div style="padding: 5px">
            </div>
            <h4>颗粒物浓度仪测试</h4>
            <div style="padding: 5px"><span id="alert"></span></div>
            <div>
                <div style="padding: 5px">
                    <%--<input type="button" value="启动BG测试程序" style="padding: 5px" onclick="StartBgTest()" />
                    <span id="countdown"></span>
                    <br/>--%>
                    <input type="button" value="启动SPAN测试程序" style="padding: 5px" onclick="StartSpanTest()" />
                    <input type="button" value="开启自动数据上报" style="padding: 5px" onclick="StartRequset(252, 23, '1')" />
                </div>
            </div>
        </div>
        <div>
            <div>
            </div>
            <h4>噪音仪测试</h4>
            <div style="padding: 5px">
                <input type="button" id="SetZ" value="设为Z计权" style="height: 25px; width: 100px" onclick="StartRequset(252, 125, '')" />
                <input type="button" id="SetC" value="设为C计权" style="height: 25px; width: 100px" onclick="StartRequset(252, 141, '')" />
                <input type="button" id="SetA" value="设为A计权" style="height: 25px; width: 100px" onclick="StartRequset(252, 157, '')" />
            </div>
            <div style="padding: 5px">
                <input type="button" id="SetF" value="设为F档" style="height: 25px; width: 100px" onclick="StartRequset(252, 173, '')" />
                <input type="button" id="SetS" value="设为S档" style="height: 25px; width: 100px" onclick="StartRequset(252, 189, '')" />
                <input type="button" id="SetI" value="设为I档" style="height: 25px; width: 100px" onclick="StartRequset(252, 205, '')" />
            </div>
        </div>
    </form>
</body>
</html>
