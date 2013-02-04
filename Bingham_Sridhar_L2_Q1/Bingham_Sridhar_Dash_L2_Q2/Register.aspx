<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="Register.aspx.cs" Inherits="Register" %>

<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" Runat="Server">

        <div class="container">
            <h1>Let's Register</h1>
            
            <table>
                <tr>
                    <td>Name :</td>
                    <td>
                        <asp:TextBox ID="txtName" runat="server"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="uxNameRequired" runat="server" ControlToValidate="txtname" ErrorMessage="Name Required" CssClass="label label-warning"></asp:RequiredFieldValidator>
                     </td>
                </tr>
                <tr>
                    <td>Email: </td>
                    <td>
                        <asp:TextBox ID="txtEmail" runat="server"></asp:TextBox>
                        <asp:RegularExpressionValidator id="EmailValidator" runat="server" 
                            ControlToValidate="txtEmail" CssClass="label label-warning" 
                            ErrorMessage="Incorrect Email format" 
                            ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator>
                    </td>
                </tr>
                <tr>
                    <td>Password:</td>
                    <td>
                        <asp:TextBox ID="txtPassword" runat="server" TextMode="Password"></asp:TextBox>
                        <asp:CustomValidator ID="uxPasswordValidator" runat="server" 
                            CssClass="lable label-warning" ErrorMessage="Password must be 7-characters." 
                            onservervalidate="uxPasswordValidator_ServerValidate"></asp:CustomValidator>
                    </td>
                </tr>
                <tr>
                    <td>Gender: </td>
                    <td>
                        <asp:DropDownList ID="uxGender" runat="server">
                            <asp:ListItem Text="Male" Value="Male"></asp:ListItem>
                            <asp:ListItem Text="Female" Value="Female"></asp:ListItem>
                        </asp:DropDownList>
                    </td>
                </tr>
                <tr>
                    <td>Phone No:</td>
                    <td>
                        <asp:TextBox ID="txtPhoneNumber" runat="server"></asp:TextBox>
                        <asp:RegularExpressionValidator ID="uxPhoneNumberValidator" runat="server" 
                            CssClass="label label-warning" ControlToValidate="txtPhoneNumber" 
                            ErrorMessage="Phone Format should be ###-###-####" 
                            ValidationExpression="((\(\d{3}\) ?)|(\d{3}-))?\d{3}-\d{4}"></asp:RegularExpressionValidator>
                    </td>
                </tr>
                <tr>
                    <td>Subscribe To:</td>
                    <td>
                        <div class="radio">
                        <asp:RadioButtonList ID="uxSubscribeTo" runat="server" >
                            <asp:ListItem Text="Readers Digest" Value="Readers Digest"></asp:ListItem>
                            <asp:ListItem Text="New York Times" Value="New York Times"></asp:ListItem>
                            <asp:ListItem Text="Motor Trend" Value="Motor Trend"></asp:ListItem>
                        </asp:RadioButtonList>
                        </div>
                    </td>
                </tr>
            </table>
            
            
            <asp:Button runat="server" ID="uxSubmit" Text="Submit" CssClass="btn btn-primary" 
                onclick="uxSubmit_Click" />
            <asp:Button runat="server" ID="uxCancel" Text="Cancel" CssClass="btn" CausesValidation="false" 
                onclick="uxCancel_Click" />

            <asp:Label ID="uxWarning" runat="server" CssClass="label label-warning" Visible="false"></asp:Label>

        </div>

</asp:Content>

