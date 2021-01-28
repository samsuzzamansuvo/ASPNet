<%@ Page Title="" Language="C#" MasterPageFile="~/Index.Master" AutoEventWireup="true" CodeBehind="login.aspx.cs" Inherits="ASPNetProjectM7.login" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <div class="container w-75">
        <div class="d-flex justify-content-center py-5">
            <h2>Login Your Account</h2>
        </div>
        <div class="row py-5">
            <div class="col-sm-6">
                <img src="images/signin-image.jpg" />
            </div>
            <div class="col-sm-6">
                <div class="form-group">
                    <label for="exampleInputEmail1">Email address</label>
                    <asp:TextBox ID="email" TextMode="Email" runat="server" class="form-control" placeholder="Enter email" aria-describedby="emailHelp"></asp:TextBox>
                    <small id="emailHelp" class="form-text text-muted">We'll never share your Password with anyone else.</small>
                </div>
                <div class="form-group">
                    <label for="exampleInputPassword1">Password</label>
                    <asp:TextBox ID="password" TextMode="Password" runat="server" class="form-control" placeholder="Password"></asp:TextBox>
                </div>
                <asp:Button ID="btnLogin" class="btn btn-primary" runat="server" Text="LogIN" OnClick="btnLogin_Click" />
            </div>
        </div>
    </div>
</asp:Content>
