<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DisplayingNumbersFrom1toNinWeb.aspx.cs" Inherits="DisplayingNumbersFrom1ToNinWeb.DisplayingNumbersFrom1toNinWeb" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Label runat="server" ID="descriptionlabel" Text="Displaying numbers from '1' to 'N' in Web" Font-Bold="true" Font-Italic="true" Font-Size="X-Large"></asp:Label>
        <br />
        <br />
        <asp:Label runat="server" ID="inputtext" Text="Please, input a number:" Font-Bold="true" Font-Italic="true" Font-Size="X-Large"></asp:Label>
        <asp:TextBox runat ="server" ID="inputtextbox" Height="20px" Width="100px" Font-Bold="true" Font-Italic="true" Font-Size="X-Large"></asp:TextBox>
        <br />
        <asp:Button runat="server" ID="checkbutton" Text="CHECK" Font-Bold="true" Font-Size="X-Large" Font-Italic="true" Height="40px" Width="150px" OnClick="checkbutton_Click" /> 
        <br />
        <br />
        <asp:Label runat="server" ID="resultlabel" Text="The numbers are the following:" Font-Bold="true" Font-Italic="true" Font-Size="X-Large"></asp:Label>
        <br />
        <br />
        <asp:ListBox runat="server" ID="ListBoxtext" Font-Bold="true" Font-Italic="true" Font-Size="X-Large" Height="170px" Width="520px"></asp:ListBox>
    
    </div>
    </form>
</body>
</html>
