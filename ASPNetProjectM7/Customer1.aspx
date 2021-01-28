<%@ Page Title="" Language="C#" MasterPageFile="~/dashboard.Master" AutoEventWireup="true" CodeBehind="Customer1.aspx.cs" Inherits="ASPNetProjectM7.Customer1" %>

<%@ Register Src="~/CustomerInsert.ascx" TagPrefix="uc1" TagName="CustomerInsert" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <br />
    <asp:gridview ID="GridView1" runat="server" OnPageIndexChanging="Unnamed1_PageIndexChanging"
        OnRowCancelingEdit="Unnamed1_RowCancelingEdit" 
        OnRowDeleting="Unnamed1_RowDeleting" 
        OnRowEditing="Unnamed1_RowEditing" 
        OnRowUpdating="Unnamed1_RowUpdating" DataKeyNames="Id">
        <Columns>
            <asp:CommandField ShowEditButton="True" />
            <asp:CommandField ShowDeleteButton="True" />
           <asp:ImageField HeaderText="image" DataImageUrlField="ImageUrl" ControlStyle-Height="75px" ControlStyle-Width="75px" >
            </asp:ImageField>
        </Columns>
     </asp:gridview>
    <br />
    <uc1:CustomerInsert runat="server" ID="CustomerInsert" />
</asp:Content>
