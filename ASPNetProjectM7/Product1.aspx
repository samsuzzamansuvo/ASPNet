<%@ Page Title="" Language="C#" MasterPageFile="~/dashboard.Master" AutoEventWireup="true" CodeBehind="Product1.aspx.cs" Inherits="ASPNetProjectM7.Product1" %>

<%@ Register Src="~/ProductInsert.ascx" TagPrefix="uc1" TagName="ProductInsert" %>




<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <br />
    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataSourceID="ObjectDataSource1" DataKeyNames="Id">
        <Columns>
            <asp:CommandField ShowDeleteButton="True" ShowEditButton="True" />
            <asp:BoundField DataField="Id" HeaderText="Id" SortExpression="Id" />
            <asp:BoundField DataField="ProductName" HeaderText="ProductName" SortExpression="ProductName" />
            <asp:BoundField DataField="ProductQTY" HeaderText="ProductQTY" SortExpression="ProductQTY" />
            <asp:BoundField DataField="Price" HeaderText="Price" SortExpression="Price" />
            <asp:BoundField DataField="TotalAmount" HeaderText="TotalAmount" SortExpression="TotalAmount" />
            <asp:BoundField DataField="ProductImage" HeaderText="ProductImage" SortExpression="ProductImage" />
            <asp:ImageField HeaderText="Image" DataImageUrlField="ProductImage" ControlStyle-Height="75px" ControlStyle-Width="75px">
            </asp:ImageField>
        </Columns>
</asp:GridView>
    <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" DeleteMethod="DeleteProduct" InsertMethod="InsertProduct" SelectMethod="productCls" TypeName="ASPNetProjectM7.DAL.ProductClsGetWway1" UpdateMethod="UpdateProduct">
        <DeleteParameters>
            <asp:Parameter Name="Id" Type="Int32" />
        </DeleteParameters>
        <InsertParameters>
            <asp:Parameter Name="ProductName" Type="String" />
            <asp:Parameter Name="ProductQTY" Type="Decimal" />
            <asp:Parameter Name="Price" Type="Decimal" />
            <asp:Parameter Name="TotalAmount" Type="Decimal" />
            <asp:Parameter Name="ProductImage" Type="String" />
        </InsertParameters>
        <UpdateParameters>
            <asp:Parameter Name="ProductName" Type="String" />
            <asp:Parameter Name="ProductQTY" Type="Decimal" />
            <asp:Parameter Name="Price" Type="Decimal" />
            <asp:Parameter Name="TotalAmount" Type="Decimal" />
            <asp:Parameter Name="ProductImage" Type="String" />
            <asp:Parameter Name="Id" Type="Int32" />
        </UpdateParameters>
    </asp:ObjectDataSource>
    <br />
    <uc1:ProductInsert runat="server" ID="ProductInsert" />
</asp:Content>
