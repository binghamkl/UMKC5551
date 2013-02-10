<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Extreme.aspx.cs" Inherits="Sridhar_Bingham_L3_Q3.Extreme" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <div class="hero-unit">
        This example does a 5 second wait on the server.  Giving a better indication of what's going on.
    </div>
    <div class="help-block">
      <div class="row-fluid">
        <div class="span5">
            This side uses a normal post back.
            <asp:Button ID="uxPostback" runat="server" Text="Run Postback"  CssClass="btn"
                onclick="uxPostback_Click" />
            <asp:Label ID="uxPostbackResult" runat="server"></asp:Label>
        </div>
        <div class="span5">
            This side uses Ajax to post back
            <asp:UpdatePanel ID="uxUpdatePanel" runat="server">
                <ContentTemplate>
                    <asp:Button ID="uxAjax" runat="server" Text="Run Ajax" onclick="uxAjax_Click" CssClass="btn" />
                    <asp:Label ID="uxAjaxResult" runat="server"></asp:Label>
                    <asp:UpdateProgress ID="uxupdateProgress" runat="server" >
                        <ProgressTemplate>
                            <div class="progress-info">
                                Posting back to the server
                            </div>
                        </ProgressTemplate>
                    </asp:UpdateProgress>
                </ContentTemplate>
            </asp:UpdatePanel>
        </div>
      </div>
    </div>
</asp:Content>
