<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AddAuthorRecordPage.aspx.cs" Inherits="LibrarySystem.AddAuthorRecordPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div style="margin-left:auto; margin-right:auto; text-align:center">
        <asp:Label runat="server" ID="SubHeadingText" Text="Add New Author" Font-Bold="true" Font-Size="XX-Large"></asp:Label>
        <br />
        <br />
        <asp:Label runat="server" ID="Label1" Text="Name:" Font-Bold="true" Font-Size="X-Large"></asp:Label>
        <asp:TextBox runat="server" ID="NameTextbox" Font-Bold="true" Font-Size="Large"></asp:TextBox>
        <asp:RequiredFieldValidator runat="server" ControlToValidate="NameTextbox" ErrorMessage="Required Field!" BackColor="Red" Font-Bold="true" Font-Size="Large" ></asp:RequiredFieldValidator>
        <br />
        <br />
         <asp:Label runat="server" ID="GenderLabel" Text="Gender:" Font-Bold="true" Font-Size="X-Large"></asp:Label>
        <asp:TextBox runat="server" ID="GenderTextbox" Font-Bold="true" Font-Size="Large"></asp:TextBox>
        <asp:RequiredFieldValidator runat="server" ControlToValidate="GenderTextbox" ErrorMessage="Required Field!" BackColor="Red" Font-Bold="true" Font-Size="Large" ></asp:RequiredFieldValidator>
        <br />
        <br />
         <asp:Label runat="server" ID="YearOfBirth" Text="Year Of Birth:" Font-Bold="true" Font-Size="X-Large"></asp:Label>
        <asp:TextBox runat="server" ID="YearOfBirthTextbox" Font-Bold="true" Font-Size="Large"></asp:TextBox>
        <asp:RequiredFieldValidator runat="server" ControlToValidate="YearOfBirthTextbox" ErrorMessage="Required Field!" BackColor="Red" Font-Bold="true" Font-Size="Large" ></asp:RequiredFieldValidator>
        <br />
        <br />
        <asp:Button runat="server" ID="ADDBUTTON" Text="Add" Font-Bold="true" Font-Size="X-Large" OnClick="AddAuthorRecordInDataBase" />
    </div>
    </form>
</body>
</html>
