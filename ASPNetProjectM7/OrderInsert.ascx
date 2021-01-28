<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="OrderInsert.ascx.cs" Inherits="ASPNetProjectM7.OrderInsert" %>
<style type="text/css">
    .auto-style1 {
        width: 41%;
    }
    .auto-style2 {
        width: 122px;
    }
</style>


<table class="auto-style1">
    <tr >
        <td colspan="2"><h2>Order Information</h2></td>
    </tr>
    <tr>
        <td class="auto-style2">ProductId</td>
        <td>
            <asp:TextBox ID="TextBox2" runat="server" Width="163px"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td class="auto-style2">Categorys</td>
        <td>
            <asp:DropDownList ID="DropDownList1" runat="server">
                <asp:ListItem>Select</asp:ListItem>
                <asp:ListItem>A</asp:ListItem>
                <asp:ListItem>B</asp:ListItem>
                <asp:ListItem>C</asp:ListItem>
                <asp:ListItem>D</asp:ListItem>
            </asp:DropDownList>
        </td>
    </tr>
    <tr>
        <td class="auto-style2">Product Quntity</td>
        <td>
            <asp:TextBox ID="TextBox3" runat="server" Width="142px"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td class="auto-style2">OrderDate</td>
        <td>
            <asp:TextBox ID="TextBox4" runat="server" Width="142px"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td class="auto-style2">TotalAmount</td>
        <td>
            <asp:TextBox ID="TextBox5" runat="server" Width="141px"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td class="auto-style2">PaidAmount</td>
        <td>
            <asp:TextBox ID="TextBox6" runat="server" Width="143px"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td class="auto-style2">DueAmount</td>
        <td>
            <asp:TextBox ID="TextBox7" runat="server" Width="145px"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td class="auto-style2">DeliveryDate</td>
        <td>
            <asp:TextBox ID="TextBox8" runat="server" Width="145px"></asp:TextBox>
        </td>
    </tr>
</table>

<p>
    <asp:Button ID="Button1" runat="server" BackColor="Aqua" BorderColor="#0099FF" OnClick="Button1_Click" Text="Insert Order" Width="95px" />
</p>


