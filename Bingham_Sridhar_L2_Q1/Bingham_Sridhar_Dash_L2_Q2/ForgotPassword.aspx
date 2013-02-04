<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="ForgotPassword.aspx.cs" Inherits="ForgotPassword" %>

<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" Runat="Server">

    <div class="form-horizontal">
        <h2>So you forgot your password?  Enter your information</h2>
        <div class="control-group">
            <label class="control-label" for="inputEmail">Email</label>
            <div class="controls">
                <asp:TextBox ID="uxEmail" runat="server" placeholder="Enter Email"></asp:TextBox>
                <asp:RequiredFieldValidator ID="uxEmailRequred" runat="server" ErrorMessage="You must enter an email address" ControlToValidate="uxEmail" placeholder="Email" CssClass="label label-warning"></asp:RequiredFieldValidator>
                <asp:RegularExpressionValidator id="EmailValidator" runat="server" 
                            ControlToValidate="uxEmail" CssClass="label label-warning" 
                            ErrorMessage="Incorrect Email format" 
                            ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*">
                 </asp:RegularExpressionValidator>

            </div>
        </div>
        <div class="control-group">
            <label class="control-label" for="inputPassword">Favorite Color.  Security Question.</label>
            <div class="controls">
                <asp:TextBox ID="uxColor" runat="server" placeholder="Enter your security"></asp:TextBox>
                <asp:RequiredFieldValidator ID="uxPasswordRequired" runat="server" ErrorMessage="You must enter a password" ControlToValidate="uxColor" CssClass="label label-warning"></asp:RequiredFieldValidator>
            </div>
        </div>
        <div class="control-group">
            <div class="controls">
                <asp:Button ID="uxRecoverPassword" runat="server" CssClass="btn-primary btn" 
                    Text="Recover Password" onclick="uxRecoverPassword_Click"  />
            </div>
        </div>
    </div>

</asp:Content>

