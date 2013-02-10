<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="TimerPostBack.aspx.cs" Inherits="Sridhar_Bingham_L3_Q3.TimerPostBack" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <div class="container">
        This page has a timer that posts back ever second.  Like the timer in the header..  Except this timer isn't in an update panel makes the server call with a post back.
        Click on one of the other pages in order to watch the time click by without a post back.
    </div>
    <div class="label-info">
        <asp:Timer ID="uxTimerPostback" runat="server" Interval="1000" 
            ontick="uxTimerPostback_Tick">
        </asp:Timer>
        <asp:Label id="uxCurrentTime" runat="server"></asp:Label>
    </div>
</asp:Content>
