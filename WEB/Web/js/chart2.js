/**
* related functions in csiteDetail.jsp
* @author ADC
*/
$(function(){
    initCharts();
    setDuration();
    getSpotNums();
    $(".realTimeData a").bind("click",getSample);
    $("#btn_hourly").bind("click",function(){
    getExcel("hour");
    });
    $("#btn_real").bind("click",function(){
    getExcel("real");
    });
    addReport();
});
var type_chart = "today_avg";
var type_data = "dust";
var ind =0;
var idx = 0;
var chart;
var chart2;
function addReport(){
var role_id = $("#roleID").text();
var csite_id = $("#csiteID").text();
var city_id = $("#cityID").text();
var csite_name = $("#csiteName").text();
var con="";
if(role_id == '4'){
con = "<div><a href='./AddReportPre.action?csiteID="+csite_id+"&cityID="+city_id+"&csiteName="+csite_name+"'>添加本月月报 ›</a></div>";
$(".shortcut").append(con);
}
}
/*
* 添加选择日期的插件
*/
function setDuration() {
//$("#start_time_csite,#end_time_csite").calendar();
$("#start_time_csite,#end_time_csite,#start_time_csite_2,#end_time_csite_2").datepicker({
showMonthAfterYear: true, // 月在年之后显示
changeMonth: true, // 允许选择月份
changeYear: true, // 允许选择年份
dateFormat:'yy-mm-dd', // 设置日期格式
closeText:'关闭', // 只有showButtonPanel: true才会显示出来
duration: 'fast',
showAnim:'fadeIn',
showOn:'button', // 在输入框旁边显示按钮触发，默认为：focus。还可以设置为both
//buttonImage: 'images/commons/calendar.gif', // 按钮图标
//buttonImageOnly: true, // 不把图标显示在按钮上，即去掉按钮
buttonText:'选择',
showButtonPanel: true,
showOtherMonths: true
//appendText: '(yyyy-mm-dd)',
});
}
/*初始化统计图表 */
function initCharts() {
    var subtitle;
    var cate;
    var type;
    var text_title;
    var unit,text_unit;
    var renderTo='container_charts';
    if($("#csiteID").text()==143){
    type_data = "noise";
    }
    if(type_data=="dust"){
    text_title = '颗粒物变化情况';
    unit = 'mg/m³';
    text_unit = '浓度 mg/m³';
    }
    else{
    text_title = '噪声指标变化情况';
    unit = 'dB(A)';
    text_unit = '分贝dB(A)';
    }
    if(type_chart=='24h_peak')
    {
    subtitle = '时间：最近24小时 每小时最高值';
    cate = new Array(24);
    }
    else if(type_chart=='24h_avg')
    {
    subtitle = '时间：最近24小时 每小时平均值';
    cate = new Array(24);
    }
    else if(type_chart=='7day_avg')
    {
    subtitle = '时间：最近一周 每日平均值';
    cate = new Array(7);
    }
    else if(type_chart=='7day_peak')
    {
    subtitle = '时间：最近一周 每日最高值';
    cate = new Array(7);
    }
    else if(type_chart=="today_peak")
    {
    subtitle = '时间：当日 每小时最高值';
    cate = new Array(24);
    }
    else if(type_chart=="today_avg")
    {
    subtitle = '时间：当日 每小时平均值';
    cate = new Array(24);
    }
    else if(type_chart=="20min")
    {
    subtitle = '时间：当日 每20分钟平均值';
    cate = new Array(72);
    renderTo = 'con_charts';
    }
    var data = "csiteID=";
    data += $("#csiteID").text();
    data += "&stuff=";
    data += type_data;
    data += "&type=";
    data += type_chart;
    var array;//用于显示图表数据
    var time_array;//存放样本时间信息
    var sid_array;//存放样本ID信息
    var array_info;//每一条目存放某series的名字
    var array_detail;//每一条目包括time与sid
    $.ajax({
    url: "getChart.action",
    data:data,
    success: function(res, textStatus){
    var jData = eval("("+res+")");//转换为json对象
    array = new Array([jData.length]);
    array_info = new Array([jData.length]);
    array_detail = new Array([jData.length]);
    $.each(jData, function(i, item) {
    var name_ = "观测点" + item.spotNum;
    var array_ = new Array([item.array.length]);
    array_info[i] = name_;
    array_detail[i] = {time:item.time_array,sid:item.sid_array};
    $.each(item.array,function(i,index) {
    var obj;
    var tt = index.substr(index.length-2,index.length);
    if(tt=='_R'){
    obj = index.substr(0,index.length-2);
    }
    else{
    obj = index;
    }
    if(obj=="-1")
    array_[i] = null;
    else
    array_[i] = obj*1;
    });
    array[i] = {name:name_,data:array_};
    });
    /*
    * 处理cate上应显示的时间值
    */
    var myDate=new Date();
    if(cate.length==24){
    if(type_chart=="today_peak" || type_chart=="today_avg")
    {
    for(var k=0;k<=23;k++)
    {
    cate[k] = k;
    }
    }
    else
    {
    for(var k=cate.length-1;k>=0;k--)
    {
    cate[k] = String(myDate.getHours());
    myDate.setTime(myDate.getTime()-3600000);
    }
    }
    }
    else if(cate.length==7){
    for(var k=cate.length-1;k>=0;k--)
    {
    cate[k] = (myDate.getMonth()+1)+"-"+myDate.getDate();
    myDate.setTime(myDate.getTime()-86400000);
    }
    }
    else{
    var k;
    for(var i=0;i<cate.length;i++){
    k = parseInt(i/3).toString();
    if(i%3==0)
    cate[i] = k;
    else
    cate[i] = k + ":" + i%3*20;
    }
    }
    chart = new Highcharts.Chart({
    chart: {
    renderTo: renderTo,
    defaultSeriesType: 'line',
    marginRight: 130,
    marginBottom: 25
    },
    title: {
    text: text_title,
    x: -20 //center
    },
    subtitle: {
    text: subtitle,
    x: -20
    },
    xAxis: {
    categories: cate
    },
    yAxis: {
    title: {
    text: text_unit
    },
    plotLines: [{
    value: 0,
    width: 1,
    color: '#808080'
    }]
    },
    tooltip: {
    formatter: function() {
    if(type_chart=='7day_peak' || type_chart=='24h_peak' || type_chart=='today_peak')
    {
    var index2 = indexOf(cate,this.x);
    var tmp = indexOf(array_info,this.series.name);
    time_array = array_detail[tmp].time;
    sid_array = array_detail[tmp].sid;
    return '<b>'+ this.series.name +'</b><br/>'+
    this.x +': '+ this.y + unit + '<br/>' +
    time_array[index2]+'<br/>'+
    '样本编号：'+sid_array[index2];
    }
    else
    {
    var index3 = indexOf(cate,this.x);
    var tmp = indexOf(array_info,this.series.name);
    time_array = array_detail[tmp].time;
    return '<b>'+ this.series.name +'</b><br/>'+
    this.x +': '+ this.y + unit + '<br/>' +
    time_array[index3];
    }
    }
    },
    legend: {
    layout: 'vertical',
    align: 'right',
    verticalAlign: 'top',
    x: -10,
    y: 100,
    borderWidth: 0
    },
    series:array,
    exporting: {
    url : adjustUrl("/export/"),
    filename : "exportchart",
    scale : 4,
    async : true,
    },
    credits: {
    enabled: false
    }
    });
    }
    });
    if(type_chart=="20min" && type_data=="noise"){
    showBg();
    }
    }
    function changeChart(){
    type_chart = $("#sel_chart").val();
    type_data = $("#sel_type").val();
    if(chart!=null)
    chart.destroy();
    initCharts();
    }
    function indexOf(array, data)
    {
    for(var i=0 ; i < array.length; i++)
    if(array[i] === data)
    return i;
    return -1;
    }
    function getExcel(type){
    var time_start = $("#start_time_csite").val();
    var time_end = $("#end_time_csite").val();
    //先根据type判断是否要求时间限制
    if(type=="real" && daysBetween(time_start,time_end)>30){
    alert("您输入的时间段过长，请保证在一个月以内。谢谢。");
    return;
    }
    var data = "csiteID=";
    data += $("#csiteID").text();
    data += "&timeFrom=" + time_start;
    data += "&timeTill=" + time_end;
    data += "&type=" + type;
    var option = {
    url: "getExcel.action",
    data:data,
    success: function(res, textStatus){
    window.location.href = res;
    },
    error: function(res, status){
    alert(status);
    }
    };
    $.ajax(option);
    }
    function getSpotNums()
    {
    var opt;
    $(".first").each(function(i)
    {
    if(i!=0){
    opt = "<option value='" + $(this).text() +"'>"+$(this).text()+"</option>";
    $(opt).appendTo("#select_1");
    $(opt).appendTo("#select_2");
    }
    });
    $("<option value='-1'>所有</option>").appendTo("#select_1");
    $("<option value='-1'>所有</option>").appendTo("#select_2");
}
