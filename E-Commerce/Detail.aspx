<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Detail.aspx.cs" Inherits="E_Commerce.Detail" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container-fluid" id="container" runat="server">

            <div class="row justify-content-center">
                <div class="col-8">
                    <div class="card bg-dark d-flex shadow-lg">
                        <div class="card-header text-center">
                            <asp:Label ID="title" runat="server" CssClass="fs-2 fw-bold"></asp:Label>
                        </div>
                        <div class="position-relative">
                            <asp:Image ID="backgroundImage" runat="server" CssClass="card-img-top" />
                            <div class="">
                                <asp:Image ID="ImageCover" runat="server" CssClass="position-absolute bottom-0 start-0 w-25 border border-danger shadow-lg" />
                            </div>
                        </div>

                        <div class="card-body">
                            
                            <p class="card-text" id="year" runat="server"></p>
                            <asp:Button ID="AddCart" runat="server" Text="Metti nel carrello" CssClass="btn btn-success" />
                        </div>
                    </div>
                </div>
            </div>
        </div>
</asp:Content>

