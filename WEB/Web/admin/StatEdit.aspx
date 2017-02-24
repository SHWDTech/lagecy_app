<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="StatEdit.aspx.cs" Inherits="Web.admin.StatEdit" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>�ޱ����ĵ�</title>
    <link rel="stylesheet" type="text/css" href="/css/right.css" />
    <meta http-equiv="Content-Type" content="text/html; charset=gb2312" />
    <script type="text/javascript" src="/My97DatePicker/WdatePicker.js"></script>
    <meta name="viewport" content="initial-scale=1.0, user-scalable=no" />
    <script type="text/javascript" src="/js/jquery-1.js"></script>
    <script type="text/javascript" src="http://api.map.baidu.com/api?v=1.4"></script>
    <style type="text/css">
        #container {
            width: 100%;
            height: 400px;
        }

        select {
            height: 22px;
            line-height: 22px;
            text-align: center;
        }
    </style>
    <script type="text/javascript">
        var TaskId;
        var maxtimeoutTimes;
        var timeID;
        var Result;
        function RequestCmd(cmdtype, cmdbyte, params, callback) {
            var dev = $('#ddlDevs').val();
            $.get("/action/Cmd.ashx", { action: 1, cmdType: cmdtype, cmdByte: cmdbyte, cmdParam: params, dev: dev, _t: new Date().getTime() }, function (data) {
                var json = eval("(" + data + ")");
                if (json.success) {
                    TaskId = json.data[0].task;
                    callback(true);
                } else {
                    callback(false);
                }
            });
        };

        function StartRequset(cmdtype, cmdbyte, params) {
            RequestCmd(cmdtype, cmdbyte, params, function (addcmd) {
                if (addcmd) {
                    maxtimeoutTimes = 0;
                    chackResponse();
                    $("#gpsResult").empty();
                    $("#gpsResult").append("����У����γ�ȣ������ĵȴ���");
                }
            });

        };

        function chackResponse() {
            ResponseCmd(TaskId, function (getcmd) {
                if (getcmd) {
                    UpdateData(Result);
                } else {
                    if (maxtimeoutTimes < 20)
                        timeID = setTimeout(function () { chackResponse(); }, 3000);
                }

            });
            maxtimeoutTimes++;
        };

        function ResponseCmd(taskId, callback) {
            $.get("/action/Cmd.ashx", { action: 2, task: taskId, _t: new Date().getTime() }, function (data) {
                var json = eval("(" + data + ")");
                if (json.success) {
                    Result = json.data[0];
                    callback(true);
                }
                else {
                    callback(false);
                }
            });
        };

        function UpdateData(obj) {
            if (obj.coordinate === "null") {
                $("#gpsResult").empty();
                $("#gpsResult").append("��ȡGPS��Ϣʧ�ܣ������ԣ�");
                return;
            }
            $("#txtLocation").val(obj.coordinate);
            $("#gpsResult").empty();
            $("#gpsResult").append("��γ��У���ɹ���");
        }
    </script>
