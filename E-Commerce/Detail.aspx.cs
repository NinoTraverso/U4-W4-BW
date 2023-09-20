using E_Commerce.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace E_Commerce
{
    public partial class Detail : System.Web.UI.Page
    {
        int id;
        List<Film> carrello = new List<Film>();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.Cookies[".ASPXAUTH"] == null)
                AddCart.Text = "Effettua il Login per acquistare";
            else AddCart.Text = "Metti nel Carrello";
            
            if (Session["Carrello"] != null)
            {
                carrello = (List<Film>)Session["Carrello"];
            }
            if (!IsPostBack)
            {
                id = Convert.ToInt32(Request.QueryString["idFilm"]);
                Film film = DB.getFilmById(id);

                title.Text = film.Title;
                backgroundImage.ImageUrl = $"Content/assets/{film.BackgroundImg}";
                ImageCover.ImageUrl = $"Content/assets/{film.CoverImg}";
                year.InnerText = $"Anno di uscita: {film.Year}";
                director.InnerText = $"Regista: {film.Director}";
                firstActor.InnerText = $"Attore protagonista: {film.FirstActor}";
                price.InnerText = $"Prezzo: {String.Format("{0:0.00 €}", film.Price)}";
                rating.InnerText = $"Rating IMDb: {String.Format("{0:0.0}", film.Rating)}";
                duration.InnerText = $"Durata: {String.Format("{0:0.0}", film.Duration)}";
                production.InnerText = $"Produttore: {film.Production}";
                if(film.Img1 != "") {
                    Image1.ImageUrl = $"Content/assets/{film.Img1}";
                    ImageModal1.ImageUrl = $"Content/assets/{film.Img1}";
                }
                else
                {
                    Image1.Visible = false ;
                }
                if (film.Img2 != "")
                {
                    Image2.ImageUrl = $"Content/assets/{film.Img2}";
                    ImageModal2.ImageUrl = $"Content/assets/{film.Img2}";
                }
                else
                {
                    Image2.Visible = false;
                }
                if (film.Img3 != "")
                {
                    Image3.ImageUrl = $"Content/assets/{film.Img3}";
                    ImageModaL3.ImageUrl = $"Content/assets/{film.Img3}";
                }
                else
                {
                    Image3.Visible = false;
                }
                if (film.Category == "Azione")
                {
                    badge.Attributes.Add("class", "badge text-bg-warning my-1");
                }else if(film.Category == "Fantascienza")
                {
                    badge.Attributes.Add("class", "badge text-bg-success my-1");
                }else if(film.Category == "Horro")
                {
                    badge.Attributes.Add("class", "badge text-bg-danger my-1");
                }else if(film.Category == "Fantasy")
                {
                    badge.Attributes.Add("class", "badge text-bg-primary my-1");
                }else if(film.Category == "Commedia")
                {
                    badge.Attributes.Add("class", "badge text-bg-light my-1");
                }
                badge.InnerText = film.Category;
            }
        }

        protected void AddCart_Click(object sender, EventArgs e)
        {
            if (AddCart.Text == "Metti nel Carrello")
            {
                id = Convert.ToInt32(Request.QueryString["idFilm"]);
                Film selectedFilm = DB.getFilmById(id);
                carrello.Add(selectedFilm);
                Session["Carrello"] = carrello;
                Response.Redirect("Default.aspx");
            }
            else Response.Redirect("Login.aspx");
        }
    }
}