<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="AddOneToAnother._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="container">
    <div class="row">
        <h1>Add One Here</h1>
        <asp:TextBox ID ="inputBox" runat="server"></asp:TextBox>
        <asp:Button ID ="computate" text="calculate" runat="server"/>
        <asp:Label ID="result" Text="result" runat="server"></asp:Label>
    </div>
</div>

</asp:Content>
