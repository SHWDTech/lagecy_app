<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="UserInGroup.aspx.cs" Inherits="Web.UserInGroup" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title></title>
    <link rel="stylesheet" type="text/css" href="css/right.css"/>
    <script language="javascript" type="text/jscript">
        function g(s) {
            return document.getElementById(s);
        }
        function copyToList(from, to)
        {
            fromList = eval('document.forms[0].' + from);
            toList = eval('document.forms[0].' + to);
            if (toList.options.length > 0 && toList.options[0].value == 'temp') {
                toList.options.length = 0;
            }
            var sel = false;
            for (i = 0; i < fromList.options.length; i++) {
                var current = fromList.options[i];
                if (current.selected) {
                    sel = true;
                    if (current.value == 'temp') {
                        alert('不能选择这个用户!');
                        return;
                    }
                    txt = current.text;
                    val = current.value;
                    toList.options[toList.length] = new Option(txt, val);
                    fromList.options[i] = null;
                    i--;
                }
            }
            if (!sel) alert('未选择任何用户!');
        }

        function allSelect() 
        {
            List = document.forms[0].RoleList;
            if (List.length && List.options[0].value == 'temp') return;
            for (i = 0; i < List.length; i++) {
                List.options[i].selected = true;
            }
        }

        function getdata() {
            var List = document.forms[0].RoleList;
            var roles = g("TUserList");
            roles.value = "";
            var s = "";
            if (List.length != 0) {
                for (i = 0; i < List.length; i++) {
                    s += List.options[i].value + ",";
                }
            }

            roles.value = s;
        }
    </script>
</head>
<body>
<form id="form1" runat="server">
<table width="100%" cellspacing="0" cellpadding="0" border="0">
  <tr><td style="font-weight:bold;background-image:url(/images/title_bg.jpg);height:28px">
  <img src="/images/go.gif"/>当前位置： <span style="font-weight:normal"> [ 用户分组管理 ] </span><span style="float:right;margin-right:20px"><img src="images/add.gif" width="10" height="10" onclick="window.location.href='UserAdd.aspx'"/> 添加</span></td></tr>
  <tr><td bgcolor="#b1ceef" height="1px"></td></tr>
</table>
<table width="100%" border="0" cellpadding="1" cellspacing="1" bgcolor="#F2F6FB">    
    <tr><td class="STYLE19" width="64px">&nbsp;用户组：</td><td>
        <asp:DropDownList ID="ddlGroup" runat="server" AutoPostBack="True"
            onselectedindexchanged="ddlGroup_SelectedIndexChanged">
        </asp:DropDownList>
        </td></tr>
  <tr><td colspan="2">
  <table width="500" height="100%" border="0" cellpadding="0" cellspacing="1" bgcolor="#CCCCCC">
                <tr><td width="200" height="30" bgcolor="#CCCCCC">
                        <div align="center">
                            用户</div>
                    </td>
                    <td width="100" bgcolor="#CCCCCC">
                        <div align="center" style="color: #FFFFFF;">
                        </div>
                    </td>
                    <td width="200" bgcolor="#CCCCCC">
                        <div align="center">
                            组用户列表</div>
                    </td>
                </tr>
                <tr>
                    <td bgcolor="#FFFFFF">
                        <div align="center" style="margin: 10px;">
                            <asp:ListBox ID="UserList" runat="server" Style="width: 160px;" SelectionMode="Multiple"
                                Height="205px"></asp:ListBox>
                            <asp:TextBox ID="OldUserList" runat="server" Style="display: none;"></asp:TextBox>
                            <asp:TextBox ID="TUserList" runat="server" Style="display: none;"></asp:TextBox>
                        </div>
                    </td>
                    <td bgcolor="#FFFFFF">
                        <div align="center">
                            <input id="btn_plus" type="button" value="   <<   " onclick="javascript:copyToList('FromGroupList','UserList')" /><br />
                            <br />
                            <input id="btn_subtract" type="button" value="   >>   " onclick="javascript:copyToList('UserList','FromGroupList')" /><br />
                            <br />
                            <asp:Button ID="btn_saverole" runat="server" Text=" 保 存 " OnClick="btn_saverole_Click" /><br />
                            <br />
                            按下CTRL鍵<br />
                            可以多選
                        </div>
                    </td>
                    <td bgcolor="#FFFFFF">
                        <div align="center" style="margin: 10px;">
                            <asp:ListBox ID="FromGroupList" runat="server" Style="width: 160px;" SelectionMode="Multiple"
                                Height="205px"></asp:ListBox>
                        </div>
                    </td>
                </tr>
      <asp:HiddenField ID="HiddenField1" runat="server" />
            </table>
     </td>	
   </tr>
   
  </table>
</form>
</body>
</html>



