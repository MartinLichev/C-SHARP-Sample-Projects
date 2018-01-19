<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="UpdateTenantRecordPage.aspx.cs" Inherits="LibrarySystem.UpdateTenantRecordPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div style="margin-left:auto; margin-right:auto; text-align:center">
        <asp:Label runat="server" ID="HeadingTetx" Text="Update Tenant" Font-Bold="true" Font-Size="XX-Large"></asp:Label>
        <br />
        <br />
        <br />
        <asp:Label runat="server" ID="SubHeadingText" Text="Please, input ID of Tenant, you wish to update!" Font-Bold="true" Font-Size="XX-Large"></asp:Label>
        <br />
        <br />
        <asp:Label runat="server" ID="IDLabel" Text="Tenant ID: " Font-Bold="true" Font-Size="X-Large"></asp:Label>
        <asp:TextBox runat="server" ID="TenantIDTextbox" Font-Bold="true" Font-Size="Large"></asp:TextBox>
        <asp:RequiredFieldValidator runat="server" ControlToValidate="TenantIDTextbox" ErrorMessage="Required Field!" BackColor="Red" Font-Size="Large" Font-Bold="true"></asp:RequiredFieldValidator>
        <br />
        <br />
        <asp:Label runat="server" ID="SecondSubHeadingLable" Text="Please input parameters of tenant you wish to add!" Font-Bold="true" Font-Size="XX-Large"></asp:Label>
        <br />
        <br />
        <br />
        <asp:Label runat="server" ID="Label1" Text="Name:" Font-Bold="true" Font-Size="X-Large"></asp:Label>
        <asp:TextBox runat="server" ID="NameTextbox" Font-Bold="true" Font-Size="Large"></asp:TextBox>
        <asp:RequiredFieldValidator runat="server" ControlToValidate="NameTextbox" ErrorMessage="Required Field!" BackColor="Red" Font-Bold="true" Font-Size="Large" ></asp:RequiredFieldValidator>
        <br />
        <br />
         <asp:Label runat="server" ID="IDCardLabel" Text="ID Card:" Font-Bold="true" Font-Size="X-Large"></asp:Label>
        <asp:TextBox runat="server" ID="IDCardTextbox" Font-Bold="true" Font-Size="Large"></asp:TextBox>
        <asp:RequiredFieldValidator runat="server" ControlToValidate="IDCardTextbox" ErrorMessage="Required Field!" BackColor="Red" Font-Bold="true" Font-Size="Large" ></asp:RequiredFieldValidator>
        <br />
        <br />
         <asp:Label runat="server" ID="UniqueCitizenshipNumber" Text="Unique Citizenship Number:" Font-Bold="true" Font-Size="X-Large"></asp:Label>
        <asp:TextBox runat="server" ID="UniqueCitizenshipNumberTextbox" Font-Bold="true" Font-Size="Large"></asp:TextBox>
        <asp:RequiredFieldValidator runat="server" ControlToValidate="UniqueCitizenshipNumberTextbox" ErrorMessage="Required Field!" BackColor="Red" Font-Bold="true" Font-Size="Large" ></asp:RequiredFieldValidator>
        <br />
        <br />
        <asp:Label runat="server" ID="AddressLabel" Text="Address:" Font-Bold="true" Font-Size="X-Large"></asp:Label>
        <asp:TextBox runat="server" ID="AddressTextBox" Font-Bold="true" Font-Size="Large"></asp:TextBox>
        <asp:RequiredFieldValidator runat="server" ControlToValidate="AddressTextBox" ErrorMessage="Required Field!" BackColor="Red" Font-Bold="true" Font-Size="Large" ></asp:RequiredFieldValidator>
        <br />
        <br />
        <asp:Label runat="server" ID="GenderLabel" Text="Gender:" Font-Bold="true" Font-Size="X-Large"></asp:Label>
        <asp:TextBox runat="server" ID="GenderTextBox" Font-Bold="true" Font-Size="Large"></asp:TextBox>
        <asp:RequiredFieldValidator runat="server" ControlToValidate="GenderTextBox" ErrorMessage="Required Field!" BackColor="Red" Font-Bold="true" Font-Size="Large" ></asp:RequiredFieldValidator>
        <br />
        <br />
         <asp:Label runat="server" ID="PhoneLabel" Text="Phone Number:" Font-Bold="true" Font-Size="X-Large"></asp:Label>
        <asp:TextBox runat="server" ID="PhoneTextBox" Font-Bold="true" Font-Size="Large"></asp:TextBox>
        <asp:RequiredFieldValidator runat="server" ControlToValidate="PhoneTextBox" ErrorMessage="Required Field!" BackColor="Red" Font-Bold="true" Font-Size="Large" ></asp:RequiredFieldValidator>
        <br />
        <br />
         <asp:Label runat="server" ID="EmailLabel" Text="Email:" Font-Bold="true" Font-Size="X-Large"></asp:Label>
        <asp:TextBox runat="server" ID="EmailTextBox" Font-Bold="true" Font-Size="Large"></asp:TextBox>
        <asp:RequiredFieldValidator runat="server" ControlToValidate="EmailTextBox" ErrorMessage="Required Field!" BackColor="Red" Font-Bold="true" Font-Size="Large" ></asp:RequiredFieldValidator>
        <br />
        <br />
        <asp:Button runat="server" ID="UPDATEBUTTON" Text="Update" Font-Bold="true" Font-Size="X-Large" OnClick="UpdateTenantRecordInDataBase" />
    </div>
    </form>
</body>
</html>
