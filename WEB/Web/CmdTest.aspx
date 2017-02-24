<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CmdTest.aspx.cs" Inherits="Web.CmdTest" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title></title>
    <link rel="stylesheet" type="text/css" href="css/right.css"/>
    <script type="text/javascript" src="js/jquery-1.js"></script>
    <script type="text/javascript">
        $("#btnReadCMP").click(function(event) {
            RequestCmd(252, 31, "");
        });

        function RequestCmd(cmdtype, cmdbyte, params) {
            $.get("Cmd.ashx", { type: 1, cmdType: cmdtype, cmdByte: cmdbyte, cmdParam: params }, function(data) {
                var json = eval("(" + data + ")");
                if (json.success) {
                    alert("任务流水号:" + json.data[0].task);
                }
                else {
                    alert(json.error);
                }
            });
        }

        function SetTimeout() {
            setTimeout('ResponseCmd()', 5000, taskId);
        }

        function ResponseCmd(taskId) {
            $.get("Cmd.ashx", { type: 2, task: taskId }, function(data) {
                var json = eval("(" + data + ")");
                if (json.success) {
                    alert("任务流水号:" + taskId +"成功");
                }
                else {
                    alert(json.error);
                }
            });
        }
    </script>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        设备：<asp:DropDownList ID="ddlLocalCtrls" runat="server"></asp:DropDownList>
    </div>
    <div>
        <input id="btnReadCMP" type="button" value="读取CMP"/>
    
    </div>
    <div><asp:Button ID="btnUpdateAES" runat="server" Text="CPM扬尘读取" onclick="OnUpdateAES" /></div><div>  
        <asp:Label ID="lblSearchResult" runat="server" Text=""></asp:Label></div>
        <div><asp:Button ID="btnObjToByte" runat="server" Text="转化" 
                onclick="btnObjToByte_Click" /> </div>
    <div><asp:Button ID="SecUploadNoisy" runat="server" Text="一秒上传噪音" 
            onclick="SecUploadNoisy_Click"  /></div>
            <div>
                <asp:Button ID="btnWinDirection" runat="server" Text="风向" onclick="btnWinDirection_Click" 
             /></div>
              <div>
                <asp:Button ID="btnWinSpeed" runat="server" Text="风速" 
                      onclick="btnWinSpeed_Click"    /></div>
                       <div>
                <asp:Button ID="btnTemHum" runat="server" Text="温湿度" onclick="btnTemHum_Click" 
                        /></div>
                         <div>
                <asp:Button ID="btnAllIndex" runat="server" Text="全部指标" onclick="btnAllIndex_Click" 
                        /></div>
    <div><asp:Button ID="btnHeart" runat="server" Text="CPM周期设定" onclick="btnUpdateHeart_Click" /></div> 
     <div> <asp:Button ID="btnReset" runat="server" Text="CPM停止" onclick="btnReset_Click" /></div>
     <div><asp:Button ID="btnAdjustTime" runat="server" Text="BG测试开始" onclick="btnAdjustTime_Click" /></div>
  <div><asp:Button ID="btnWorkMode" runat="server" Text="BG测试停止"  onclick="btnWorkMode_Click" /></div>
  <div><asp:Button ID="btnClearTimePlan" runat="server" Text="BG测试结果" onclick="btnClearTimePlan_Click" /> </div> 
  <div><asp:Button ID="btnDownloadPhoneNumber" runat="server" Text="SPAN测试开始" onclick="btnDownloadPhoneNumber_Click" /></div>
  <div><asp:Button ID="btnDeletePhoneNumber" runat="server" Text="SPAN测试停止" onclick="btnDeletePhoneNumber_Click" /></div>
  <div><asp:Button ID="btnSelectMSCount" runat="server" Text="SPAN测试结果" onclick="btnSelectMSCount_Click" /></div>
   <div><asp:Button ID="btnQueryMSContent" runat="server" Text="开关量 OUT1 输出控制" onclick="btnQueryMSContent_Click" /></div>
  <div><asp:Button ID="btnDeleteMSContent" runat="server" Text="开关量 OUT2 输出控制"  onclick="btnDeleteMSContent_Click" /> </div> 
  <div><asp:Button ID="btnSelectLocalCtrlAttr" runat="server" Text="主动上传瞬时值-开" onclick="btnSelectLocalCtrlAttr_Click" /></div>  
  <div><asp:Button ID="btnInitialLED" runat="server" Text="主动上传瞬时值-关" onclick="btnInitialLED_Click" /> </div> 
   <div><asp:Button ID="btnDeleteLED" runat="server" Text="读出瞬时值" onclick="btnDeleteLED_Click" /> </div> 
  <div><asp:Button ID="btnSetLight" runat="server" Text="主动上传1秒值-开" onclick="btnSetLight_Click" />  </div>
  <div><asp:Button ID="btnSetFadeTime" runat="server" Text="主动上传1秒值-关" onclick="btnSetFadeTime_Click" /> </div>
 <div> <asp:Button ID="btnSetLEDLight" runat="server" Text="读回1秒值" onclick="btnSetLEDLight_Click" /> </div>  
 <div><asp:Button ID="btnSetLogicGroup" runat="server" Text="设为Z计权" onclick="btnSetLogicGroup_Click" /></div>
 <div><asp:Button ID="btnDeleteLogicGroup" runat="server" Text="设为C计权" onclick="btnDeleteLogicGroup_Click" /></div>
 <div><asp:Button ID="btnSetLEDScene" runat="server" Text="设为A计权" onclick="btnSetLEDScene_Click" /> </div>
 <div><asp:Button ID="btnDeleteLEDScene" runat="server" Text="设为F档"　onclick="btnDeleteLEDScene_Click" /></div>
 <div><asp:Button ID="btnSetLEDPlan" runat="server" Text="设为S档"  onclick="btnSetLEDPlan_Click" /></div>
