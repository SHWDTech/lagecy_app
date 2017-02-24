<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DeviceConfigSeparate.aspx.cs" Inherits="Web.DeviceConfigSeparate" %>

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
            if (obj.State == 1) {
                state = "命令执行成功!";
            } else if (obj.State == 0) {
                state = "命令执行失败!";
            }

            if (state != "") {
                alert(state);
                return;
            }

            if (cmp != "N/A") {
                $("#pm").html(cmp);
            }
            if (noise != "N/A") {
                $("#noise").html(noise);
            }
            if (wd != "N/A") {
                $("#wd").html(wd);
            }
            if (ws != "N/A") {
                $("#ws").html(ws);
            }
            if (temp != "N/A") {
                $("#tmp").html(temp - 4.0);
            }
            if (hum != "N/A") {
                $("#hum").html(hum);
            }
            //$("#updatetime").html(obj.Time);
        }
    </script>
</head>
<body>
    <form id="form1" runat="server">
    <h3>当前工地单项数据实时查询</h3>
    <div>
    <p>
            <input id="txtCycleTime" type="hidden" value="3000"/> 
            </p>
            <select id="selDevs">
                <option value="2">1号设备</option>
                <option value="3" selected>中央商场</option> 
            </select>
            <a href="DeviceConfigAll.aspx">转到整体数据查询</a>
            <table id="tbRealData" class="GridTableContent" cellspacing="0" cellpadding="0" border="0" wight="100%" height="75px">
                    <tr class="GTContentTitle">
                        <td>
                            颗粒物浓度(mg/m³)
                        </td>
                        <td>
                            噪音值(db)
                        </td>
                        <td>
                            风向(°)
                        </td>
                        <td>
                            风速(m/s)
                        </td>
                        <td>
                            温度(℃)
                        </td>
                        <td>
                            湿度(%)
                        </td>
                    </tr>
                    <tr>
                        <td id="pm">
                            N/A
                        </td>
                        <td id="noise">
                            N/A
                        </td>
                        <td id="wd">
                            N/A
                        </td>
                        <td id="ws">
                            N/A
                        </td>
                        <td id="tmp">
                            N/A
                        </td>
                        <td id="hum">
                            N/A
                        </td>
                    </tr>
                <tr>
                    <td id="questpm"><input type="button" onclick="RequestCmd(252, 31, '')" value="更新颗粒物浓度" style="padding : 5px"/></td>
                    <td id="Td1"><input type="button" onclick="RequestCmd(252, 109, '')" value="更新噪音值" style="padding : 5px"/></td>
                    <td id="Td2"><input type="button" onclick="RequestCmd(252, 43, '1')" value="更新风向值" style="padding : 5px"/></td>
                    <td id="Td3"><input type="button" onclick="RequestCmd(252, 42, '1')" value="更新风速值" style="padding : 5px"/></td>
                    <td id="Td4" colspan="2"><input type="button" onclick="RequestCmd(252, 25, '')" value="更新温湿度值" style="padding : 5px"/></td>
                </tr>
            </table>
    </div>
    </form>
</body>
</html>
