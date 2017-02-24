<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="UserAdd.aspx.cs" Inherits="Web.admin.UserAdd" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>�ޱ����ĵ�</title>
    <link rel="stylesheet" type="text/css" href="/css/right.css" />
    <script type="text/javascript" src="/My97DatePicker/WdatePicker.js"></script>
    <script src="/js/RegisterJS.js?version=20150302" type="text/javascript"></script>
    <link type="text/css" rel="stylesheet" href="/css/register.css" />
    <style type="text/css">
        select {
            height: 22px;
            line-height: 22px;
            text-align: center;
        }
    </style>
    <script type="text/javascript">
        function OnSubmit() {
            if (userSubmitCheck()) {
                document.getElementById("form1").submit();
            }
        }
    </script>
</head>
<body>
    <form id="form1" runat="server">
        <table width="100%" cellspacing="0" cellpadding="0" border="0">
            <tr>
                <td style="font-weight: bold; background-image: url(/images/title_bg.jpg); height: 28px">
                    <img src="/images/go.gif" />��ǰλ�ã� <span style="font-weight: normal">[ ����û� ] </span></td>
            </tr>
            <tr>
                <td bgcolor="#b1ceef" height="1px"></td>
            </tr>
        </table>
        <div>
            <table width="100%" border="0" cellpadding="1" cellspacing="1">
                <tr>
                    <td class="STYLE19" width="64px">�û�����</td>
                    <td>
                        <asp:TextBox ID="txtUserName" runat="server" onblur="this.className='frame';startRequest();" onfocus="this.className='frameB'"></asp:TextBox>
                        <span style="color: Red">(*)</span><span>��ʹ��4-20λӢ����ĸ+�������</span>
                    </td>
                </tr>
                <tr id="tr_username" style="position: relative; display: none">
                    <td class="STYLE19"></td>
                    <td id="span_username" style="color: red"></td>
                </tr>
                <tr>
                    <td class="STYLE19">���룺</td>
                    <td>
                        <asp:TextBox ID="txtPwd" runat="server" onblur="this.className='frame';CheckPsd();" onfocus="this.className='frameB'"></asp:TextBox>
                        <span style="color: Red">(*)</span><span>Ϊ��߰�ȫ�ԣ���ѡ��6λ�������ַ���</span>
                    </td>
                </tr>
                <tr id="tr_pwd" style="position: relative; display: none">
                    <td class="STYLE19"></td>
                    <td id="span_pwd" style="color: red"></td>
                </tr>
                <tr>
                    <td class="STYLE19">ȷ�����룺</td>
                    <td>
                        <asp:TextBox ID="txtConfirmPwd" runat="server" onblur="this.className='frame';CheckConfirmPsd();" onfocus="this.className='frameB'"></asp:TextBox>
                        <span style="color: Red">(*)</span>
                    </td>
                </tr>
                <tr id="tr_comfirmpwd" style="position: relative; display: none">
                    <td class="STYLE19"></td>
                    <td id="span_comfirmpwd" style="color: red"></td>
                </tr>
                <tr>
                    <td class="STYLE19">���䣺</td>
                    <td>
                        <asp:TextBox ID="txtEmail" runat="server" onblur="this.className='frame';checkemail();" onfocus="this.className='frameB'"></asp:TextBox>
                        <span style="color: Red">(*)</span><span>���������һأ�����д��ʵ����</span>
                    </td>
                </tr>
                <tr id="tr_email" style="position: relative; display: none">
                    <td class="STYLE19"></td>
                    <td id="span_email" style="color: red"></td>
                </tr>
                <tr>
                    <td class="STYLE19">�绰��</td>
                    <td>
                        <asp:TextBox ID="txtPhone" runat="server" onblur="this.className='frame';checkphone();" onfocus="this.className='frameB'"></asp:TextBox>
                        <span style="color: Red">(*)</span><span>11λ�ֻ�����</span>
                    </td>
                </tr>
                <tr id="tr_phone" style="position: relative; display: none">
                    <td class="STYLE19"></td>
                    <td id="span_phone" style="color: red"></td>
                </tr>
                <tr>
                    <td class="STYLE19">���أ�</td>
                    <td>
                        <asp:DropDownList ID="textRemark" runat="server"></asp:DropDownList>
                    </td>
                </tr>
                <tr>
                    <td class="STYLE19">��ɫ��</td>
                    <td>
                        <asp:RadioButton ID="rbtn1" runat="server" Checked="True" GroupName="Role" Text="����Ա" />
                        &nbsp;&nbsp;&nbsp;<asp:RadioButton ID="rbtn2" runat="server" GroupName="Role" Text="��������Ա" />
                    </td>
                </tr>
                <tr>
                    <td class="STYLE19"></td>
                    <td>
                        <input type="button" value="����" onclick="OnSubmit()" style="padding: 5px; margin-right: 45px"/>
                        <input type="button" value="����" style="padding: 5px; margin-left: 45px" onclick="reset();" />
                    </td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>



