<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DeleteTenantRecordPage.aspx.cs" Inherits="LibrarySystem.DeleteTenantRecordPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div style ="margin-left:auto; margin-right:auto; text-align:center">
        <asp:Label runat="server" ID="HeadingText" Text="Please, input name of record you wish to delete!" Font-Bold="true" Font-Size="XX-Large"></asp:Label>
        <br />
        <br />
        <br />
        <asp:Label runat="server" ID="NameLabel" Text="Name:" Font-Bold="true" Font-Size="X-Large"></asp:Label>
        <asp:TextBox runat="server" ID="NameTextbox" Font-Bold="true" Font-Size="Large"></asp:TextBox>
        <asp:RequiredFieldValidator runat="server" ControlToValidate="NameTextbox" BackColor="Red" Text="Required Field!" Font-Size="Large" Font-Bold="true"></asp:RequiredFieldValidator>
        <br />
        <br />
        <br />
        <asp:Button runat="server" ID="DeleteBook" Text="Delete" Font-Size="X-Large" Font-Bold="true" OnClick="DeleteTenantRecordFromDataBase" />
    </div>
    </form>
</body>
</html>
