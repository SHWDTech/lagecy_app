<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="User.aspx.cs" Inherits="Web.admin.User" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link rel="stylesheet" type="text/css" href="/css/right.css" />
</head>
<body>
    <form id="form1" runat="server">
        <table style="width: 100%; border-spacing: 0; border: 0; padding: 0;">
            <tr>
                <td style="font-weight: bold; background-image: url(/images/title_bg.jpg); height: 28px">
                    <img src="/images/go.gif" />当前位置： <span style="font-weight: normal">[ 用户管理 ] </span><a href="UserAdd.aspx"><span style="float: right; margin-right: 20px">
                        <img src="/images/add.gif" width="10" height="10" />
                        添加</span></a></td>
            </tr>
            <tr>
                <td style="background-color: #b1ceef; height: 1px;"></td>
            </tr>
        </table>
        <table style="width: 100%; border: 0; border-spacing: 1px; padding: 0; background-color: #F2F6FB;">
            <tr>
                <td>&nbsp;用户名：<asp:TextBox ID="txtUserName" runat="server" Style="margin-right: 30px"></asp:TextBox>
                    <asp:Button ID="btnSubmit" runat="server" Text="搜索" CssClass="button" OnClick="OnSubmit" Style="padding: 5px" />
                </td>
            </tr>
            <tr>
                <td colspan="2">
                    <table style="width: 100%; border: 0; border-spacing: 1px; padding: 0;">
                        <tr>
                            <td width="5%" class="STYLE10">
                                <input id="chbAll" type="checkbox" /></td>
                            <td width="10%" class="STYLE10">用户名</td>
                            <td width="10%" class="STYLE10">角色</td>
                            <td width="15%" class="STYLE10">注册时间</td>
                            <td width="15%" class="STYLE10">最后登录时间</td>
                            <td width="15%" class="STYLE10">区县</td>
                            <td width="8%" class="STYLE10">状态</td>
                            <td width="22%" class="STYLE10">操作</td>
                        </tr>
                        <asp:Repeater ID="Repeater" runat="server" OnItemCommand="Repeater_ItemCommand" OnItemDataBound="Repeater_ItemDataBound">
                            <HeaderTemplate>
                            </HeaderTemplate>
                            <ItemTemplate>
                                <tr>
                                    <td class="STYLE18">
                                        <asp:CheckBox ID="chb" runat="server" /></td>
                                    <td class="STYLE18"><%#DataBinder.Eval(Container.DataItem, "UserName")%></td>
                                    <td class="STYLE18">
                                        <asp:Literal ID="ltlRole" runat="server"></asp:Literal></td>
                                    <td class="STYLE18"><%#DataBinder.Eval(Container.DataItem, "RegTime")%></td>
                                    <td class="STYLE18"><%#DataBinder.Eval(Container.DataItem, "LastTime")%></td>
                                    <td class="STYLE18">
                                        <asp:Literal ID="ltlCountry" runat="server"></asp:Literal></td>
                                    <td class="STYLE18">
                                        <asp:Literal ID="ltlStatus" runat="server"></asp:Literal></td>
                                    <td class="STYLE18">
                                        <img src="/images/edit.gif" /><asp:LinkButton ID="lbtnLock" runat="server" CommandName="Lock" CommandArgument='<%#DataBinder.Eval(Container.DataItem,"UserId")%>'>锁定</asp:LinkButton>
                                        <asp:LinkButton ID="lbtnPass" runat="server" CommandName="Pass" CommandArgument='<%#DataBinder.Eval(Container.DataItem,"UserId")%>'>审核通过</asp:LinkButton>
                                        <img src="/images/del.gif" /><asp:LinkButton ID="lbtnDel" runat="server" CommandName="Del" CommandArgument='<%#DataBinder.Eval(Container.DataItem,"UserId")%>'>删除</asp:LinkButton>&nbsp; &nbsp;
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
                                <table style="width: 312px; padding: 0; border: 0; border-spacing: 0; float: right;">
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



