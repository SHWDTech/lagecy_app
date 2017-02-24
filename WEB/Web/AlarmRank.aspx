<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AlarmRank.aspx.cs" Inherits="Web.Alarm" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>当前标准下超标率前五名监测点</title>
    <meta http-equiv="content-type" content="text/html; charset=gb2312" />
     <link rel="stylesheet" type="text/css" href="css/simple.css" />
     <link rel="stylesheet" type="text/css" href="css/table.css" />
    <script type="text/javascript" src="/My97DatePicker/WdatePicker.js"></script>
    <script type="text/javascript" src="js/table.js"></script>
    <script type="text/javascript" src="js/jquery-1.js"></script>
    <script type="text/javascript">
        var cityId;
        window.onload = init;
        function init() {
            cityId = window.parent.cityId;
            GetCurDayData();
        }

        function GetCurDayData() {
            $.get("action/Alarm.ashx", { action: 1, cityId: cityId }, function (data) {
                var json = eval("(" + data + ")");
                if (!json.success) return;
                if (json.totalCount !== "0") {
                    setTableData(json.data);
                }
            });
        }
        function GetData() {
            var time1 = $("#txtStartTime").val();
            var time2 = $("#txtEndTime").val();
            var str = "starttime:" + time1 + "#endtime:" + time2 + "#cityId" + cityId;
            if ($("#searchInput").val() === str) return;
            $.get("action/Alarm.ashx", { action: 2, starttime: time1, endtime: time2, cityId: cityId }, function(data) {
                var json = eval("(" + data + ")");
                if (!json.success) return;
                    setTableData(json.data);
            });
        }
        var tbStat;
        function setTableData(items) {
            if (tbStat == null) tbStat = new TableCtrl("tbStat");
            if (tbStat == null) return;
            tbStat.reset();

            var content = new Array();
            for (var i = 0; i < items.length; i++) {
                content.length = 0;
                content.push(items[i].Name);
                content.push(items[i].DBNum);
                content.push(items[i].TPNum);
                content.push(items[i].Total);
                tbStat.addRows(i, content.length, content);
            }
            return;
        }
    </script>
</head>
<body>
    <form id="form1" runat="server">
    <h3>当前标准下超标率前五名监测点</h3>
    <div>&nbsp;&nbsp;&nbsp;
       <asp:TextBox ID="txtStartTime" runat="server" onclick="WdatePicker({dateFmt:'yyyy-MM-dd'})"></asp:TextBox>
       &nbsp;&nbsp;至：&nbsp;&nbsp;
       <asp:TextBox ID="txtEndTime" runat="server" onclick="WdatePicker({dateFmt:'yyyy-MM-dd'})"></asp:TextBox>
       &nbsp;&nbsp;
       <input id="btnSubmit" type="button" value="提交" style="padding: 5px" onclick="GetData()"/>
    </div>
    <div style="margin-top:20px">
        <table id="tbStat" class="GridTableContent" style="border: 0; border-spacing: 0; padding: 0;">
            <tbody><tr class="GTContentTitle">
            <td width="150px">工程名称</td>
	        <td width="100px">噪音超标次数</td>
	        <td width="100px">颗粒物超标次数</td>
	        <td width="100px">超标总次数</td></tr></tbody>
	    </table>
	</div>
    </form>
</body>
</html>
