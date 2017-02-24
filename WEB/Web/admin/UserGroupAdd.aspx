<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="UserGroupAdd.aspx.cs" Inherits="Web.UserGroupAdd" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title></title>
    <link rel="stylesheet" type="text/css" href="css/right.css"/>
    <link rel="stylesheet" type="text/css" href="css/popWin.css"/>
        <script type="text/javascript" src="js/zTree/js/jquery-1.4.4.min.js"></script>
    <link rel="stylesheet" href="js/zTree/css/zTreeStyle/zTreeStyle.css" type="text/css" />
<script type="text/javascript" src="js/zTree/js/jquery.ztree.core-3.5.min.js"></script>
<script type="text/javascript" src="js/zTree/js/jquery.ztree.excheck-3.5.min.js"></script>
    <script type="text/javascript">
        function setAuth(){
            if($("input[name='auth']:checked").val()=="rd1"){
                $("#trGroups").hide();
                resetGroupAuth();
            }
            else{
                if($("#hdUG").val() == "0")
                {
                    $.get("UserGroupAdd.ashx", {action: "getGroup"}, function(data) {
                        if (data == "err") return;
                        addUserGroup(data);
                        $("#hdUG").val(1);
                    });
                }
                
                $("#trGroups").show();
            }
            
            return;
        }
        
        function addUserGroup(data){
            var obj = eval("(" + data +")");

            var html = "<select id=\"selUG\" name=\"selUG\" style='margin:5px' onchange=\"changeGroup(this.value)\">";
            html += "<option value=\"-1\">--请选择--</option>";
            for(var i = 0; i < obj.count; i++){
                html += "<option value=\""+obj.items[i].Id+"\">"+obj.items[i].Name+"</option>";
            }
            html +="</select>";
            $("#tdGroups").html(html);
            
        }
        function changeGroup(groupId){
            if(groupId == -1) return;
            $.get("UserGroupAdd.ashx", {action: "getGroupAuth", groupId:groupId}, function(data) {
                if (data == "err") return;
                setGroupAuth(data);
            });
            
            return;
        }
        function setGroupAuth(data){
            var obj = eval("(" + data +")");
            var treeObj = $.fn.zTree.getZTreeObj("tree");
            var nodes = treeObj.getNodes();
            var node = null;
            for(var i = 0; i < obj.count; i++){
                for(var j= 0; j < nodes.length; j++){
                    node = nodes[j];
                    if(node.id == "M" + obj.items[i].Id)
                    {
                        node.checked = true; 
                        treeObj.updateNode(node);
                        break;
                    }
                }
            }
        }
        function resetGroupAuth(){
            var treeObj = $.fn.zTree.getZTreeObj("tree");
            var nodes = treeObj.getNodes();
            var node = null;
            for(var j= 0; j < nodes.length; j++){
                node.checked = false; 
                treeObj.updateNode(node);
            }
        }
        
        var setting = { view: { showIcon: false },
            data: { simpleData: { enable: true} },
            check: { enable: true },
            view: { dblClickExpand: false }
        }; 
        var zNodes =<%= zNodesStr %>;
        $(document).ready(function() {
            $.fn.zTree.init($("#treeDemo"), setting, zNodes);
        });
    </script>
</head>
<body>
<form id="form1" runat="server">
<table width="100%" cellspacing="0" cellpadding="0" border="0">
  <tr><td style="font-weight:bold;background-image:url(/images/title_bg.jpg);height:28px">
  <img src="/images/go.gif"/>当前位置： <span style="font-weight:normal"> [ 添加用户组 ] </span></td></tr>
  <tr><td bgcolor="#b1ceef" height="1px"></td></tr>
</table>
<table width="100%" border="0" cellpadding="1" cellspacing="1" bgcolor="#F2F6FB">    
    <tr><td class="STYLE19" width="64px">组名：</td><td><asp:TextBox ID="txtName" runat="server"></asp:TextBox>
        </td></tr>
    <tr><td class="STYLE19">描述：</td><td><asp:TextBox ID="txtDescription" runat="server"></asp:TextBox>
        </td></tr>
    <tr><td class="STYLE19">排序：</td><td><asp:TextBox ID="txtOrder" runat="server"></asp:TextBox>
        </td></tr>
    <tr><td class="STYLE19">权限：</td><td>
        <input id="rtbn1" type="radio" name="auth" onclick="setAuth();" checked="checked" value="rd1"/>重新分配  
        <input id="rtbn2" type="radio" name="auth" onclick="setAuth();" value="rd2"/>拷贝已有组
        <input id="hdUG" type="hidden" value="0" />
        </td></tr>
    <tr id="trGroups" style="display:none"><td class="STYLE19">组名：</td><td id="tdGroups"></td></tr>
    <tr id="trModule"><td class="STYLE19">模块：</td><td><div><ul id="treeDemo" class="ztree"></ul></div></td></tr>
    <tr><td class="STYLE19"></td><td><asp:Button ID="btnAdd" runat="server" Text="新增" onclick="btnAdd_Click"/>
&nbsp;&nbsp;&nbsp;
        <asp:Button ID="btnReset" runat="server" Text="重置" onclick="btnReset_Click" /></td></tr>
</table>
</form>
</body>
</html>



