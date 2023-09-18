<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="List.aspx.cs" Inherits="E_Commerce.Admin.List" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">


    <div class="mx-5 text-center">
    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="true" CssClass="table table-bordered table-striped table-hover">
        <HeaderStyle CssClass="table-primary" />
        <RowStyle CssClass="table table-light" />
        <AlternatingRowStyle CssClass="table-secondary" />
    </asp:GridView>
    </div>



</asp:Content>
