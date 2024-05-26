<%@ Page Language="C#" AutoEventWireup="true" CodeFile="StockDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            text-align: justify;
        }
    </style>
</head>
<body style="width: 403px; height: 419px">

    <form id="form1" runat="server">

 <p class="auto-style1">
     <asp:Label ID="lblProduct_ID" runat="server" style="z-index: 1; left: 10px; top: 15px; position: absolute; right: 993px;" Text="Product_ID" width="72px"></asp:Label>
     <asp:TextBox ID="txtProduct_ID" runat="server" style="z-index: 1; left: 127px; top: 12px; position: absolute; height: 22px; width: 126px;" width="128px" Height="22px"></asp:TextBox>

&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
     <asp:Button ID="btnFind" runat="server" Height="28px" OnClick="btnFind_Click" Text="Find" Width="64px" />

</p>
<p class="auto-style1">
     <asp:Label ID="lblProduct_Name" runat="server" style="z-index: 1; left: 10px; top: 48px; position: absolute; width: 72px; height: 19px; bottom: 511px;" Text="Product_Name"></asp:Label>
     <asp:TextBox ID="txtProduct_Name" runat="server" style="z-index: 1; left: 128px; top: 49px; position: absolute" width="128px" height="22px"></asp:TextBox>
 </p>
 <p class="auto-style1">
     <asp:Label ID="lblProd_Description" runat="server" style="z-index: 1; left: 10px; top: 91px; position: absolute" Text="Prod_Description" width="72px" height="19px"></asp:Label>
     <asp:TextBox ID="txtProd_Description" runat="server" style="z-index: 1; left: 128px; top: 92px; position: absolute" width="128px" height="22px"></asp:TextBox>
 </p>
 <p class="auto-style1">
     <asp:Label ID="lblProd_Price" runat="server" style="z-index: 1; left: 10px; top: 128px; position: absolute; width: 72px; height: 19px" Text="Prod_Price"></asp:Label>
     <asp:TextBox ID="txtProd_Price" runat="server" style="z-index: 1; left: 128px; top: 127px; position: absolute" width="128px" height="22px"></asp:TextBox>
 </p>
 <p class="auto-style1">
     <asp:TextBox ID="txtProd_Quantity" runat="server" style="z-index: 1; left: 128px; top: 166px; position: absolute" width="128px" height="22px"></asp:TextBox>
     <asp:Label ID="lblProd_Quantity" runat="server" style="z-index: 1; left: 10px; top: 169px; position: absolute; " Text="Prod_Quantity" width="72px" height="19px"></asp:Label>
 </p>
 <p class="auto-style1">
     <asp:Label ID="lblDate_Added" runat="server" style="z-index: 1; left: 10px; top: 205px; position: absolute; " Text="Date_Added" height="19px" width="72px"></asp:Label>
     <asp:TextBox ID="txtDate_Added" runat="server" style="z-index: 1; left: 128px; top: 205px; position: absolute; " width="128px" height="22px"></asp:TextBox>
 </p>
 <p class="auto-style1">
     <asp:Label ID="lblSupplier_ID" runat="server" style="z-index: 1; left: 10px; top: 243px; position: absolute; width: 72px; " Text="Supplier_ID" height="19px"></asp:Label>
     <asp:TextBox ID="txtSupplier_ID" runat="server" style="z-index: 1; left: 128px; top: 243px; position: absolute" width="128px" height="22px"></asp:TextBox>
 </p>
 <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 11px; top: 316px; position: absolute; height: 19px" width="72px"></asp:Label>
 <asp:Button ID="btnOK" runat="server" OnClick="btnOK_Click" style="z-index: 1; left: 34px; top: 393px; position: absolute" Text="OK" width="60px" />
 <asp:Button ID="btnCancel" runat="server" style="z-index: 1; left: 114px; top: 393px; position: absolute" Text="Cancel" />

    </form>
</body>
</html>

