<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="ProductInsert.ascx.cs" Inherits="ASPNetProjectM7.ProductInsert" %>
<style type="text/css">
    .auto-style1 {
        width: 51%;
    }
    .auto-style2 {
        width: 111px;
    }
</style>

<table class="auto-style1">
    <tr>
        <td class="auto-style2">&nbsp;</td>
        <td>&nbsp;</td>
    </tr>
    <tr>
        <td class="auto-style2">ProductName</td>
        <td>
            <asp:TextBox ID="TextBox1" runat="server" Width="147px"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td class="auto-style2">Product Quantity</td>
        <td>
            <asp:TextBox ID="TextBox2" runat="server" Width="145px"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td class="auto-style2">Price</td>
        <td>
            <asp:TextBox ID="TextBox3" runat="server" Width="140px"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td class="auto-style2">&nbsp;Total Amount&nbsp;</td>
        <td>
            <asp:TextBox ID="TextBox4" runat="server" Width="141px"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td>Upload Image</td>
        <td>:</td>
        <asp:FileUpload ID="FileUpload1" runat="server" />
    </tr>
</table>
<p>
    <asp:Button ID="Button1" runat="server" BackColor="Aqua" Text="Save Data" Width="108px" OnClick="Button1_Click" />
</p>

