<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Config.aspx.cs" Inherits="Web.admin.Config" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>无标题文档</title>
    <link rel="stylesheet" type="text/css" href="/css/right.css" />
    <script type="text/javascript" src="/My97DatePicker/WdatePicker.js"></script>
    <script type="text/javascript" src="/js/jquery-1.js"></script>
    <style type="text/css">
        select {
            height: 22px;
            line-height: 22px;
            text-align: center;
        }
    </style>
    <script type="text/javascript">
        var OffSetCpm = <%=OffSetCpm%>;
        var OffSetPlusCpm = <%=OffSetPlusCpm%>;
        var OffSetNoise = <%=OffSetNoise%>;
        var OffSetPlusNoise = <%=OffSetPlusNoise%>;
        function modifyoffset() {
            var offsetcpm = $("#t_offsetcpm").val();
            var offsetpluscpm = $("#t_offsetcpmplus").val();
            var offsetnoise = $("#t_offsetnoise").val();
            var offsetplusnoise = $("#t_offsetnoiseplus").val();
            $.post("/action/Config.ashx", { action: 1, offsetcpm: offsetcpm, offsetpluscpm: offsetpluscpm, offsetnoise: offsetnoise, offsetplusnoise: offsetplusnoise }, function (data) {
                var json = eval("(" + data + ")");
                if (json.success) {
                    alert("修改OFFSET成功。");
                } else {
                    alert(json.error);
                }

            });

        }
        function modifyAlarm() {
            var dustAlarm = $("#DustAlarm").val();
            var dbAlarm = $("#DbAlarm").val();
            var id = $('#ddlAlarmType').val();
            $.post("/action/Config.ashx", { action: 2, dustAlarm: dustAlarm, dbalarm: dbAlarm, ID: id }, function(data) {
                var json = eval("(" + data + ")");
                if (json.success) {
                    alert("修改成功！");
                } else {
                    alert(json.error);
                }
            });
        }
        function alarmUpdate(id) {
            $("#modifyDiv").css('display', '');
            $.post("/action/Config.ashx", { action: 3, id: id }, function(data) {
                var json = eval("(" + data + ")");
                if (json.success) {
                    readAlarmDat(json.data[0], id);
                }
            });
        }

        function readAlarmDat(obj, id) {
            $("#alarmNameModify").val(obj.Name);
            $("#DustAlarmModify").val(obj.DustRange);
            $("#DbAlarmModify").val(obj.DbRange);
            $("#HiddenField1").val(id);
        }
    </script>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table style="width: 100%; border: 0; border-spacing: 0; padding: 0;">
                <tr>
                    <td style="font-weight: bold; background-image: url('data:image/jpeg;base64,/9j/4AAQSkZJRgABAQEASABIAAD/2wBDAAICAgICAgICAgICAgICAwQDAgIDBAUEBAQEBAUGBQUFBQUFBgYHBwgHBwYJCQoKCQkMDAwMDAwMDAwMDAwMDAz/2wBDAQMDAwUEBQkGBgkNCwkLDQ8ODg4ODw8MDAwMDAwMDAwMDAwMDAwMDAwMDAwMDAwMDAwMDAwMDAwMDAwMDAwMDAz/wAARCAAcAAEDAREAAhEBAxEB/8QAFgABAQEAAAAAAAAAAAAAAAAAAwYJ/8QAHBAAAgICAwAAAAAAAAAAAAAAAAMBExRRUlOS/8QAFgEBAQEAAAAAAAAAAAAAAAAAAQQD/8QAFxEBAQEBAAAAAAAAAAAAAAAAABESAf/aAAwDAQACEQMRAD8A3Vvf3N9SU54zohA7F8oGCpLJbsuyg31//9k=') /*/images/title_bg.jpg*/; height: 28px">
                        <img alt="" src="/images/go.gif" />当前位置： <span style="font-weight: normal">[ 参数设置 ] </span></td>
                </tr>
                <tr>
                    <td style="background-color: #b1ceef; height: 1px;"></td>
                </tr>
            </table>
            <div style="margin: 15px;">
                <h2>OffSet设置：</h2>
                <span style="margin-left: 5px">颗粒物系数</span>
                <asp:TextBox ID="t_offsetcpm" runat="server" Width="30px"></asp:TextBox>
                <span style="margin-left: 5px">颗粒物偏移量</span>
                <asp:TextBox ID="t_offsetcpmplus" runat="server" Width="30px"></asp:TextBox>
                <span style="margin-left: 5px">噪音系数</span>
                <asp:TextBox ID="t_offsetnoise" runat="server" Width="30px"></asp:TextBox>
                <span style="margin-left: 5px">噪音偏移量</span>
                <asp:TextBox ID="t_offsetnoiseplus" runat="server" Width="30px"></asp:TextBox>
                <br />
                <input type="button" onclick="modifyoffset()" value="修改OffSet值" style="padding: 5px; margin-top: 15px" />
            </div>
            <div style="margin: 15px">
                <h2>报警类型管理：</h2>
                <table style="width: 45%; border: 0; padding: 0; border-spacing: 0;">
                    <tr>
                        <td width="20%" class="STYLE10">编号</td>
                        <td width="20%" class="STYLE10">名称</td>
                        <td width="20%" class="STYLE10">颗粒物报警值</td>
                        <td width="20%" class="STYLE10">噪音报警值</td>
                        <td width="20%" class="STYLE10">操作</td>
                    </tr>
                    <asp:Repeater ID="Repeater" runat="server" OnItemCommand="Repeater_ItemCommand">
                        <HeaderTemplate>
                        </HeaderTemplate>
                        <ItemTemplate>
                            <tr>
                                <td class="STYLE18"><%#DataBinder.Eval(Container.DataItem, "ID")%></td>
                                <td class="STYLE18"><%#DataBinder.Eval(Container.DataItem, "Name")%></td>
                                <td class="STYLE18"><%#DataBinder.Eval(Container.DataItem, "DustRange")%></td>
                                <td class="STYLE18"><%#DataBinder.Eval(Container.DataItem, "DbRange")%></td>
                                <td class="STYLE18">
                                    <img alt="" src="/images/edit.gif" /><a href="javascript:alarmUpdate(<%#DataBinder.Eval(Container.DataItem,"Id")%>)">更新</a>
                                    <img alt="" src="/images/del.gif" /><asp:LinkButton ID="lbtnDel" runat="server" CommandName="Del" CommandArgument='<%#DataBinder.Eval(Container.DataItem,"Id")%>'>删除</asp:LinkButton>
                                </td>
                            </tr>
                        </ItemTemplate>
                        <FooterTemplate>
                        </FooterTemplate>
                    </asp:Repeater>
                </table>
                <div style="margin-top: 15px; display: none;" id="modifyDiv">
                    <h3>报警类型信息修改：</h3>
                    <span>报警类型：</span>
                    <asp:TextBox runat="server" ID="alarmNameModify" style="width: 100px;"></asp:TextBox>
                    <span style="color: red">*必填</span>
                    <span>颗粒物报警数值：</span>
                    <asp:TextBox runat="server" ID="DustAlarmModify" style="width: 45px;"></asp:TextBox>
                    <span>mg/m³</span>
                    <span>噪音报警数值：</span>
                    <asp:TextBox runat="server" ID="DbAlarmModify" style="width: 30px;"></asp:TextBox>
                    <span>Db</span>
                    <asp:HiddenField ID="HiddenField1" runat="server" />
                    <asp:Button runat="server" style="padding: 5px;" Text="更新" ID="alarmTypeModify" OnClick="alarmTypeModify_Click"/>
                </div>
                <div style="margin-top: 15px;">
                    <h3>报警类型信息添加：</h3>
                    <span>报警类型：</span>
                    <asp:TextBox runat="server" ID="alarmName" style="width: 100px;"></asp:TextBox>
                    <span style="color: red">*必填</span>
                    <span>颗粒物报警数值：</span>
                    <asp:TextBox runat="server" ID="DustAlarm" style="width: 45px;"></asp:TextBox>
                    <span>mg/m³</span>
                    <span>噪音报警数值：</span>
                    <asp:TextBox runat="server" ID="DbAlarm" style="width: 30px;"></asp:TextBox>
                    <span>Db</span>
                    <asp:Button runat="server" style="padding: 5px;" Text="添加" ID="alarmTypeAdd" OnClick="alarmTypeAdd_Click"/>
                </div>
            </div>
        </div>
    </form>
</body>
</html>
