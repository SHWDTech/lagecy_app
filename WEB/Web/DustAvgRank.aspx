<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DustAvgRank.aspx.cs" Inherits="Web.DustAvgRank" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <meta http-equiv="content-type" content="text/html; charset=gb2312" />
    <link rel="stylesheet" type="text/css" href="css/simple.css" />
    <link rel="stylesheet" type="text/css" href="css/table.css" />
    <script type="text/javascript" src="/My97DatePicker/WdatePicker.js"></script>
    <script type="text/javascript" src="js/table.js"></script>
    <script type="text/javascript" src="js/jquery-1.js"></script>
    <script type="text/javascript" src="js/url.js"></script>
    <script type="text/javascript">
        var cityId;
        window.onload = init;
        function init() {
            cityId = window.parent.cityId;
        }
        function GetData() {
            var dataType = $("#selDustType").val();
            var time1 = $("#txtStartTime").val();
            var time2 = $("#txtEndTime").val();
            var str = "starttime:" + time1 + "#endtime:" + time2 + "#dusttype:" + dataType + "#cityId" + cityId;
            if ($("#searchInput").val() === str) return;
            $.get("action/StatisDay.ashx", { action: 3, starttime: time1, endtime: time2, dusttype: dataType, cityId: cityId, _t: new Date().getTime() }, function (data) {
                var json = eval("(" + data + ")");
                if (!json.success) return;
                if (json.totalCount !== "0") {
                    setTableData(json.data);
                }
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
                content.push(items[i].Code);
                content.push(items[i].Avg);
                content.push(items[i].Max);
                content.push(items[i].Min);
                content.push(items[i].ValidDataNum);
                tbStat.addRows(i, content.length, content);
            }
            return;
        }
    </script>
</head>
<body>
    <form id="form1" runat="server">
        <h3>本区县污染物均值排名情况</h3>
        <div>
            &nbsp;&nbsp;&nbsp;
       <asp:TextBox ID="txtStartTime" runat="server" onclick="WdatePicker({dateFmt:'yyyy-MM-dd'})"></asp:TextBox>
            &nbsp;&nbsp;至：&nbsp;&nbsp;
       <asp:TextBox ID="txtEndTime" runat="server" onclick="WdatePicker({dateFmt:'yyyy-MM-dd'})"></asp:TextBox>
            &nbsp;&nbsp;
       污染类型：<select id="selDustType">
           <option value="0">颗粒物</option>
           <option value="1">噪音</option>
           <option value="2">PM2.5</option>
           <option value="3">PM10</option>
       </select>
            <input id="btnSubmit" type="button" style="padding: 5px; margin-left: 5px" value="提交" onclick="GetData()" />
        </div>
        <div style="margin-top: 20px">
            <table id="tbStat" class="GridTableContent" style="border: 0; border-spacing: 0; padding: 0;">
                <tbody>
                    <tr class="GTContentTitle">
                        <td width="150px">工程名称</td>
                        <td width="150px">监测点</td>
                        <td width="100px">日均值</td>
                        <td width="100px">最大值</td>
                        <td width="100px">最小值</td>
                        <td width="100px">有效值</td>
                    </tr>
                </tbody>
            </table>
        </div>
    </form>
</body>
</html>
