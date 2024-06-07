<%@ Page Language="C#" AutoEventWireup="true" CodeFile="StockConfirmDelete.aspx.cs" Inherits="_1_ConfirmDelete" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        #form1 {
            height: 366px;
            z-index: 1;
            left: 558px;
            top: 69px;
            position: absolute;
            width: 549px;
            text-align: center;
            background-color: #808080;
        }
    </style>
</head>
<body style="height: 481px; width: 1474px; text-align: center; background-color: #FFFFFF;">
    <form id="form1" runat="server">
        <div>
        </div>
        <p>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        </p>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Label ID="Label1" runat="server" style="font-weight: 700; z-index: 1; left: 134px; top: 76px; position: absolute; color: #FFFFFF;" Text="Are You Sure You Want To Delete This Record?"></asp:Label>
        <br />
        <br />
        <br />
        <br />
        <p>
            &nbsp;</p>
        <p>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            &nbsp;<asp:Button ID="btnYes" runat="server" height="26px" OnClick="btnYes_Click" Text="Yes" width="56px" style="z-index: 1; left: 193px; top: 211px; position: absolute" />
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="btnNo" runat="server" height="26px" OnClick="btnNo_Click" Text="No" width="56px" style="z-index: 2; left: 313px; top: 207px; position: absolute" />
        </p>
    </form>
</body>
</html>
