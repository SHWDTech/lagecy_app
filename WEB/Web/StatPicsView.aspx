<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="StatPicsView.aspx.cs" Inherits="Web.StatPicsView" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link rel="stylesheet" type="text/css" href="css/simple.css" />
    <script type="text/javascript" src="js/url.js"></script>
    <script type="text/javascript" src="js/jquery-1.js"></script>
    <script type="text/javascript" src="/My97DatePicker/WdatePicker.js"></script>
    <style type="text/css">
        .photoPanel dl {
            float: left;
            margin: 20px 15px;
        }
    </style>
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
        <form id="form1" runat="server" action="#" method="post" autocomplete="off">
            <div class="line-box2"></div>
            <div class="clear"></div>
            <div style="margin-top: 20px;">
                <span style="padding: 5px;">当前工地 -></span>
                <span><%=statName %>|</span>
                <span style="padding: 5px;">选择监测点  ></span>
                <asp:DropDownList ID="ddlDevs" runat="server"></asp:DropDownList>
                <span style="padding: 5px; margin-left: 15px">开始时间</span>
                <asp:TextBox runat="server" ID="startTime" onclick="WdatePicker({dateFmt:'yyyy-MM-dd'})"></asp:TextBox>
                <span style="padding: 5px; margin-left: 15px">结束时间</span>
                <asp:TextBox runat="server" ID="endTime" onclick="WdatePicker({dateFmt:'yyyy-MM-dd'})"></asp:TextBox>
                <asp:Button runat="server" Text="查询" Style="padding: 5px; margin-left: 25px;" ID="btnQuery" OnClick="btnQuery_Click" />
            </div>
            <hr style="margin-top: 15px;" />
            <div class="photoPanel">
                <asp:Repeater ID="Repeater" runat="server">
                    <HeaderTemplate>
                    </HeaderTemplate>
                    <ItemTemplate>
                        <dl>
                            <dd>
                                <a href="<%#DataBinder.Eval(Container.DataItem, "FileName")%>" target="_Blank">
                                    <img alt="" style="width: 240px;" src="<%#DataBinder.Eval(Container.DataItem, "FileName")%>" />
                                </a>
                            </dd>
                            <dd><span>拍摄时间：<%#DataBinder.Eval(Container.DataItem, "AddTime")%></span></dd>
                        </dl>
                    </ItemTemplate>
                    <FooterTemplate>
                    </FooterTemplate>
                </asp:Repeater>
            </div>
            <table style="width: 100%; border: 0; border-spacing: 0; padding: 0;">
                <tr>
                    <td width="33%">
                        <div align="left">
                            <span class="STYLE22">&nbsp;&nbsp;共有 <strong>
                                <asp:Literal ID="labCount" runat="server"></asp:Literal></strong> 条记录，当前第<strong>
                                    <asp:Literal ID="labPageIndex" runat="server"></asp:Literal>/<asp:Literal ID="labPageCount" runat="server"></asp:Literal></strong> 页</span>
                        </div>
                    </td>
                    <td width="67%">
                        <table style="width: 312px; border: 0; border-spacing: 0; padding: 0; float: right">
                            <tr>
                                <td width="49">
                                    <div align="center">
                                        <asp:ImageButton ID="firstPage" runat="server" ImageUrl="/images/first.gif" OnClick="firstPage_Click" />
                                    </div>
                                </td>
                                <td width="49">
                                    <div align="center">
                                        <asp:ImageButton ID="prevPage" runat="server" ImageUrl="/images/back.gif" OnClick="prevPage_Click" />
                                    </div>
                                </td>
                                <td width="49">
                                    <div align="center">
                                        <asp:ImageButton ID="nextPage" runat="server" ImageUrl="/images/next.gif" OnClick="nextPage_Click" />
                                    </div>
                                </td>
                                <td width="49">
                                    <div align="center">
                                        <asp:ImageButton ID="lastPage" runat="server" ImageUrl="/images/last.gif" OnClick="lastPage_Click" />
                                    </div>
                                </td>
                                <td width="37" class="STYLE22">
                                    <div align="center">转到</div>
                                </td>
                                <td width="34">
                                    <div align="center">
                                        <asp:TextBox ID="txtPageIndex" runat="server" CssClass="pageIndex"></asp:TextBox>
                                    </div>
                                </td>
                                <td width="22" class="STYLE22">
                                    <div align="center">页</div>
                                </td>
                                <td width="35">
                                    <asp:ImageButton ID="goPage" runat="server" ImageUrl="/images/page_go.gif" OnClick="goPage_Click" /></td>
                            </tr>
                        </table>
                    </td>
                </tr>
            </table>
            <asp:HiddenField runat="server" ID="HiddenstatId" />
        </form>
    </div>
</body>
</html>