<div><asp:Button ID="btnDelLEDPlan" runat="server" Text="设为I档"  onclick="btnDelLEDPlan_Click" /></div> 
<div><asp:Button ID="btnLEDMaxLight" runat="server" Text="写入新的灵敏度级" onclick="btnLEDMaxLight_Click" /> </div>
<div><asp:Button ID="btnLEDMinLight" runat="server" Text="读出仪器当前的灵敏度级" onclick="btnLEDMinLight_Click" /></div>
<div><asp:Button ID="btnFaultLight" runat="server" Text="读出仪器的校准结果" onclick="btnFaultLight_Click" /></div>
<div><asp:Button ID="btnResetLED" runat="server" Text="峰值C声级" onclick="btnResetLED_Click" /></div> 
<div><asp:Button ID="btnSetLightParam" runat="server" Text="峰值C声级清零" onclick="btnSetLightParam_Click" />   </div>
<div><asp:Button ID="btnSelectLEDAttr" runat="server" Text="写入设备地址" onclick="btnSelectLEDAttr_Click" /> </div>
<div><asp:Button ID="btnSelectLEDPlan" runat="server" Text="读取实时数据" onclick="btnSelectLEDPlan_Click" /></div>   
<div><asp:Button ID="btnLEDGroup" runat="server" Text="写入设备地址" onclick="btnLEDGroup_Click" /></div>  
<div><asp:Button ID="btnSelectLEDScene" runat="server" Text="读取实时数据"  onclick="btnSelectLEDScene_Click" /> </div>
<div><asp:Button ID="btnUpLEDAlert" runat="server" Text="读取温湿度值" onclick="btnUpLEDAlert_Click" /> </div>


<%--    <div>
    密钥更新命令：<asp:Button ID="Button1" runat="server" Text="校时" onclick="OnAdjustTime" />
    </div>--%>
    </form>
</body>
</html>
