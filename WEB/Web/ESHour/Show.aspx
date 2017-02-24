<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeBehind="Show.aspx.cs" Inherits="ESMonitor.Web.ESHour.Show" Title="显示页" %>
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
		TP
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblTP" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		DB
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblDB" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		Datatime
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblDatatime" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		WindSpeed
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblWindSpeed" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		Rain
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblRain" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		WindDirection
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblWindDirection" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		Temperature
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblTemperature" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		Humidity
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblHumidity" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		Airpressure
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblAirpressure" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		DataStatus
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblDataStatus" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		ValidDataNum
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblValidDataNum" runat="server"></asp:Label>
	</td></tr>
</table>

                    </td>
                </tr>
            </table>
</asp:Content>
<%--<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceCheckright" runat="server">
</asp:Content>--%>




