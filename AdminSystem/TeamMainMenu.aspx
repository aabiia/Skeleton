<%@ Page Language="C#" AutoEventWireup="true" CodeFile="TeamMainMenu.aspx.cs" Inherits="TeamMainMenu" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            text-align: center;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="auto-style1">
        <br />
        <asp:Button ID="btnStock" runat="server" OnClick="btnStock_Click" style="z-index: 1; left: 802px; top: 243px; position: absolute; height: 61px; width: 145px; right: 558px;" Text="Stock" Font-Bold="True" Font-Size="20pt" />
        <asp:Button ID="btnOrder" runat="server" OnClick="btnOrder_Click" style="z-index: 1; left: 583px; top: 243px; position: absolute; height: 61px; width: 145px; right: 777px;" Text="Order" Font-Bold="True" Font-Size="20pt" />
        <asp:Label ID="Label1" runat="server" style="z-index: 1; left: 575px; top: 69px; position: absolute; height: 77px; width: 400px; color: #FFFFFF; text-align: center; background-color: #666666;" Text="Team Main Menu" BackColor="Yellow" Font-Bold="True" Font-Size="30pt" ForeColor="Black"></asp:Label>
        </div>
    </form>
</body>
</html>
