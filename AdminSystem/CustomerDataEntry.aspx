<%@ Page Language="C#" AutoEventWireup="true" CodeFile="CustomerDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    &nbsp;<form id="form1" runat="server">
        <div>
        </div>
        <asp:Label ID="IbICustomerId" runat="server" style="z-index: 1; left: 22px; top: 56px; position: absolute; width: 89px; right: 385px;" Text="Customer ID"></asp:Label>
        <asp:TextBox ID="txtCustomerId" runat="server" style="z-index: 1; left: 118px; top: 54px; position: absolute"></asp:TextBox>
        <p>
            <asp:Label ID="Label1" runat="server" style="z-index: 1; left: 22px; top: 87px; position: absolute" Text="FirstName" width="89px"></asp:Label>
        </p>
        <asp:TextBox ID="txtFirstName" runat="server" style="z-index: 1; left: 118px; top: 88px; position: absolute"></asp:TextBox>
        <asp:Label ID="Label2" runat="server" style="z-index: 1; left: 22px; top: 121px; position: absolute" Text="LastName" width="89px"></asp:Label>
        <p>
            <asp:TextBox ID="txtLastName" runat="server" style="z-index: 1; left: 118px; top: 124px; position: absolute"></asp:TextBox>
        </p>
        <asp:Label ID="Label3" runat="server" style="z-index: 1; left: 22px; top: 160px; position: absolute" Text="Email" width="89px"></asp:Label>
        <asp:TextBox ID="txtEmail" runat="server" style="z-index: 1; left: 118px; top: 159px; position: absolute"></asp:TextBox>
        <asp:Label ID="Label5" runat="server" style="z-index: 1; left: 22px; top: 229px; position: absolute" Text="DateOfBirth" width="89px"></asp:Label>
        <asp:TextBox ID="txtDateOfBirth" runat="server" style="z-index: 1; left: 118px; top: 232px; position: absolute"></asp:TextBox>
        <asp:CheckBox ID="chkActive" runat="server" style="z-index: 1; left: 115px; top: 269px; position: absolute" Text="Active" />
        <asp:Label ID="IbIError" runat="server" style="z-index: 1; left: 34px; top: 298px; position: absolute"></asp:Label>
        <asp:Button ID="btnOK" runat="server" OnClick="btnOK_Click" style="z-index: 1; left: 24px; top: 332px; position: absolute; width: 60px" Text="OK" />
        <asp:Button ID="btnCancel" runat="server" style="z-index: 1; left: 134px; top: 331px; position: absolute" Text="Cancel" />
        <asp:Label ID="Label6" runat="server" style="z-index: 1; left: 22px; top: 193px; position: absolute" Text="Address" width="89px"></asp:Label>
        <asp:TextBox ID="txtAddress" runat="server" style="z-index: 1; left: 118px; top: 193px; position: absolute"></asp:TextBox>
    </form>
</body>
</html>
