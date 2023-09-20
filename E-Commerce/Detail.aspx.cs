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