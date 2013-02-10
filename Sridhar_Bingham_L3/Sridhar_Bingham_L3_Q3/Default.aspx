<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true"
    CodeBehind="Default.aspx.cs" Inherits="Sridhar_Bingham_L3_Q3._Default" %>

<asp:Content ID="HeaderContent" runat="server" ContentPlaceHolderID="HeadContent">
</asp:Content>
<asp:Content ID="BodyContent" runat="server" ContentPlaceHolderID="MainContent">
    <div class="hero-unit">
        This example uses the webservice we created in Question 1 of Lab 3.  The webserver is on our cloud server at
        http://vhost1693.site1.compute.ihost.com/lab3/AccountService.asmx
    </div>
    <div class="help-block">
      <div class="row-fluid">
        <div class="span5">
            This side uses a normal post back.
            <asp:TextBox ID="uxUserNamePostBack" runat="server" placeholder="UserName"></asp:TextBox>
            <asp:TextBox ID="uxDepositPostback" runat="server" placeholder="Deposit"></asp:TextBox>
            <asp:Button ID="uxDepositAmountPostBack" runat="server" CssClass="btn" 
                Text="Deposit into account" onclick="uxDepositAmountPostBack_Click" />
            <table class="table table-bordered table-hover">
                <tr>
                    <td>Succeeded</td>
                    <td><asp:Label ID="uxStatusPostback" runat="server"></asp:Label></td>
                </tr>
                <tr class="error">
                    <td>Error</td>
                    <td><asp:Label ID="uxErrorPostback" runat="server"></asp:Label></td>
                </tr>
                <tr>
                    <td>Transaction Msg</td>
                    <td><asp:Label ID="uxTranMsgPostback" runat="server"></asp:Label></td>
                </tr>
            </table>
        </div>
        <div class="span5">
            This side uses Ajax to post back
            <asp:UpdatePanel ID="uxUpdatePanel" runat="server">
                <ContentTemplate>
                    <asp:TextBox ID="uxUserNameAjax" runat="server" placeholder="UserName"></asp:TextBox>
                    <asp:TextBox ID="uxDepositAjax" runat="server" placeholder="Deposit"></asp:TextBox>
                    <asp:Button ID="uxDepositAmountAjax" runat="server" CssClass="btn" 
                        Text="Deposit into account" onclick="uxDepositAmountAjax_Click" />

                    <table class="table table-bordered table-hover">
                        <tr>
                            <td>Succeeded</td>
                            <td><asp:Label ID="uxStatusAjax" runat="server"></asp:Label></td>
                        </tr>
                        <tr class="error">
                            <td>Error</td>
                            <td><asp:Label ID="uxErrorAjax" runat="server"></asp:Label></td>
                        </tr>
                        <tr>
                            <td>Transaction Msg</td>
                            <td><asp:Label ID="uxTranMsgAjax" runat="server"></asp:Label></td>
                        </tr>
                    </table>

                </ContentTemplate>
            </asp:UpdatePanel>
        </div>
      </div>
    </div>
</asp:Content>
