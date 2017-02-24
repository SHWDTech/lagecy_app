<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true"
    CodeBehind="Add.aspx.cs" Inherits="ESMonitor.Web.ESMin.Add" Title="增加页" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">    
    <table style="width: 100%;" cellpadding="2" cellspacing="1" class="border">
        <tr>
            <td class="tdbg">
                
<table cellSpacing="0" cellPadding="0" width="100%" border="0">
	<tr>
	<td height="25" width="30%" align="right">
		StatCode
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtStatCode" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		TP
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtTP" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		DB
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtDB" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		Datatime
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox ID="txtDatatime" runat="server" Width="70px"  onfocus="setday(this)"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		WindSpeed
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtWindSpeed" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		Rain
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtRain" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		WindDirection
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtWindDirection" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		Temperature
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtTemperature" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		Humidity
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtHumidity" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		Airpressure
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtAirpressure" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		DataStatus
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtDataStatus" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
</table>
<script src="/js/calendar1.js" type="text/javascript"></script>

            </td>
        </tr>
        <tr>
            <td class="tdbg" align="center" valign="bottom">
                <asp:Button ID="btnSave" runat="server" Text="保存"
                    OnClick="btnSave_Click" class="inputbutton" onmouseover="this.className='inputbutton_hover'"
                    onmouseout="this.className='inputbutton'"></asp:Button>
                <asp:Button ID="btnCancle" runat="server" Text="取消"
                    OnClick="btnCancle_Click" class="inputbutton" onmouseover="this.className='inputbutton_hover'"
                    onmouseout="this.className='inputbutton'"></asp:Button>
            </td>
        </tr>
    </table>
    <br />
</asp:Content>
<%--<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceCheckright" runat="server">
</asp:Content>--%>
