<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="MobilePicView.aspx.cs" Inherits="Web.MobilePicView" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <meta http-equiv="content-type" content="text/html; charset=gb2312" />
    <meta name="viewport" content="initial-scale=1.0, user-scalable=no" />
    <link rel="stylesheet" type="text/css" href="css/extra.css" />
    <link rel="stylesheet" type="text/css" href="css/simple.css" />
    <link rel="stylesheet" type="text/css" href="css/table.css" />
    <script src='js/jquery-1.9.1.min.js' type='text/javascript'></script>
    <style type="text/css">
        .btn1 {
            position: absolute;
            line-height: 23px;
            height: 23px;
            font-size: 14px;
            width: 60px;
        }

        .btn2 {
            padding: 5px;
        }
    </style>
    <script type="text/javascript">
        window.onload = init;
        function init() {
            getlist();
        };
        function getlist() {
            var serverip = "121.42.34.0";
            var user = "test";
            var pwd = "123";
            var urlxx = "http://" + serverip + ":2600/bin/getUserAccessDevicesimpleforwebapi?uname=" + user + "&pwd=" + pwd;

            $.ajax({
                type: "get",
                url: urlxx,
                dataType: "jsonp",
                jsonpCallback: "success_jsonpCallback",//自定义的jsonp回调函数名称，默认为jQuery自动生成的随机函数名
                success: function (json) {
                    var r = json[0].resultxx;
                    if (r == "ok") {
                        setupdevlist(json[0].data);
                    }
                    else {
                        alert(json[0].data);
                    }
                    //alert(json[0].did);
                    //alert(json[0].dname);

                },
                error: function () {
                    alert('fail');
                }
            });
            //document.getElementById("WebAPI2").initservice(serverip);
        };
        function setupdevlist(data) {
            var selDevs = $("#selDevs");
            var selDevspic = $("#selDevspic");
            for (var i = 0; i < data.length ; i++) {
                selDevs.append('<option value=' + data[i].did + '>' + data[i].dname + '</option>');
                selDevspic.append('<option value=' + data[i].did + '>' + data[i].dname + '</option>');
            }
        };
        function readpic() {
            getphotolist();
        };
    </script>
