<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="HomePage.aspx.cs" Inherits="LibrarySystem.HomePage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div style="margin-left:auto; margin-right:auto; text-align:center">
        <asp:Label runat="server" ID="HeadingText" Text="Library System Homepage" Font-Bold="true" Font-Size="XX-Large"></asp:Label>
        <br />
        <br />
        <br />
        <asp:GridView runat="server" ID="GridView" Font-Bold="True" Font-Size="X-Large" style="margin-left:auto; margin-right:auto; text-align:center" DataSourceID="EntityDataSourceBooks" AutoGenerateColumns="False" BackColor="White" BorderColor="#CC9966" BorderStyle="None" BorderWidth="1px" CellPadding="4" DataKeyNames="ID" Width="1265px">
            <Columns>
                <asp:TemplateField HeaderText="ID">
                    <ItemTemplate>
                        <asp:Label runat="server" ID="ID" Text='<%# Bind("ID") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Name">
                    <ItemTemplate>
                        <asp:Label runat="server" ID="Name" Text= '<%# Bind("Name") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Author">
                    <ItemTemplate>
                        <asp:Label runat="server" ID="Author" Text= '<%# Bind("Author") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText ="ISBN">
                    <ItemTemplate>
                        <asp:Label runat="server" ID="ISBN" Text='<%# Bind("ISBN") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Number Of Pages">
                    <ItemTemplate>
                        <asp:Label runat="server" ID="NumberOfPages" Text='<%# Bind("NumberOfPages") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Year Of Publishing">
                    <ItemTemplate>
                        <asp:Label runat="server" ID="YearOfPublishing" Text='<%# Bind("YearOfPublishing") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
            </Columns>
            <FooterStyle BackColor="#FFFFCC" ForeColor="#330099" />
            <HeaderStyle BackColor="#990000" Font-Bold="True" ForeColor="#FFFFCC" />
            <PagerStyle BackColor="#FFFFCC" ForeColor="#330099" HorizontalAlign="Center" />
            <RowStyle BackColor="White" ForeColor="#330099" />
            <SelectedRowStyle BackColor="#FFCC66" Font-Bold="True" ForeColor="#663399" />
            <SortedAscendingCellStyle BackColor="#FEFCEB" />
            <SortedAscendingHeaderStyle BackColor="#AF0101" />
            <SortedDescendingCellStyle BackColor="#F6F0C0" />
            <SortedDescendingHeaderStyle BackColor="#7E0000" />
        </asp:GridView>
        <br />
        <br />
        <br />
        <asp:Button runat="server" ID="ADDBUTTON" Text="Add Book" Font-Bold="true" Font-Size="X-Large" OnClick="RedirectToAddBookRecordPage"/>
        <asp:Button runat="server" ID="DELETEBUTTON" Text="Delete Book" Font-Bold="true" Font-Size="X-Large" OnClick="RedirectToDeleteBookRecordPage" />
        <asp:Button runat="server" ID="UPDATEBUTTON" Text="Update Book" Font-Bold="true" Font-Size="X-Large" OnClick="RedirectToUpdateBookRecordPage" />
        <asp:EntityDataSource runat="server" ID="EntityDataSourceBooks" ConnectionString="name=LibraryDataBaseEntities" DefaultContainerName="LibraryDataBaseEntities" EnableFlattening="False" EntitySetName="Books"></asp:EntityDataSource>
    </div>
        <br />
        <br />
        <br />
        <div style="margin-left:auto; margin-right:auto; text-align:center">
            <asp:Label runat="server" ID="SubHeadingAuthors" Text="Authors" Font-Bold="true" Font-Size="XX-Large"></asp:Label>
            <br />
            <br />
            <br />
            <asp:GridView runat="server" ID="AuthorsGridView" style="margin-left:auto; margin-right:auto; text-align:center" Font-Bold="True" Font-Size="X-Large" DataSouceId="EntityDataSourceAuthors" AutoGenerateColumns="False" BackColor="White" BorderColor="#CC9966" BorderStyle="None" BorderWidth="1px" CellPadding="4" DataKeyNames="ID" DataSourceID="EntityDataSourceAuthors" Width="1284px">
                <Columns>
                    <asp:TemplateField HeaderText="ID">
                        <ItemTemplate>
                            <asp:Label runat="server" ID="ID" Text='<%# Bind("ID") %>'></asp:Label>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="Name">
                        <ItemTemplate>
                            <asp:Label runat="server" ID="Name" Text='<%# Bind("Name") %>'></asp:Label>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="Gender">
                        <ItemTemplate>
                            <asp:Label runat="server" ID="Gender" Text='<%# Bind("Gender") %>'></asp:Label>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="Year Of Birth">
                        <ItemTemplate>
                            <asp:Label runat="server" ID="YearOfBirth" Text='<%# Bind("YearOfBirth") %>'></asp:Label>
                        </ItemTemplate>
                    </asp:TemplateField>
                </Columns>
                <FooterStyle BackColor="#FFFFCC" ForeColor="#330099" />
                <HeaderStyle BackColor="#990000" Font-Bold="True" ForeColor="#FFFFCC" />
                <PagerStyle BackColor="#FFFFCC" ForeColor="#330099" HorizontalAlign="Center" />
                <RowStyle BackColor="White" ForeColor="#330099" />
                <SelectedRowStyle BackColor="#FFCC66" Font-Bold="True" ForeColor="#663399" />
                <SortedAscendingCellStyle BackColor="#FEFCEB" />
                <SortedAscendingHeaderStyle BackColor="#AF0101" />
                <SortedDescendingCellStyle BackColor="#F6F0C0" />
                <SortedDescendingHeaderStyle BackColor="#7E0000" />
            </asp:GridView>
            <asp:EntityDataSource runat="server" ID="EntityDataSourceAuthors" ConnectionString = "name=LibraryDataBaseEntities" DefaultContainerName="LibraryDataBaseEntities" EnableFlattening="False" EntitySetName="Authors"></asp:EntityDataSource>
            <br />
            <br />
            <br />
            <asp:Button runat="server" ID="AddButtonAuthors" Text="Add Author" Font-Bold="true" Font-Size="X-Large" OnClick="RedirectToAddAuthorRecordPage"/>
        <asp:Button runat="server" ID="DeleteButtonAuthors" Text="Delete Author" Font-Bold="true" Font-Size="X-Large" OnClick="RedirectToDeleteBookRecordPage" />
        <asp:Button runat="server" ID="UpdateButtonAuthors" Text="Update Author" Font-Bold="true" Font-Size="X-Large" OnClick="RedirectToUpdateAuthorRecordPage"/>
        </div>
        <br />
        <br />
        <br />
        <div style="margin-left:auto; margin-right:auto; text-align:center">
            <asp:Label runat="server" ID="SubHeadingTenants" Text="Tenants" Font-Bold="true" Font-Size="XX-Large"></asp:Label>
            <br />
            <br />
            <br />
            <asp:GridView runat="server" ID="TenantsGridView" style="margin-left:auto; margin-right:auto; text-align:center" DataSourceID="EntityDataSourceTenants" Font-Size="X-Large" Font-Bold="true" AutoGenerateColumns="False" BackColor="White" BorderColor="#CC9966" BorderStyle="None" BorderWidth="1px" CellPadding="4" DataKeyNames="ID" Width="1298px">
                <Columns>
               <asp:TemplateField HeaderText="ID">
                        <ItemTemplate>
                            <asp:Label runat="server" ID="ID" Text='<%# Bind("ID") %>'></asp:Label>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="Name">
                        <ItemTemplate>
                            <asp:Label runat="server" ID="Name" Text='<%# Bind("Name") %>'></asp:Label>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="ID Card">
                        <ItemTemplate>
                            <asp:Label runat="server" ID="Gender" Text='<%# Bind("IDCard") %>'></asp:Label>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="Unique Citizenship Number">
                        <ItemTemplate>
                            <asp:Label runat="server" ID="UniqueCitizenshipNumber" Text='<%# Bind("UniqueCitizenshipNumber") %>'></asp:Label>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="Address">
                        <ItemTemplate>
                            <asp:Label runat="server" ID="Address" Text='<%# Bind("Address") %>'></asp:Label>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="Gender">
                        <ItemTemplate>
                            <asp:Label runat="server" ID="Gender" Text='<%# Bind("Gender") %>'></asp:Label>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="Phone Number">
                        <ItemTemplate>
                            <asp:Label runat="server" ID="PhoneNumber" Text='<%# Bind("PhoneNumber") %>'></asp:Label>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="Email">
                        <ItemTemplate>
                            <asp:Label runat="server" ID="Email" Text='<%# Bind("Email") %>'></asp:Label>
                        </ItemTemplate>
                    </asp:TemplateField>
                </Columns>
                <FooterStyle BackColor="#FFFFCC" ForeColor="#330099" />
                <HeaderStyle BackColor="#990000" Font-Bold="True" ForeColor="#FFFFCC" />
                <PagerStyle BackColor="#FFFFCC" ForeColor="#330099" HorizontalAlign="Center" />
                <RowStyle BackColor="White" ForeColor="#330099" />
                <SelectedRowStyle BackColor="#FFCC66" Font-Bold="True" ForeColor="#663399" />
                <SortedAscendingCellStyle BackColor="#FEFCEB" />
                <SortedAscendingHeaderStyle BackColor="#AF0101" />
                <SortedDescendingCellStyle BackColor="#F6F0C0" />
                <SortedDescendingHeaderStyle BackColor="#7E0000" />
            </asp:GridView>
            <asp:EntityDataSource runat="server" ID="EntityDataSourceTenants" ConnectionString="name=LibraryDataBaseEntities" DefaultContainerName="LibraryDataBaseEntities" EnableFlattening="False" EntitySetName="Tenants"></asp:EntityDataSource>
            <br />
            <br />
            <br />
            <asp:Button runat="server" ID="AddButtonTenants" Text="Add Tenant" Font-Bold="true" Font-Size="X-Large" OnClick="RedirectToAddTenantRecordPage"/>
        <asp:Button runat="server" ID="DeleteButtonTenants" Text="Delete Tenant" Font-Bold="true" Font-Size="X-Large" OnClick="RedirectToDeleteBookRecordPage" />
        <asp:Button runat="server" ID="UpdateButtonTenants" Text="Update Tenant" Font-Bold="true" Font-Size="X-Large" OnClick="RedirectToUpdateTenantRecordPage" />
        </div>   
    </form>
</body>
</html>
