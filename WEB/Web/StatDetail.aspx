<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="StatDetail.aspx.cs" Inherits="Web.StatDetail" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>工地详细信息</title>
    <link rel="stylesheet" type="text/css" href="css/right.css" />
    <meta http-equiv="Content-Type" content="text/html; charset=gb2312" />
    <link rel="stylesheet" type="text/css" href="css/simple.css" />
    <link rel="stylesheet" type="text/css" href="css/table.css" />
    <script type="text/javascript" src="js/url.js"></script>
    <script type="text/javascript" src="js/jquery-1.js"></script>
    <script type="text/javascript" src="js/highchart/standalone-framework.js"></script>
    <script type="text/javascript" src="js/highchart/highcharts.js"></script>
    <script type="text/javascript" src="js/chart.js"></script>
    <script type="text/javascript" src="js/table.js"></script>
    <script type="text/javascript">
        window.onload = init;
        var sid;
        var cityId;
        function init() {
            var request = GetUrlRequest();
            cityId = request["cityId"];
            sid = request["sid"];
            loadStat();
            changeChart();
            updateRealTimeData();
            var hre = "StatPic.aspx?sid=" + sid;
            var hrehis = "StatPicsView.aspx?sid=" + sid + "&cityId=" + cityId;
            $("#piclink").attr('href', hre);
            $("#picHistory").attr('href', hrehis);
        }
        function loadStat() {
            $.get("action/Stat.ashx", { action: 3, sid: sid }, function (data) {
                var json = eval("(" + data + ")");
                if (!json.success) return;
                setStatInfo(json.data[0]);
            });

        }
        function setStatInfo(obj) {
            $("#spanName").html(obj.Name);
            $("#spanAddr").html(obj.Addr);
            $("#spanCountry").html(obj.Country);
            $("#spanStreet").html(obj.Street);
            $("#spanLong").html(obj.Long);
            $("#spanLant").html(obj.Lant);
            $("#spanDepart").html(obj.Depart);
            $("#spanSquare").html(obj.Square);
            $("#spanStartTime").html(obj.StartTime);
            $("#spanStage").html(obj.Stage);
            $("#spanMan").html(obj.Man);
            $("#spanMobile").html(obj.Mobile);
        }
        var chart = null;
        function changeChart() {
            var type = $("#seltype").val();
            var dataType = $("#selDustType").val();
            var str = "type:" + type + "#dusttype:" + dataType + "#cityId" + cityId;
            if ($("#searchInput").val() === str) return;
            var textTitle = cityId + "污染物指标折线图";;
            var subTitle = "";
            var textUnit = "";
            var xCates = new Array();
            var yCates = new Array();
            var objName = "";
            if (dataType === "0") { objName = "颗粒物"; textUnit = "浓度 mg/m³"; }
            else if (dataType === "1") { objName = "噪音"; textUnit = "分贝dB(A)"; }
            else if (dataType === "2") { objName = "PM2.5"; textUnit = "浓度 mg/m³"; }
            else if (dataType === "3") { objName = "PM10"; textUnit = "浓度 mg/m³"; }
            if (type === "0") { subTitle = "当日每小时均值" } else if (type === "1") { subTitle = "24小时内均值" } else if (type === "2") { subTitle = "一周内均值" }
            var url; var act;
            if (type === "2") { url = "action/StatisDay.ashx"; act = 5; } else { url = "action/StatisHour.ashx"; act = 2 }
            $.get(url, { action: act, datetype: type, dusttype: dataType, cityId: cityId, sid: sid }, function (data) {
                var json = eval("(" + data + ")");
                if (!json.success) return;

                if (json.totalCount !== "0") {
                    for (var i = 0; i < json.data.length; i++) {
                        xCates.push(json.data[i].Time);
                        yCates.push(parseFloat(json.data[i].Val));
                    }
                }

                if (chart != null) chart.destroy();
                var options = cfgChart(textTitle, subTitle, textUnit, xCates);
                chart = new Highcharts.Chart(options);
                chart.addSeries({ name: objName, data: yCates });
            });
        }
        function updateRealTimeData() {
            $.get("action/StatisMin.ashx", { action: 1, sid: sid }, function (data) {
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
                content.push(items[i].DevId);
                content.push(items[i].TP);
                content.push(items[i].PM25);
                content.push(items[i].PM100);
                content.push(items[i].DB);
                content.push(items[i].WD);
                content.push(items[i].WS);
                //if (items[i].TEMP !== "") {
                //    content.push((items[i].TEMP - 4.0).toString().substring(0, 4));
                //} else {
                //    content.push(items[i].TEMP);
                //}
                content.push("N/A");
                content.push(items[i].HUM);
                content.push(items[i].UpdateTime);
                tbStat.addRows(i, content.length, content);
            }
            return;
        }
    </script>
    <%-- ReSharper disable once CssBrowserCompatibility --%>
    <style type="text/css">
        .constructPanel {
            border: 2px solid #D7E1E1;
            border-radius: 7px 7px 7px 7px;
            float: left;
            font-size: 14px;
            width: 300px;
        }

            .constructPanel .info {
                margin: 0 auto;
                width: 98%;
            }

                .constructPanel .info div {
                    border-bottom: 1px solid #EEEEEE;
                }

            .constructPanel span {
                color: #666666;
                padding: 7px 7px 7px 0;
                height: 20px;
                display: inline-block;
            }

            .constructPanel .label {
                font-weight: bold;
                padding: 7px 0 7px 7px;
                width: 80px;
            }

            .constructPanel .shortcut {
                line-height: 34px;
                padding: 10px 12px 40px;
            }

        .diagram {
            font-size: 13px;
            margin: 20px 20px 0 340px;
            text-align: center;
        }

            .diagram span {
                display: inline-block;
                padding: 0 20px 20px;
            }

        .realTimeData, .historyData, .historyPhoto {
            margin: 30px 20px 40px;
        }

            .realTimeData dt, .historyData dt, .historyPhoto dt {
                font-size: 18px;
                font-weight: bold;
                padding: 0 0 2px;
            }

            .historyData .button {
                font-size: 14px;
            }

            .historyData dt, .historyPhoto dt {
                border-bottom: 1px solid #CCCCCC;
            }

            .realTimeData dt a, .realTimeData dt a:visited {
                background-image: url('data:image/png;base64,iVBORw0KGgoAAAANSUhEUgAAACAAAAAgCAYAAABzenr0AAAABGdBTUEAALGPC/xhBQAAACBjSFJNAAB6JgAAgIQAAPoAAACA6AAAdTAAAOpgAAA6mAAAF3CculE8AAAABmJLR0QA/wD/AP+gvaeTAAAFeElEQVRYw8WXW2xc1RWGv3UuM+PbeOxcnLohPonjSAQoQ5OWKpWJiwLpRRVOEUJVhYgFT32pE2hFaamxoFWpKtu0QjySPrS0EgWXVm1fosQiNIRAMhVJCAUpE+I6ruMY2zMez8yZs1cfcmKZiWfSmKhsaWkf7f2f9f/730tn7yOqyqfZrOW++Px7D595/r2Huj41AarGU9UDz53uGXzudE/i/y4gUENH4kYccXuNmuO/OvXgstxYtgCjhpa6Fu72vk5r3VpP0QPPnnxgcOjkA9fkhlxLEQ6c+E4SSAp4iPTdsfYOopFaHHGYnZ/i6PhRikExrdCz9+bfHrwuAn75zrc9ge8B3SBexHZoijUCcNPKzfjYaGhlzHY4deEEo5lxQIcU+h+95cXpZQn4xT/vT4gwCLK7zo2xsamNplgzjh2lYErhNiiFoMSlDIoq1NguQZDl2PhJisZPq9Lzg1v/UNENZ6nBn6fuS4rwSq0T825etQHXaWCmWORCIYtvpvA1T8n4KAbf5NGQ3BYX17K5oS7BytpGRjMXPOAeoKKAKxz42fF7kwIHVtfFExtXtDEx72M0wLHy1LoGR5RiEFBj2yDCv6YzKKBAU9Sl0XU4NTGJb0xaoOex5EtVa+FjAp4+tishcHxVXb3XGl/DxXyBNfWQK87xUa7AZC6PH5gF/OaWZs7MzuNYQlu8hovZec5ncgBDIvQ/ftvLVff/ii0wanZHLMtb3xQnW5ohIjmOj87hGwUYBkaAg09sGU499Xa3Bsan3oWWGod3xyfxjaaBnie2DB+8GnElAQ+ubazBkOXsVIaZfAmgH9jXt/XVdBmW+ohhKlckdT4DMAT09219teKqn3zrm4NPbv3znooCVDVZ48LRc1P4RlNAT/8X/pJaKplRw+EPPwJIh7iqq/7Jm9/YDXQDlQUYY0iNzQKkEL7y1Bf/WnE1xhiAIUVHnr79b1XJf3zkawlgUJBE+dzHPsVGDUbNtFFTlTzE7go0QFVfqYZ7/I2dCaPmgGORMGqumC8TEKSNBnt++qW/VyV/7B87ugINBlVNr9GgGi4Zkic3r65nKWx5EQ4/s23/vkoJv//6nQlB+hB6b4jXsqG5jpEzE0vhPEF2I/Q1x1xubV3B+dk5AjWpqgKe2bZ/TyXyRw51dQnygmtb3ufXtjBVgExRL9cCjxzqSgJdgmwHul3bomNVEw2xOILDB5PjGGN+U573qofR3te2J4A+oLetKcG65pWkZ+YpGWhrcHjj7NkFbNSxWdPQQEtDA3XRRibmYGVNlPcnPmAsM5Me6BxZX9WBJci7gBcituPdvs4jZ4R/Z31c2yXiCIlYLXe2d+AbiLkuRmzmihZ+ECVbtFkfdzg2doKxzMw0sGspjooO7H1t+yDQ2970WW5p3cC57AwlDQjUBwRLLBxxscQOD6EojkQQhEQ0QjZ/kSOj7zBbyKWBXQOdI6mleKo58Cege3T2gtexop22+nbmg0vHsAiAELVtLBEEIWrZFErz/Cdznv3nTjNbyALsA/YMdI5MVyKpWgOL939js8e2dV8mbwIMIIAEBQ6fOwLARG6SQqkIl76Mw8CzA50jaa7S/qcr2eVaiDpRb+eGu1gdb8XXEtncNH9892W4dF6kgVQlqz+RgHI3NjVvYkf7TqZyF/n9yd8x0Dki10K6LAHlbsScmPe51bfx5tjhTyRgoQhFxAVcIBpGLOxrwmc3hAafuSn+3bt/uKknXzp8X/huZ4X8GWAeKAD5sC8APhCoqllwQERswA5FuVXCCcPe8WjHlhu/2vKjX+849C0gAEph+FWiFGKNqupiAUJY3GFYi3qrbGxxAAvXwsthFvWmbEwB1ZD4mmvgerdl/5pdr/ZfxSSIL/GYYpEAAAAldEVYdGRhdGU6Y3JlYXRlADIwMTMtMDQtMDNUMTc6MTg6MDIrMDg6MDDjrwpDAAAAJXRFWHRkYXRlOm1vZGlmeQAyMDEzLTAyLTIxVDEwOjE0OjE2KzA4OjAwAxjOEwAAAE10RVh0c29mdHdhcmUASW1hZ2VNYWdpY2sgNi44LjgtNyBRMTYgeDg2XzY0IDIwMTQtMDItMjggaHR0cDovL3d3dy5pbWFnZW1hZ2ljay5vcmdZpF9/AAAAGHRFWHRUaHVtYjo6RG9jdW1lbnQ6OlBhZ2VzADGn/7svAAAAF3RFWHRUaHVtYjo6SW1hZ2U6OkhlaWdodAAzMij0+PQAAAAWdEVYdFRodW1iOjpJbWFnZTo6V2lkdGgAMzLQWzh5AAAAGXRFWHRUaHVtYjo6TWltZXR5cGUAaW1hZ2UvcG5nP7JWTgAAABd0RVh0VGh1bWI6Ok1UaW1lADEzNjE0MTI4NTa+f5v6AAAAE3RFWHRUaHVtYjo6U2l6ZQAxLjQ2S0JCpIp5rQAAAGJ0RVh0VGh1bWI6OlVSSQBmaWxlOi8vL2hvbWUvZnRwLzE1MjAvZWFzeWljb24uY24vZWFzeWljb24uY24vY2RuLWltZy5lYXN5aWNvbi5jbi9wbmcvMTA5NjYvMTA5NjY4MC5wbmeP5+5zAAAAAElFTkSuQmCC') /*images/refresh.png*/;
                line-height: 32px;
                width: 32px;
                display: inline-block;
            }

                .realTimeData dt a:hover {
                    background-image: url('data:image/png;base64,iVBORw0KGgoAAAANSUhEUgAAACAAAAAgCAYAAABzenr0AAAABGdBTUEAALGPC/xhBQAAACBjSFJNAAB6JgAAgIQAAPoAAACA6AAAdTAAAOpgAAA6mAAAF3CculE8AAAABmJLR0QA/wD/AP+gvaeTAAAFeElEQVRYw8WXW2xc1RWGv3UuM+PbeOxcnLohPonjSAQoQ5OWKpWJiwLpRRVOEUJVhYgFT32pE2hFaamxoFWpKtu0QjySPrS0EgWXVm1fosQiNIRAMhVJCAUpE+I6ruMY2zMez8yZs1cfcmKZiWfSmKhsaWkf7f2f9f/730tn7yOqyqfZrOW++Px7D595/r2Huj41AarGU9UDz53uGXzudE/i/y4gUENH4kYccXuNmuO/OvXgstxYtgCjhpa6Fu72vk5r3VpP0QPPnnxgcOjkA9fkhlxLEQ6c+E4SSAp4iPTdsfYOopFaHHGYnZ/i6PhRikExrdCz9+bfHrwuAn75zrc9ge8B3SBexHZoijUCcNPKzfjYaGhlzHY4deEEo5lxQIcU+h+95cXpZQn4xT/vT4gwCLK7zo2xsamNplgzjh2lYErhNiiFoMSlDIoq1NguQZDl2PhJisZPq9Lzg1v/UNENZ6nBn6fuS4rwSq0T825etQHXaWCmWORCIYtvpvA1T8n4KAbf5NGQ3BYX17K5oS7BytpGRjMXPOAeoKKAKxz42fF7kwIHVtfFExtXtDEx72M0wLHy1LoGR5RiEFBj2yDCv6YzKKBAU9Sl0XU4NTGJb0xaoOex5EtVa+FjAp4+tishcHxVXb3XGl/DxXyBNfWQK87xUa7AZC6PH5gF/OaWZs7MzuNYQlu8hovZec5ncgBDIvQ/ftvLVff/ii0wanZHLMtb3xQnW5ohIjmOj87hGwUYBkaAg09sGU499Xa3Bsan3oWWGod3xyfxjaaBnie2DB+8GnElAQ+ubazBkOXsVIaZfAmgH9jXt/XVdBmW+ohhKlckdT4DMAT09219teKqn3zrm4NPbv3znooCVDVZ48LRc1P4RlNAT/8X/pJaKplRw+EPPwJIh7iqq/7Jm9/YDXQDlQUYY0iNzQKkEL7y1Bf/WnE1xhiAIUVHnr79b1XJf3zkawlgUJBE+dzHPsVGDUbNtFFTlTzE7go0QFVfqYZ7/I2dCaPmgGORMGqumC8TEKSNBnt++qW/VyV/7B87ugINBlVNr9GgGi4Zkic3r65nKWx5EQ4/s23/vkoJv//6nQlB+hB6b4jXsqG5jpEzE0vhPEF2I/Q1x1xubV3B+dk5AjWpqgKe2bZ/TyXyRw51dQnygmtb3ufXtjBVgExRL9cCjxzqSgJdgmwHul3bomNVEw2xOILDB5PjGGN+U573qofR3te2J4A+oLetKcG65pWkZ+YpGWhrcHjj7NkFbNSxWdPQQEtDA3XRRibmYGVNlPcnPmAsM5Me6BxZX9WBJci7gBcituPdvs4jZ4R/Z31c2yXiCIlYLXe2d+AbiLkuRmzmihZ+ECVbtFkfdzg2doKxzMw0sGspjooO7H1t+yDQ2970WW5p3cC57AwlDQjUBwRLLBxxscQOD6EojkQQhEQ0QjZ/kSOj7zBbyKWBXQOdI6mleKo58Cege3T2gtexop22+nbmg0vHsAiAELVtLBEEIWrZFErz/Cdznv3nTjNbyALsA/YMdI5MVyKpWgOL939js8e2dV8mbwIMIIAEBQ6fOwLARG6SQqkIl76Mw8CzA50jaa7S/qcr2eVaiDpRb+eGu1gdb8XXEtncNH9892W4dF6kgVQlqz+RgHI3NjVvYkf7TqZyF/n9yd8x0Dki10K6LAHlbsScmPe51bfx5tjhTyRgoQhFxAVcIBpGLOxrwmc3hAafuSn+3bt/uKknXzp8X/huZ4X8GWAeKAD5sC8APhCoqllwQERswA5FuVXCCcPe8WjHlhu/2vKjX+849C0gAEph+FWiFGKNqupiAUJY3GFYi3qrbGxxAAvXwsthFvWmbEwB1ZD4mmvgerdl/5pdr/ZfxSSIL/GYYpEAAAAldEVYdGRhdGU6Y3JlYXRlADIwMTMtMDQtMDNUMTc6MTg6MDIrMDg6MDDjrwpDAAAAJXRFWHRkYXRlOm1vZGlmeQAyMDEzLTAyLTIxVDEwOjE0OjE2KzA4OjAwAxjOEwAAAE10RVh0c29mdHdhcmUASW1hZ2VNYWdpY2sgNi44LjgtNyBRMTYgeDg2XzY0IDIwMTQtMDItMjggaHR0cDovL3d3dy5pbWFnZW1hZ2ljay5vcmdZpF9/AAAAGHRFWHRUaHVtYjo6RG9jdW1lbnQ6OlBhZ2VzADGn/7svAAAAF3RFWHRUaHVtYjo6SW1hZ2U6OkhlaWdodAAzMij0+PQAAAAWdEVYdFRodW1iOjpJbWFnZTo6V2lkdGgAMzLQWzh5AAAAGXRFWHRUaHVtYjo6TWltZXR5cGUAaW1hZ2UvcG5nP7JWTgAAABd0RVh0VGh1bWI6Ok1UaW1lADEzNjE0MTI4NTa+f5v6AAAAE3RFWHRUaHVtYjo6U2l6ZQAxLjQ2S0JCpIp5rQAAAGJ0RVh0VGh1bWI6OlVSSQBmaWxlOi8vL2hvbWUvZnRwLzE1MjAvZWFzeWljb24uY24vZWFzeWljb24uY24vY2RuLWltZy5lYXN5aWNvbi5jbi9wbmcvMTA5NjYvMTA5NjY4MC5wbmeP5+5zAAAAAElFTkSuQmCC') /*images/refresh.png*/;
                    text-decoration: none;
                }

            .realTimeData th {
                vertical-align: top;
            }

                .realTimeData th div {
                    font-weight: normal;
                }

            .realTimeData th, .realTimeData td {
                border-left: 1px solid #D7E1E1;
            }

            .historyData input[type="text"], .historyPhoto input[type="text"] {
                width: 70px;
            }

            .historyData span, .historyPhoto span {
                padding: 7px;
            }

            .historyData dd, .historyPhoto dd {
                padding: 5px 0 0;
            }
    </style>
</head>
<body>
    <div id="Search__Waiting" style="position: absolute; padding-left: 3px; padding-right: 3px; font-size: 12px; font-family: Arial,Verdana,Tahoma; color: rgb(255, 255, 255); z-index: 300; top: 280px; left: 574.5px; display: none;">
        <img style="width: 30px; height: 30px; border: 0;" src="images/gb/loading.gif" alt="更新" />
        <b></b>
    </div>
    <div id="HeaderDiv">
        <!--header-->
        <div id="header">
            <div class="subNav">
                <span id="divlogin"><a href="javascript:history.back()">返回</a> | <a href="quit.aspx">退出</a></span>
            </div>
            <div class="Logo">
                <h1>上海建设工程颗粒物与噪声在线监控平台</h1>
            </div>
        </div>
    </div>

    <div id="container">
        <form id="form1" runat="server">
            <div class="line-box2"></div>
            <div class="clear"></div>
            <div class="main_sh">
                <div class="constructPanel">
                    <div class="info">
                        <div><span class="label">工 地 名：</span><span id="spanName"></span></div>
                        <div><span class="label">工地地址：</span><span id="spanAddr"></span></div>
                        <div><span class="label">所属区县：</span><span id="spanCountry"></span></div>
                        <div><span class="label">所属街镇：</span><span id="spanStreet"></span></div>
                        <div><span class="label">工地经度：</span><span id="spanLong"></span></div>
                        <div><span class="label">工地维度：</span><span id="spanLant"></span></div>
                        <div><span class="label">所属企业：</span><span id="spanDepart"></span></div>
                        <div><span class="label">占地面积：</span><span id="spanSquare"></span></div>
                        <div><span class="label">开始时间：</span><span id="spanStartTime"></span></div>
                        <div><span class="label">施工进展：</span><span id="spanStage"></span></div>
                        <div><span class="label">联 系 人：</span><span id="spanMan"></span></div>
                        <div><span class="label">联系电话：</span><span id="spanMobile"></span></div>
                    </div>
                    <div class="shortcut">
                        <div><a href="#" id="piclink">查看现场照片 ›</a></div>
                        <div><a href="#" id="picHistory">查看历史照片 ›</a></div>
                        <div><a href="#">查看现场视频 ›</a></div>
                        <div><a href="#">查看工地平面图 ›</a></div>
                    </div>
                </div>
                <div class="diagram">
                    <span>选择数据类型：
  <select id="selDustType">
      <option value="0" selected="selected">颗粒物</option>
      <option value="1">噪声</option>
      <option value="2">PM2.5</option>
      <option value="3">PM10</option>
  </select>
                    </span>
                    <span>选择数据类型：
  <select id="seltype">
      <option value="0" selected="selected">当日小时均值变化</option>
      <option value="1">24小时内均值变化</option>
      <option value="2">一周内均值变化</option>
  </select>
                    </span>
                    <span>
                        <input id="searchInput" type="hidden" />
                        <input type="button" value="点击查看" onclick="changeChart()" style="padding: 5px" />
                    </span>
                    <div>
                        <dl class="realTimeData">
                            <dt>该工地各监测点实时数据<a href="javascript:void(0);" onclick="updateRealTimeData();">&nbsp;</a>
                            </dt>
                            <dd>
                                <table id="tbStat" class="GridTableContent" style="padding: 0; border: 0" width="100%">
                                    <tr class="GTContentTitle">
                                        <td width="72px">监测点</td>
                                        <td width="72px">CPM<br/>(mg/m<sup>3</sup>)</td>
                                        <td width="72px">PM2.5<br/>(mg/m<sup>3</sup>)</td>
                                        <td width="72px">PM10<br/>(mg/m<sup>3</sup>)</td>
                                        <td width="72px">噪声dB(A)</td>
                                        <td width="72px">风向</td>
                                        <td width="72px">风速(m/s)</td>
                                        <td width="72px">温度(℃)</td>
                                        <td width="72px">湿度(%)</td>
                                        <td width="120px">时间</td>
                                    </tr>
                                    <tr>
                                        <td></td>
                                        <td></td>
                                        <td></td>
                                        <td></td>
                                        <td></td>
                                        <td></td>
                                        <td></td>
                                        <td></td>
                                        <td></td>
                                        <td></td>
                                    </tr>
                                </table>
                            </dd>
                        </dl>
                    </div>
                    <div id="LineChart" style="width: 100%; height: 400px; margin-top: 20px">
                    </div>
                </div>
                <div class="clear"></div>
            </div>
        </form>

    </div>
    <div class="clear"></div>

    <div id="FooterDiv" style="margin-top: 100px">
        <div id="bottom">
            <div class="botbox">
                <p style="text-align: center">
                    <span style="margin-right: 30px">上海驿鼎机电工程有限公司</span>
                    <a href="http://www.yidingjd.com/" style="margin-right: 5px">联系我们</a><span style="margin-right: 5px">|</span>
                    <a href="http://www.yidingjd.com/">关于我们</a>
                </p>
            </div>
        </div>
    </div>
</body>
</html>
