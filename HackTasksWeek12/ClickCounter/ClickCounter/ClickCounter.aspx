<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ClickCounter.aspx.cs" Inherits="ClickCounter.ClickCounter" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
            border-style: solid;
            border-width: 1px;
        }
        .auto-style2 {
            height: 23px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Label ID="Label1" runat="server"></asp:Label>
    </div>
        <div>
            <asp:Button ID="Button1" runat="server" Text="Clicker" OnClick="Button1_Click" />
        </div>
        <div>
            <asp:Label ID="Label2"  runat="server"><%: Session["click"] %> </asp:Label>
            <asp:Label ID="Label3" runat="server"> <%: Application["allclicks"] %> </asp:Label>
        </div>
        <div>
            <asp:Button ID="Button2" runat="server" Text="Change user" OnClick="button2_click" />
        </div>
    </form>
    <table class="auto-style1">
        <tr>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style2"></td>
            <td class="auto-style2"></td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
    </table>
</body>
</html>
