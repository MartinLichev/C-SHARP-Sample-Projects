<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AddBookRecordPage.aspx.cs" Inherits="LibrarySystem.AddBookRecordPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div style ="margin-left:auto; margin-right:auto; text-align:center">
        <asp:Label runat="server" ID="HeadingText" Text="Add New Book" Font-Size="XX-Large" Font-Bold="true"></asp:Label>
        <br />
        <br />
        <br />
        <asp:Label runat="server" ID="NameLabel" Text="Name:" Font-Bold="true" Font-Size="X-Large"></asp:Label>
        <asp:TextBox runat="server" ID="NameTextbox" Font-Bold="true" Font-Size="Large"></asp:TextBox>
        <asp:RequiredFieldValidator runat="server" ControlToValidate="NameTextbox" ErrorMessage="Required Field!" BackColor="Red" Font-Bold="true" Font-Size="Large" ></asp:RequiredFieldValidator>
        <br />
        <br />
         <asp:Label runat="server" ID="AuthorLabel" Text="Author:" Font-Bold="true" Font-Size="X-Large"></asp:Label>
        <asp:TextBox runat="server" ID="AuthorTextbox" Font-Bold="true" Font-Size="Large"></asp:TextBox>
        <asp:RequiredFieldValidator runat="server" ControlToValidate="AuthorTextbox" ErrorMessage="Required Field!" BackColor="Red" Font-Bold="true" Font-Size="Large" ></asp:RequiredFieldValidator>
        <br />
        <br />
         <asp:Label runat="server" ID="ISBNLabel" Text="ISBN:" Font-Bold="true" Font-Size="X-Large"></asp:Label>
        <asp:TextBox runat="server" ID="ISBNTextbox" Font-Bold="true" Font-Size="Large"></asp:TextBox>
        <asp:RequiredFieldValidator runat="server" ControlToValidate="ISBNTextbox" ErrorMessage="Required Field!" BackColor="Red" Font-Bold="true" Font-Size="Large" ></asp:RequiredFieldValidator>
        <br />
        <br />
         <asp:Label runat="server" ID="NumberOfPagesLabel" Text="Number Of Pages:" Font-Bold="true" Font-Size="X-Large"></asp:Label>
        <asp:TextBox runat="server" ID="NumberOfPagesTextbox" Font-Bold="true" Font-Size="Large"></asp:TextBox>
        <asp:RequiredFieldValidator runat="server" ControlToValidate="NumberOfPagesTextbox" ErrorMessage="Required Field!" BackColor="Red" Font-Bold="true" Font-Size="Large" ></asp:RequiredFieldValidator>
        <br />
        <br />
         <asp:Label runat="server" ID="YearOfPublishingLabel" Text="Year Of Publishing:" Font-Bold="true" Font-Size="X-Large"></asp:Label>
        <asp:TextBox runat="server" ID="YearOfPublishingTextbox" Font-Bold="true" Font-Size="Large"></asp:TextBox>
        <asp:RequiredFieldValidator runat="server" ControlToValidate="YearOfPublishingTextbox" ErrorMessage="Required Field!" BackColor="Red" Font-Bold="true" Font-Size="Large" ></asp:RequiredFieldValidator>
        <br />
        <br />
        <asp:Button runat="server" ID="ADDBUTTON" Text="Add" Font-Bold="true" Font-Size="X-Large" OnClick="AddBookRecordInDataBase" />
    </div>
    </form>
</body>
</html>
