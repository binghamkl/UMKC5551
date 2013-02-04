<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="RegistrationConfirmation.aspx.cs" Inherits="RegistrationConfirmation" %>

<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" Runat="Server">

        <div class="container">
            <h1>Registration Complete</h1>
            
            <table>
                <tr>
                    <td>Name :</td>
                    <td><asp:Label ID="lblName" runat="server"></asp:Label></td>
                </tr>
                <tr>
                    <td>Email: </td>
                    <td><asp:Label ID="lblEmail" runat="server"></asp:Label></td>
                </tr>
                <tr>
                    <td>Password:</td>
                    <td><asp:Label ID="lblPassword" runat="server"></asp:Label></td>
                </tr>
                <tr>
                    <td>Gender: </td>
                    <td><asp:Label ID="lblGender" runat="server"></asp:Label></td>
                </tr>
                <tr>
                    <td>Phone No:</td>
                    <td><asp:Label ID="lblPhoneNo" runat="server"></asp:Label></td>
                </tr>
                <tr>
                    <td>Subscribe To:</td>
                    <td><asp:Label ID="lblSubscribeTo" runat="server"></asp:Label></td>
                </tr>
            </table>
            
            
            <asp:Label ID="uxWarning" runat="server" CssClass="label label-warning" Visible="false"></asp:Label>

        </div>

</asp:Content>

