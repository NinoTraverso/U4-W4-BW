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
              
            }
        }
    }
}