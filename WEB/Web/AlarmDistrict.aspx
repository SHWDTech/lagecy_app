<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AlarmDistrict.aspx.cs" Inherits="Web.AlarmDistrict" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
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
    <script language="javascript" type="text/javascript">
        var chart;
        var cityId;
        window.onload = init;
        function init() {
             cityId = window.parent.cityId;
        }
        
        function changeChart() {
            var type = $("#seltype").val();
            var dataType = $("#selDustType").val();
            var time1 = $("#txtStartTime").val();
            var time2 = $("#txtEndTime").val();
            var str="starttime:" + time1+"#endtime:"+time2 + "#dusttype:"+dataType +"#cityId"+cityId;
            if($("#searchInput").val() === str) return;
            var textTitle = "";
            var subTitle = "";
            var textUnit = "";
            var xCates = new Array();
            var yCates = new Array();
            var objName = "污染物超标次数";
            if (type === "0") { textTitle = cityId + "污染物超标次数折线图"; }
            if (dataType === "0") { subTitle = "颗粒物 超标次数"; textUnit = "次数";}
            else if (dataType === "1") { subTitle = "噪音 超标次数"; textUnit = "次数"; }

            $.get("action/Alarm.ashx", { action: 3, starttime: time1, endtime: time2, dusttype: dataType, cityId: cityId }, function(data) {
                var json = eval("(" + data + ")");
                if (!json.success) return;

                if (json.totalCount !== "0") {
                    for (var i = 0; i < json.data.length; i++) {
                        xCates.push(json.data[i].Time);
                        yCates.push(parseFloat(json.data[i].Val));
                    }
                }

                if (chart != null) chart.destroy();
                var options = cfgChart(textTitle, subTitle, textUnit,xCates);
                chart = new Highcharts.Chart(options);
                chart.addSeries({ name: objName, data: yCates });
            });
        }        
 
    </script>
</head>
<body>
    <form id="form1" runat="server">
    <h3>本区县整体超标情况变化趋势</h3>
    <div>&nbsp;&nbsp;&nbsp;
       <input id="txtStartTime" type="text" onclick="WdatePicker({dateFmt:'yyyy-MM-dd'})"/>
       &nbsp;&nbsp;至：&nbsp;&nbsp;
       <input id="txtEndTime" type="text" onclick="WdatePicker({dateFmt:'yyyy-MM-dd'})"/>
       &nbsp;&nbsp;   
        <select id="seltype">
            <option value="0">每日变化情况</option>
        </select>
        污染类型：<select id="selDustType">
            <option value="0">颗粒物</option>
            <option value="1">噪音</option>
        </select>
        <input id="searchInput" type="hidden" />
       <input id="btnSubmit" type="button" value="提交" style="padding: 5px" onclick="changeChart()"/>
    </div>
    <div id="LineChart" style="width:100%;height:400px;margin-top:20px">
    </div>
    </form>
</body>
</html>
