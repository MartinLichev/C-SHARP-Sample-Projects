<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="BasicCalculator.aspx.cs" Inherits="BasicCalculator.BasicCalculator" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Label ID ="Calculator" runat="server" Text ="Basic Calculator" Font-Italic ="true" Font-Bold ="true" Font-Size="X-Large"></asp:Label>
        <br />
        <br />
        <asp:Label ID="FirstNumber" runat="server" Text="FirstNumber:" Font-Bold="true" Font-Italic="true" Font-Size="X-Large"></asp:Label>
        <asp:TextBox ID="FirstNumberText" runat="server" Height="20px" Width="100px"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="SecondNumber" runat="server" Text="SecondNumber:" Font-Bold="true" Font-Italic="true" Font-Size="X-Large"></asp:Label>
        <asp:TextBox ID="SecondNumberText" runat="server" Height="20px" Width="100px"></asp:TextBox>
        <br />
        <br />
        <asp:Button runat="server" ID="SumButton" Text="SUM" Height="50px" Width="100px" OnClick="SumButton_Click" />
        <asp:Button runat ="server" ID="DevideButton" Text="DEVIDE" Height="50px" Width="100px" OnClick="DevideButton_Click" />
        <asp:Button runat="server" ID="MultipleButton" Text="MULTIPLE" Height="50px" Width="100px" OnClick="MultipleButton_Click" />
        <asp:Button runat="server" ID="SubtractionButton" Text="SUBSTRACT" Height="50px" Width="100px" OnClick="SubtractionButton_Click" />
        <br />
        <br />
        <asp:Label ID="ResultLabel" runat="server" Text="Result:" Font-Size="X-Large" Font-Bold="true" Font-Italic="true"></asp:Label>
        <asp:TextBox ID="Resulttext" runat="server" Height="20px" Width="100px" ReadOnly ="true"></asp:TextBox>
    </div>
    </form>
</body>
</html>
