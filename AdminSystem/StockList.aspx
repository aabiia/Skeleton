﻿<%@ Page Language="C#" AutoEventWireup="true" CodeFile="StockList.aspx.cs" Inherits="_1_List" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body style="height: 423px">
    <form id="form1" runat="server">
        <div style="height: 298px">
        <asp:ListBox ID="lstProductList" runat="server" Height="296px" Width="322px"></asp:ListBox>
        </div>

        <asp:Label ID="lblText" runat="server" style="z-index: 1; left: 86px; top: 438px; position: absolute" Text="Enter Product Name"></asp:Label>
        <asp:Button ID="btnClear" runat="server" OnClick="btnClear_Click" style="z-index: 1; left: 201px; top: 516px; position: absolute" Text="Clear" />

        <p style="height: 25px">
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="btnAdd" runat="server" OnClick="btnAdd_Click" Text="Add" Height="25px" Width="51px" />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:Button ID="btnEdit" runat="server" OnClick="btnEdit_Click" Text="Edit" />
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="btnDelete" runat="server" OnClick="btnDelete_Click" Text="Delete" />
            <asp:Button ID="BtnMebu" runat="server" OnClick="BtnMebu_Click" style="z-index: 1; left: 306px; top: 387px; position: absolute" Text="Return to the Main Menu" />
        </p>
        <p style="height: 25px">
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Label ID="lblError" runat="server"></asp:Label>
        </p>
        <asp:TextBox ID="txtProduct_Name" runat="server" style="z-index: 1; left: 79px; top: 474px; position: absolute"></asp:TextBox>
        <asp:Button ID="btnApply" runat="server" OnClick="btnApply_Click" style="z-index: 1; left: 67px; top: 513px; position: absolute" Text="Apply" />
    </form>
</body>
</html>
