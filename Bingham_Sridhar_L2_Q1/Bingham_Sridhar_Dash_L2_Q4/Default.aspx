<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<asp:Content ID="HeaderContent" runat="server" ContentPlaceHolderID="HeadContent">
</asp:Content>
<asp:Content ID="BodyContent" runat="server" ContentPlaceHolderID="MainContent">
    <div id="SearchInfoDiv">
        <div>
            <pre>This is an example of consuming a web service from http://www.webservicex.net/uszip.asmx.  Just enter your zip code below.  Entering an invalid zip code will result in empty data being returned.</pre>
        </div>
        <div class="form-search">
        <div class="input-append">
            Enter Zip Code : 
            <asp:TextBox ID="uxZipCode" placeholder="Zip Code" runat="server" CssClass="span2 search-query" ></asp:TextBox>
            <asp:Button ID="uxSearchZip" runat="server" Text="Search" CssClass="btn" 
                onclick="uxSearchZip_Click" />
        </div>
        </div>
    </div>
    <div id="raw">
        <h2>Raw</h2>
        <asp:Literal ID="uxRaw" runat="server" Mode="Encode"></asp:Literal>
    </div>
    <div class="row-fluid">
        <div id="RawXMLDiv" class="span6 alert-success">
            <h2>Tree View</h2>
            <asp:TreeView ID="uxRawXMLTree" runat="server" ></asp:TreeView>
        </div>
        <div id="DeserializedDiv" class="span6 alert-info">
            <h2>DeSerialized</h2>
            <table class="table table-bordered table-hover">
                <tr>
                    <td>City:</td>
                    <td><asp:Label ID="uxCity" runat="server"></asp:Label></td>
                </tr>
                <tr>
                    <td>State:</td>
                    <td><asp:Label ID="uxState" runat="server"></asp:Label></td>
                </tr>
                <tr>
                    <td>Zip Code:</td>
                    <td><asp:Label ID="uxZip" runat="server"></asp:Label></td>
                </tr>
                <tr>
                    <td>Area Code:</td>
                    <td><asp:Label ID="uxAreaCode" runat="server"></asp:Label></td>
                </tr>
                <tr>
                    <td>Time Zone:</td>
                    <td><asp:Label ID="uxTimeZone" runat="server"></asp:Label></td>
                </tr>
            </table>
        </div>
        <div>   
            <asp:Label ID="uxWarningError" CssClass="label-warning" runat="server"></asp:Label>
        </div>
    </div>
</asp:Content>
