<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="RealTimeMonitoring.aspx.cs" Inherits="Web.RealTimeMonitoring" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link rel="stylesheet" type="text/css" href="css/simple.css" />
    <link rel="stylesheet" type="text/css" href="css/table.css" />
    <script type="text/javascript" src="js/jquery-1.js"></script>
    <script type="text/javascript">
        var OffSetCpm = <%=OffSetCpm%>;
        var OffSetPlusCpm = <%=OffSetPlusCpm%>;
        var OffSetNoise = <%=OffSetNoise%>;
        var OffSetPlusNoise = <%=OffSetPlusNoise%>;
        var isQuesting = false;
        var isReading = false;
        var intervalNum;
        var intervalNumAuto;
        $(document).ready(function () {
            $("#btnReadESAuto").click(function () { SwitchReadMode() });
        });

        function SwitchReadMode() {
            if (isReading) {
                clearInterval(intervalNumAuto);
                isQuesting = false;
                $("#btnReadESAuto").val("开始读取实时监测信息");
            }
            else if (!isReading) {
                ReadAutoQuery();
                intervalNumAuto = setInterval(function() {
                    ReadAutoQuery();
                }, 60000);
                isReading = true;
                $("#btnReadESAuto").val("停止读取实时监测信息");
            }
        }

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

            if (cmp != "N/A") {
                $("#pm").html(cmp * OffSetCpm + OffSetPlusCpm);                
            } else {
                $("#pm").html(cmp);
            }
            if (noise != "N/A") {
                $("#noise").html(noise * OffSetNoise + OffSetPlusNoise);                
            } else {
                $("#noise").html(noise);
            }
            $("#wd").html(wd);
            $("#ws").html(ws);
            if (temp != "N/A") {
                $("#tmp").html((temp - 4.0).toString().substring(0, 4));
            } else {
                $("#tmp").html(temp);
            }
            $("#hum").html(hum);
            $("#updatetime").html(obj.Time);
        }
    </script>
    <script type="text/javascript" src="js/highchart/standalone-framework.js"></script>
    <script type="text/javascript" src="js/highchart/highcharts.js"></script>
    <script type="text/javascript" src="js/highchart/exporting.js"></script>
    <script language="javascript" type="text/javascript">
        function GetChartData() {
            var devid = $("#selDevs").val();
            var ctrl = $("#selControls").val();
            var type = $('#seltype').val();
            $.get("action/Chart.ashx", { ctrl: ctrl, devid: devid, type: type, _t: new Date().getTime() }, function (data) {
                var json = eval("(" + data + ")");
                if (json.success) {
                    setChart(json.data[0]);
                }
            });
        }

        function ReadAutoQuery() {
            var devid = $("#selDevs").val();
            $.get("action/Cmd.ashx", { action: 3, devid: devid }, function(data) {
                var json = eval("(" + data + ")");
                if (json.success) {
                    UpdateData(json.data[0]);
                }
            });
        }

        var chart;
        function setChart(obj) {
            var data = null;
            data = obj.series.split(',');
            for (var i = 0; i < data.length; i++)
            {
                data[i] = parseFloat(data[i]);
            }
            var Categories = obj.xAxisCategories.split(',');
            chart = new Highcharts.Chart({
                chart: {
                    renderTo: 'container',          //放置图表的容器
                    defaultSeriesType: 'line',    //图表类型line, spline, area, areaspline, column, bar, pie , scatter
                    //zoomType: 'x',                  //放大
                    inverted: false                  //左右显示，默认上下正向
                },
                title: {
                    text: obj.Title,        //图标的标题
                    style: {}                        //标题样式
                },
                subtitle: {
                    text: obj.SubTitle            //图标的副标题
                },
                xAxis: {
                    categories: Categories,
                    labels: {
                        rotation: -45,
                        align: 'right',
                        style: { font: 'normal 13px 宋体' }
                    }
                },
                yAxis: {
                    min: 0,
                    title: { text: obj.yAxisTitle }  //Y轴坐标标题  labels:纵柱标尺
                },
                legend: {                               //【图例】位置样式
                    layout: 'horizontal',               //【图例】显示的样式：水平（horizontal）/垂直（vertical）
                    backgroundColor: '#FFFFFF',
                    borderColor: '#CCC',
                    borderWidth: 1,
                    align: 'center',
                    verticalAlign: 'top',
                    enabled: true,
                    //x: 100,
                    y: 50,
                    //floating: true,
                    shadow: true
                },
                //loading: {  需要配合chart.showLoading();使用
                //    hideDuration: 10000,
                //    showDuration: 10000
                //},
                tooltip: {
                    formatter: function () {                 //当鼠标悬置数据点时的格式化提示
                        return '<b>' + this.x + '</b><br/>' + this.series.name + ': ' + Highcharts.numberFormat(this.y, 1);
                    }
                },
                credits: {
                    enabled: false
                },
                plotOptions: {
                    column: {
                        pointPadding: 0.2,  //图表柱形的
                        borderWidth: 0      //图表柱形的粗细 
                        //pointWidth:15    你想显示的宽度(number型）

                    }, bar: {
                        dataLabels: {
                            enabled: false
                        }
                    }
                },
                series: [{ name: obj.seriesname, data: data }]
            });

            //chart.showLoading();
        };
    </script>
</head>
<body>
    <form id="form1" runat="server">
        <h3>当前工地总体数据实时监测</h3>
        <div>
            <div>
                <p>
                    <input id="txtCycleTime" type="hidden" value="3000" />
                </p>
                <asp:DropDownList ID="selDevs" runat="server">
            </asp:DropDownList>
                <input id="btnReadESAuto" type="button" value="开始读取实时监测信息" style="padding: 5px"/>
                <%--<input id="btnReadES" type="button" value="开启自动查询(问答式)" style="padding: 5px" />--%>
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
        <div style="margin-top: 25px">
            <select id="selControls">
                <option value="1">当日小时均值变化</option>
                <option value="2">24小时内均值变化</option>
                <option value="3">一周内均值变化</option>
            </select>
            <select id="seltype" style="margin-left: 25px">
                <option value="1">颗粒物浓度</option>
                <option value="2">噪音</option>
            </select>
            <input style="margin-left: 25px; padding: 5px" type="button" value="查询" onclick="GetChartData()"/>
            
        </div>
        <div id="container" style="min-width: 800px; height: 400px"></div>
    </form>
</body>
</html>
