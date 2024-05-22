<%@ Page Language="C#" AutoEventWireup="true" CodeFile="CustomerDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        #form1 {
            height: 554px;
        }
    </style>
</head>
<body style="height: 552px">
    <form id="form1" runat="server">
        <asp:Label ID="IbICustomerId" runat="server" Style="z-index: 1; left: 20px; top: 53px; position: absolute; width: 89px; right: 1010px;" Text="Customer ID"></asp:Label>
        <asp:TextBox ID="txtCustomerId" runat="server" Style="z-index: 1; left: 118px; top: 54px; position: absolute"></asp:TextBox>
        <asp:Label ID="Label1" runat="server" Style="z-index: 1; left: 22px; top: 87px; position: absolute" Text="FirstName" Width="89px"></asp:Label>
        <asp:Button ID="btnFind" runat="server" Style="z-index: 1; left: 336px; top: 55px; position: absolute" Text="Find" OnClick="btnFind_Click" Width="60px" />
        <asp:TextBox ID="txtFirstName" runat="server" Style="z-index: 1; left: 118px; top: 88px; position: absolute"></asp:TextBox>
        <asp:Label ID="Label2" runat="server" Style="z-index: 1; left: 22px; top: 121px; position: absolute" Text="LastName" Width="89px"></asp:Label>
        <asp:TextBox ID="txtLastName" runat="server" Style="z-index: 1; left: 118px; top: 124px; position: absolute"></asp:TextBox>
        <asp:Label ID="Label3" runat="server" Style="z-index: 1; left: 22px; top: 160px; position: absolute" Text="Email" Width="89px"></asp:Label>
        <asp:TextBox ID="txtEmail" runat="server" Style="z-index: 1; left: 118px; top: 159px; position: absolute"></asp:TextBox>
        <asp:Label ID="Label5" runat="server" Style="z-index: 1; left: 22px; top: 229px; position: absolute" Text="DateOfBirth" Width="89px"></asp:Label>
        <asp:TextBox ID="txtDateOfBirth" runat="server" Style="z-index: 1; left: 118px; top: 232px; position: absolute"></asp:TextBox>
        <asp:CheckBox ID="chkActive" runat="server" Style="z-index: 1; left: 115px; top: 269px; position: absolute" Text="Active" />
        <asp:Button ID="btnOK" runat="server" OnClick="btnOK_Click" Style="z-index: 1; left: 24px; top: 331px; position: absolute; width: 60px" Text="OK" />
        <asp:Button ID="btnCancel" runat="server" Style="z-index: 1; left: 134px; top: 331px; position: absolute" Text="Cancel" />
        <asp:Label ID="Label6" runat="server" Style="z-index: 1; left: 22px; top: 193px; position: absolute" Text="Address" Width="89px"></asp:Label>
        <asp:TextBox ID="txtAddress" runat="server" Style="z-index: 1; left: 118px; top: 193px; position: absolute"></asp:TextBox>
        <asp:Label ID="lblErrorMessage" runat="server" ForeColor="Red" Style="z-index: 1; left: 27px; top: 298px; position: absolute; bottom: 351px" Text="Label" Visible="False"></asp:Label>
    </form>
</body>
</html>
