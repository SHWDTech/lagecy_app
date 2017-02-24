<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeBehind="Modify.aspx.cs" Inherits="ESMonitor.Web.Stats.Modify" Title="修改页" %>
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
		<asp:label id="lblId" runat="server"></asp:label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		StatCode
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtStatCode" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		StatName
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtStatName" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		ChargeMan
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtChargeMan" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		Telepone
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtTelepone" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		Longitude
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtLongitude" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		Department
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtDepartment" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		Adress
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtAdress" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		Country
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtCountry" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		Street
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtStreet" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		Square
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtSquare" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		ProStartTime
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox ID="txtProStartTime" runat="server" Width="70px"  onfocus="setday(this)"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		Stage
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtStage" runat="server" Width="200px"></asp:TextBox>
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
</asp:Content>
<%--<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceCheckright" runat="server">
</asp:Content>--%>

