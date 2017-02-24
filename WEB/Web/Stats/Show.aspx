<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeBehind="Show.aspx.cs" Inherits="ESMonitor.Web.Stats.Show" Title="显示页" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
   <table style="width: 100%;" cellpadding="2" cellspacing="1" class="border">
                <tr>                   
                    <td class="tdbg">
                               
<table cellSpacing="0" cellPadding="0" width="100%" border="0">
	<tr>
	<td height="25" width="30%" align="right">
		Id
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblId" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		StatCode
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblStatCode" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		StatName
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblStatName" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		ChargeMan
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblChargeMan" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		Telepone
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblTelepone" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		Longitude
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblLongitude" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		Department
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblDepartment" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		Adress
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblAdress" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		Country
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblCountry" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		Street
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblStreet" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		Square
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblSquare" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		ProStartTime
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblProStartTime" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		Stage
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblStage" runat="server"></asp:Label>
	</td></tr>
</table>

                    </td>
                </tr>
            </table>
</asp:Content>
<%--<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceCheckright" runat="server">
</asp:Content>--%>




