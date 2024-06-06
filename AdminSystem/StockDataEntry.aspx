<%@ Page Language="C#" AutoEventWireup="true" CodeFile="StockDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            text-align: justify;
            height: 282px;
            width: 375px;
        }
        #form1 {
            height: 479px;
            width: 379px;
        }
    </style>
</head>
<body style="width: 379px; height: 284px">

    <form id="form1" runat="server">

 <p class="auto-style1">
     <asp:Label ID="lblProduct_ID" runat="server" style="z-index: 1; left: 12px; top: 42px; position: absolute; right: 888px;" Text="Product_ID" width="72px"></asp:Label>
     <asp:TextBox ID="txtProduct_ID" runat="server" style="z-index: 1; left: 141px; top: 37px; position: absolute; height: 22px; width: 126px;" width="128px" Height="22px"></asp:TextBox>

&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
     
     <asp:Label ID="lblProduct_Name" runat="server" style="z-index: 1; left: 8px; top: 78px; position: absolute; width: 72px; height: 19px; bottom: 470px;" Text="Product_Name"></asp:Label>
     <asp:TextBox ID="txtProduct_Name" runat="server" style="z-index: 1; left: 136px; top: 74px; position: absolute" width="128px" height="22px"></asp:TextBox>
     <asp:TextBox ID="txtProd_Description" runat="server" style="z-index: 1; left: 167px; top: 114px; position: absolute" width="128px" height="22px"></asp:TextBox>
     <asp:Label ID="lblProd_Price" runat="server" style="z-index: 1; left: 12px; top: 156px; position: absolute; width: 72px; height: 19px" Text="Prod_Price"></asp:Label>
     <asp:TextBox ID="txtProd_Price" runat="server" style="z-index: 1; left: 134px; top: 149px; position: absolute" width="128px" height="22px"></asp:TextBox>
     <asp:TextBox ID="txtProd_Quantity" runat="server" style="z-index: 1; left: 131px; top: 189px; position: absolute" width="128px" height="22px"></asp:TextBox>
     <asp:Label ID="lblProd_Quantity" runat="server" style="z-index: 1; left: 7px; top: 188px; position: absolute; " Text="Prod_Quantity" width="72px" height="19px"></asp:Label>
     <asp:Label ID="lblDate_Added" runat="server" style="z-index: 1; left: 14px; top: 235px; position: absolute; " Text="Date_Added" height="19px" width="72px"></asp:Label>
     <asp:TextBox ID="txtDate_Added" runat="server" style="z-index: 1; left: 128px; top: 231px; position: absolute; " width="128px" height="22px"></asp:TextBox>
     <asp:Label ID="lblSupplier_ID" runat="server" style="z-index: 1; left: 10px; top: 279px; position: absolute; width: 72px; " Text="Supplier_ID" height="19px"></asp:Label>
     <asp:TextBox ID="txtSupplier_ID" runat="server" style="z-index: 1; left: 126px; top: 275px; position: absolute" width="128px" height="22px"></asp:TextBox>

     <asp:Label ID="lblProd_Description" runat="server" style="z-index: 1; left: 13px; top: 117px; position: absolute; width: 140px; bottom: 431px;" Text="Prod_Description" height="19px"></asp:Label>
     <asp:Button ID="btnFind" runat="server" OnClick="btnFind_Click1" style="z-index: 1; left: 320px; top: 40px; position: absolute" Text="Find" />

</p>
 <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 11px; top: 316px; position:absolute; height: 19px" width="72px"></asp:Label>
 <asp:Button ID="btnOK" runat="server" OnClick="btnOK_Click" style="z-index: 1; left: 34px; top: 393px; position: absolute" Text="OK" width="60px" />
 <asp:Button ID="btnCancel" runat="server" style="z-index: 1; left: 114px; top: 393px; position: absolute" Text="Cancel" OnClick="btnCancel_Click" />

        <asp:Button ID="btnMenu" runat="server" OnClick="btnMenu_Click" style="z-index: 1; left: 294px; top: 395px; position: absolute" Text="Return to the MAIN MENU" />

    </form>
</body>
</html>

