<%@ Page Title="" Language="C#" MasterPageFile="~/dashboard.Master" AutoEventWireup="true" CodeBehind="OrderInfo.aspx.cs" Inherits="ASPNetProjectM7.OrderInfo" %>

<%@ Register Src="~/OrderInsert.ascx" TagPrefix="uc1" TagName="OrderInsert" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <script src="Scripts/jquery-3.0.0.min.js"></script>
    <script src="Scripts/jquery-ui.js"></script>
    <link href="Scripts/jquery-ui.css" rel="stylesheet" />
    <script>
        $(document).ready(function () {
            $("input[Id$=TextBox4]").datepicker({
                appendText: "Select Date"
            })
        })

        $(document).ready(function () {
            $("input[Id$=TextBox8]").datepicker({
                appendText: "Select Date"
            })
        })
    </script>
    <br />
    <asp:GridView ID="GridView1" runat="server" OnPageIndexChanging="GridView1_PageIndexChanging" OnRowCancelingEdit="GridView1_RowCancelingEdit" OnRowDeleting="GridView1_RowDeleting" OnRowEditing="GridView1_RowEditing" OnRowUpdating="GridView1_RowUpdating">
        <Columns>
            <asp:CommandField ShowEditButton="True" />
            <asp:CommandField ShowDeleteButton="True" />
        </Columns>
    </asp:GridView>

      <br />
    <uc1:OrderInsert runat="server" ID="OrderInsert" />
</asp:Content>
