<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="search.aspx.cs" Inherits="E_Commerce.search" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:TextBox ID="ToSearch" runat="server"></asp:TextBox>
    <asp:Button ID="Button1" runat="server" Text="Cerca" OnClick="Button1_Click" />

    <asp:Repeater ID="RepeaterFound" runat="server" ItemType="E_Commerce.Models.Film">
        <ItemTemplate>
           <p class="glass text-light"><%# Item.Title %></p> 
        </ItemTemplate>
    </asp:Repeater>
</asp:Content>
