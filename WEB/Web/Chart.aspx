<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Chart.aspx.cs" Inherits="Web.Chart" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title></title>
    <script type="text/javascript" src="js/highchart/standalone-framework.js"></script>
    <script type="text/javascript" src="js/highchart/highcharts.js"></script>
    <script type="text/javascript">
        function init() {
            var chart = new Highcharts.Chart({
            title: {
                text: 'Monthly Average Temperature',
                x: -20 //center
            },
            subtitle: {
                text: 'Source: WorldClimate.com',
                x: -20
            },
                chart: {
                    renderTo: 'container'
                },

                xAxis: {
                    categories: ['Jan', 'Feb', 'Mar', 'Apr', 'May', 'Jun','Jul', 'Aug', 'Sep', 'Oct', 'Nov', 'Dec']
                },

                series: [{
                    data: [29.9, 71.5, 106.4, 129.2, 144.0, 176.0, 135.6, 148.5, 216.4, 194.1, 95.6, 54.4]
}]

                });

            }
    </script>
</head>
<body onload="init()">
    <form id="form1" runat="server">
    <div id="container" style="min-width:800px;height:400px"></div>
    </form>
</body>
</html>
