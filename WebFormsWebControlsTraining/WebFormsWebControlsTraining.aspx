<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebFormsWebControlsTraining.aspx.cs" Inherits="WebFormsWebControlsTraining.WebFormsWebControlsTraining" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div style="margin-left:auto; margin-right:auto; text-align:center" runat="server">
        <asp:Label runat="server" ID="HeadingLabel" Text="Web Forms - Web Controls Training" Font-Bold="true" Font-Size="XX-Large"></asp:Label>
        <br />
        <br />
        <asp:Label runat="server" ID="ListBoxExample" Text="ListBox Example:" Font-Bold="true" Font-Size="X-Large"></asp:Label>
        <br />
        <br />
        <asp:ListBox runat="server" ID="ListBox" Font-Bold="true" Font-Size="X-Large" Width="400px"></asp:ListBox>
        <br />
        <br />
        <asp:Label runat="server" ID="CheckBoxExample" Text="CheckBox Example:" style="margin-left:auto; margin-right:auto; text-align:center" Font-Bold="true" Font-Size="X-Large"></asp:Label>
        <br />
        <br />
        <asp:CheckBoxList runat="server" ID="CheckBoxList"  style="margin-left:auto; margin-right:auto; text-align:center" Font-Size= "X-Large" Font-Bold="true" Width="400px"></asp:CheckBoxList>
        <br />
        <br />
        <asp:Label runat="server" ID="ListBox2Text" style ="margin-left:auto; margin-right:auto; text-align:center" Text="ListBox Example With Objects:" Font-Size="X-Large" Font-Bold="true"></asp:Label>
        <br />
        <br />
        <asp:ListBox runat="server" ID="ListBox2" Font-Bold="true" Font-Size="X-Large" Width="500px" style="margin-left:auto; margin-right:auto; text-align:center" ItemType="Child"></asp:ListBox>
        <br />
        <br />
        <asp:Label runat="server" ID="DropDownText" Font-Bold="true" Font-Size="X-Large" style ="margin-left:auto; margin-right:auto; text-align:center" Text="DropDownList"></asp:Label>
        <br />
        <br />
        <asp:DropDownList runat="server" ID="DropDownList" Font-Bold="true" Font-Size="X-Large" Width="400px" style="margin-left:auto; margin-right:auto; text-align:center"></asp:DropDownList>


    
    </div>
    </form>
</body>
</html>
