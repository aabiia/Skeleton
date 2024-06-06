<%@ Page Language="C#" AutoEventWireup="true" CodeFile="StockLogin.aspx.cs" Inherits="StockLogin" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Label ID="Label1" runat="server" style="z-index: 1; left: 665px; top: 49px; position: absolute" Text="Stock(Product) Login page"></asp:Label>
        <asp:Label ID="lblUsername" runat="server" style="z-index: 1; left: 596px; top: 103px; position: absolute; right: 685px;" Text="Username ::"></asp:Label>
        <asp:Label ID="lblPassword" runat="server" style="z-index: 1; left: 595px; top: 154px; position: absolute" Text="Password ::"></asp:Label>
        <asp:TextBox ID="tstUsername" runat="server" style="z-index: 1; left: 748px; top: 103px; position: absolute"></asp:TextBox>
        <asp:TextBox ID="txtPassword" runat="server" style="z-index: 1; left: 747px; top: 155px; position: absolute" TextMode="Password"></asp:TextBox>
        <asp:Label ID="lblError" runat="server" ForeColor="Red" style="z-index: 1; left: 976px; top: 130px; position: absolute"></asp:Label>
        <asp:Button ID="btnLogin" runat="server" OnClick="btnLogin_Click" style="z-index: 1; left: 637px; top: 241px; position: absolute" Text="Login" />
        <asp:Button ID="btnCancel" runat="server" style="z-index: 1; left: 887px; top: 237px; position: absolute" Text="Cancel" OnClick="btnCancel_Click" />
    </form>
</body>
</html>
