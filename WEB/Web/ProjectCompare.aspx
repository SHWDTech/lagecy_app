<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ProjectCompare.aspx.cs" Inherits="Web.ProjectCompare" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title></title>
</head>
<body>
    <form id="form1" runat="server">

        <h3>按工期进行综合对比</h3>
        <asp:HiddenField ID="hiddencityId" Value="0" runat="server" />
        <div>
            <asp:GridView ID="gvProjectCompare" runat="server" Width="788px"
                BackColor="White" BorderColor="#DEDFDE"
                BorderStyle="None" BorderWidth="1px" CellPadding="4" Font-Size="11pt" ForeColor="Black"
                GridLines="Vertical" AutoGenerateColumns="False"
                EnableModelValidation="True"
                PageSize="15" Height="199px">
                <FooterStyle BackColor="#CCCC99" />
                <HeaderStyle BackColor="#6B696B" Font-Bold="True" ForeColor="White" />
                <PagerStyle BackColor="#F7F7DE" ForeColor="Black" HorizontalAlign="Right" />
                <RowStyle HorizontalAlign="Center" BackColor="#F7F7DE" />

                <AlternatingRowStyle BackColor="White" />
                <Columns>
                    <asp:BoundField DataField="UpdateTime" HeaderText="最近两个月" />
                    <asp:BoundField DataField="TPAVG" DataFormatString="{0:N1}"
                        HeaderText="颗粒物" />
                    <asp:BoundField DataField="DBAVG" DataFormatString="{0:N1}"
                        HeaderText="噪音" />
                    <asp:BoundField DataField="PM25AVG" DataFormatString="{0:N1}"
                        HeaderText="PM2.5" />
                    <asp:BoundField DataField="PM100AVG" DataFormatString="{0:N1}"
                        HeaderText="PM10" />
                    <asp:BoundField DataField="Stage" DataFormatString="{0:N1}"
                        HeaderText="类型" />
                </Columns>
            </asp:GridView>
        </div>
    </form>
</body>
</html>
