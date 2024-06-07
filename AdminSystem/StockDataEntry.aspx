<%@ Page Language="C#" AutoEventWireup="true" CodeFile="StockDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            text-align: left;
            height: 351px;
            width: 383px;
        }
        #form1 {
            height: 479px;
            width: 701px;
        }
    </style>
</head>
<body style="width: 379px; height: 301px">

    <form id="form1" runat="server">

 <p class="auto-style1">
     <asp:Label ID="lblProduct_ID" runat="server" style="z-index: 1; left: 12px; top: 42px; position: absolute; right: 888px;" Text="Product_ID" width="72px"></asp:Label>
     <asp:TextBox ID="txtProduct_ID" runat="server" style="z-index: 1; left: 141px; top: 37px; position: absolute; height: 22px; width: 126px;" width="128px" Height="22px"></asp:TextBox>

&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
     
     <asp:Label ID="lblProduct_Name" runat="server" style="z-index: 1; left: 12px; top: 78px; position: absolute; width: 72px; height: 19px; bottom: 470px;" Text="Product_Name"></asp:Label>
     <asp:TextBox ID="txtProduct_Name" runat="server" style="z-index: 1; left: 141px; top: 74px; position: absolute" width="126px" height="22px"></asp:TextBox>
     <asp:TextBox ID="txtProd_Description" runat="server" style="z-index: 1; left: 141px; top: 114px; position: absolute" width="126px" height="22px"></asp:TextBox>
     <asp:Label ID="lblProd_Price" runat="server" style="z-index: 1; left: 12px; top: 156px; position: absolute; width: 72px; height: 19px" Text="Prod_Price"></asp:Label>
     <asp:TextBox ID="txtProd_Price" runat="server" style="z-index: 1; left: 141px; top: 149px; position: absolute" width="126px" height="22px"></asp:TextBox>
     <asp:TextBox ID="txtProd_Quantity" runat="server" style="z-index: 1; left: 141px; top: 189px; position: absolute" width="126px" height="22px"></asp:TextBox>
     <asp:Label ID="lblProd_Quantity" runat="server" style="z-index: 1; left: 12px; top: 188px; position: absolute; " Text="Prod_Quantity" width="72px" height="19px"></asp:Label>
     <asp:Label ID="lblDate_Added" runat="server" style="z-index: 1; left: 12px; top: 235px; position: absolute; " Text="Date_Added" height="19px" width="72px"></asp:Label>
     <asp:TextBox ID="txtDate_Added" runat="server" style="z-index: 1; left: 141px; top: 231px; position: absolute; " width="126px" height="22px"></asp:TextBox>
     <asp:Label ID="lblSupplier_ID" runat="server" style="z-index: 1; left: 12px; top: 279px; position: absolute; width: 72px; " Text="Supplier_ID" height="19px"></asp:Label>
     <asp:TextBox ID="txtSupplier_ID" runat="server" style="z-index: 1; left: 141px; top: 275px; position: absolute" width="126px" height="22px"></asp:TextBox>

     <asp:Label ID="lblProd_Description" runat="server" style="z-index: 1; left: 12px; top: 117px; position: absolute; width: 72px; bottom: 431px;" Text="Prod_Description" height="19px"></asp:Label>
     <asp:Button ID="btnFind" runat="server" OnClick="btnFind_Click1" style="z-index: 1; left: 320px; top: 40px; position: absolute" Text="Find" />

 <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 412px; top: 23px; position:absolute; height: 19px; text-align: center; color: #FF3300; margin-bottom: 0px;" width="72px"></asp:Label>

</p>
 <asp:Button ID="btnOK" runat="server" OnClick="btnOK_Click" style="z-index: 1; left: 51px; top: 383px; position: absolute" Text="OK" width="60px" />
 <asp:Button ID="btnCancel" runat="server" style="z-index: 1; left: 156px; top: 382px; position: absolute" Text="Cancel" OnClick="btnCancel_Click" />

        <asp:Button ID="btnMenu" runat="server" OnClick="btnMenu_Click" style="z-index: 1; left: 27px; top: 445px; position: absolute" Text="Return to the Main Menu" />

    </form>
</body>
</html>

