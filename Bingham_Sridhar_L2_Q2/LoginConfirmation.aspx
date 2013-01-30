<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="LoginConfirmation.aspx.cs" Inherits="LoginConfirmation" %>

<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" Runat="Server">

    <div class="container">
        <h2>Login Values</h2>
        <table class="table table-hover table-bordered">
            <tr>
                <td>Email</td>
                <td><asp:Label ID="uxEmail" runat="server" ></asp:Label></td>
            </tr>
            <tr>
                <td>Password</td>
                <td><asp:Label ID="uxPassword" runat="server"></asp:Label></td>
            </tr>
            <tr>
                <td>Remember Me</td>
                <td><asp:Label ID="uxRememberMe" runat="server"></asp:Label></td>
            </tr>
        </table>
    </div>

</asp:Content>

