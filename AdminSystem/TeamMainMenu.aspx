<%@ Page Language="C#" AutoEventWireup="true" CodeFile="TeamMainMenu.aspx.cs" Inherits="TeamMainMenu" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <br />
        <asp:Button ID="btnStock" runat="server" OnClick="btnStock_Click" style="z-index: 1; left: 473px; top: 227px; position: absolute; height: 60px; width: 186px; right: 381px;" Text="Stock" Font-Bold="True" Font-Size="20pt" />
        <asp:Button ID="btnOrder" runat="server" OnClick="btnOrder_Click" style="z-index: 1; left: 236px; top: 228px; position: absolute; height: 60px; width: 186px; right: 985px;" Text="Order" Font-Bold="True" Font-Size="20pt" />
        <asp:Label ID="Label1" runat="server" style="z-index: 1; left: 404px; top: 87px; position: absolute; height: 64px; width: 388px;" Text="Team Main Menu" BackColor="Yellow" Font-Bold="True" Font-Size="30pt" ForeColor="Black"></asp:Label>
    </form>
</body>
</html>
