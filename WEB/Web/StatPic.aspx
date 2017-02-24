<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="StatPic.aspx.cs" Inherits="Web.StatPic" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>查看现场照片</title>
    <link rel="stylesheet" type="text/css" href="css/simple.css" />
    <link rel="stylesheet" type="text/css" href="css/extra.css" />
    <script type="text/javascript" src="js/url.js"></script>
    <script type="text/javascript" src="js/jquery-1.js"></script>
    <script type="text/javascript" src="js/SitePhoto.js"></script>
    <script type="text/javascript">
        window.onload = init;
        function init() {
            var request = GetUrlRequest();
            var sid = request["sid"];
            var link = "StatPicsView.aspx?sid=" + sid;
            $("#hisPhoto").attr('href', link);
        }
    </script>
</head>
<body>
    <div id="Search__Waiting" style="position: absolute; padding-left: 3px; padding-right: 3px; font-size: 12px; font-family: Arial,Verdana,Tahoma; color: rgb(255, 255, 255); z-index: 300; top: 280px; left: 574.5px; display: none;">
        <img alt="" style="width: 30px; height: 30px; border: 0;" src="images/gb/loading.gif" />
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
    <div id="container">
        <form id="form1" runat="server">
            <div class="line-box2"></div>
            <div class="clear"></div>
            <div class="photoFrame" id="spot1">
                <div class="photoDev"><%=statName %> - <%=DevName %></div>
                <div id="photoTime"></div>
                <div>
                    <div class="photo">
                        <img alt="" id="photo" />
                    </div>
                    <div class="control">
                        <asp:HiddenField ID="devId" runat="server" />
                        <asp:HiddenField ID="devCode" runat="server" />
                        <input class="controlUpLeft" value="左上" type="button" />
                        <input class="controlUp" value="上" type="button" />
                        <input class="controlUpRight" value="右上" type="button" />
                        <input class="controlDown" value="下" type="button" />
                        <input class="controlLeft" value="左" type="button" />
                        <input class="controlRight" value="右" type="button" />
                        <input class="controlDownLeft" value="左下" type="button" />
                        <input class="controlDownRight" value="右下" type="button" />
                        <input class="controlCapture" value="拍照" type="button" />
                        <asp:DropDownList runat="server" ID="controlPreset"></asp:DropDownList>
                        <a style="position:absolute;top:60px;left:240px;font-size:16px;" id="hisPhoto"><span>查看历史照片。</span></a>
                    </div>
                </div>
            </div>
        </form>
    </div>
</body>
</html>
