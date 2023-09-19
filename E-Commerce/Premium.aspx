<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Premium.aspx.cs" Inherits="E_Commerce.Premium" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="row row-cols-4 justify-content-evenly">
        <div class="col">
            <div class="card text-bg-secondary" style="width: 18rem;">
                <div class="card-body">
                    <h5 class="card-title">1 Mese</h5>
                    <h6 class="card-subtitle mb-2 text-body-secondary">$9.99</h6>
                    <p class="card-text">Goditi un mese di Film!</p>
                    <button class="btn btn-success">Acquista!</button>
                </div>
            </div>
        </div>

        <div class="col">
            <div class="card text-bg-secondary" style="width: 18rem;">
                <div class="card-body">
                    <h5 class="card-title">3 Mesi</h5>
                    <h6 class="card-subtitle mb-2 text-body-secondary">$19.99</h6>
                    <p class="card-text">Goditi tre mesi di Film!</p>
                    <button class="btn btn-success">Acquista!</button>
                </div>
            </div>
        </div>

        <div class="col">
            <div class="card text-bg-secondary" style="width: 18rem;">
                <div class="card-body">
                    <h5 class="card-title">12 Mesi</h5>
                    <h6 class="card-subtitle mb-2 text-body-secondary">$99.99</h6>
                    <p class="card-text">Goditi un anno intero di Film!</p>
                    <button class="btn btn-success">Acquista!</button>
                </div>
            </div>
        </div>
    </div>
</asp:Content>
