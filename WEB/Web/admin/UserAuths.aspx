<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="UserAuths.aspx.cs" Inherits="Web.UserAuths" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title></title>
    <link rel="stylesheet" type="text/css" href="css/right.css"/>
    <link rel="stylesheet" href="js/zTree/css/zTreeStyle/zTreeStyle.css" type="text/css" />
    <script type="text/javascript" src="js/zTree/js/jquery-1.4.4.min.js"></script>
    <script type="text/javascript" src="js/zTree/js/jquery.ztree.core-3.5.min.js"></script>
    <script type="text/javascript" src="js/zTree/js/jquery.ztree.excheck-3.5.min.js"></script>
    <script type="text/javascript">       
       var AreaTree = null;//区域树
       var CmdTree = null;//命令树
       var zAreaNodes = <%= zAreaNodeStr %>;
       var zCmdNodes = <%= zCmdNodeStr %>;
       var zUserNodes = <%= zUserNodeStr %>;
       var clickedNode;
       var setting = {view: {showIcon: false},
			data: {simpleData: {enable: true}},
			callback: {onClick: onClick,onExpand:onExpand,beforeDblClick: beforeDblClick,onDblClick: OnDblClick},
			check: {enable: true },
			view:{dblClickExpand:false}
	    };

	    function beforeDblClick(treeId, treeNode) {
			if(treeNode == null) return false;
			var type = treeNode.id.substring(0, 1);
			if(type=="N")return true;else return false;
		}
		
		var chkedLEDCtrls = new Array();
		var chkedLogicGroup = new Array();
		function getCheckedChildNodes(pNodes){
		    var nodes = pNodes.children;
		    if (nodes) 
		    {
                for (var i = 0; i < nodes.length; i++) 
                {
                    var type = nodes[i].id.substring(0, 1);
                    if (nodes[i].checked)
                    {
                        if(type == "C")
                        {
                            chkedLEDCtrls.push(nodes[i].id.substring(1, nodes[i].id.length));
                        }
                        else if (type=="G")
                        {
                            chkedLogicGroup.push(nodes[i].id.substring(1, nodes[i].id.length));
                        }
                    }
                    getCheckedChildNodes(nodes[i]);
                }
            }
		}
		function OnDblClick(event, treeId, treeNode) {
		    $("#txtArea").val(treeNode.name);
		    chkedLEDCtrls.length = 0;chkedLogicGroup.length = 0;
		    getCheckedChildNodes(treeNode);
		    $("#HiddenFieldNodeId").val(treeNode.id.substring(1, treeNode.id.length));
		    $("#HiddenFieldLEDCtrl").val(chkedLEDCtrls.join(','));
		    $("#HiddenFieldGroup").val(chkedLogicGroup.join(','));
		    chkedLEDCtrls.length = 0;chkedLogicGroup.length = 0;
		}
		
		var asynLoadNodes= new Array();
		function isLoaded(nodeId){
		    var flag = false;
		    for(var i=0;i < asynLoadNodes.length;i++)
		    {
		        if(asynLoadNodes[i] == nodeId)
		        {
		            flag = true;
		            break;
		        }
		    }
		    return flag;
		}
		function addAsynLoadNodes(nodeId){asynLoadNodes.push(nodeId);}
		function onClick(event, treeId, treeNode, clickFlag) {
            sendCmd(treeNode);
		}
		function onExpand(event, treeId, treeNode){
		    sendCmd(treeNode);
		}
		function sendCmd(treeNode) {
		    if(treeNode==null || treeNode.id==clickedNode) return;else clickedNode = treeNode.id;
			var type = treeNode.id.substring(0, 1); var nodeId = treeNode.id.substring(1, treeNode.id.length);
			if (type == "N"){
                $.ajax({
                    url:"LogicGroupService.aspx",
                    type:'get',
                    data:{action: "loadSubItems", id: nodeId},
                    beforeSend:showLoader,
                    complete:hideLoader,
                    success:function(data){
                        if (data == "err") { alert("查询失败，请稍候重试"); return; }
                        addAsynLoadNodes(nodeId);
                        addSubItems(treeNode, eval(data));
                        AreaTree.expandNode(treeNode, true, false, true);
                    }
                });
            }
            else if(type=="G")
            {
                if(isLoaded(nodeId)) return;
                $.ajax({
                    url:"LogicGroupService.aspx",
                    type:'get',
                    data:{action: "loadSubLEDCtrls", id: nodeId},
                    beforeSend:showLoader,
                    complete:hideLoader,
                    success:function(data){
                        if (data == "err") { alert("查询失败，请稍候重试"); return; }
                        addAsynLoadNodes(nodeId);
                        addSubItems(treeNode, eval(data));
                        AreaTree.expandNode(treeNode, true, false, true);
                    }
                });
            }
		}
		
		function showLoader(){$("#loader").css({display:""});}
		function hideLoader(){$("#loader").css({display:"none"});}
		function addSubItems(treeNode, newNodes){
		    if(AreaTree != null && newNodes.length > 0){
		        AreaTree.addNodes(treeNode, newNodes);
		    }
		}
        $(document).ready(function(){
			AreaTree = $.fn.zTree.init($("#AreaTree"), setting, zAreaNodes);
			CmdTree = $.fn.zTree.init($("#CmdTree"), setting, zCmdNodes);
			UserTree = $.fn.zTree.init($("#UserTree"), setting, zUserNodes);
		});
		function cmdsAll(checked){
		    if(checked && CmdTree!=null){
		        document.getElementById("cmdChkCancel").checked = false;
		        CmdTree.checkAllNodes(true);
		    }
		}
		function cmdsCancel(checked){
		    if(checked && CmdTree!=null){
		        document.getElementById("cmdChkAll").checked = false;
		        CmdTree.checkAllNodes(false);
		    }
		}
		function onSubmit(){
		    if(AreaTree==null || CmdTree==null || UserTree== null)return;
		    var areas="";
		    var logicGroups="";
		    var ledCtrls="";
		    var cmds="";
		    var users="";
		    
		    var nodes = AreaTree.getCheckedNodes(true);    
		    for(var i=0;i<nodes.length;i++)
		    {
		        var type = nodes[i].id.substring(0, 1); 
		        var nodeId = nodes[i].id.substring(1, nodes[i].id.length);
		        if(type=="N")
		        {
		            areas += nodeId + ",";
		        }
		        else if(type=="G")
		        {
		            logicGroups += nodeId + ",";
		        }
		        else if(type=="C")
		        {
		            ledCtrls += nodeId + ",";
		        }
		    }
		   
		    nodes = CmdTree.getCheckedNodes(true);
		    for(var i=0;i<nodes.length;i++)
		    {
		        cmds += nodes[i].id + ",";
		    }
		    
		    nodes = UserTree.getCheckedNodes(true);
		    for(var i=0;i<nodes.length;i++)
		    {
		        users += nodes[i].id + ",";
		    }

	        if(areas.length > 0) areas = areas.substring(0, areas.length - 1);
		    if(logicGroups.length > 0) logicGroups = logicGroups.substring(0, logicGroups.length - 1);
		    if(ledCtrls.length > 0) ledCtrls = ledCtrls.substring(0, ledCtrls.length - 1);
			if(cmds.length > 0) cmds = cmds.substring(0, cmds.length - 1);
		    if(users.length > 0) users = users.substring(0, users.length - 1);        
		    $.ajax({
                url:"UserAuthsService.ashx",
                type:'POST',
                data:{action: "AddAuths", area:areas, logicGroup:logicGroups, ledCtrl:ledCtrls,cmd:cmds,user:users},
                beforeSend:showLoader,
                complete:hideLoader,
                success:function(data){
                    alert(data);
                }
            });
		}
		function showLoader(){$("#loader").css({display:""});}
		function hideLoader(){$("#loader").css({display:"none"});}
    </script>
    <style type="text/css">
