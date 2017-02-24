<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SiteList.aspx.cs" Inherits="Web.SiteList" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head id="Head1" runat="server">
    <title></title>
     <meta http-equiv="content-type" content="text/html; charset=gb2312" />
     <link rel="stylesheet" type="text/css" href="css/simple.css" />
     <link rel="stylesheet" type="text/css" href="css/table.css" />
     <style type="text/css">
     dt {
        color: #7FBD33;
        font-size: 18px;
        font-weight: bold;
        line-height: 34px;
        margin: 0 0 5px;
     }
     dd {
        color: #7E8B6D;
        font-size: 14px;
        line-height: normal;
        margin: 0 0 10px;
    }
     </style>
    <script type="text/javascript" src="js/jquery-1.js"></script>
    <script type="text/javascript" src="js/table.js"></script>
    <script type="text/javascript" src="js/url.js"></script>
    <script type="text/javascript">

        var cityId = "";
        var tbStat = null;
        $(function() {
            cityId = window.parent.cityId;
            LoadStats(cityId);
        });

        function LoadStats(cityId) {
            $.get("action/Stat.ashx", { action: 1, cityId: cityId }, function (data) {
                var json = eval("(" + data + ")");
                if (!json.success) return;
                if (json.totalCount != "0") {
                    setTableData(json.data);
                    //alert(json.totalCount);
                }
                setTitle(json.totalCount, json.data);
            });
        }
        function setTitle(total, items) {
            var jcCount = 0, jgCount = 0;
            if (total != "0") {
                for (var i = 0; i < items.length; i++) {
                    if (items[i].Stage == "基础") { jcCount += 1; }
                    else if (items[i].Stage == "结构") { jgCount += 1; }
                }
            }
            $("#spanTotal").html(total);
            $("#spanJC").html(jcCount);
            $("#spanJG").html(jgCount);
        }
        function setTableData(items) {
            if (tbStat == null) tbStat = new TableCtrl("tbStat");
            if (tbStat == null) return;
            tbStat.reset();

            var content = new Array();
            //alert(items.length);
            for (var i = 0; i < items.length; i++) {
                content.length = 0;
                var str = "<a href=\"StatDetail.aspx?sid=" + items[i].Id +"&cityId=" + cityId + "\" target='_parent' />" + items[i].Name + "</a>";
                content.push(str);
                content.push(items[i].Man);
                content.push(items[i].Mobile);
                content.push(items[i].Addr);
                content.push(items[i].Depart);
                content.push(items[i].Stage);
                tbStat.addRows(i, content.length, content);
            }
            return;
        }
    </script>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <dl><dt>本区当前共监测建筑工程<span id="spanTotal">0</span>家</dt>
    <dd>其中， 基础期工程<span id="spanJC">0</span>家， 结构期工程<span id="spanJG">0</span>家</dd>
    </dl>
    <div>
     <table id="tbStat"class="GridTableContent" cellspacing="0" cellpadding="0" border="0">
    <tr class="GTContentTitle">
        <td width="300px">工程名称</td>
        <td width="100px">联系人</td>
        <td width="100px">联系电话</td>
	<td width="250px">工程地址</td>
	<td width="250px">总承包单位</td>
	<td width="70px">工期</td></tr>
    </table>
    </div>
    </div>
    </form>
</body>
</html>