</head>
<body>
    <div id="Search__Waiting" style="position: absolute; padding-left: 3px; padding-right: 3px; font-size: 12px; font-family: Arial,Verdana,Tahoma; color: rgb(255, 255, 255); z-index: 300; top: 280px; left: 574.5px; display: none;">
        <img src="images/gb/loading.gif" style="width: 30px; height: 30px; border: 0" />
        <b></b>
    </div>
    <div id="HeaderDiv">
        <!--header-->
        <div id="header">
            <div class="subNav">
                <span id="divlogin"><a href="javascript:history.back()">返回</a> | <a href="quit.aspx">退出</a></span>
            </div>
            <div class="Logo">
                <h1>上海建设工程颗粒物与噪声在线监控平台</h1>
            </div>
        </div>
    </div>
    <form id="form1" runat="server">
        <div class="line-box2"></div>
        <div class="clear"></div>
        <div style="margin-left: 25%; margin-right: 25%; width: 50%;">
            <div>
                <div>
                    <div id="flashContent">
                        <p>
                            To view this page ensure that Adobe Flash Player version 
									11.1.0 or greater is installed. 
                        </p>
                        <script type="text/javascript">
                            var pageHost = ((document.location.protocol == "https:") ? "https://" : "http://");
                            document.write("<a href='http://www.adobe.com/go/getflashplayer'><img src='"
                                            + pageHost + "www.adobe.com/images/shared/download_buttons/get_flash_player.gif' alt='Get Adobe Flash player' /></a>");
                        </script>
                    </div>
                    <noscript>
								<object classid="clsid:D27CDB6E-AE6D-11cf-96B8-444553540000" width="100%" height="100%" id="WebAPI2">
									<param name="movie" value="http://121.42.34.0:2600/webclient_api/WebAPI2.swf" />
									<param name="quality" value="high" />
									<param name="bgcolor" value="#ffffff" />
									<param name="allowScriptAccess" value="always" />
									<param name="allowFullScreen" value="true" />
									<!--[if !IE]>-->
									<object type="application/x-shockwave-flash" data="http://121.42.34.0:2600/webclient_api/WebAPI2.swf" width="100%" height="100%">
										<param name="quality" value="high" />
										<param name="bgcolor" value="#ffffff" />
										<param name="allowScriptAccess" value="always" />
										<param name="allowFullScreen" value="true" />
									<!--<![endif]-->
									<!--[if gte IE 6]>-->
										<p> 
											Either scripts and active content are not permitted to run or Adobe Flash Player version
											11.1.0 or greater is not installed.
										</p>
									<!--<![endif]-->
										<a href="http://www.adobe.com/go/getflashplayer">
											<img src="http://www.adobe.com/images/shared/download_buttons/get_flash_player.gif" alt="Get Adobe Flash Player" />
										</a>
									<!--[if !IE]>-->
									</object>
									<!--<![endif]-->
								</object>
							</noscript>
                </div>
                <div>
                    <span>选择设备：</span>
                    <select id="selDevs"></select>
                    <input type="button" class="btn2" value="获取视频" onclick="getvideo();" />
                    <input type="button" class="btn2" value="关闭视频" onclick="closevideo();" />
                    <input type="button" class="btn2" value="远程调阅" onclick="remote();" />
                    <span>拍照质量：</span>
                    <select id="qua">
                        <option selected="selected" value="0">最好</option>
                        <option value="1">很好</option>
                        <option value="2">较好</option>
                        <option value="3">一般</option>
                        <option value="4">较差</option>
                        <option value="5">最差</option>
                    </select>
                    <span>分辨率：</span>
                    <select id="res">
                        <option selected="selected" value="0">默认</option>
                        <option value="1">D1</option>
                        <option value="2">720P</option>
                        <option value="3">1080P</option>
                        <option value="4">CIF</option>
                        <option value="5">QCIF</option>
                    </select>
                    <input value="连接云台服务器" type="button" style="padding: 5px;" onclick="connect()" />
                </div>
            </div>
            <div style="margin-top: 15px;">
                <%--<span>拍照质量：</span>
                <select id="qua">
                    <option selected="selected" value="0">最好</option>
                    <option value="1">很好</option>
                    <option value="2">较好</option>
                    <option value="3">一般</option>
                    <option value="4">较差</option>
                    <option value="5">最差</option>
                </select>
                <span>分辨率：</span>
                <select id="res">
                    <option selected="selected" value="0">默认</option>
                    <option value="1">D1</option>
                    <option value="2">720P</option>
                    <option value="3">1080P</option>
                    <option value="4">CIF</option>
                    <option value="5">QCIF</option>
                </select>
                <input value="连接云台服务器" type="button" style="padding: 5px;" onclick="connect()" />--%>
            </div>
            <div class="control">
                <input class="controlUpLeft" value="近景" type="button" onclick="near()" />
                <input class="controlUp" value="上" type="button" onclick="up()" />
                <input class="controlUpRight" value="远景" type="button" onclick="far()" />
                <input class="controlDown" value="下" type="button" onclick="down()" />
                <input class="controlLeft" value="左" type="button" onclick="left()" />
                <input class="controlRight" value="右" type="button" onclick="right()" />
                <input class="controlDownLeft" value="焦点调远" type="button" onclick="focus_far()" />
                <input class="controlDownRight" value="焦点调近" type="button" onclick="focus_near()" />
                <input class="controlCapture" value="拍照" type="button" onclick="takepicture();" />
            </div>
            <div>
                <input type="checkbox" id="check1" style="display: none" checked="checked" />
                <input type="checkbox" id="check2" style="display: none" />
                <input type="checkbox" id="check3" style="display: none" />
                <input type="checkbox" id="check4" style="display: none" />
            </div>
        </div>
        <%--        <div style="width: 70%">
            <select id="selDevspic"></select>
            <input type="button" value="查看照片" onclick="readpic()" class="btn2" />
            <div id="picCantiner">
            </div>
        </div>--%>
    </form>
    <script type="text/javascript" src="js/swfobject.js"></script>
    <script type="text/javascript" src="js/FABridge.js"></script>
    <script type="text/javascript" src="js/demojs.js?v1.12"></script>
</body>
</html>
