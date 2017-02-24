<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="map.aspx.cs" Inherits="Web.map" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title></title>
    <meta http-equiv="Content-Type" content="text/html; charset=gb2312" />
    <meta name="viewport" content="initial-scale=1.0, user-scalable=no" />
    <link rel="stylesheet" type="text/css" href="css/right.css"/>
    <link rel="stylesheet" type="text/css" href="css/tab.css"/>
    <link rel="stylesheet" type="text/css" href="css/popWin.css"/>
<%--    <script type="text/javascript" src="http://api.map.baidu.com/api?v=1.4"></script>--%>
    <script type="text/javascript" src="js/zTree/js/jquery-1.4.4.min.js"></script>
    <link rel="stylesheet" href="js/zTree/css/zTreeStyle/zTreeStyle.css" type="text/css" />
<script type="text/javascript" src="js/zTree/js/jquery.ztree.core-3.5.min.js"></script>
<script type="text/javascript" src="js/zTree/js/jquery.ztree.excheck-3.5.min.js"></script>
    <script type="text/javascript">
    function map_load() {//异步调用
        var load = document.createElement("script");
        load.src = "http://api.map.baidu.com/api?v=1.4&callback=map_init";
        document.body.appendChild(load);
    }

    window.onload = map_load;
    var map = null;
    function map_init() {
        map = new BMap.Map("container");
        map.centerAndZoom("上海", 12);
        map.addControl(new BMap.NavigationControl({ anchor: BMAP_ANCHOR_TOP_RIGHT }));  //右上角，仅包含平移和缩放按钮
        map.enableScrollWheelZoom();    //启用滚轮放大缩小，默认禁用
        map.enableContinuousZoom();    //启用地图惯性拖拽，默认禁用
    
       var iconSize = new BMap.Size(48, 48)
       icons.push(new BMap.Icon("images/map/gray.png", iconSize));
       icons.push(new BMap.Icon("images/map/blue.png", iconSize));
       icons.push(new BMap.Icon("images/map/green.png", iconSize));
       icons.push(new BMap.Icon("images/map/red.png", iconSize));
       icons.push(new BMap.Icon("images/map/yellow.png", iconSize));
    }
       var sContent = <%= infoStr %>;
       var zNodes =<%= zNodesStr %>;
       var localCtrls = new Array();
       var ledCtrls = new Array();
       var icons=new Array();
       var points = new Array();
       var oldTreeNode ="";
       var setting = {view: {showIcon: false},
			data: {simpleData: {enable: true}},
			callback: {onClick: onClick, beforeDblClick: beforeDblClick,onDblClick: OnDblClick},
			check: {enable: true },
			view:{dblClickExpand:false}
	    };
	    function beforeDblClick(treeId, treeNode) {
			var type = treeNode.id.substring(0, 1); 
			if(type != "N"){ return false;}else {return true;}
		}
		function OnDblClick(event, treeId, treeNode) {
		    var nodeId = treeNode.id.substring(1, treeNode.id.length);
		    g("hd_search").value = "id=" + nodeId + "&name=" + treeNode.name;
		    openWin1(); 
		}
