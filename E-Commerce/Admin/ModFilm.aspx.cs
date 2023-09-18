using E_Commerce.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace E_Commerce.Admin
{
    public partial class ModFilm : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(Request.QueryString["IdFilm"] != null)
            {
                int id = Convert.ToInt32(Request.QueryString["IdFilm"].ToString());
                Film film = Database.GetById(id);
                TitleBox.Text = film.Title;
                DirectorBox.Text = film.Director;
                PriceBox.Text = film.Price.ToString();
                CategoryBox.Text = film.Category;
                DurationBox.Text = film.Duration;
                ProductionBox.Text = film.Production;
                FirstActorBox.Text = film.FirstActor;
                YearBox.Text = film.Year;
                string rating = film.Rating.ToString();
                RatingBox.Text = rating;
            }
        }
        protected void InsertButton_Click(object sender, EventArgs e)
        {
            string fileNameBg = "";
            if (BackgroundUpload.HasFile)
            {
                fileNameBg = BackgroundUpload.FileName;
                BackgroundUpload.SaveAs(Server.MapPath($"/Content/img/{BackgroundUpload.FileName}"));
            }
            string fileNameCover = "";
            if (CoverImgUpload.HasFile)
            {
                fileNameCover = CoverImgUpload.FileName;
                CoverImgUpload.SaveAs(Server.MapPath($"/Content/img/{CoverImgUpload.FileName}"));
            }
            string fileNameImg1 = "";
            if (Img1Upload.HasFile)
            {
                fileNameImg1 = Img1Upload.FileName;
                Img1Upload.SaveAs(Server.MapPath($"/Content/img/{Img1Upload.FileName}"));
            }
            string fileNameImg2 = "";
            if (Img2Upload.HasFile)
            {
                fileNameImg2 = Img2Upload.FileName;
                Img2Upload.SaveAs(Server.MapPath($"/Content/img/{Img2Upload.FileName}"));
            }
            string fileNameImg3 = "";
            if (Img3Upload.HasFile)
            {
                fileNameImg3 = Img3Upload.FileName;
                Img3Upload.SaveAs(Server.MapPath($"/Content/img/{Img3Upload.FileName}"));
            }


            Database.Insert(TitleBox.Text,ProductionBox.Text, CategoryBox.Text, YearBox.Text, DurationBox.Text, FirstActorBox.Text, Convert.ToDouble(PriceBox.Text), fileNameBg, fileNameCover, fileNameImg1, fileNameImg2, fileNameImg3, DirectorBox.Text, Convert.ToDouble(RatingBox.Text));

            Response.Redirect("../Default.aspx");
        }
    }
}