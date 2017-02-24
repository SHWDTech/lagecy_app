<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="map.aspx.cs" Inherits="Web.map" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title></title>
    <meta http-equiv="Content-Type" content="text/html; charset=gb2312" />
    <meta name="viewport" content="initial-scale=1.0, user-scalable=no" />
    <script type="text/javascript" src="http://api.map.baidu.com/api?v=1.4"></script>
    <script type="text/javascript" src="js/zTree/js/jquery-1.4.4.min.js"></script>
    <link rel="stylesheet" href="js/zTree/css/zTreeStyle/zTreeStyle.css" type="text/css" />
<script type="text/javascript" src="js/zTree/js/jquery.ztree.core-3.5.js"></script>
<script type="text/javascript" src="js/zTree/js/jquery.ztree.excheck-3.5.js"></script>
    <script type="text/javascript">
       var sContent = <%= sb.ToString() %>;
       var zNodes =<%= zNodes.ToString() %>;
       var map;
       var localCtrls = new Array();
       var ledCtrls = new Array();
       var icons=new Array();
       icons.push(new BMap.Icon("images/map/gray.png", new BMap.Size(48, 48)));
       icons.push(new BMap.Icon("images/map/blue.png", new BMap.Size(48, 48)));
       icons.push(new BMap.Icon("images/map/green.png", new BMap.Size(48, 48)));
       icons.push(new BMap.Icon("images/map/red.png", new BMap.Size(48, 48)));
       icons.push(new BMap.Icon("images/map/yellow.png", new BMap.Size(48, 48)));
       
       var oldTreeNode ="";
       var setting = {view: {showIcon: false},
			data: {simpleData: {enable: true}},
			callback: {beforeClick: beforeClick,onClick: onClick},
			check: {enable: true }};
		function beforeClick(treeId, treeNode, clickFlag) {
			clickFlag = 1;
			return true;
		}
		function onClick(event, treeId, treeNode, clickFlag) {
			if(treeNode.id==oldTreeNode) return;else oldTreeNode = treeNode.id;
			var type = treeNode.id.substring(0, 1); var nodeId = treeNode.id.substring(1, treeNode.id.length);
			if (type == "N"){
			    setMapCenter(nodeId, type);
            
                $.get("mapservice.aspx", {action: "getMarks", id: nodeId, type: type}, function(data) {
                if (data == "err") { alert("��ʱ�޷���ѯ����ע��Ϣ"); return; }
                map.clearOverlays();localCtrls.length = 0;ledCtrls.length=0;
                localCtrls = eval(data);var len = localCtrls.length;
                for(var i=0; i < len;i++){var point = new BMap.Point(Number(localCtrls[i].Long), Number(localCtrls[i].Lant)); 
                var marker = new BMap.Marker(point,{title:localCtrls[i].name});map.addOverlay(marker);}});
            }
            else if(type=="S")
            {
                var len = localCtrls.length;
                if(len>0)
                {
                    for(var i=0; i < len;i++){if(localCtrls[i].id == parseInt(nodeId)){var point = new BMap.Point(Number(localCtrls[i].Long), Number(localCtrls[i].Lant));map.panTo(point);}} 
                }
                else
                {
                    setMapCenter(nodeId, type);
                }
                
                $.get("mapservice.aspx", {action: "getMarks", id: nodeId, type: type}, function(data) {
                    if (data == "err") { alert("��ʱ�޷���ѯ����ע��Ϣ"); return; }
                    map.clearOverlays(); ledCtrls.length = 0;
                    ledCtrls = eval(data);var len = ledCtrls.length;
                    for(var i=0; i < len;i++){var point = new BMap.Point(Number(ledCtrls[i].Long), Number(ledCtrls[i].Lant)); 
                    var iconIndex = ledCtrls[i].status;
                    var marker = new BMap.Marker(point,{icon:icons[iconIndex],title:ledCtrls[i].name});map.addOverlay(marker);}})
            }
            else if(type=="C")
            {
                var len = ledCtrls.length;
                if(len > 0)
                {
                    for(var i=0; i < len;i++){if(ledCtrls[i].id == parseInt(nodeId)){var point = new BMap.Point(Number(ledCtrls[i].Long), Number(ledCtrls[i].Lant));map.panTo(point);}}
                }
                else
                {
                    setMapCenter(nodeId, type);
                    
                    $.get("mapservice.aspx", {action: "getMarks", id: nodeId, type: type}, function(data) {
                    if (data == "err") { alert("��ʱ�޷���ѯ����ע��Ϣ"); return; }
                    map.clearOverlays(); ledCtrls.length = 0;
                    ledCtrls = eval(data);var len = ledCtrls.length;
                    for(var i=0; i < len;i++){var point = new BMap.Point(Number(ledCtrls[i].Long), Number(ledCtrls[i].Lant)); 
                    var iconIndex = ledCtrls[i].status;
                    var marker = new BMap.Marker(point,{icon:icons[iconIndex],title:ledCtrls[i].name});map.addOverlay(marker);}})
                }
            }
		}
        $(document).ready(function(){
			$.fn.zTree.init($("#treeDemo"), setting, zNodes);
		});

        function setMapCenter(nodeId, type){
            $.get("mapservice.aspx", { action: "center", id: nodeId, type: type}, function(data) {
                if (data == "err") { alert("��ʱ�޷���ѯ����ע��Ϣ"); return; }
                var arr = data.split(';'); var point = new BMap.Point(Number(arr[0]), Number(arr[1])); 
                map.panTo(point);});
        }
        
        function addMark() {
            var size = parseInt($("#size").val());
            var str = ""; for (i = 1; i <= size; i++) { str += $("#select" + i.toString()).val() + ","; }
            if (str.length > 0) str = str.substring(0, str.length - 1);
            $.get("mapservice.aspx", {action:"addMark", name: $("#name").val(), addr: $("#addr").val(), point: $("#point").val(), nodes: str },
            function(data){alert(data)});
        }