#sidebar {width:300px;float:left;}
#cmdbar {width:300px;float:left;}
#userbar{width:120px;float:left;}
.InfoNav{
    background: url("images/mapinfo_4.png") no-repeat scroll right -68px transparent;
    height: 32px;
    line-height:32px;
    text-align:center;
    font-weight:bold;
    width: 100%;
}
#main{margin-left: 720px;height:100%;}
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
<div id="loader" style="display:none;top:50%;left:50%;position:absolute"><img alt="loading..." src="images/loader.gif" /></div>
<table width="100%" cellspacing="0" cellpadding="0" border="0">
  <tr><td style="font-weight:bold;background-image:url(images/title_bg.jpg);height:28px">
  <img src="/images/go.gif"/>当前位置： <span style="font-weight:normal"> [ 用户权限管理 ] </span></td></tr>
  <tr><td bgcolor="#b1ceef" height="1px"></td></tr>
</table>
    <div id="sidebar">
        <div class="InfoNav">区域权限</div>
        <div><ul id="AreaTree" class="ztree"></ul></div>
    </div>
    <div id="cmdbar">
        <div class="InfoNav">命令权限</div>
        <div style="margin:10px"><span><input id="cmdChkAll" type="checkbox"checked onclick="cmdsAll(this.checked)"/>全选</span>
            <span><input id="cmdChkCancel" type="checkbox" onclick="cmdsCancel(this.checked)"/>取消全选</span></div>
        <div><ul id="CmdTree" class="ztree"></ul></div>
    </div>
    <div id="userbar">
        <div class="InfoNav">用户列表</div>
        <div><ul id="UserTree" class="ztree"></ul></div>
    </div>
    <div id="main">
	    <div id="tools"></div>
	    <div>
            <input id="btnUp" type="button" value="更新" onclick="onSubmit();"/>
&nbsp;&nbsp;&nbsp;
        <input id="btnReset" type="reset" value="重置" /></div>
	</div>
</form>
</body>
</html>



