<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Cameras.aspx.cs" Inherits="Web.admin.Cameras" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>无标题文档</title>
    <link rel="stylesheet" type="text/css" href="/css/right.css" />
    <meta http-equiv="Content-Type" content="text/html; charset=gb2312" />
    <script type="text/javascript">
        function g(s) {
            return document.getElementById(s);
        }
        function search() {
            var name = g("txtName"); var no = g("txtNo"); var placeno = g("txtPlaceNo"); var localCtrl = g("ddlLocalCtrls").value;
            var str = name + ";" + no + ";" + placeno + ";" + localCtrl;
            if (str !== g("hd_search").value) { g("hd_search").value = str; return true; }
            return false;
        }
    </script>
    <style type="text/css">
        #container {
            width: 400px;
            height: 300px;
        }

        select {
            height: 22px;
            line-height: 22px;
            text-align: center;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <table style="border-spacing: 0; width: 100%; border: 0; padding: 0">
            <tr>
                <td style="font-weight: bold; background-image: url(/images/title_bg.jpg); height: 28px">
                    <img alt="当前位置" src="/images/go.gif" />当前位置： <span style="font-weight: normal">[ 设备 ] </span><a href="DevAdd.aspx"><span style="float: right; margin-right: 20px">
                        <img alt="" src="/images/add.gif" width="10" height="10" />
                        添加</span></a></td>
            </tr>
            <tr>
                <td style="background-color: #b1ceef; height: 1px;"></td>
            </tr>
        </table>
        <input id="hd_search" type="hidden" />
        <table style="width: 100%; border: 0; border-spacing: 1px; padding: 0;">
            <tr>
                <td>检测点编号：<asp:TextBox ID="txtStatCode" runat="server" Style="margin-right: 30px"></asp:TextBox>
                    <asp:Button ID="btnSubmit" runat="server" Text="搜索" CssClass="button" OnClick="OnSubmit" Style="padding: 5px" /></td>
            </tr>
            <tr>
                <td colspan="2">
                    <table style="width: 100%; border: 0; border-spacing: 1px; padding: 0;">
                        <tr>
                            <td width="10%" class="STYLE10">检测点编号</td>
                            <td width="15%" class="STYLE10">设备编号</td>
                            <td width="10%" class="STYLE10">安装时间</td>
                            <td width="10%" class="STYLE10">预计结束时间</td>
                            <td width="10%" class="STYLE10">实际结束时间</td>
                            <td width="10%" class="STYLE10">启动</td>
                            <td width="10%" class="STYLE10">视频地址</td>
                            <td width="10%" class="STYLE10">操作</td>
                        </tr>
                        <asp:Repeater ID="Repeater" runat="server" OnItemCommand="Repeater_ItemCommand" OnItemDataBound="Repeater_ItemDataBound">
                            <HeaderTemplate>
                            </HeaderTemplate>
                            <ItemTemplate>
                                <tr>
                                    <td class="STYLE18"><%#DataBinder.Eval(Container.DataItem, "StatCode")%></td>
                                    <td class="STYLE18"><%#DataBinder.Eval(Container.DataItem, "DevCode")%></td>
                                    <td class="STYLE18"><%#DataBinder.Eval(Container.DataItem, "StartTime", "{0:yyyy-MM-dd}")%></td>
                                    <td class="STYLE18"><%#DataBinder.Eval(Container.DataItem, "PreEndTime", "{0:yyyy-MM-dd}")%></td>
                                    <td class="STYLE18"><%#DataBinder.Eval(Container.DataItem, "EndTime", "{0:yyyy-MM-dd}")%></td>
                                    <td class="STYLE18">
                                        <asp:Literal ID="ltlDevStatus" runat="server"></asp:Literal></td>
                                    <td class="STYLE18"><%#DataBinder.Eval(Container.DataItem, "VideoURL")%></td>
                                    <td class="STYLE18">
                                        <img alt="添加设备" src="/images/del.gif" /><asp:LinkButton ID="lbtnDel" runat="server" CommandName="Del" CommandArgument='<%#DataBinder.Eval(Container.DataItem,"Id")%>'>删除</asp:LinkButton>&nbsp; &nbsp;
                                    </td>
                                </tr>
                            </ItemTemplate>
                            <FooterTemplate>
                            </FooterTemplate>
                        </asp:Repeater>
                    </table>
                </td>
            </tr>
            <tr>
                <td height="30" colspan="2">
                    <table style="width: 100%; border: 0; border-spacing: 0; padding: 0;">
                        <tr>
                            <td width="33%">
                                <div align="left"><span class="STYLE22">&nbsp;&nbsp;共有 <strong>
                                    <asp:Literal ID="labCount" runat="server"></asp:Literal></strong> 条记录，当前第<strong>
                                        <asp:Literal ID="labPageIndex" runat="server"></asp:Literal>/<asp:Literal ID="labPageCount" runat="server"></asp:Literal></strong> 页</span></div>
                            </td>
                            <td width="67%">
                                <table style="width: 312px; border: 0; border-spacing: 0; padding: 0;float: right">
                                    <tr>
                                        <td width="49">
                                            <div align="center">
                                                <asp:ImageButton ID="firstPage" runat="server" ImageUrl="/images/first.gif" OnClick="firstPage_Click" /></div>
                                        </td>
                                        <td width="49">
                                            <div align="center">
                                                <asp:ImageButton ID="prevPage" runat="server" ImageUrl="/images/back.gif" OnClick="prevPage_Click" /></div>
                                        </td>
                                        <td width="49">
                                            <div align="center">
                                                <asp:ImageButton ID="nextPage" runat="server" ImageUrl="/images/next.gif" OnClick="nextPage_Click" /></div>
                                        </td>
                                        <td width="49">
                                            <div align="center">
                                                <asp:ImageButton ID="lastPage" runat="server" ImageUrl="/images/last.gif" OnClick="lastPage_Click" /></div>
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
                </td>
            </tr>
        </table>
    </form>
</body>
</html>

