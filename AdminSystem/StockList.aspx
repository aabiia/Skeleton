<%@ Page Language="C#" AutoEventWireup="true" CodeFile="StockList.aspx.cs" Inherits="_1_List" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body style="height: 423px">
    <br />
    <br />
    <br />
    <form id="form1" runat="server">
        <div style="height: 298px">
        <asp:ListBox ID="lstProductList" runat="server" Height="296px" Width="322px"></asp:ListBox>
            
        </div>



        <asp:Label ID="lblText" runat="server" style="z-index: 1; left: 130px; top: 442px; position: absolute" Text="Enter Product Name"></asp:Label>
        <asp:Button ID="btnClear" runat="server" OnClick="btnClear_Click" style="z-index: 1; left: 207px; top: 517px; position: absolute" Text="Clear" height="26px" width="60px" />

        <p style="height: 25px">
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="btnAdd" runat="server" OnClick="btnAdd_Click" Text="Add" Height="26px" Width="60px" />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:Button ID="btnEdit" runat="server" OnClick="btnEdit_Click" Text="Edit" height="26px" width="60px" />
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="btnDelete" runat="server" OnClick="btnDelete_Click" Text="Delete" height="26px" width="60px" />
            <asp:Button ID="BtnMebu" runat="server" OnClick="BtnMebu_Click" style="z-index: 1; left: 358px; top: 407px; position: absolute" Text="Return to the Main Menu" />
        </p>
        <p style="height: 25px">
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Label ID="lblError" runat="server" style="color: #FF0000"></asp:Label>
        </p>
        <asp:TextBox ID="txtProduct_Name" runat="server" style="z-index: 1; left: 117px; top: 471px; position: absolute; width: 152px;"></asp:TextBox>
        <asp:Button ID="btnApply" runat="server" OnClick="btnApply_Click" style="z-index: 1; left: 111px; top: 515px; position: absolute" Text="Apply" height="26px" width="60px" />
    </form>
</body>
</html>
