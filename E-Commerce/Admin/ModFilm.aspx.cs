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
            if (Request.QueryString["id"] != null)
            {
                
            }
        }
        protected void InsertButton_Click(object sender, EventArgs e)
        {
            string fileNameBg = "";
            if (BackgroundUpload.HasFile)
            {
                fileNameBg = BackgroundUpload.FileName;
                BackgroundUpload.SaveAs(Server.MapPath($"/Content/assets/{BackgroundUpload.FileName}"));
            }
            string fileNameCover = "";
            if (CoverImgUpload.HasFile)
            {
                fileNameCover = CoverImgUpload.FileName;
                CoverImgUpload.SaveAs(Server.MapPath($"/Content/assets/{CoverImgUpload.FileName}"));
            }
            string fileNameImg1 = "";
            if (Img1Upload.HasFile)
            {
                fileNameImg1 = Img1Upload.FileName;
                Img1Upload.SaveAs(Server.MapPath($"/Content/assets/{Img1Upload.FileName}"));
            }
            string fileNameImg2 = "";
            if (Img2Upload.HasFile)
            {
                fileNameImg2 = Img2Upload.FileName;
                Img2Upload.SaveAs(Server.MapPath($"/Content/assets/{Img2Upload.FileName}"));
            }
            string fileNameImg3 = "";
            if (Img3Upload.HasFile)
            {
                fileNameImg3 = Img3Upload.FileName;
                Img3Upload.SaveAs(Server.MapPath($"/Content/assets/{Img3Upload.FileName}"));
            }

            DB.Insert(TitleBox.Text, ProductionBox.Text, CategoryBox.Text, YearBox.Text, DurationBox.Text, FirstActorBox.Text, Convert.ToDouble(PriceBox.Text),fileNameBg, fileNameCover, fileNameImg1, fileNameImg2, fileNameImg3, DirectorBox.Text,Convert.ToDouble(RatingBox.Text));
            Response.Redirect("../Default.aspx");
        }

        protected void ModifyButton_Click(object sender, EventArgs e)
        {
            string fileNameBg = "";
            if (BackgroundUpload.HasFile)
            {
                fileNameBg = BackgroundUpload.FileName;
                BackgroundUpload.SaveAs(Server.MapPath($"/Content/assets/{BackgroundUpload.FileName}"));
            }
            string fileNameCover = "";
            if (CoverImgUpload.HasFile)
            {
                fileNameCover = CoverImgUpload.FileName;
                CoverImgUpload.SaveAs(Server.MapPath($"/Content/assets/{CoverImgUpload.FileName}"));
            }
            string fileNameImg1 = "";
            if (Img1Upload.HasFile)
            {
                fileNameImg1 = Img1Upload.FileName;
                Img1Upload.SaveAs(Server.MapPath($"/Content/assets/{Img1Upload.FileName}"));
            }
            string fileNameImg2 = "";
            if (Img2Upload.HasFile)
            {
                fileNameImg2 = Img2Upload.FileName;
                Img2Upload.SaveAs(Server.MapPath($"/Content/assets/{Img2Upload.FileName}"));
            }
            string fileNameImg3 = "";
            if (Img3Upload.HasFile)
            {
                fileNameImg3 = Img3Upload.FileName;
                Img3Upload.SaveAs(Server.MapPath($"/Content/assets/{Img3Upload.FileName}"));
            }
            int id= Convert.ToInt32(Request.QueryString["id"]);
            DB.Modify(id,TitleBox.Text, ProductionBox.Text, CategoryBox.Text, YearBox.Text, DurationBox.Text, FirstActorBox.Text, Convert.ToDouble(PriceBox.Text), fileNameBg, fileNameCover, fileNameImg1, fileNameImg2, fileNameImg3, DirectorBox.Text, Convert.ToDouble(RatingBox.Text));
            Response.Redirect("../Default.aspx");
        }
    }
}