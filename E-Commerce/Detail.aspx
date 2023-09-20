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
                    <div class="position-relative px-5">
                        <asp:Image ID="backgroundImage" runat="server" CssClass="card-img-top" />
                        <div class="">
                            <asp:Image ID="ImageCover" runat="server" CssClass="position-absolute bottom-0 start-0 w-25 border border-danger shadow-lg" />
                        </div>
                    </div>

                    <div class="card-body">
                        <div class="px-5">
                            <span id="badge" runat="server"></span>
                            <p class="card-text border-bottom" id="year" runat="server"></p>
                            <p class="card-text border-bottom" id="director" runat="server"></p>
                            <p class="card-text border-bottom" id="production" runat="server"></p>
                            <p class="card-text border-bottom" id="firstActor" runat="server"></p>
                            <p class="card-text border-bottom" id="price" runat="server"></p>
                            <p class="card-text border-bottom" id="rating" runat="server"></p>
                            <p class="card-text border-bottom" id="duration" runat="server"></p>
                        </div>
                        <div class="px-5">
                            <h4 class="text-center">Immagini correlate</h4>
                            <asp:ImageButton ID="Image1" runat="server" OnClientClick="return false;" CssClass="w-25" data-bs-toggle="modal" data-bs-target="#exampleModal" data-bs-whatever="@mdo" />
                            <asp:ImageButton ID="Image2" runat="server" OnClientClick="return false;" CssClass="w-25" data-bs-toggle="modal" data-bs-target="#exampleModal2" data-bs-whatever="@mdo" />
                            <asp:ImageButton ID="Image3" runat="server" OnClientClick="return false;" CssClass="w-25" data-bs-toggle="modal" data-bs-target="#exampleModal3" data-bs-whatever="@mdo" />
                        </div>
                    </div>
                    <div class="card-footer text-body-secondary">
                        <asp:Button ID="AddCart" runat="server" Text="Metti nel carrello" CssClass="btn btn-success" OnClick="AddCart_Click" />
                    </div>
                </div>
            </div>
        </div>

        <div class="row">
            <div class="col-12">
                <div class="accordion" id="accordionExample">
                    <div class="accordion-item">
                        <h2 class="accordion-header">
                            <button class="accordion-button bg-dark text-light" type="button" data-bs-toggle="collapse" data-bs-target="#collapseOne" aria-expanded="true" aria-controls="collapseOne">
                                Commenti
                            </button>
                        </h2>
                        <div id="collapseOne" class="accordion-collapse collapse bg-dark text-light" data-bs-parent="#accordionExample">
                            <div class="accordion-body">
                                <strong>This is the first item's accordion body.</strong> It is shown by default, until the collapse plugin adds the appropriate classes that we use to style each element. These classes control the overall appearance, as well as the showing and hiding via CSS transitions. You can modify any of this with custom CSS or overriding our default variables. It's also worth noting that just about any HTML can go within the <code>.accordion-body</code>, though the transition does limit overflow.
                            </div>
                        </div>
                    </div>


                </div>
            </div>
        </div>
        <div class="row">
                        <div class="col-12">
                <asp:TextBox ID="CommentBox" runat="server" CssClass="form-control w-100"></asp:TextBox>
                <asp:Button ID="SendComment" runat="server" Text="Invia" CssClass="btn btn-success w-100" />
            </div>
        </div>
    </div>
    <div class="modal fade bg-dark" id="exampleModal" aria-labelledby="exampleModalLabel" aria-hidden="false">
        <div class="modal-dialog">
            <div class="modal-content">
                <div class="modal-header">
                    <button type="button" class="btn-close" data-bs-dismiss="modal" aria-label="Close"></button>
                </div>
                <div class="modal-body">
                    <asp:Image ID="ImageModal1" runat="server" CssClass="img-fluid" />

                </div>

            </div>
        </div>
    </div>
    <div class="modal fade bg-dark" id="exampleModal2" aria-labelledby="exampleModal2Label" aria-hidden="false">
        <div class="modal-dialog">
            <div class="modal-content">
                <div class="modal-header">
                    <button type="button" class="btn-close" data-bs-dismiss="modal" aria-label="Close"></button>
                </div>
                <div class="modal-body">
                    <asp:Image ID="ImageModal2" runat="server" CssClass="img-fluid" />

                </div>

            </div>
        </div>
    </div>
    <div class="modal fade bg-dark" id="exampleModal3" aria-labelledby="exampleModal3Label" aria-hidden="false">
        <div class="modal-dialog">
            <div class="modal-content">
                <div class="modal-header">
                    <button type="button" class="btn-close" data-bs-dismiss="modal" aria-label="Close"></button>
                </div>
                <div class="modal-body">
                    <asp:Image ID="ImageModaL3" runat="server" CssClass="img-fluid" />

                </div>

            </div>
        </div>
    </div>
</asp:Content>

