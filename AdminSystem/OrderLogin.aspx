<%@ Page Language="C#" AutoEventWireup="true" CodeFile="OrderLogin.aspx.cs" Inherits="OrderLogin" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        #form1 {
            height: 386px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <asp:Label ID="Label1" runat="server" style="z-index: 1; left: 258px; top: 55px; position: absolute" Text="orders Login page" Font-Size="18pt"></asp:Label>
        <asp:Label ID="lblUsername" runat="server" style="z-index: 1; left: 239px; top: 111px; position: absolute; right: 627px;" Text="Username"></asp:Label>
        <asp:Label ID="lblPassword" runat="server" style="z-index: 1; left: 238px; top: 193px; position: absolute" Text="Password"></asp:Label>
        <asp:TextBox ID="tstUsername" runat="server" style="z-index: 1; left: 288px; top: 137px; position: absolute"></asp:TextBox>
        <asp:TextBox ID="txtPassword" runat="server" style="z-index: 1; left: 285px; top: 223px; position: absolute" TextMode="Password"></asp:TextBox>
        <asp:Label ID="lblError" runat="server" ForeColor="Red" style="z-index: 1; left: 581px; top: 287px; position: absolute"></asp:Label>
        <asp:Button ID="btnLogin" runat="server" OnClick="btnLogin_Click" style="z-index: 1; left: 211px; top: 278px; position: absolute" Text="Login" Font-Size="12pt" />
        <asp:Button ID="btnCancel" runat="server" style="z-index: 1; left: 401px; top: 282px; position: absolute" Text="Cancel" OnClick="btnCancel_Click" Font-Size="12pt" />
    </form>
</body>
</html>