</script>
<style type="text/css">
html{height:100%}
body{height:100%;margin:0px;padding:0px;font-size:12px;}
#sidebar {width:240px;float:left;}
#main{margin-left: 240px;height:100%}
#container{width:100%;height:400px}
#info {width:100%;margin:0 auto;}
#MapInfoNav {
    background: url("images/mapinfo_4.png") no-repeat scroll right -68px transparent;
    height: 32px;
    line-height:32px;
    text-align:center;
    font-weight:bold;
    width: 100%;
}
#tools {
    background: url("../images/nav_bj.gif") repeat-x scroll 0 0 transparent;
    height: 32px;
    line-height:32px;
    width: 100%;
    vertical-align:middle;
}
</style>
</head>
<body>
    <form id="form1" runat="server">
    <div id="sidebar"><div id="MapInfoNav">���򵼺�</div><div>
		<ul id="treeDemo" class="ztree"></ul>
	</div></div>
    <div id="main">
        <div id="tools">
            <asp:Literal ID="ltlArea" runat="server"></asp:Literal></div>
        <div id="container"></div>
        <div id="info">��������</div>
    </div>
</form>
</body>
<script type="text/javascript">
//    var sContent =
//"<div style='width:200px,height:400px'><h4 style='margin:0 0 5px 0;padding:2px 0'>��ӱ�ע��</h4>" +
//"<p>���ƣ�<input name='name' type='text'id='name'></p><p></p>" +
//"<p>��ַ��<input name='addr' type='text'id='addr'></p><p><input id='btnSubmit' type='button' value='�ύ' onclick='addMark()'></p><input id='point' name='point' type='hidden' />" +
//"</div>";   
    map = new BMap.Map("container");
    map.centerAndZoom("�Ϻ�", 9);
    map.addControl(new BMap.NavigationControl({ anchor: BMAP_ANCHOR_TOP_RIGHT }));  //���Ͻǣ�������ƽ�ƺ����Ű�ť
    map.enableScrollWheelZoom();    //���ù��ַŴ���С��Ĭ�Ͻ���
    map.enableContinuousZoom();    //���õ�ͼ������ק��Ĭ�Ͻ���
    var infoWindow = new BMap.InfoWindow(sContent);  // ������Ϣ���ڶ���
    infoWindow.enableCloseOnClick(false); 
    var markers;
    map.addEventListener("click", function(e) {
        this.clearOverlays();
        this.closeInfoWindow();
        //var myIcon = new BMap.Icon("images/map/blue.png", new BMap.Size(48, 48));
        var marker = new BMap.Marker(e.point); // ������ע
        this.addOverlay(marker); // ����ע��ӵ���ͼ��
        marker.openInfoWindow(infoWindow); // ����Ϣ����
        document.getElementById("point").value = e.point.lng.toString() + ";" + e.point.lat.toString();
        markers = marker;
    });

</script>
</html>
