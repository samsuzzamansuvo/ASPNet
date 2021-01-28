<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="CustomerInsert.ascx.cs" Inherits="ASPNetProjectM7.CustomerInsert" %>
<style type="text/css">
    .auto-style1 {
        width: 365px;
    }
    .auto-style2 {
        width: 216px;
    }
</style>
<table class="auto-style1">
    <tr>
        <td><h2>Customer Information</h2></td>
    </tr>
    <tr>
        <td>Customer Name</td>
        <td>:</td>
        <td class="auto-style2">
            <asp:TextBox ID="Name" runat="server"></asp:TextBox>
        </td>
    </tr>

     <tr>
        <td>Age</td>
        <td>:</td>
        <td class="auto-style2">
            <asp:TextBox ID="age" runat="server"></asp:TextBox>
        </td>
    </tr>

     <tr>
        <td>Email</td>
        <td>:</td>
        <td class="auto-style2">
            <asp:TextBox ID="email" runat="server"></asp:TextBox>
        </td>
    </tr>

     <tr>
        <td>Confirm Email</td>
        <td>:</td>
        <td class="auto-style2">
            <asp:TextBox ID="conEmail" runat="server"></asp:TextBox>
        </td>
    </tr>

     <tr>
        <td>Address</td>
        <td>:</td>
        <td class="auto-style2">
            <asp:TextBox ID="address" runat="server"></asp:TextBox>
        </td>
    </tr>

    <tr>
        <td>image</td>
        <td>:</td>
        <td class="auto-style2">
            <asp:FileUpload ID="FileUpload1" runat="server" />
        </td>
        <td>
            &nbsp;</td>
    </tr>

    <tr>
        <td>
            <asp:Button ID="btnInsert" runat="server" Text="Button" OnClick="btnInsert_Click" />
        </td>
    </tr>
</table>