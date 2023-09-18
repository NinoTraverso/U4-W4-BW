﻿using E_Commerce.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace E_Commerce
{
    public partial class Home : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {

                string connectionString = ConfigurationManager.ConnectionStrings["ConnectionStringDB"].ToString();
                SqlConnection conn = new SqlConnection(connectionString);

                SqlCommand cmd = new SqlCommand("select * from Films", conn);
                SqlDataReader sqlDataReader;

                conn.Open();

                List<Film> films = new List<Film>();
                sqlDataReader = cmd.ExecuteReader();
                while (sqlDataReader.Read())
                {
                    Film film = new Film();
                    film.Id = Convert.ToInt32(sqlDataReader["IdFilm"]);
                    film.Title = sqlDataReader["Title"].ToString();
                    film.Director = sqlDataReader["Director"].ToString();
                    film.Price = Convert.ToDouble(sqlDataReader["Price"]);
                    film.Category = sqlDataReader["Category"].ToString();
                    film.Duration = sqlDataReader["Duration"].ToString();
                    film.Production = sqlDataReader["Production"].ToString();
                    film.FirstActor = sqlDataReader["FirstActor"].ToString();
                    film.Year = sqlDataReader["Year"].ToString();
                    film.Rating = Convert.ToDouble(sqlDataReader["Rating"]);
                    film.BackgroundImg = sqlDataReader["BackgroundImg"].ToString();
                    film.CoverImg = sqlDataReader["CoverImg"].ToString();
                    film.Img1 = sqlDataReader["Img1"].ToString();
                    film.Img2 = sqlDataReader["Img2"].ToString();
                    film.Img3 = sqlDataReader["Img3"].ToString();
                    films.Add(film);
                }

                Repeater1.DataSource = films;
                Repeater1.DataBind();

                conn.Close();

            }
        }
    }
}