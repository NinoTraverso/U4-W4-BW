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
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                int id = Convert.ToInt32(Request.QueryString["idFilm"]);
                Film film = DB.getFilmById(id);

                title.Text = film.Title;
                backgroundImage.ImageUrl = $"Content/assets/{film.BackgroundImg}";
                ImageCover.ImageUrl = $"Content/assets/{film.CoverImg}";
                year.InnerText = $"Anno di uscita: {film.Year}";
                director.InnerText = $"Regista: {film.Director}";
                firstActor.InnerText = $"Attore protagonista: {film.FirstActor}";
                price.InnerText = $"Prezzo: {String.Format("{0:0.00 €}", film.Price)}";
                rating.InnerText = $"Rating IMDb: {String.Format("{0:0.0}", film.Rating)}";
                duration.InnerText = $"Durata: {String.Format("{0:0.0}", film.Duration)}h";
                production.InnerText = $"Produttore: {film.Production}";
                if(film.Img1 != "") {
                    Image1.ImageUrl = $"Content/assets/{film.Img1}";
                }
                else
                {
                    Image1.Visible = false ;
                }
                if (film.Img2 != "")
                {
                    Image2.ImageUrl = $"Content/assets/{film.Img2}";
                }
                else
                {
                    Image2.Visible = false;
                }
                if (film.Img3 != "")
                {
                    Image3.ImageUrl = $"Content/assets/{film.Img3}";
                }
                else
                {
                    Image3.Visible = false;
                }

                badge.InnerText = film.Category;
            }
        }
    }
}