<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="data.aspx.cs" Inherits="data" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
            background-color: #CC33FF;
        }
        .auto-style2 {
            width: 100%;
        }
        .auto-style3 {
            width: 430px;
        }
        .auto-style4 {
            width: 100%;
            background-color: #99FF66;
        }
        .auto-style5 {
            width: 443px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table class="auto-style1">
                <tr>
                    <td>INSERT DEPARTMENT DETAILS</td>
                </tr>
            </table>
        </div>
        <table class="auto-style2">
            <tr>
                <td class="auto-style3">DEPARTMENT NAME</td>
                <td>
                    <asp:TextBox ID="txtdept" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style3">BUILDING NAME</td>
                <td>
                    <asp:TextBox ID="txtbuilding" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style3">BUDGET</td>
                <td>
                    <asp:TextBox ID="txtbudget" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style3">&nbsp;</td>
                <td>
                    <asp:Button ID="txtsubmit" runat="server" OnClick="txtsubmit_Click" Text="SUBMIT" />
                </td>
            </tr>
        </table>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <table class="auto-style4">
            <tr>
                <td>INSERT INSTRUCTOR DETAILS</td>
            </tr>
        </table>
        <table class="auto-style2">
            <tr>
                <td class="auto-style5">INSTRUCTOR ID</td>
                <td>
                    <asp:TextBox ID="txti_id" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style5">INSTRUCTOR NAME</td>
                <td>
                    <asp:TextBox ID="txti_name" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style5">DEPARTMENT NAME</td>
                <td>
                    <asp:TextBox ID="txti_dept" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style5">SALARY</td>
                <td>
                    <asp:TextBox ID="txti_salary" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style5">&nbsp;</td>
                <td>
                    <asp:Button ID="txtsubmit1" runat="server" OnClick="txtsubmit1_Click" Text="SUBMIT" />
                </td>
            </tr>
        </table>
    </form>
</body>
</html>
