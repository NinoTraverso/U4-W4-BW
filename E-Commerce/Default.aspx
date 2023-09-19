<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="E_Commerce.Home" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="Content/Site.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h3 class="fw-bold text-white text-center">Interstellar</h3>
    <div class="d-flex justify-content-center preview-container position-relative w-100">
        <video autoplay muted id="video" runat="server" class="w-100" controls>
            <source src="Content/assets/interstellar.mp4" />
        </video>
    </div>

    <div class="anchor-container mb-5 d-flex align-items-center justify-content-evenly text-bg-secondary">
        <a href="#Azione" class="btn btn-warning px-2 my-2">Azione</a>
        <a href="#Fantascienza" class="btn btn-info px-2 my-2">Fantascienza</a>
        <a href="#Horror" class="btn btn-danger px-2 my-2">Horror</a>
        <a href="#Fantasy" class="btn btn-success px-2 my-2">Fantasy</a>
        <a href="#Commedia" class="btn btn-light px-2 my-2">Commedia</a>
    </div>


    <h2 id="Azione" class="text-center">Azione</h2>
    <div class="row">
        <asp:Repeater ID="RepeaterAzione" runat="server" ItemType="E_Commerce.Models.Film">
            <ItemTemplate>
                <div class="col-4">
                    <div class="card text-bg-secondary" style="width: 18rem;">
                        <a href="Detail.aspx?idFilm=<%# Item.Id %>">
                            <img src="Content/assets/<%# Item.CoverImg %>" class="card-img-top" alt="<%# Item.Title %>">
                        </a>

                    </div>
                </div>
            </ItemTemplate>
        </asp:Repeater>
    </div>

    <h2 id="Fantascienza" class="text-center">Fantascienza</h2>
<div class="row">
    <asp:Repeater ID="RepeaterFantascienza" runat="server" ItemType="E_Commerce.Models.Film">
        <ItemTemplate>
            <div class="col-4">
                <div class="card text-bg-secondary" style="width: 18rem;">
                    <a href="Detail.aspx?idFilm=<%# Item.Id %>">
                        <img src="Content/assets/<%# Item.CoverImg %>" class="card-img-top" alt="<%# Item.Title %>">
                    </a>

                </div>
            </div>
        </ItemTemplate>
    </asp:Repeater>
</div>

        <h2 id="Horror" class="text-center">Horror</h2>
<div class="row">
    <asp:Repeater ID="RepeaterHorror" runat="server" ItemType="E_Commerce.Models.Film">
        <ItemTemplate>
            <div class="col-4">
                <div class="card text-bg-secondary" style="width: 18rem;">
                    <a href="Detail.aspx?idFilm=<%# Item.Id %>">
                        <img src="Content/assets/<%# Item.CoverImg %>" class="card-img-top" alt="<%# Item.Title %>">
                    </a>

                </div>
            </div>
        </ItemTemplate>
    </asp:Repeater>
</div>

        <h2 id="Fantasy" class="text-center">Fantasy</h2>
<div class="row">
    <asp:Repeater ID="RepeaterFantasy" runat="server" ItemType="E_Commerce.Models.Film">
        <ItemTemplate>
            <div class="col-4">
                <div class="card text-bg-secondary" style="width: 18rem;">
                    <a href="Detail.aspx?idFilm=<%# Item.Id %>">
                        <img src="Content/assets/<%# Item.CoverImg %>" class="card-img-top" alt="<%# Item.Title %>">
                    </a>

                </div>
            </div>
        </ItemTemplate>
    </asp:Repeater>
</div>

        <h2 id="Commedia" class="text-center">Commedia</h2>
<div class="row">
    <asp:Repeater ID="RepeaterCommedia" runat="server" ItemType="E_Commerce.Models.Film">
        <ItemTemplate>
            <div class="col-4">
                <div class="card text-bg-secondary" style="width: 18rem;">
                    <a href="Detail.aspx?idFilm=<%# Item.Id %>">
                        <img src="Content/assets/<%# Item.CoverImg %>" class="card-img-top" alt="<%# Item.Title %>">
                    </a>

                </div>
            </div>
        </ItemTemplate>
    </asp:Repeater>
</div>

</asp:Content>
