<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="QuaterMonitorReport.aspx.cs" Inherits="Web.QuaterMonitorReport" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <script type="text/javascript" src="js/jquery.js"></script>
    <script type="text/javascript" src="js/highchart/standalone-framework.js"></script>
    <script type="text/javascript" src="js/highchart/highcharts.js"></script>
    <script type="text/javascript" src="js/highchart/exporting.js"></script>
    <script type="text/javascript">
        var cityId;
        window.onload = init;
        function init() {
            cityId = window.parent.cityId;
            $("#hiddencityId").val(cityId);
        }
    </script>
    <script language="javascript" type="text/javascript">
        var chart;
        $(document).ready(function() {

             
            chart = new Highcharts.Chart({
                chart: {
                    renderTo: 'container',          //放置图表的容器
                    defaultSeriesType: 'column',    //图表类型line, spline, area, areaspline, column, bar, pie , scatter
                    //zoomType: 'x',                  //放大
                    inverted: false                  //左右显示，默认上下正向
                },
                title: {                            
                    text: '污染物指标报表',        //图标的标题
                    style:{}                        //标题样式
                },
                subtitle: {                         
                    text: '各地区平均值'              //图标的副标题
                },
                xAxis: {                            
                    categories: <%= XAxisCategories %>, //X轴的坐标值
                    labels: {
                        rotation: -45,
                        align: 'right',
                        style: {font: 'normal 13px 宋体'}
                    }
                },
                 yAxis: {
                     min: 0,
                     title: {text: '大小（m/N）'}  //Y轴坐标标题  labels:纵柱标尺
                 },
                 legend: {                               //【图例】位置样式
                     layout: 'horizontal',               //【图例】显示的样式：水平（horizontal）/垂直（vertical）
                     backgroundColor: '#FFFFFF',
                     borderColor: '#CCC',
                     borderWidth: 1,
                     align: 'center',
                     verticalAlign: 'top',
                     enabled:true,
                     //x: 100,
                     y: 50,
                     //floating: true,
                     shadow: true
                 },
                 //loading: {  需要配合chart.showLoading();使用
                 //    hideDuration: 10000,
                 //    showDuration: 10000
                 //},
                 tooltip: {
                     formatter: function() {                 //当鼠标悬置数据点时的格式化提示
                         return '<b>'+ this.x +'</b><br/>'+ this.series.name + ': '+ Highcharts.numberFormat(this.y, 1);
                     }
                 },
                 credits: {
                     enabled: false
                 },
                 plotOptions: {
                     column: {
                         pointPadding: 0.2,  //图表柱形的
                         borderWidth: 0      //图表柱形的粗细 
                         //pointWidth:15    你想显示的宽度(number型）

                     },bar: {
                         dataLabels: {
                             enabled: false
                         }
                     }
                 },
                 series:<%= ReturnValue %>
                });
            
            //chart.showLoading();
        });
    </script>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table>
                <tr>
                    <td>选项数据类型：<asp:DropDownList ID="ddlSelectYear" runat="server">
                    </asp:DropDownList>年<asp:DropDownList ID="ddlSelectQuater" runat="server">
                    </asp:DropDownList>污染类型：<asp:DropDownList ID="ddlPolutionKind" runat="server">
                    </asp:DropDownList><asp:Button ID="btnSubmit" runat="server" Text="提交"
                        OnClick="btnSubmit_Click" /></td>
                    <asp:HiddenField ID="hiddencityId" runat="server" />
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="lblAvgShow" runat="server" Text="Label" Visible="False"></asp:Label>
                    </td>
                </tr>

            </table>
        </div>
        <div>
            <asp:Label ID="lblShowError" runat="server" Text="Label" Visible="False" Font-Size="Larger" ForeColor="Red"></asp:Label>

        </div>
        <div style="text-align: center">
            <table>
                <tr>
                    <td>
                        <asp:GridView ID="gvReportShow" runat="server" BackColor="White" BorderColor="#DEDFDE"
                            BorderStyle="None" BorderWidth="1px" CellPadding="4" Font-Size="11pt" ForeColor="Black"
                            GridLines="Vertical" AutoGenerateColumns="False"
                            EnableModelValidation="True" Width="628px">
                            <Columns>
                                <asp:BoundField DataField="StatName" HeaderText="工程名称" />
                                <asp:BoundField DataField="IndexAVG" DataFormatString="{0:N1}"
                                    HeaderText="平均值" />
                                <asp:BoundField DataField="IndexMin" DataFormatString="{0:N1}"
                                    HeaderText="最小值" />
                                <asp:BoundField DataField="IndexMax" DataFormatString="{0:N1}"
                                    HeaderText="最大值" />
                                <asp:BoundField DataField="ValidDays" HeaderText="有效天数" />
                            </Columns>
                            <FooterStyle BackColor="#CCCC99" />
                            <RowStyle BackColor="#F7F7DE" />
                            <SelectedRowStyle BackColor="#CE5D5A" Font-Bold="True" ForeColor="White" />
                            <PagerStyle BackColor="#F7F7DE" ForeColor="Black" HorizontalAlign="Right" />
                            <HeaderStyle BackColor="#6B696B" Font-Bold="True" ForeColor="White" />
                            <AlternatingRowStyle BackColor="White" />
                        </asp:GridView>
                    </td>
                </tr>
                <tr>
                    <td style="text-align: center">
                        <asp:Button ID="btnOutPutExcel" runat="server" Font-Size="9pt" Text="导入Excel"
                            Style="border-left-color: #3333ff; border-bottom-color: #3333ff; border-top-style: inset; border-top-color: #3333ff; border-right-style: inset; border-left-style: inset; border-right-color: #3333ff; border-bottom-style: inset"
                            OnClick="btnOutPutExcel_Click" /></td>
                </tr>
            </table>


        </div>
        <div id="container" style="min-width: 800px; height: 400px"></div>
    </form>
</body>
</html>
