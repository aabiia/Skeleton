<%@ Page Language="C#" AutoEventWireup="true" CodeFile="StockLogin.aspx.cs" Inherits="StockLogin" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            font-weight: bold;
        }
        .auto-style2 {
            text-align: center;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">

        <div class="auto-style2">
        <div>
        </div>
        <asp:Label ID="Label1" runat="server" style="z-index: 1; left: 694px; top: 25px; position: absolute; height: 60px; width: 226px; font-weight: 700; color: #FFFFFF; background-color: #666666; " Font-Size="20pt" Text="Stock Login Page"></asp:Label>
        <asp:Label ID="lblUsername" runat="server" style="z-index: 1; left: 596px; top: 103px; position: absolute; height: 26px; width: 106px; font-weight: 700;" Text="Username ::"></asp:Label>
        <asp:Label ID="lblPassword" runat="server" style="z-index: 1; left: 596px; top: 154px; position: absolute; height: 26px; font-weight: 700;" Text="Password ::" width="106px"></asp:Label>
        <asp:TextBox ID="tstUsername" runat="server" style="z-index: 1; left: 748px; top: 107px; position: absolute" height="22px" width="128px"></asp:TextBox>
        <asp:Label ID="lblError" runat="server" ForeColor="Red" style="z-index: 1; left: 924px; top: 108px; position: absolute"></asp:Label>
        <asp:Button ID="btnLogin" runat="server" OnClick="btnLogin_Click" style="z-index: 1; left: 735px; top: 242px; position: absolute" Text="Login" CssClass="auto-style1" height="26px" width="60px" />
        <asp:Button ID="btnCancel" runat="server" style="z-index: 1; left: 821px; top: 240px; position: absolute" Text="Cancel" OnClick="btnCancel_Click" CssClass="auto-style1" Height="26px" Width="60px" />
        </div>
        <asp:TextBox ID="txtPassword" runat="server" style="z-index: 1; left: 748px; top: 156px; position: absolute" TextMode="Password" height="22px" width="128px"></asp:TextBox>
    </form>
</body>
</html>
