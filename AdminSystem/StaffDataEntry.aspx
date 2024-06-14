<%@ Page Language="C#" AutoEventWireup="true" CodeFile="StaffDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Label ID="lblStaffId" runat="server" style="z-index: 1; left: 10px; top: 72px; position: absolute; height: 19px; bottom: 476px;" Text="Staff ID" width="75px"></asp:Label>
        <asp:TextBox ID="txtStaffId" runat="server" style="z-index: 1; left: 84px; top: 66px; position: absolute; width: 119px; height: 29px;" OnTextChanged="txtStaffId_TextChanged"></asp:TextBox>
        <p>
            <asp:Button ID="btnFind" runat="server" OnClick="btnFind_Click1" style="z-index: 1; left: 216px; top: 69px; position: absolute; width: 94px; height: 30px;" Text="Find" />
        </p>
        <asp:Label ID="lblDateHired" runat="server" height="19px" style="z-index: 1; left: 10px; top: 176px; position: absolute; width: 75px;" Text="Date Hired"></asp:Label>
        <p>
            <asp:TextBox ID="txtDateHired" runat="server" style="z-index: 1; top: 172px; position: absolute; width: 119px; left: 84px; height: 29px;"></asp:TextBox>
            <asp:TextBox ID="txtAddress" runat="server" style="z-index: 1; left: 84px; top: 119px; position: absolute; width: 119px; height: 29px"></asp:TextBox>
        </p>
        <p>
            <asp:Label ID="lblAddress" runat="server" height="19px" style="z-index: 1; left: 10px; top: 129px; position: absolute" Text="Address" width="75px"></asp:Label>
        </p>
        <asp:Label ID="lblEmail" runat="server" height="19px" style="z-index: 1; left: 10px; top: 224px; position: absolute" Text="Email" width="75px"></asp:Label>
        <p>
            <asp:TextBox ID="txtEmail" runat="server" style="z-index: 1; left: 84px; top: 222px; position: absolute; width: 119px; height: 29px;"></asp:TextBox>
        </p>
        <asp:Label ID="lblFirstName" runat="server" style="z-index: 1; left: 10px; top: 281px; position: absolute" Text="First Name" height="19px" width="75px"></asp:Label>
        <asp:TextBox ID="txtFirstName" runat="server" style="z-index: 1; left: 84px; top: 268px; position: absolute; width: 119px; height: 29px;"></asp:TextBox>
        <p>
            &nbsp;</p>
        <p>
            <asp:Label ID="lblLastName" runat="server" height="19px" style="z-index: 1; left: 10px; top: 333px; position: absolute" Text="LastName" width="75px"></asp:Label>
            <asp:TextBox ID="txtLastName" runat="server" style="z-index: 1; left: 84px; top: 316px; position: absolute; width: 119px; height: 29px"></asp:TextBox>
        </p>
        <asp:Label ID="lblGender" runat="server" height="19px" style="z-index: 1; left: 10px; top: 376px; position: absolute" Text="Gender" width="75px"></asp:Label>
        <asp:TextBox ID="txtGender" runat="server" style="z-index: 1; left: 84px; top: 361px; position: absolute; width: 119px; height: 29px; bottom: 166px;"></asp:TextBox>
        <asp:Label ID="lblPosition" runat="server" height="19px" style="z-index: 1; left: 10px; top: 415px; position: absolute" Text="Position" width="75px"></asp:Label>
        <asp:TextBox ID="txtPosition" runat="server" style="z-index: 1; left: 84px; top: 406px; position: absolute; width: 119px; height: 29px"></asp:TextBox>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <p>
            <asp:CheckBox ID="chkIsActive" runat="server" style="z-index: 1; left: 10px; top: 471px; position: absolute" Text="Active" />
        </p>
        <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 157px; top: 459px; position: absolute"></asp:Label>
        <asp:Button ID="btnOK" runat="server" OnClick="btnOK_Click" style="z-index: 1; left: 33px; top: 514px; position: absolute; right: 709px; height: 25px;" Text="OK" width="64px" />
        <asp:Button ID="btnCancel" runat="server" OnClick="btnCancel_Click" style="z-index: 1; left: 140px; top: 515px; position: absolute; width: 64px; height: 25px" Text="Cancel" />
        <p>
            &nbsp;</p>
    </form>
</body>
</html>
