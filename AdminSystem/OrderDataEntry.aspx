<%@ Page Language="C#" AutoEventWireup="true" CodeFile="OrderDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        #form1 {
            height: 436px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <br />
        <br />
        <asp:Label ID="lblOrderID" runat="server" style="z-index: 1; left: 10px; top: 59px; position: absolute" Text="OrderID" width="126px"></asp:Label>
        <asp:Button ID="btnFind" runat="server" OnClick="btnFind_Click" style="z-index: 1; left: 340px; top: 59px; position: absolute" Text="Find" />
        <div style="margin-left: 40px">
            <asp:TextBox ID="txtOrderID" runat="server" style="z-index: 1; left: 149px; top: 58px; position: absolute"></asp:TextBox>
        </div>
        <br />
        <br />
        <asp:Label ID="lblCustomerID" runat="server" style="z-index: 1; left: 10px; top: 103px; position: absolute" Text="CustomerID" width="126px"></asp:Label>
        <asp:TextBox ID="txtCustomerID" runat="server" style="z-index: 1; left: 148px; top: 101px; position: absolute"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="lblPaymentMethod" runat="server" style="z-index: 1; left: 10px; top: 147px; position: absolute" Text="PaymentMethod"></asp:Label>
        <asp:TextBox ID="txtPaymentMethod" runat="server" style="z-index: 1; left: 146px; top: 146px; position: absolute"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="lblAddress" runat="server" style="z-index: 1; left: 10px; top: 191px; position: absolute" Text="Address" width="126px"></asp:Label>
        <asp:TextBox ID="txtAddress" runat="server" style="z-index: 1; left: 139px; top: 193px; position: absolute"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="lblDate" runat="server" style="z-index: 1; left: 10px; top: 235px; position: absolute" Text="Date" width="126px"></asp:Label>
        <asp:TextBox ID="txtDate" runat="server" style="z-index: 1; left: 137px; top: 237px; position: absolute"></asp:TextBox>
        <br />
        <br />
        <asp:CheckBox ID="chkPaymentStatus" runat="server" style="z-index: 1; left: 139px; top: 282px; position: absolute" />
        <br />
        <br />
        <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 87px; top: 329px; position: absolute"></asp:Label>
        <asp:Button ID="btnMenu" runat="server" OnClick="btnMenu_Click" style="z-index: 1; left: 280px; top: 367px; position: absolute" Text="Return to Main Menu" />
        <br />
        <br />
        <asp:Button ID="btnCancel" runat="server" style="z-index: 1; left: 143px; top: 370px; position: absolute" Text="Cancel" OnClick="btnCancel_Click" />
        <asp:Button ID="btnOk" runat="server" OnClick="btnOk_Click" style="z-index: 1; left: 36px; top: 368px; position: absolute" Text="Ok" />
        <br />
        <br />
    </form>
    <p>
        &nbsp;</p>
    <p>
        &nbsp;</p>
    <p>
        &nbsp;</p>
</body>
</html>
