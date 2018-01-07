<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="FurnituresAndOrdersHomePage.aspx.cs" Inherits="FurnituresOrdersSystem.FurnituresAndOrdersHomePage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div style="margin-left:auto; margin-right:auto; text-align:center">
        <asp:Label runat="server" ID="HomePageHeading" Text="Furnitures and Orders CRM System" Font-Bold="true" Font-Size="XX-Large"></asp:Label>
        <br />
        <br />
        <br />
        <br />
        <asp:GridView runat="server" ID="GridView" style="margin-left:auto; margin-right:auto; text-align:center" Font-Bold="True" Font-Size="X-Large" DataSourceID="EntityDataSource" AutoGenerateColumns="False" BackColor="#CCCCCC" BorderColor="#999999" BorderStyle="Solid" BorderWidth="3px" CellPadding="4" CellSpacing="2" ForeColor="Black">
            <Columns>
                <asp:TemplateField HeaderText ="Name">
                    <ItemTemplate>
                        <asp:Label runat ="server" ID="NameLabel" Text='<%# Bind("Name") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText ="Description">
                    <ItemTemplate>
                        <asp:Label runat ="server" ID="DescriptionLabel" Text='<%# Bind("Description") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText ="Height">
                    <ItemTemplate>
                        <asp:Label runat="server" ID="HeightLabel" Text='<%# Bind("Height") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText ="Width">
                    <ItemTemplate>
                        <asp:Label runat="server" ID="WidthLabel" Text='<%# Bind("Width") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Country Of Origin">
                    <ItemTemplate>
                        <asp:Label runat="server" ID="CountyrOfOriginLabel" Text='<%# Bind("CountryOfOrigin") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField>
                    <ItemTemplate>
                        <asp:LinkButton runat="server" ID="EditButton" Text="Edit" CommandArgument="Edit"></asp:LinkButton>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField>
                    <ItemTemplate>
                        <asp:LinkButton runat="server" ID="DeleteButton" Text="Delete" CommandArgument="Delete"></asp:LinkButton>
                    </ItemTemplate>
                </asp:TemplateField>
            </Columns>
            <FooterStyle BackColor="#CCCCCC" />
            <HeaderStyle BackColor="Black" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="#CCCCCC" ForeColor="Black" HorizontalAlign="Left" />
            <RowStyle BackColor="White" />
            <SelectedRowStyle BackColor="#000099" Font-Bold="True" ForeColor="White" />
            <SortedAscendingCellStyle BackColor="#F1F1F1" />
            <SortedAscendingHeaderStyle BackColor="#808080" />
            <SortedDescendingCellStyle BackColor="#CAC9C9" />
            <SortedDescendingHeaderStyle BackColor="#383838" />
        </asp:GridView>
        <br />
        <br />
        <asp:Button runat="server" ID="CreateButton" Text="Add" Font-Bold="true" Font-Size="X-Large" OnClick="CreateRecord" />
        <asp:EntityDataSource  runat="server" ID="EntityDataSource" ConnectionString="name=FurnituresAndOrdersDataBaseEntities" DefaultContainerName="FurnituresAndOrdersDataBaseEntities" EnableFlattening="False" EntitySetName="Orders" Select="it.[Name], it.[Description], it.[Height], it.[Width], it.[CountryOfOrigin]"></asp:EntityDataSource>
    </div>
    </form>
</body>
</html>