//		function beforeClick(treeId, treeNode, clickFlag) {
//			clickFlag = 1;
//			return true;
//		}
		
		function onClick(event, treeId, treeNode, clickFlag) {
			//if(treeNode.id==oldTreeNode) return;else oldTreeNode = treeNode.id;
			var type = treeNode.id.substring(0, 1); var nodeId = treeNode.id.substring(1, treeNode.id.length);
			if (type == "N")
			{
                if(treeNode.id!=oldTreeNode)
                {
                    $.get("mapservice.aspx", {action: "getMarks", id: nodeId, type: type}, function(data) {
                    if (data == "err") { alert("暂时无法查询到标注信息"); return; }
                    addLocalCtrls(data);oldTreeNode = treeNode.id;});
                    
                    $.get("mapservice.aspx", {action: "getNavis", id: nodeId, type: type}, function(data) {
                    if (data == "err") { alert("暂时无法查询到标注信息"); return; }
                    SetNavigation(nodeId, data);});   
                }
                else {
                    map.setViewport(points);
                }
            }
            else if(type=="S")
            {
                if(treeNode.id!=oldTreeNode)
                {
                    $.get("mapservice.aspx", {action: "getMarks", id: nodeId, type: type}, function(data) {
                    if (data == "err") { alert("暂时无法查询到标注信息"); return; }
                    addLEDCtrls(data);oldTreeNode = treeNode.id;})
                }
                else
                {
                    map.setViewport(points);
                }
            }
            else if(type=="C")
            {
                if(treeNode.id!=oldTreeNode)
                {
                    //setMapCenter(nodeId, type); 
                    $.get("mapservice.aspx", {action: "getMarks", id: nodeId, type: type}, function(data) {
                    addLEDCtrls(data);oldTreeNode = treeNode.id;})
                }
                else
                {
                    for(var i=0; i < ledCtrls.length;i++)
                    {
                        if(ledCtrls[i].id == parseInt(nodeId))
                        {
                            var point = new BMap.Point(Number(ledCtrls[i].Long), Number(ledCtrls[i].Lant));
                            map.panTo(point);
                            break;
                        }
                     }
                }
            }
		}
		
		//加载树形导航
        $(document).ready(function(){
			$.fn.zTree.init($("#treeDemo"), setting, zNodes);
		});
		
		var subWin1 = ["mapEnergy.aspx","mapAlarms.aspx", "mapStatInfo.aspx"];
		var subWin2 = ["mapLocalEnergy.aspx","mapLocalAlarms.aspx", "mapLocalCtrlStatus.aspx", "mapLocalPlans.aspx"];
		var subWin3 = ["mapLEDEnergy.aspx","mapLEDAlarms.aspx", "mapLEDCtrlStatus.aspx", "mapLEDPlans.aspx"];
        
        function HoverLi(subWinIndex, n, params){
            subWinTabSize = 0;
            var subWin;
            
            switch (subWinIndex)
            {
                case 1:subWin = subWin1;break;
                case 2:subWin = subWin2;break;
                case 3:subWin = subWin3;break;
            }
            for (var i = 1; i <= subWin.length; i++) { g('tb_' + i).className = 'normaltab'; } 
            g('tb_' + n).className = 'hovertab';
            var url = subWin[n - 1] + "?"+ g("hd_search").value;
            g('iframeResult').src = url; index = n;
        }
        
        function showDiv(content){
            var isIE = (document.all) ? true : false;
            var isIE6 = isIE && ([/MSIE (\d)\.0/i.exec(navigator.userAgent)][0][1] == 6);
            var divbg = g("divbg");
            var diveditcontent = g("diveditcontent");
            var divcontent = g("divcontent");
            divbg.style.display = "";
            
            diveditcontent.style.display = "block";
            diveditcontent.style.position = !isIE6 ? "fixed" : "absolute";
            diveditcontent.style.top = diveditcontent.style.left = "50%";
            diveditcontent.style.marginTop = - diveditcontent.offsetHeight / 2 + "px";
            diveditcontent.style.marginLeft = - diveditcontent.offsetWidth / 2 + "px";
            divcontent.innerHTML = content; 
        }
        function openWin1() {
            var _html="<div class='w936'><div id='tb' class='tb_'><ul>"+
              "<li id='tb_1' class='hovertab' onclick='HoverLi(1, 1);'> 能    耗 </li>"+
              "<li id='tb_2' class='normaltab' onclick='HoverLi(1, 2);'> 故    障 </li>"+
              "<li id='tb_3' class='normaltab' onclick='HoverLi(1, 3);'> 基本统计 </li></ul>"+
              "<iframe width='100%' frameborder='0' name='iframeResult' id='iframeResult' scrolling='no'></iframe>"+
            "</div></div>";
            showDiv(_html);
            HoverLi(1, 1);
        }
        function openWin2() { 
            var _html="<div class='w936'><div id='tb' class='tb_'><ul>"+
              "<li id='tb_1' class='hovertab' onclick='HoverLi(2, 1);'> 能    耗 </li>"+
              "<li id='tb_2' class='normaltab' onclick='HoverLi(2, 2);'> 故    障 </li>"+
              "<li id='tb_3' class='normaltab' onclick='HoverLi(2, 3);'> 控制状态 </li>"+
              "<li id='tb_4' class='normaltab' onclick='HoverLi(2, 4);'> 调光计划 </li></ul>"+
              "<iframe width='100%'frameborder='0' name='iframeResult' id='iframeResult' scrolling='no'></iframe>"+
            "</div></div>";
           showDiv(_html);
           HoverLi(2, 1);
        }
        
        function openWin3() {
            var _html="<div class='w936'><div id='tb' class='tb_'><ul>"+
              "<li id='tb_1' class='hovertab' onclick='HoverLi(3, 1);'> 能    耗 </li>"+
              "<li id='tb_2' class='normaltab' onclick='HoverLi(3, 2);'> 故    障 </li>"+
              "<li id='tb_3' class='normaltab' onclick='HoverLi(3, 3);'> 控制状态 </li>"+
              "<li id='tb_4' class='normaltab' onclick='HoverLi(3, 4);'> 调光计划 </li></ul>"+
              "<iframe width='100%' frameborder='0' name='iframeResult' id='iframeResult' scrolling='no'></iframe>"+
            "</div></div>";
            showDiv(_html);
            HoverLi(3, 1);
        }
        

        
        //隐藏窗口
        function Hide() {
            var divbg = g("divbg");
            var diveditcontent = g("diveditcontent");
            var divcontent = g("divcontent");
            divbg.style.display = "none";
            diveditcontent.style.display = "none";
            divcontent.innerHTML = ""; 
        }

        function addLocalCtrls(data)
        {       
            map.clearOverlays();
            localCtrls.length = 0;ledCtrls.length=0;points.length = 0;
            localCtrls = eval(data);var len = localCtrls.length;
            for(var i=0; i < len;i++)
            {
                points.push(new BMap.Point(Number(localCtrls[i].Long), Number(localCtrls[i].Lant)));
                addPoint(localCtrls[i]);
            }
            map.setViewport(points);
        }
        var clickedLable = null;
        function addPoint(obj)
        {
            var point = new BMap.Point(Number(obj.Long), Number(obj.Lant)); 
            var marker = new BMap.Marker(point);
            map.addOverlay(marker);
            var label = new BMap.Label(obj.name,{offset:new BMap.Size(20,0)});
            marker.setLabel(label);
            var info = createInfoWin1(obj);
            marker.addEventListener("click", function(){this.openInfoWindow(info);activeLabel(this.getLabel());});
        }
        function addPoint2(obj)
        {
            var point = new BMap.Point(Number(obj.Long), Number(obj.Lant));
            var marker = new BMap.Marker(point,{icon:icons[obj.status]});
            map.addOverlay(marker);
            var label = new BMap.Label(obj.name,{offset:new BMap.Size(40,0)});
            marker.setLabel(label);
            var info = createInfoWin2(obj);
            marker.addEventListener("click", function(){this.openInfoWindow(info);activeLabel(this.getLabel());});
        }
        function activeLabel(label){
            if (clickedLable != label){label.setStyle({ color : "green"});
            if (clickedLable !=null) clickedLable.setStyle({ color : "black"});
            clickedLable=label;}
        }
        function addLEDCtrls(data){
            map.clearOverlays(); ledCtrls.length = 0;points.length = 0;
            ledCtrls = eval(data);var len = ledCtrls.length;
            for(var i=0; i < len;i++){ 
                points.push(new BMap.Point(Number(ledCtrls[i].Long), Number(ledCtrls[i].Lant)));
                addPoint2(ledCtrls[i]);} //闭包解决
            map.setViewport(points);
        }
        
        
        // 创建信息窗口
		 function createInfoWin1(obj){
		    var stautsStr="";
		    switch(obj.stauts)
		    {   
		        case 1: stautsStr="正常";break;
		        default: stautsStr="--";break;
		    }
		    var content="<div style='width:150px,height:400px'><h4 style='margin:2px'>集中控制器</h4>" +
                "<fieldset><legend>基本属性</legend>" +
                "<p>设备名称："+obj.name+"</p>" + "<p>设备编号："+obj.no.toString()+"</p>" +
                "<p>设备类型：485型</p>" + "<p>工作模式：远程控制</p>" + 
                "<p>设备状态："+stautsStr+"</p>" +
                "</fieldset>" + 
                "<fieldset><legend>统计信息</legend>" +
                "<p>终端数目：2</p>" + "<p>本月能耗：100w</p>" +
                "</fieldset>" + 
                "<fieldset><legend>调光计划</legend>" +
                "当前计划：5月12号-5月14号 18:00 - 20:00 亮度:80" + 
                "</fieldset>" + 
                "<a href='javascript:void(0);'onclick='openWin2();' style='float:right;padding-top:10px'/>更多>></a>"+
                "</div>";
            g("hd_search").value = "id=" + obj.id + "&name=" + obj.name;
		    return new BMap.InfoWindow(content);  
		 }
		
	     function createInfoWin2(obj){
		     var stautsStr="";
		    switch(obj.stauts)
		    {
		        case 1: stautsStr="异常";break;
		        case 2: stautsStr="开";break;
		        case 3: stautsStr="故障";break;
		        case 4: stautsStr="正常";break;
		        default: stautsStr="--";break;
		    }
		    var content="<div style='width:150px,height:400px'><h4 style='margin:2px'>单灯控制器</h4>" +                
                "<fieldset><legend>基本属性</legend>" +
                "<p>设备名称："+obj.name+"</p>" + "<p>设备编号："+obj.no.toString()+"</p>" + "<p>安装编号："+obj.placeNo+"</p>" +
                "<p>最大亮度：100</p>" + "<p>最小亮度：10</p>" + "<p>故障亮度：50</p>" +
                "<p>设备状态："+stautsStr+"</p>" +
                "</fieldset>" + 
                "<fieldset><legend>统计信息</legend>" +
                "<p>本月能耗：100w</p>" +
                "</fieldset>" + 
                "<fieldset><legend>调光计划</legend>" +
                "当前计划：18:00 - 20:00 亮度:80" + 
                "</fieldset>" + 
                "<a href='javascript:void(0);'onclick='openWin3()' style='float:right;padding-top:10px'/>更多>></a>"+
                "</div>";
            g("hd_search").value = "id=" + obj.id + "&name=" + obj.name;
		    return new BMap.InfoWindow(content);  
		 }
		 
		var naviArr = new Array();
		function SetNavigation(nodeId, data)
		{
		    naviArr.length = 0;
		    SetNavigationList("N"+nodeId);
		    var i=1;
		    var size = parseInt(g("size").value);
		    for(i = 1; i <= size; i++)
		    {
		        var obj = g("area" + i.toString());
		        hideOptions(obj)
		        clearOptions(obj);
		    }
		    
		    i = 1;

		    while(naviArr.length>0)
		    {
		        var data = ""; 
		        var pId = naviArr.pop();
		        var selfId = "";
		        for(var j= 0; j<zNodes.length; j++)
		        {
		            if((zNodes[j].id.indexOf('N') >= 0) && (zNodes[j].pId == pId))
		            {
		                selfId = zNodes[j].id.substring(1, zNodes[j].id.length);
                        data +=  zNodes[j].name + "," + selfId +"|";
                    }
		        }
		        var obj = g("area" + i.toString());
		        showOptions(obj);
		        if(data.length > 0)
		        {
		            addOption(obj, data.substring(0, data.length - 1));
		            if (naviArr.length >= 1)
		            {
		                selfId = naviArr[naviArr.length - 1];
		                selOption(obj, selfId.substring(1, selfId.length));
		            }
		        }
		        i++;
		    }
		    if (i > 1)
		    {    
		        var obj = g("area" + (i - 1).toString());
		        selOption(obj, nodeId);
		    }
		}
		
		function SetNavigationList(nodeId)
		{
		    var len = zNodes.length;
		    for(var i= 0; i<len; i++)
		    {
		        if (nodeId == "N0")
		            return;
		            
		        if(zNodes[i].id == nodeId)
		        {
		            naviArr.push(zNodes[i].pId);
		            SetNavigationList(zNodes[i].pId);
		            
		            break;
		        }
		    }
		}
		
		function GetNextSelectOptions(nodeId){
		    var len = zNodes.length;
		    var data = "";
		    for(var i= 0; i<len; i++)
		    {
		        if((zNodes[i].id.indexOf('N') >= 0) && (zNodes[i].pId == nodeId))
		        {
		            var selfId = zNodes[i].id.substring(1, zNodes[i].id.length);
                    data +=  zNodes[i].name + "," + selfId +"|";
		        }
		    }
		    if(data.length > 0)
		        data = data.substring(0, data.length - 1);
		    return data;
		}
		
        function ExpandTree(nodeId, parentNodeId)
        {
            var treeObj = $.fn.zTree.getZTreeObj("treeDemo");
            var node = treeObj.getNodesByParam("id", "N"+nodeId);
            if (node.length > 0)
            {
                var a=treeObj.expandNode(node[0], true, false, true);
            }
        }
        function setMapCenter(nodeId, type){
            $.get("mapservice.aspx", { action: "center", id: nodeId, type: type}, function(data) 
            {
                if (data == "err") { alert("暂时无法查询到标注信息"); return; }
                var arr = data.split(';'); 
                var point = new BMap.Point(Number(arr[0]), Number(arr[1])); 
                map.panTo(point);
             });
        }
        function g(id){return document.getElementById(id);}
        
        function setNextSelect(objIndex)
        {
            var size = parseInt(g("size").value);
            var parentId = g("area" + objIndex.toString()).value;
            var fatherId = 0;
            var obj=null;
            if(objIndex!=1){
                fatherId = g("area" + (objIndex - 1).toString()).value;
            }
            if(parentId != "-1") ExpandTree(parentId, fatherId);
            if (objIndex + 1 <= size){
                var data = GetNextSelectOptions("N" + parentId);
                obj = g("area" + (objIndex + 1).toString());
                if(data.length > 0)
                {
                    showOptions(obj);
                    clearOptions(obj);
                    addOption(obj,data);
                }
                else
                {
                    clearOptions(obj);
                    hideOptions(obj);
                }
            }
            for(var i=objIndex + 2;i <=size; i++){
                obj = g("area" + i.toString());
                clearOptions(obj);
                hideOptions(obj);
            }
        }
        function clearOptions(obj){
            obj.options.length=0;
        }
        function addOption(obj, options){
            var arr = options.split('|');
            
            obj.options.add(new Option("","-1"));
            for(var i = 0; i < arr.length; i++)
            {
                var str = arr[i].split(',');
                obj.options.add(new Option(str[0],str[1]));
            }
        }
        function selOption(obj,nodeId){
            obj.value = nodeId
        }
        
        function hideOptions(obj){
            obj.style.display = 'none';
        }
        function showOptions(obj){
            obj.style.display = '';
        }
        function search(){
        	var size = g("size").value;
        	size = parseInt(size);
        	var nodeId = 0;
        	for(var i = size; i > 0; i--)
        	{
        	    var parentId = g("area" + i.toString()).value;
        	    if((parentId != "-1") && (parentId != ""))
        	    {
                    nodeId = parseInt(parentId);
                    break;
        	    }
        	}
            
            if (nodeId > 0)
            {
                setMapCenter(nodeId, "N");
                $.get("mapservice.aspx", {action: "getMarks", id: nodeId, type: "N"}, function(data) {
                if (data == "err") { alert("暂时无法查询到标注信息"); return; }
                addLocalCtrls(data);});
            }
        }
    </script>
<style type="text/css">
#sidebar {width:240px;float:left;}
#main{margin-left: 240px;height:100%}
#container{width:100%;height:500px;margin:0;}
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
    <div id="sidebar"><div id="MapInfoNav">区域导航</div><div>
		<ul id="treeDemo" class="ztree"></ul>
	</div></div>
    <div id="main">
        <div id="tools">
            <asp:Literal ID="ltlArea" runat="server"></asp:Literal></div>
        <div id="container"></div>
    </div>
<input id="hd_search" type="hidden" />    
<div id="divbg" style="display: none;">
</div>     
<div id="diveditcontent" style="display: none;">
    <div id="divheader"><a href="javascript:void(0);" onclick="Hide();"></a></div>      
    <div id="divcontent"></div>
</div>
</form>
</body>
</html>
