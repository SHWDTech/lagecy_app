<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="StatAdd.aspx.cs" Inherits="Web.admin.StatAdd" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>�ޱ����ĵ�</title>
    <link rel="stylesheet" type="text/css" href="/css/right.css" />
    <meta http-equiv="Content-Type" content="text/html; charset=gb2312" />
    <script type="text/javascript" src="/My97DatePicker/WdatePicker.js"></script>
    <meta name="viewport" content="initial-scale=1.0, user-scalable=no" />
    <script type="text/javascript" src="http://api.map.baidu.com/api?v=1.4"></script>
    <link type="text/css" rel="stylesheet" href="/css/register.css" />
    <script src="/js/RegisterJS.js?version=20150302" type="text/javascript"></script>
    <script type="text/javascript" src="/js/jquery-1.js"></script>
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
        function OnSubmit() {
            if (statSubmitCheck()) {
                document.getElementById("form1").submit();
            }
        }
    </script>
</head>
<body>
    <form id="form1" runat="server">
        <table width="100%" cellspacing="0" cellpadding="0" border="0">
            <tr>
                <td style="font-weight: bold; background-image: url(/images/title_bg.jpg); height: 28px">
                    <img src="/images/go.gif" />��ǰλ�ã� <span style="font-weight: normal">[ �������� ] </span></td>
            </tr>
            <tr>
                <td bgcolor="#b1ceef" height="1px"></td>
            </tr>
        </table>
        <div>
            <div style="float: left; width: 550px">
                <table width="100%" border="0" cellpadding="1" cellspacing="1">
                    <tr>
                        <td class="STYLE19" width="100px">�����ţ�</td>
                        <td>
                            <asp:TextBox ID="txtStatNo" runat="server" onblur="this.className='frame';checkStatCode();" onfocus="this.className='frameB'"></asp:TextBox>
                            <span style="color: Red">(*)</span> <span>����Ϊ20���ַ����ڵ�Ӣ�Ļ����֡�</span>
                        </td>
                    </tr>
                    <tr id="tr_StatNo" style="position: relative; display: none">
                        <td class="STYLE19"></td>
                        <td id="span_StatNo" style="color: red"></td>
                    </tr>
                    <tr>
                        <td class="STYLE19">�������ƣ�</td>
                        <td>
                            <asp:TextBox ID="txtStatName" runat="server" onblur="this.className='frame';checkStatName();" onfocus="this.className='frameB'"></asp:TextBox>
                            <span style="color: Red">(*)</span> <span>����Ϊ25���ַ����ڵ����ġ�Ӣ�Ļ����֡�</span>
                        </td>
                    </tr>
                    <tr id="tr_StatName" style="position: relative; display: none">
                        <td class="STYLE19"></td>
                        <td id="span_StatName" style="color: red"></td>
                    </tr>
                    <tr>
                        <td class="STYLE19">���ظ����ˣ�</td>
                        <td>
                            <asp:TextBox ID="txtChargeMan" runat="server" onblur="this.className='frame';checkChargeMan();" onfocus="this.className='frameB'"></asp:TextBox>
                            <span style="color: Red">(*)</span> <span>����Ϊ10���ַ����ڵ����ġ�Ӣ�Ļ����֡�</span>
                        </td>
                    </tr>
                    <tr id="tr_ChargeMan" style="position: relative; display: none">
                        <td class="STYLE19"></td>
                        <td id="span_ChargeMan" style="color: red"></td>
                    </tr>
                    <tr>
                        <td class="STYLE19">��ϵ�绰��</td>
                        <td>
                            <asp:TextBox ID="txtPhone" runat="server" onblur="this.className='frame';checkphone();" onfocus="this.className='frameB'"></asp:TextBox>
                            <span style="color: Red">(*)</span> <span>11λ�ֻ����롣</span>
                        </td>
                    </tr>
                    <tr id="tr_phone" style="position: relative; display: none">
                        <td class="STYLE19"></td>
                        <td id="span_phone" style="color: red"></td>
                    </tr>
                    <tr>
                        <td class="STYLE19">ʩ����λ��</td>
                        <td>
                            <asp:TextBox ID="txtDept" runat="server" onblur="this.className='frame';checkDepart();" onfocus="this.className='frameB'"></asp:TextBox>
                            <span style="color: Red">(*)</span> <span>����Ϊ15���ַ����ڵ����ġ�Ӣ�Ļ����֡�</span>
                        </td>
                    </tr>
                    <tr id="tr_Dept" style="position: relative; display: none">
                        <td class="STYLE19"></td>
                        <td id="span_Dept" style="color: red"></td>
                    </tr>
                    <tr>
                        <td class="STYLE19">ʩ����ַ��</td>
                        <td>
                            <asp:TextBox ID="txtAddr" runat="server" onblur="this.className='frame';checkAddr();" onfocus="this.className='frameB'"></asp:TextBox>
                            <span style="color: Red">(*)</span> <span>����Ϊ25���ַ����ڵ����ġ�Ӣ�Ļ����֡�</span>
                        </td>
                    </tr>
                    <tr id="tr_Addr" style="position: relative; display: none">
                        <td class="STYLE19"></td>
                        <td id="span_Addr" style="color: red"></td>
                    </tr>
                    <tr>
                        <td class="STYLE19">�������أ�</td>
                        <td>
                            <asp:DropDownList ID="ddlCountry" runat="server">
                            </asp:DropDownList>
                            <span style="color: Red">(*)</span>
                        </td>
                    </tr>
                    <tr>
                        <td class="STYLE19">�����ֵ���</td>
                        <td>
                            <asp:TextBox ID="txtStreet" runat="server" onblur="this.className='frame';checkStreet();" onfocus="this.className='frameB'"></asp:TextBox>
                            <span style="color: Red">(*)</span> <span>����Ϊ10���ַ����ڵ����ġ�Ӣ�Ļ����֡�</span>
                        </td>
                    </tr>
                    <tr id="tr_Street" style="position: relative; display: none">
                        <td class="STYLE19"></td>
                        <td id="span_Street" style="color: red"></td>
                    </tr>
                    <tr>
                        <td class="STYLE19">ռ�������</td>
                        <td>
                            <asp:TextBox ID="txtSquare" runat="server" onblur="this.className='frame';checkSquare();" onfocus="this.className='frameB'"></asp:TextBox>
                            <span style="color: Red">(*)</span>
                        </td>
                    </tr>
                    <tr id="tr_Square" style="position: relative; display: none">
                        <td class="STYLE19"></td>
                        <td id="span_Square" style="color: red"></td>
                    </tr>
                    <tr>
                        <td class="STYLE19">���̿�ʼʱ�䣺</td>
                        <td>
                            <asp:TextBox ID="txtStartTime" runat="server" onclick="WdatePicker({dateFmt:'yyyy-MM-dd'})" CssClass="Wdate" onblur="this.className='frame';checkStartTime();" onfocus="this.className='frameB'"></asp:TextBox>
                            <span style="color: Red">(*)</span>
                        </td>
                    </tr>
                    <tr id="tr_StartTime" style="position: relative; display: none">
                        <td class="STYLE19"></td>
                        <td id="span_StartTime" style="color: red"></td>
                    </tr>
                    <tr>
                        <td class="STYLE19">ʩ����չ��</td>
                        <td>
                            <asp:DropDownList ID="ddlStage" runat="server">
                                <asp:ListItem Value="0">����</asp:ListItem>
                                <asp:ListItem Value="1">�ṹ</asp:ListItem>
                                <asp:ListItem Value="2">�깤</asp:ListItem>
                            </asp:DropDownList>
                            <span style="color: Red">(*)</span>
                        </td>
                    </tr>
                    <tr>
                        <td class="STYLE19">��γ�ȣ�</td>
                        <td>
                            <asp:TextBox ID="txtLocation" runat="server" onblur="this.className='frame';checkLocation();" onfocus="this.className='frameB'"></asp:TextBox>
                            <span style="color: Red">(*)</span><span>ֵ��;�Ÿ����������ҷ���ͼ��ֱ�ӵ�����á�</span></td>
                    </tr>
                    <tr id="tr_Location" style="position: relative; display: none">
                        <td class="STYLE19"></td>
                        <td id="span_Location" style="color: red"></td>
                    </tr>
                    <tr>
                        <td class="STYLE19">ʩ����չ��</td>
                        <td>
                            <asp:DropDownList ID="ddlAlarmType" runat="server"></asp:DropDownList>
                        </td>
                    </tr>
                    <tr>
                        <td class="STYLE19"></td>
                        <td>
                            <input type="button" style="padding: 5px; margin-right: 20px" value="�ύ" onclick="OnSubmit()" />
                            <input type="button" style="padding: 5px; margin-left: 20px" value="����" /></td>
                    </tr>
                </table>
            </div>
            <div style="float: left; margin-left: 10px; width: 500px">
                <div id="container"></div>
            </div>
        </div>
    </form>
</body>
<script type="text/javascript">
    var map = new BMap.Map("container");
    map.centerAndZoom("�Ϻ�", 9);
    map.addControl(new BMap.NavigationControl({ anchor: BMAP_ANCHOR_TOP_RIGHT }));  //���Ͻǣ�������ƽ�ƺ����Ű�ť
    map.enableScrollWheelZoom();    //���ù��ַŴ���С��Ĭ�Ͻ���
    map.enableContinuousZoom();    //���õ�ͼ������ק��Ĭ�Ͻ���
    map.addEventListener("click", function (e) {
        this.clearOverlays();
        this.closeInfoWindow();
        var marker = new BMap.Marker(e.point);        // ������ע
        this.addOverlay(marker);                     // ����ע��ӵ���ͼ��
        document.getElementById("txtLocation").value = e.point.lng.toString() + ";" + e.point.lat.toString();
    });

</script>
</html>
