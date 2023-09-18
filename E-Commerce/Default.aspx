﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="E_Commerce.Home" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <script src="Scripts/default.js"></script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h3 class="fw-bold text-white text-center">Interstellar</h3>
    <div class="d-flex justify-content-center preview-container position-relative w-100">
        <video autoplay id="video" runat="server" class="w-100" controls>
            <source src="Content/assets/interstellar.mp4" />
        </video>
    </div>

</asp:Content>
