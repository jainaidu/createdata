<%@ Page Language="C#" AutoEventWireup="true" CodeFile="data.aspx.cs" Inherits="data" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
            background-image: url('Bin/UAHuntsville_BLUE_Ele.jpg');
        }
        .auto-style2 {
            width: 100%;
            background-color: #3399FF;
        }
        .auto-style3 {
            width: 100%;
        }
        .auto-style4 {
            width: 391px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <table class="auto-style1">
            <tr>
                <td>&nbsp;</td>
            </tr>
        </table>
        <p>
            &nbsp;</p>
        <table class="auto-style2">
            <tr>
                <td>INSERT DEPARTMENT DETAILS</td>
            </tr>
        </table>
        <table class="auto-style3">
            <tr>
                <td class="auto-style4">DEPARTMENT NAME</td>
                <td>
                    <asp:TextBox ID="txtdept" runat="server" OnTextChanged="txtdept_TextChanged"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style4">BUILDING NAME</td>
                <td>
                    <asp:TextBox ID="txtbuilding" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style4">BUDGET</td>
                <td>
                    <asp:TextBox ID="txtbudget" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style4">&nbsp;</td>
                <td>
                    <asp:Button ID="txtsubmit" runat="server" OnClick="txtsubmit_Click" Text="Button" />
                </td>
            </tr>
        </table>
    </form>
</body>
</html>
