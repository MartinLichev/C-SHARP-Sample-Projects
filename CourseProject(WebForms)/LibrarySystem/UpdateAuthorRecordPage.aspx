<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="UpdateAuthorRecordPage.aspx.cs" Inherits="LibrarySystem.UpdateAuthorRecordPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div style="margin-left:auto; margin-right:auto; text-align:center">
        <asp:Label runat="server" ID="HeadingTetx" Text="Update Author" Font-Bold="true" Font-Size="XX-Large"></asp:Label>
        <br />
        <br />
        <br />
        <asp:Label runat="server" ID="SubHeadingText" Text="Please, input ID of Author, you wish to update!" Font-Bold="true" Font-Size="XX-Large"></asp:Label>
        <br />
        <br />
        <asp:Label runat="server" ID="IDLabel" Text="Author ID: " Font-Bold="true" Font-Size="X-Large"></asp:Label>
        <asp:TextBox runat="server" ID="AuthorIDTextbox" Font-Bold="true" Font-Size="Large"></asp:TextBox>
        <asp:RequiredFieldValidator runat="server" ControlToValidate="AuthorIDTextbox" ErrorMessage="Required Field!" BackColor="Red" Font-Size="Large" Font-Bold="true"></asp:RequiredFieldValidator>
        <br />
        <br />
        <asp:Label runat="server" ID="SecondSubHeadingLable" Text="Please input parameters of author you wish to add!" Font-Bold="true" Font-Size="XX-Large"></asp:Label>
        <br />
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
        <asp:Button runat="server" ID="UPDATEBUTTON" Text="Update" Font-Bold="true" Font-Size="X-Large" OnClick="UpdateAuthorRecordInDataBase"/>
    </div>
    </form>
</body>
</html>
