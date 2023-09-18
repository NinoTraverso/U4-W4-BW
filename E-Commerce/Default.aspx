<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="E_Commerce.Home" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="d-flex justify-content-center preview-container position-relative">
        <video autoplay class="w-75" id="video" runat="server">
            <source src="Content/assets/interstellar.mp4" />
        </video>
        <div id="preview-overlay">
            <div id="preview-details" class="ms-3">
                <h3 class="fw-bold">Interstellar</h3>
                <button><i class="fa-solid fa-play p-2"> Play</i></button>
                <button id="muteButton" runat="server" OnClick="muteVideo"><i class="fa-solid fa-volume-mute p-2"></i></button>
            </div>
        </div>
    </div>

</asp:Content>
