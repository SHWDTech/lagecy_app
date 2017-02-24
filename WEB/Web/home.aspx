<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="home.aspx.cs" Inherits="Web.Home" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <meta http-equiv="content-type" content="text/html; charset=gb2312" />
    <meta name="viewport" content="initial-scale=1.0, user-scalable=no" />
    <link rel="stylesheet" type="text/css" href="css/simple.css" />
    <link rel="stylesheet" type="text/css" href="css/table.css" />
    <style type="text/css">
        #mapContainer {
            width: 100%;
            height: 500px;
            margin: 0;
        }

        #info {
            width: 100%;
            margin: 0 auto;
        }

        a:link {
            color: blue;
            text-decoration: underline;
        }
    </style>
    <script type="text/javascript" src="js/url.js"></script>
    <script type="text/javascript" src="js/jquery-1.js"></script>
    <script type="text/javascript" src="My97DatePicker/WdatePicker.js"></script>
    <script type="text/javascript" src="js/table.js"></script>
    <script type="text/javascript">
        window.onload = init;
        function iFrameHeight(obj) {
            if (obj == null) return;
            var ifm = obj.name;
            var subWeb = document.frames ? document.frames[ifm].document : obj.contentDocument;
            if (subWeb != null) {
                obj.height = subWeb.body.scrollHeight + "px";
            }
        }

        var cityId = "";
        function init() {
            var request = GetUrlRequest();
            cityId = request["cityId"];
            mapload();
            $("#divAys dd a").click(function () {
                $(this).attr("href", $(this).attr("href") + "&cityId=" + cityId);
            });
        }
        function mapload() {//�첽����
            var load = document.createElement("script");
            load.src = "http://api.map.baidu.com/api?v=1.4&callback=map_init";
            document.body.appendChild(load);
        }

        var map = null;
        var points = new Array();
        function map_init() {
            map = new BMap.Map("mapContainer");
            map.centerAndZoom("�Ϻ�", 12);
            //            map.addControl(new BMap.NavigationControl({ anchor: BMAP_ANCHOR_TOP_RIGHT }));  //���Ͻǣ�������ƽ�ƺ����Ű�ť
            map.enableScrollWheelZoom();    //���ù��ַŴ���С��Ĭ�Ͻ���
            map.enableContinuousZoom();    //���õ�ͼ������ק��Ĭ�Ͻ���

            LoadStats(cityId);
        }

        function addPoint(obj) {
            var point = new BMap.Point(Number(obj.Long), Number(obj.Lant));
            points.push(point);
            var marker = new BMap.Marker(point);
            map.addOverlay(marker);
            var label = new BMap.Label(obj.Name, { offset: new BMap.Size(20, 0) });
            marker.setLabel(label);
            var info = createInfoWin(obj.Id);
            var id = obj.Id;
            marker.addEventListener("click", function () { this.openInfoWindow(info); setInfoWin(id); activeLabel(this.getLabel()); });
        }

        var statDatas = null;
        var esDatas = null;
        function LoadStats(cityId) {
            $.get("action/Stat.ashx", { action: 1, cityId: cityId }, function (data) {
                var json = eval("(" + data + ")");
                if (!json.success) return;
                if (json.totalCount != "0") {
                    statDatas = json.data;
                    setMarkers(json.data);
                    setTableData(json.data);
                }
            });
        }
        function LoadESMin(id) {
            $.get("action/Stat.ashx", { action: 2, id: id }, function (data) {
                var json = eval("(" + data + ")");
                if (json.success) {
                    data = json.data[0];
                    updateInfoWIn(data);
                }
            });
        }
        function GetStatData(id) {
            var data = null;
            for (var i = 0; i < statDatas.length; i++) {
                if (statDatas[i].Id == id) {
                    data = statDatas[i];
                    break;
                }
            }
            return data;
        }
        var statObj;
        function setInfoWin(id) {
            statObj = GetStatData(id);
            LoadESMin(id);
            return;
        }

        function updateInfoWIn(data) {
            var cmp = data != null ? data.CMP : "--";
            var noise = data != null ? data.Noise : "--";
            var time = data != null ? data.Time : "--";
            $("#txtMan").html("��ϵ�ˣ�" + statObj.Man);
            $("#txtMobile").html("��ϵ��ʽ��" + statObj.Mobile);
            $("#txtStage").html("���̽��ȣ�" + statObj.Stage);
            $("#txtCMP").html("������Ũ�ȣ�" + cmp + "(mg/m3)");
            $("#txtNoise").html("����ֵ��" + noise + "dB(A)");
            $("#txtTime").html("����ʱ�䣺" + time);
        }
        function createInfoWin(id) {
            var content = "<div style='width:200px; height:150px'>" +
                "<p id=\"txtMan\"></p>" +
                "<p id=\"txtMobile\"></p>" +
                "<p id=\"txtStage\"></p>" +
                "<p id=\"txtCMP\"></p>" +
                "<p id=\"txtNoise\"></p>" +
                "<p id=\"txtTime\"></p>" +
                "<a href=\"StatDetail.aspx?sid=" + id + "&cityId=" + cityId + "\" style='float:right;padding-top:10px'/>����>></a>" +
                "</div>";
            return new BMap.InfoWindow(content);
        }

        var clickedLable = null;
        function activeLabel(label) {
            if (clickedLable != label) {
                label.setStyle({ color: "green" });
                if (clickedLable != null) clickedLable.setStyle({ color: "black" });
                clickedLable = label;
            }
        }
        function setMapCenter(nodeId, type) {
            map.setViewport(points);
        }

        function setMarkers(items) {
            points.length = 0;
            for (var i = 0; i < items.length; i++) {
                addPoint({ Long: items[i].Long, Lant: items[i].Lant, Name: items[i].Name, Id: items[i].Id });
            }
            map.setViewport(points);
        }
        var tbStat = null;

        function setTableData(items) {
            if (tbStat == null) tbStat = new TableCtrl("tbStat");
            if (tbStat == null) return;
            tbStat.reset();

            var content = new Array();
            for (var i = 0; i < items.length; i++) {
                content.length = 0;
                var str = "<a href=\"StatDetail.aspx?sid=" + items[i].Id + "&cityId=" + cityId + "\" />" + items[i].Name + "</a>";
                content.push(str);
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
    <div id="Search__Waiting" style="position: absolute; padding-left: 3px; padding-right: 3px; font-size: 12px; font-family: Arial,Verdana,Tahoma; color: rgb(255, 255, 255); z-index: 300; top: 280px; left: 574.5px; display: none;">
        <img align="middle" src="images/gb/loading.gif" style="width: 30px; height: 30px; border: 0" />
        <b></b>
    </div>
    <div id="HeaderDiv">
        <!--header-->
        <div id="header">
            <div class="subNav">
                <span id="divlogin"><a href="javascript:history.back()">����</a> | <a href="quit.aspx">�˳�</a></span>
            </div>
            <div class="Logo">
                <h1>�Ϻ����蹤�̿��������������߼��ƽ̨</h1>
            </div>
        </div>
    </div>

    <div id="container">
        <form id="form1" runat="server" action="#" method="post" autocomplete="off">
            <div class="line-box2"></div>
            <div class="clear"></div>

            <div class="main_sh">
                <div class="sh_left">
                    <div class="leftlist">
                        <div class="wx_jsframe_jiao">
                            <strong>ʵʱ����</strong>
                        </div>
                        <div class="leftlist_1" style="height: 100px">
                            <asp:Label ID="alarmCMP" runat="server"></asp:Label>
                            <br />
                            <asp:Label ID="alarmDB" runat="server"></asp:Label>
                            <br />
                            <asp:Label ID="alarmTotal" runat="server"></asp:Label>
                        </div>
                    </div>
                    <div class="leftlist" style="margin-top: 20px">
                        <div class="wx_jsframe_jiao">
                            <strong>ͳ�Ʒ���</strong>
                        </div>
                        <div class="leftlist_1">
                            <dl id="divAys">
                                <dd><span><a href="Analysis.aspx?id=1">�����ص�ǰ���</a></span></dd>
                                <dd><span><a href="Analysis.aspx?id=2">������ǰ�������վ</a></span></dd>
                                <dd><span><a href="Analysis.aspx?id=3">�����ؿ����ﳬ�����</a></span></dd>
                                <dd><span><a href="Analysis.aspx?id=3">��ʷ�����������ͳ��</a></span></dd>
                                <dd><span><a href="Analysis.aspx?id=1">�鿴����>></a></span></dd>
                            </dl>
                        </div>
                    </div>
                    <!-- star add similar,relevant -->
                </div>
                <div class="sh_mid">

                    <div id="searchdiv" class="searchCol">
                        <div class="jsmenu" id="searchmenu">
                            �������ࣺ
    <span><a href="javascript::void()">������</a></span>
                            <span><a href="javascript::void()">����</a></span>
                        </div>
                        <div id="mapContainer"></div>
                        <table id="tbStat" class="GridTableContent" cellspacing="0" cellpadding="0" border="0">
                            <tr class="GTContentTitle">
                                <td width="250px">��������</td>
                                <td width="250px">���̵�ַ</td>
                                <td width="200px">�ܳа���λ</td>
                                <td width="70px">����</td>
                            </tr>
                        </table>
                    </div>
                </div>
            </div>
        </form>
    </div>

    <div class="clear"></div>

    <div id="FooterDiv" style="margin-top: 100px">
        <div id="bottom">
            <div class="botbox">
                <p style="text-align: center">
                    <span style="margin-right: 30px">�Ϻ��䶦���繤�����޹�˾</span>
                    <a href="http://www.yidingjd.com/" style="margin-right: 5px">��ϵ����</a><span style="margin-right: 5px">|</span>
                    <a href="http://www.yidingjd.com/">��������</a>
                </p>
            </div>
        </div>
    </div>
</body>
</html>
