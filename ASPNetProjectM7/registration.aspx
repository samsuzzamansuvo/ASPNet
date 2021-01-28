<%@ Page Title="" Language="C#" MasterPageFile="~/Index.Master" AutoEventWireup="true" CodeBehind="registration.aspx.cs" Inherits="ASPNetProjectM7.registration" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container w-75">
        <div class="d-flex justify-content-center py-3">
            <h2>Register As New Member</h2>
        </div>
        <div class="row">
            <asp:Label ID="lblSuccess" runat="server" Text="" ForeColor="Green"></asp:Label>
            <asp:Label ID="lblError" runat="server" Text="" ForeColor="Red"></asp:Label>
        </div>
        <div class="row py-3">
            <div class="col-sm-6">
                <img src="images/signup-image.jpg" />
            </div>
            <div class="col-sm-6">
                <div class="form-group">
                    <label for="name">User Name</label>
                    <asp:TextBox ID="username" class="form-control" runat="server" placeholder="Enter your name"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="username" ErrorMessage="*User name is required" ForeColor="#FF3300"></asp:RequiredFieldValidator>
                </div>
                <div class="form-group">
                    <label for="exampleInputEmail1">Email address</label>
                    <asp:TextBox ID="email" TextMode="Email" class="form-control" runat="server" placeholder="Enter email"></asp:TextBox>
                    <small id="emailHelp" class="form-text text-muted">We'll never share your email with anyone else.<br />
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="email" ErrorMessage="*Email address is required" ForeColor="Red"></asp:RequiredFieldValidator>
                    <br />
                    <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="email" ErrorMessage="*please insert a valid email address" ForeColor="Red"></asp:RegularExpressionValidator>
                    </small></div>
                <div class="form-group">
                    <label for="exampleInputEmail1">Password</label>
                    <asp:TextBox ID="password" TextMode="Password" class="form-control" runat="server" placeholder="Enter password"></asp:TextBox>
                    <asp:RangeValidator ID="RangeValidator1" runat="server" ControlToValidate="password" ErrorMessage="*password must be atleast 7 character long" MaximumValue="7" MinimumValue="15" ForeColor="Red"></asp:RangeValidator>
                    <br />
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="password" ErrorMessage="*Password is required" ForeColor="Red"></asp:RequiredFieldValidator>
                </div>
                <div class="form-group">
                    <label for="exampleFormControlTextarea1">Address</label>
                    <asp:TextBox ID="address" class="form-control" runat="server" placeholder="Enter your address"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="address" ErrorMessage="*Please insert your address" ForeColor="Red"></asp:RequiredFieldValidator>
                </div>
                <div class="form-group">
                    <label for="exampleFormControlTextarea1">Image</label>
                    <asp:FileUpload ID="FileUpload1" runat="server" />
                </div>

                <asp:Button ID="btnSignup" class="btn btn-primary" runat="server" Text="Sign Up" OnClick="btnSignup_Click" />
            </div>
        </div>
    </div>
</asp:Content>
