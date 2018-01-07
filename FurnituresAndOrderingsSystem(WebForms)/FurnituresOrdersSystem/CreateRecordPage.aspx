<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CreateRecordPage.aspx.cs" Inherits="FurnituresOrdersSystem.CreateRecordPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div style ="margin-left:auto; margin-right:auto; text-align:center">
    <asp:Label runat="server" Text="Create, new Furniture Record!" Font-Bold="true" Font-Size="XX-Large"></asp:Label>
        <br />
        <br />
        <br />
        <asp:Label runat="server" ID="NameLabel" Text="Name:" Font-Bold="true" Font-Size="X-Large"></asp:Label>
        <asp:TextBox runat="server" ID="NameText" Font-Bold="true" Font-Size="Large"></asp:TextBox>
        <br />
        <br />
        <br />
        <asp:Label runat="server" ID="DescriptionLabel" Text="Description:" Font-Bold="true" Font-Size="X-Large"></asp:Label>
        <asp:TextBox runat="server" ID="DescriptionText" Font-Bold="true" Font-Size="Large"></asp:TextBox>
        <br />
        <br />
        <br />
        <asp:Label runat="server" ID="HeightLabel" Text="Height:" Font-Bold="true" Font-Size="X-Large"></asp:Label>
        <asp:TextBox runat="server" ID="HeightText" Font-Bold="true" Font-Size="Large"></asp:TextBox>
        <br />
        <br />
        <br />
        <asp:Label runat="server" ID="WidthLabel" Text="Width:" Font-Bold="true" Font-Size="X-Large"></asp:Label>
        <asp:TextBox runat="server" ID="WidthText" Font-Bold="true" Font-Size="Large"></asp:TextBox>
        <br />
        <br />
        <br />
        <asp:Label runat="server" ID="CountryOfOriginLabel" Text="Country Of Origin:" Font-Bold="true" Font-Size="X-Large"></asp:Label>
        <asp:TextBox runat="server" ID="CountryOfOriginText" Font-Bold="true" Font-Size="Large"></asp:TextBox>
        <br />
        <br />
        <br />
        <asp:Button runat="server" ID="CreateButton" Text="Add Record" Font-Bold="true" Font-Size="X-Large" OnClick="CreateRecord" />    
    </div>
    </form>
</body>
</html>
