function cfgChart(textTitle, subTitle, textUnit, xCates) {
    var options = {
        chart: {
            renderTo: "LineChart",
            marginRight: 90,
            marginBottom: 25
        },
        title: {
            text: textTitle
        },
        subtitle: {
            text: subTitle
        },
        xAxis: {
            categories: xCates
        },
        yAxis: {
            title: {
                text: textUnit
            }
        },
        legend: {
            layout: "vertical",
            align: "right",
            verticalAlign: "top",
            x: -10,
            y: 30,
            borderWidth: 0
        },
        tooltip: {
            formatter: function () {                 //当鼠标悬置数据点时的格式化提示
                return "<b>" + this.x + "</b><br/>" + this.series.name + ":" + Highcharts.numberFormat(this.y, 1);
            }
        },
        credits: {
            enabled: false
        },
        plotOptions: {
            column: {
                pointPadding: 0.2, //图表柱形的
                borderWidth: 0      //图表柱形的粗细 
                //pointWidth:15    你想显示的宽度(number型）

            }, bar: {
                dataLabels: {
                    enabled: false
                }
            }
        },
        navigation: {
            buttonOptions: { enabled: true }
        },
        exporting: {
            buttons: {
                contextButton: {
                    menuItems: [
                        {
                            text: "打印图片",
                            onclick: function () { this.print(); }
                        },
                        { separator: true },
                        {
                            text: "导出JPEG",
                            onclick: function () {
                                this.exportChart({ type: 'image/jpeg' });
                            }
                        },
                        {
                            text: "导出PNG",
                            onclick: function () {
                                this.exportChart({ type: 'image/png' });
                            }
                        },
                        {
                            text: "导出PDF",
                            onclick: function () {
                                this.exportChart({ type: 'application/pdf' });
                            }
                        }
                    ]
                }
            },
            width: "400px",
            formAttributes: { "accept-charset": "utf-8" },
            url: "/ExportChart.aspx" //将此URL改成自己服务器请求URL即可
        }
    }

    return options;
}

function getXCates(timetype, starttime, endtime) {
    var arr = null;
    var date;
    var hour;
    var i;
    switch (timetype) {
        case "0"://当日每小时
            arr = new Array();
            for (i = 0; i < 23; i++) arr.push(i);
            break;
        case "1"://前24小时
            arr = new Array(24);
            date = new Date();
            hour = date.getHours();
            for (i = arr.length - 1; i >= 0; i--) {
                arr[i] = date.getHours();
                date.setTime(date.getTime() - 3600000);
            }
            break;
        case "2"://前7天
            arr = new Array(7);
            date = new Date();
            hour = date.getHours();
            for (i = arr.length - 1; i >= 0; i--) {
                arr[i] = (date.getMonth() + 1) + "-" + date.getDate();
                date.setTime(date.getTime() - 86400000);
            }
            break;
        case "3"://前若干天
            var str = starttime.replace(/-/g, "/");
            var startdate = new Date(str);
            var str2 = endtime.replace(/-/g, "/");
            var enddate = new Date(str2);
            var days = parseInt(Math.abs(startdate - enddate) / 86400000);
            arr = new Array(days);
            date = new Date();
            for (i = 0; i < days; i++) {
                date.setTime(startdate.getTime() + 86400000 * i);
                arr[i] = date.getFullYear() + "-" + (date.getMonth() + 1) + "-" + date.getDate();
            }
            break;
    }
    return arr;
}
function getTime(timetype) {
    var stime = "", etime = "";
    var date = new Date();
    switch (timetype) {
        case "0"://当日每小时
            etime = formatDate(date, "yyyy-MM-dd hh:mm:ss");
            stime = formatDate(date, "yyyy-MM-dd");
            break;
        case "1"://前24小时
            etime = formatDate(date, "yyyy-MM-dd hh:mm:ss");
            date.setTime(date.getTime() - 86400000);
            stime = formatDate(date, "yyyy-MM-dd hh:mm:ss");
            break;
        case "2"://前7天
            etime = formatDate(date, "yyyy-MM-dd hh:mm:ss");
            date.setTime(date.getTime() - 7 * 86400000);
            stime = formatDate(date, "yyyy-MM-dd hh:mm:ss");
            break;
    }
    return { starttime: stime, endtime: etime };
}
//格式化日期,
function formatDate(date, format) {
    var paddNum = function (num) {
        num += "";
        return num.replace(/^(\d)$/, "0$1");
    }
    //指定格式字符
    var cfg = {
        yyyy: date.getFullYear() //年 :4位
          , yy: date.getFullYear().toString().substring(2)//年 :2位
          , M: date.getMonth() + 1  //月 :如果1位的时候不补0
          , MM: paddNum(date.getMonth() + 1) //月 :如果1位的时候补0
          , d: date.getDate()   //日 :如果1位的时候不补0
          , dd: paddNum(date.getDate())//日 :如果1位的时候补0
          , hh: date.getHours()  //时
          , mm: date.getMinutes() //分
          , ss: date.getSeconds() //秒
    }
    format || (format = "yyyy-MM-dd hh:mm:ss");
    return format.replace(/([a-z])(\1)*/ig, function (m) { return cfg[m]; });
}
function setStatData(timeType, statId, datatime, val, xCates, yCates) {
    var str = datatime.replace(/-/g, "/");
    var date = new Date(str);
    var o;
    switch (timeType) {
        case "0": //当日每小时
        case "1": //前24小时
            o = date.getHours();
            break;
        case "2": //前7天
            o = (date.getMonth() + 1) + "-" + date.getDate();
            break;
        default: // 前若干天
            o = date.getFullYear() + "-" + (date.getMonth() + 1) + "-" + date.getDate();
            break;
    }

    for (var i = 0; i < yCates.length; i++) {
        if (yCates[i] == null) {
            var data = []; for (var j = 0; j < xCates.length; j++) data[j] = 0;
            yCates[i] = { statId: statId, data: data };
        }
        if (yCates[i].statId === statId) {
            for (var k = 0; k < xCates.length; k++) {
                if (xCates[k] === o) {
                    yCates[i].data[k] = val; break;
                }
            }
        }
    }
}