<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Registered.aspx.cs" Inherits="Bingham_Sridhar_L2_Q1.Registered" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Registration Successful</title>
    <link href="css/bootstrap.css" rel="Stylesheet" type="text/css" />
    <link href="css/bootstrap-responsive.css" rel="Stylesheet" type="text/css" />
</head>
<body>
    <form id="form1" runat="server">
        <div class="container">
            <h1>Magazine Subscription</h1>
            
            <table>
                <tr>
                    <td>Name :</td>
                    <td>
                        <asp:Label ID="lblName" runat="server"></asp:Label>
                     </td>
                </tr>
                <tr>
                    <td>Email: </td>
                    <td>
                        <asp:Label ID="lblEmail" runat="server"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td>Password:</td>
                    <td>
                        <asp:Label ID="lblPassword" runat="server"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td>Gender: </td>
                    <td>
                        <asp:Label ID="lblGender" runat="server"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td>Phone No:</td>
                    <td>
                        <asp:Label ID="lblPhoneNo" runat="server"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td>Subscribe To:</td>
                    <td>
                        <asp:Label ID="lblSubscribeTo" runat="server"></asp:Label>
                    </td>
                </tr>
            </table>
            
            
            <asp:Label ID="uxWarning" runat="server" CssClass="label label-warning" Visible="false"></asp:Label>

        </div>
    </form>
    <script src="js/jquery-1.9.0.js" type="text/javascript"></script>
    <script src="js/bootstrap.js" type="text/javascript"></script>
</body>
</html>
