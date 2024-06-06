<%@ Page Language="C#" AutoEventWireup="true" CodeFile="OrderList.aspx.cs" Inherits="_1_List" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        #form1 {
            height: 678px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <br />
        <br />
        <asp:ListBox ID="lstOrderList" runat="server" style="z-index: 1; left: 10px; top: 59px; position: absolute; height: 393px; width: 434px"></asp:ListBox>
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <asp:Button ID="btnAdd" runat="server" OnClick="btnAdd_Click" style="z-index: 1; left: 10px; top: 499px; position: absolute" Text="Add" />
        <asp:Button ID="btnEdit" runat="server" OnClick="btnEdit_Click" style="z-index: 1; left: 120px; top: 499px; position: absolute" Text="Edit" />
        <asp:Button ID="btnDelete" runat="server" OnClick="btnDelete_Click" style="z-index: 1; left: 240px; top: 499px; position: absolute" Text="Delete" />
        <asp:Button ID="btnMainMenu" runat="server" OnClick="btnMainMenu_Click" style="z-index: 1; left: 370px; top: 499px; position: absolute" Text="Return to the main menu" />
        <br />
        <br />
        <br />
        <br />
        <asp:Label ID="lblAddress" runat="server" style="z-index: 1; left: 10px; top: 587px; position: absolute" Text="Enter Address"></asp:Label>
        <asp:TextBox ID="txtAddress" runat="server" style="z-index: 1; left: 135px; top: 582px; position: absolute"></asp:TextBox>
        <asp:Label ID="lblError" runat="server" ForeColor="Red" style="z-index: 1; left: 377px; top: 582px; position: absolute"></asp:Label>
        <br />
        <br />
        <asp:Button ID="btnClearFilter" runat="server" OnClick="btnClearFilter_Click" style="z-index: 1; left: 183px; top: 641px; position: absolute" Text="Clear Filter" />
        <asp:Button ID="btnApplyFilter" runat="server" OnClick="btnApplyFilter_Click" style="z-index: 1; left: 10px; top: 631px; position: absolute" Text="Apply Filter" />
        <br />
        <br />
    </form>
</body>
</html>
