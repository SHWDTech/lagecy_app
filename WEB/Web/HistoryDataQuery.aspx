<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="HistoryDataQuery.aspx.cs" Inherits="Web.HistoryDataQuery" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link rel="stylesheet" type="text/css" href="css/simple.css" />
    <link rel="stylesheet" type="text/css" href="css/table.css" />
    <script type="text/javascript" src="/My97DatePicker/WdatePicker.js"></script>
    <style type="text/css">
        .auto-style1 {
            width: 1041px;
        }

        .auto-style2 {
            height: 21px;
        }
    </style>
    <script type="text/javascript">
        var cityId;
        window.onload = init;
        function init() {
            cityId = window.parent.cityId;
        }
    </script>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table>

                <tr>

                    <td class="auto-style1">厂区：<asp:DropDownList ID="ddlfactory" runat="server">
                    </asp:DropDownList>

                        设备：<asp:DropDownList ID="ddldev" runat="server">
                        </asp:DropDownList>
                        选择查询日期：
                        <asp:DropDownList ID="ddlQueryContent" runat="server">
                        </asp:DropDownList>
                        起始时间：<asp:TextBox ID="txtStartTime" runat="server" onclick="WdatePicker({dateFmt:'yyyy-MM-dd'})" CssClass="Wdate" Width="110px"></asp:TextBox>
                        结束时间：
        <asp:TextBox ID="txtEndTime" runat="server" onclick="WdatePicker({dateFmt:'yyyy-MM-dd'})" CssClass="Wdate" Width="110px"></asp:TextBox><br />
                        <asp:Button
                            ID="btnQuery" runat="server" Text="查询" OnClick="btnQuery_Click" Width="37px" />
                        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
         <asp:Label ID="lblShowError" runat="server" Text="Label" Visible="False" Font-Size="Larger" ForeColor="Red"></asp:Label></td>
                </tr>
                <tr>
                    <td class="auto-style2"></td>
                </tr>
                <tr>
                    <td class="auto-style1">
                        <asp:GridView ID="gvHistoryShow" runat="server" Width="788px"
                            BackColor="White" BorderColor="#DEDFDE"
                            BorderStyle="None" BorderWidth="1px" CellPadding="4" Font-Size="11pt" ForeColor="Black"
                            GridLines="Vertical" AutoGenerateColumns="False"
                            EnableModelValidation="True"
                            AllowPaging="True" OnPageIndexChanging="gvHistoryShow_PageIndexChanging"
                            PageSize="15" Height="369px" AllowSorting="True" OnSorting="gvHistoryShow_Sorting">
                            <FooterStyle BackColor="#CCCC99" />
                            <HeaderStyle BackColor="#6B696B" Font-Bold="True" ForeColor="White" />
                            <PagerStyle BackColor="#F7F7DE" ForeColor="Black" HorizontalAlign="Right" />
                            <RowStyle HorizontalAlign="Center" BackColor="#F7F7DE" />

                            <AlternatingRowStyle BackColor="White" />

                            <Columns>
                                <asp:BoundField DataField="UpdateTime" HeaderText="时间段" SortExpression="UpdateTime">
                                    <ControlStyle Font-Underline="False" />
                                </asp:BoundField>
                                <asp:BoundField DataField="TP" DataFormatString="{0:N1}"
                                    HeaderText="颗粒物" SortExpression="TP">
                                    <ControlStyle Font-Underline="True" />
                                </asp:BoundField>

                                <asp:BoundField DataField="DB" DataFormatString="{0:N1}"
                                    HeaderText="噪音" SortExpression="DB">
                                    <ControlStyle Font-Underline="True" />
                                </asp:BoundField>
                                <asp:BoundField DataField="WindSpeed" DataFormatString="{0:N1}"
                                    HeaderText="风速" SortExpression="WindSpeed">
                                    <ControlStyle Font-Underline="True" />
                                </asp:BoundField>
                                <asp:BoundField DataField="WindDirection" DataFormatString="{0:N1}"
                                    HeaderText="风向" SortExpression="WindDirection">
                                    <ControlStyle Font-Underline="True" />
                                </asp:BoundField>
                                <asp:BoundField DataField="Temperature" DataFormatString="{0:N1}"
                                    HeaderText="温度" SortExpression="Temperature">
                                    <ControlStyle Font-Underline="True" />
                                </asp:BoundField>
                                <asp:BoundField DataField="Humidity" DataFormatString="{0:N1}"
                                    HeaderText="湿度" SortExpression="Humidity">
                                    <ControlStyle Font-Underline="True" />
                                </asp:BoundField>
                            </Columns>
                            <SelectedRowStyle BackColor="#CE5D5A" Font-Bold="True" ForeColor="White" />
                        </asp:GridView>
                    </td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
