<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="StatDustHistroy.aspx.cs" Inherits="Web.StatDustHistroy" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <meta http-equiv="content-type" content="text/html; charset=gb2312" />
    <link rel="stylesheet" type="text/css" href="css/simple.css" />
    <link rel="stylesheet" type="text/css" href="css/table.css" />
    <script type="text/javascript" src="/My97DatePicker/WdatePicker.js"></script>
    <script type="text/javascript" src="js/jquery.js"></script>
    <script type="text/javascript" src="js/highchart/standalone-framework.js"></script>
    <script type="text/javascript" src="js/highchart/highcharts.js"></script>
    <script type="text/javascript" src="js/highchart/exporting.js"></script>
    <script type="text/javascript" src="js/chart.js"></script>
    <script type="text/javascript" src="js/url.js"></script>
    <script language="javascript" type="text/javascript">
        var chart;
        var cityId;
        window.onload = init;
        function init() {
            cityId = window.parent.cityId;
            LoadStats(cityId);
        }

        function LoadStats(cityId) {
            $.get("action/Stat.ashx", { action: 1, cityId: cityId }, function (data) {
                var json = eval("(" + data + ")");
                if (!json.success) return;
                if (json.totalCount !== "0") {
                    statsArr = json.data;
                    SetStats(json.data);
                }
            });
        }
        function SetStats(data) {
            var selObj = $("#selStats");
            selObj.size = data.length;
            for (var i = 0; i < data.length; i++) {
                selObj.append("<option value='" + data[i].Id + "'>" + data[i].Name + "</option>");
            }
        }

        function changeChart() {
            var dataType = $("#selDustType").val();
            var time1 = $("#txtStartTime").val();
            var time2 = $("#txtEndTime").val();
            var str = "starttime:" + time1 + "#endtime:" + time2 + "#dusttype:" + dataType + "#cityId" + cityId;
            if ($("#searchInput").val() === str) return; else $("#searchInput").val(str);
            var textTitle = "";
            var subTitle = "";
            var textUnit = "";
            var xCates = getXCates("3", time1, time2);
            var yCates = new Array(selectStats.length);
            var statStr = selectStats != null ? selectStats.join(",") : "";
            if (dataType === "0") { textTitle = "颗粒物日均值变化情况"; subTitle = "颗粒物 整体平均值"; textUnit = "浓度 mg/m&sup3;"; }
            else if (dataType === "1") { textTitle = "噪音日均值变化情况"; subTitle = "噪音 整体平均值"; textUnit = "分贝dB(A)"; }

            if (chart != null) chart.destroy();
            var options = cfgChart(textTitle, subTitle, textUnit, xCates);
            chart = new Highcharts.Chart(options);
            $.get("action/StatisDay.ashx", { action: 4, starttime: time1, endtime: time2, dusttype: dataType, cityId: cityId, stats: statStr, t: new Date().toString() }, function (data) {
                var json = eval("(" + data + ")");
                if (!json.success) return;

                if (json.totalCount !== "0") {
                    for (var i = 0; i < json.data.length; i++) {
                        setStatData(json.data[i].StatId, json.data[i].Time, parseFloat(json.data[i].Val), xCates, yCates);
                    }


                    for (var j = 0; j < yCates.length; j++) {
                        var obj = $("#queryStats option");
                        var yname = "";
                        var k = 0;
                        for (k ; k < obj.length; k++) {
                            if (yCates[j].statId === obj[k].value) {
                                yname = obj[k].text;
                            }
                        }
                        chart.addSeries({ name: yname, data: yCates[j].data });
                    }
                }
            });

        }
        function setStatData(statId, datatime, val, xCates, yCates) {
            var str = datatime.replace(/-/g, "/");
            var date = new Date(str);
            var o = date.getFullYear() + "-" + (date.getMonth() + 1) + "-" + date.getDate();
            for (var i = 0; i < yCates.length; i++) {
                if (yCates[i] == null) {
                    var data = []; for (var j = 0; j < xCates.length; j++) data[j] = 0;
                    yCates[i] = { statId: statId, data: data };
                }
                if (yCates[i].statId === statId) {
                    for (var k = 0; k < xCates.length; k++) {
                        if (xCates[k] === o) {
                            yCates[i].data[k] = val; return;
                        }
                    }
                }
            }
        }

        var statsArr = new Array();
        var selectStats = new Array();
        function AddStat() {
            var seltxt = $("#selStats option:selected").text();
            var selval = $("#selStats option:selected").val();
            var obj = $("#queryStats");
            if (!isOptionExist(selval)) {
                obj.append(new Option(seltxt, selval, true, true));
            }
            var ret = false;
            for (var i = 0; i < selectStats.length; i++) {
                if (selectStats[i] === selval) {
                    ret = true;
                    break;
                }
            }
            if (!ret) {
                selectStats.push(selval);
            }
        }

        function isOptionExist(selval) {
            var isExit = false;
            var obj = $("#queryStats option");
            for (var i = 0; i < obj.length; i++) {
                if (obj[i].value === selval) {
                    isExit = true;
                    break;
                }
            }
            return isExit;
        }

        function RemoveStat() {
            var selval = $("#queryStats option:selected").val();
            $("#queryStats option:selected").remove();
            $('#queryStats option:last').attr('selected', 'selected');
            var temp = new Array();
            for (var i = 0; i < selectStats.length; i++) {
                if (!(selectStats[i] === selval))
                    temp.push(selectStats[i]);
            }
            selectStats = temp;
        }
    </script>
</head>
<body>
    <form id="form1" runat="server">
        <input id="searchInput" type="hidden" />
        <h3>各工程历史污染物变化情况</h3>
        <div style="margin: 10px">
            <div style="float: left">
                <span style="padding: 5px">本区域工程：</span>
                <br />
                <select id="selStats" size="15" style="height: 100px; width: 300px">
                </select>
            </div>
            <div style="float: left">
                <input id="btnAddStat" type="button" style="padding: 5px; margin: 10px; margin-top: 20px" value="添加选择=>" onclick="AddStat()" />
                <br />
                <input id="btnClearStats" type="button" style="padding: 5px; margin: 10px" value="<=清除选择" onclick="RemoveStat()" />
            </div>
            <div>
                <span style="padding: 5px">已选择工程：</span>
                <br />
                <select id="queryStats" size="15" style="height: 100px; width: 300px"></select>
            </div>
        </div>
        <div>
            &nbsp;&nbsp;&nbsp;
       <input id="txtStartTime" type="text" onclick="WdatePicker({ dateFmt: 'yyyy-MM-dd' })" />
            &nbsp;&nbsp;至：&nbsp;&nbsp;
       <input id="txtEndTime" type="text" onclick="WdatePicker({ dateFmt: 'yyyy-MM-dd' })" />
            &nbsp;&nbsp;   
        <select id="seltype" name="D1">
            <option value="0">日均值变化情况</option>
        </select>
            污染类型：<select id="selDustType" name="D2">
                <option value="0">颗粒物</option>
                <option value="1">噪音</option>
                <option value="2">PM2.5</option>
                <option value="3">PM10</option>
            </select>
            <input id="btnSubmit" type="button" style="padding: 5px; margin-left: 5px" value="提交" onclick="changeChart()" />
        </div>
        <div id="LineChart" style="width: 100%; height: 400px; margin-top: 20px">
        </div>
    </form>
</body>
</html>
