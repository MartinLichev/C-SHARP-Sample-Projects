<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AddingEmployeesSystem.aspx.cs" Inherits="AddingEmployeesSystem.AddingEmployeesSystem" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>My Company Site</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Label runat="server" ID="IntoLabel" Font-Bold="true" Font-Size="X-Large" Text="Adding new Employees to existing Company System:"></asp:Label>
        <br />
        <br />
        <asp:Label runat="server" ID="AddingEmployeeLabel" Font-Bold="true" Font-Size="X-Large" Text="Please, add new Employee:"></asp:Label>
        <asp:TextBox runat="server" ID="AddingEmployeeText" Font-Bold="true" Font-Size="X-Large" Height="30px" Width="300px"></asp:TextBox>
        <br />
        <br />
        <asp:Label runat="server" ID="CheckCurrentPositionLabel" Text="Current Position in List:" Font-Bold="true" Font-Size="X-Large"></asp:Label>
        <asp:TextBox runat="server" ID="CheckCurrentPositionText" Font-Bold="true" Font-Size="X-Large" Height="30px" Width="100px" ReadOnly="true"></asp:TextBox>
        <br />
        <br />
        <asp:Button runat="server" ID="AddButton" Text="ADD" Font-Bold="true" Font-Size="X-Large" Height="60px" Width="150px" OnClick="AddButton_Click" />
        <asp:Button runat="server" ID="CheckPositionButton" Text="CHECK" Font-Bold="true" Font-Size="X-Large" Height="60px" Width="150px" OnClick="CheckPositionButton_Click" />
        <asp:Button runat="server" ID="DeleteButton" Text="DELETE" Font-Bold="true" Font-Size="X-Large" Height="60px" Width="150px" OnClick="DeleteButton_Click" />
        <asp:Button runat="server" ID="ClearButton" Text="CLEAR LIST" Font-Bold="true" Font-Size="X-Large" Height="60px" Width ="200px" OnClick="ClearButton_Click" />
        <br />
        <br />
        <asp:ListBox runat="server" ID="ListboxEmployees" Height="200px" Width="340px" Font-Bold="true" Font-Size="X-Large"  BackColor="SteelBlue"></asp:ListBox>

    
    </div>
    </form>
</body>
</html>
