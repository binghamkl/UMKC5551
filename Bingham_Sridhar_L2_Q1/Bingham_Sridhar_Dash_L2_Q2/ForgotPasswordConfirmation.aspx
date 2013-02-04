<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="ForgotPasswordConfirmation.aspx.cs" Inherits="ForgotPasswordConfirmation" %>

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
                <td>Favorite Color</td>
                <td><asp:Label ID="uxColor" runat="server"></asp:Label></td>
            </tr>
            <tr>
                <td>Recovered Password</td>
                <td><asp:Label ID="uxPassword" runat="server"></asp:Label></td>
            </tr>
        </table>
    </div>


</asp:Content>