</head>
<body>
    <form id="form1" runat="server">
        <table style="border: 0; padding: 0; border-spacing: 0; width: 100%;">
            <tr>
                <td style="font-weight: bold; background-image: url('data:image/jpeg;base64,/9j/4AAQSkZJRgABAQEASABIAAD/2wBDAAICAgICAgICAgICAgICAwQDAgIDBAUEBAQEBAUGBQUFBQUFBgYHBwgHBwYJCQoKCQkMDAwMDAwMDAwMDAwMDAz/2wBDAQMDAwUEBQkGBgkNCwkLDQ8ODg4ODw8MDAwMDAwMDAwMDAwMDAwMDAwMDAwMDAwMDAwMDAwMDAwMDAwMDAwMDAz/wAARCAAcAAEDAREAAhEBAxEB/8QAFgABAQEAAAAAAAAAAAAAAAAAAwYJ/8QAHBAAAgICAwAAAAAAAAAAAAAAAAMBExRRUlOS/8QAFgEBAQEAAAAAAAAAAAAAAAAAAQQD/8QAFxEBAQEBAAAAAAAAAAAAAAAAABESAf/aAAwDAQACEQMRAD8A3Vvf3N9SU54zohA7F8oGCpLJbsuyg31//9k=') /*/images/title_bg.jpg*/; height: 28px">
                    <img alt="" src="/images/go.gif" />��ǰλ�ã� <span style="font-weight: normal">[ �༭���� ] </span></td>
            </tr>
            <tr>
                <td style="background-color: #b1ceef; height: 1px;"></td>
            </tr>
        </table>
        <div>
            <div style="float: left; width: 350px">
                <table style="border: 0; padding: 0; border-spacing: 0;">
                    <tr>
                        <td class="STYLE19" width="72px">�����ţ�</td>
                        <td>
                            <asp:TextBox ID="txtNo" runat="server"></asp:TextBox></td>
                    </tr>
                    <tr>
                        <td class="STYLE19">�������ƣ�</td>
                        <td>
                            <asp:TextBox ID="txtName" runat="server" ReadOnly="true"></asp:TextBox></td>
                    </tr>
                    <tr>
                        <td class="STYLE19">���ظ����ˣ�</td>
                        <td>
                            <asp:TextBox ID="txtChargeMan" runat="server"></asp:TextBox></td>
                    </tr>
                    <tr>
                        <td class="STYLE19">��ϵ�绰��</td>
                        <td>
                            <asp:TextBox ID="txtMobile" runat="server"></asp:TextBox></td>
                    </tr>
                    <tr>
                        <td class="STYLE19">ʩ����λ��</td>
                        <td>
                            <asp:TextBox ID="txtDept" runat="server"></asp:TextBox></td>
                    </tr>
                    <tr>
                        <td class="STYLE19">ʩ����ַ��</td>
                        <td>
                            <asp:TextBox ID="txtAddr" runat="server"></asp:TextBox></td>
                    </tr>
                    <tr>
                        <td class="STYLE19">�������أ�</td>
                        <td>
                            <asp:DropDownList ID="ddlCountry" runat="server">
                            </asp:DropDownList>
                        </td>
                    </tr>
                    <tr>
                        <td class="STYLE19">��������</td>
                        <td>
                            <asp:TextBox ID="txtStreet" runat="server"></asp:TextBox></td>
                    </tr>
                    <tr>
                        <td class="STYLE19">ռ�������</td>
                        <td>
                            <asp:TextBox ID="txtSquare" runat="server"></asp:TextBox></td>
                    </tr>
                    <tr>
                        <td class="STYLE19">���̿�ʼʱ�䣺</td>
                        <td>
                            <asp:TextBox ID="txtStartTime" runat="server" onclick="WdatePicker({dateFmt:'yyyy-MM-dd'})" CssClass="Wdate"></asp:TextBox></td>
                    </tr>
                    <tr>
                        <td class="STYLE19">ʩ����չ��</td>
                        <td>
                            <asp:DropDownList ID="ddlStage" runat="server">
                                <asp:ListItem Value="0">����</asp:ListItem>
                                <asp:ListItem Value="1">�ṹ</asp:ListItem>
                                <asp:ListItem Value="2">�깤</asp:ListItem>
                            </asp:DropDownList></td>
                    </tr>
                    <tr>
                        <td class="STYLE19">��γ�ȣ�</td>
                        <td>
                            <asp:TextBox ID="txtLocation" runat="server"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td class="STYLE19"></td>
                        <td>
                            <asp:DropDownList ID="ddlDevs" runat="server">
                            </asp:DropDownList>
                            <span id="gpsResult" style="color: red"></span>
                        </td>
                    </tr>
                    <tr>
                        <td class="STYLE19">�������ͣ�</td>
                        <td>
                            <asp:DropDownList ID="ddlAlarmType" runat="server">
                            </asp:DropDownList></td>
                    </tr>
                    <tr style="height: 32px;">
                        <td class="STYLE19">
                            <asp:Button ID="btnSubmit" runat="server" Text="�ύ" Style="padding: 5px" CssClass="button" OnClick="OnSubmit" />
                        </td>
                        <td>
                            <input id="btnReset" type="button" value="����" style="padding: 5px; margin-left: 30px;" onclick="reset();" />
                            <input id="btnGetGps" type="button" value="��ȡ��γ��" style="padding: 5px; margin-left: 30px;" onclick="StartRequset(251, 47, '')" />
                        </td>
                    </tr>
                </table>
                <asp:HiddenField ID="HiddenId" runat="server" />
            </div>
            <div style="float: left; margin-left: 10px; width: 800px">
                <div id="container"></div>
            </div>
        </div>
    </form>
</body>
<script type="text/javascript">
    var map = new BMap.Map("container");
    var str = document.getElementById("txtLocation").value.split(';');
    var point = new BMap.Point(Number(str[0]), Number(str[1]));
    map.centerAndZoom(point, 20);
    var marker = new BMap.Marker(point);
    map.addOverlay(marker);
    //map.addControl(new BMap.NavigationControl({ anchor: BMAP_ANCHOR_TOP_RIGHT }));  //���Ͻǣ�������ƽ�ƺ����Ű�ť
    map.enableScrollWheelZoom();    //���ù��ַŴ���С��Ĭ�Ͻ���
    map.enableContinuousZoom();    //���õ�ͼ������ק��Ĭ�Ͻ���
    map.addEventListener("click", function (e) {
        this.clearOverlays();
        this.closeInfoWindow();
        var marker = new window.BMap.Marker(e.point);        // ������ע
        this.addOverlay(marker);                     // ����ע��ӵ���ͼ��
        document.getElementById("txtLocation").value = e.point.lng.toString() + ";" + e.point.lat.toString();
    });

</script>
</html>
