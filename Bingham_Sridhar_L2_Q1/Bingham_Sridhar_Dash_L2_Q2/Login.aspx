<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="Login.aspx.cs" Inherits="Login" %>

<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" Runat="Server">
</asp:Content>


<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" Runat="Server">
    <div class="form-horizontal">
        <h2>Enter Login</h2>
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
            <label class="control-label" for="inputPassword">Password</label>
            <div class="controls">
                <asp:TextBox ID="uxPassword" runat="server" TextMode="Password" placeholder="Enter Password"></asp:TextBox>
                <asp:RequiredFieldValidator ID="uxPasswordRequired" runat="server" ErrorMessage="You must enter a password" ControlToValidate="uxPassword" CssClass="label label-warning"></asp:RequiredFieldValidator>
                <asp:CustomValidator ID="uxPasswordValidator" runat="server" ControlToValidate="uxPassword" 
                            CssClass="lable label-warning" ErrorMessage="Password must be 7-characters." 
                            onservervalidate="uxPasswordValidator_ServerValidate"></asp:CustomValidator>
            </div>
        </div>
        <div class="control-group">
            <div class="controls">
                <label class="checkbox">
                    <asp:CheckBox ID="uxRememberMe" runat="server" Text="Remember Me" />
                </label>
                <asp:Button ID="uxSubmitLogin" runat="server" CssClass="btn-primary btn" 
                    Text="Login" onclick="uxSubmitLogin_Click" />
            </div>
        </div>
    </div>
    <div class="well-large form-horizontal">
        <asp:LinkButton ID="uxForgotPassword" runat="server" CssClass="btn" PostBackUrl="ForgotPassword.aspx" Text="I forgot my Password" CausesValidation="false"></asp:LinkButton>
        <asp:LinkButton ID="uxRegister" runat="server" CssClass="btn" PostBackUrl="Register.aspx" Text="I don't have an account.  Let me register" CausesValidation="false"></asp:LinkButton>
    </div>
</asp:Content>

