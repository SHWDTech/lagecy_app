<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Analysis.aspx.cs" Inherits="Web.Analysis" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title></title>
    <link rel="stylesheet" type="text/css" href="css/simple.css" />
    <script type="text/javascript" src="js/url.js"></script>
    <script type="text/javascript" src="js/jquery-1.js"></script>
    <script type="text/javascript" src="My97DatePicker/WdatePicker.js"></script>
    <script type="text/javascript">
        var pages;
        var cityId = "";
        $(function() {
            var request = GetUrlRequest();
            cityId = request["cityId"];
            pages = [
                { id: 1, href: "SiteList.aspx?cityId=" + cityId }, { id: 2, href: "DustAvgRank.aspx?cityId=" + cityId }, { id: 3, href: "DustDistrict.aspx?cityId=" + cityId },{id: 4, href: "AlarmRank.aspx?cityId="}
            ];
            setIFrame();
            $(".divAys dd a").click(function(event) {
                var elem = event.target;
                var href = elem.href || '';
                href = href.replace(/(&|\?)cityId=[0-9]*/gi, "");
                href += (href.indexOf('?')>=0) ? "&" : "?";
                elem.href = href +"cityId=" + cityId;
            });
        });

        var iframeId = <%=IframeId %>;
       
        function setIFrame() { 
            var pageId=parseInt(iframeId);
            for(var i=0; i<pages.length;i++){
                if(pages[i].id===pageId)
                {
                    document.getElementById("ifrRight").src=pages[i].href;
                    break;
                }
            }
        }
        function iFrameHeight(obj) {
            if (obj == null) return;
            var ifm = obj.name;
            var leftH = document.getElementById("divleft").offsetHeight;
            var subWeb = document.frames ? document.frames[ifm].document : obj.contentDocument;
            if (subWeb != null) { 
                obj.height = leftH > subWeb.body.scrollHeight?leftH +"px": subWeb.body.scrollHeight+ "px";
            }
        }
    </script>
</head>
<body>
<div id="Search__Waiting" style="position: absolute; padding-left: 3px; padding-right: 3px; font-size: 12px; font-family: Arial,Verdana,Tahoma; color: rgb(255, 255, 255); z-index: 300; top: 280px; left: 574.5px; display: none;">
<img alt="" style="width: 30px; height: 30px; border: 0;"src="images/gb/loading.gif" />
<b> </b>
</div>
<div id="HeaderDiv">
<!--header-->
<div id="header">
    <div class="subNav"><span id="divlogin"><a href="javascript:history.back()">返回</a> | <a href="quit.aspx">退出</a></span>
    </div>
    <div class="Logo"><h1>上海建设工程颗粒物与噪声在线监控平台</h1>
    </div>    
</div>
</div>

<div id="container">
    <form id="form1" runat="server" action="#" method="post" autocomplete="off">
<div class="line-box2"> </div>
<div class="clear"></div>

<div class="main_sh">
    <div id="divleft" class="sh_left">
       <div class="leftlist">         
            <div class="wx_jsframe_jiao">
               <strong>查询导出</strong>
         </div>
         <div class="leftlist_1">
         <dl class="divAys">
              <dd><span><a href="SiteList.aspx" target="ifrRight">各工程当前情况</a></span></dd>
               <dd><span><a href="DustAvgRank.aspx" target="ifrRight">本区县污染物均值排名情况</a></span></dd>
               <dd ><span><a href="DustDistrict.aspx" target="ifrRight">本区县整体污染物变化情况</a></span></dd>
               <dd><span><a href="StatDustHistroy.aspx" target="ifrRight">各工程历史污染物变化情况</a></span></dd>
               <dd><span><a href="ProjectCompare.aspx" target="ifrRight">按工期进行综合对比</a></span></dd> 
		    
		    </dl> 
		    </div>
		</div>
		<div class="leftlist" style="margin-top:20px">
	     <div class="wx_jsframe_jiao">
               <strong>统计分析</strong>
         </div>
         <div class="leftlist_1">
         <dl class="divAys">
              <dd><span><a href="MonthMonitorReport.aspx" target="ifrRight">本区县颗粒物平均浓度月报表</a></span></dd>
               <dd><span><a href="QuaterMonitorReport.aspx" target="ifrRight">本区县颗粒物平均浓度季度报表</a></span></dd>
               <dd ><span><a href="YearMonitorReport.aspx" target="ifrRight">本区县颗粒物平均浓度年报表</a></span></dd>
		    </dl> 
		    </div>
		</div>
		<div class="leftlist" style="margin-top:20px">    
		 <div class="wx_jsframe_jiao">
               <strong>综合评价</strong>
         </div>
         <div class="leftlist_1">
         <dl class="divAys">
              <dd><span><a href="AlarmRank.aspx" target="ifrRight">当前标准下超标率前五名监测点</a></span></dd>
               <dd><span><a href="AlarmDistrict.aspx" target="ifrRight">本区县整体超标情况变化趋势</a></span></dd>
		    </dl> 
		    </div>
	</div>
        <!-- star add similar,relevant -->
  </div>
    <div class="sh_mid">
        <iframe id="ifrRight" name="ifrRight" width="800px" height="100%" src="SiteList.aspx" style="border: 0" scrolling="no" onload="iFrameHeight(this)">
        </iframe>
    </div>
</div>
    </form>
</div>

<div class="clear"></div>

<div id="FooterDiv"  style="margin-top:100px">
 <div id="bottom"><div class="botbox">
 <p style="text-align: center"><span style="margin-right: 30px">上海驿鼎机电工程有限公司</span>
	<a href="http://www.yidingjd.com/" style="margin-right: 5px">联系我们</a><span style="margin-right: 5px">|</span>
	<a href="http://www.yidingjd.com/">关于我们</a>
 </p>
  </div></div></div>
</body>
</html>
