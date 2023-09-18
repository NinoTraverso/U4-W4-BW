using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace E_Commerce.Models
{
    public class Database
    {
        public static Film GetById(int IdFilm)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["ConnectionStringDB"].ConnectionString.ToString();
            SqlConnection conn = new SqlConnection(connectionString);

            SqlCommand cmd = new SqlCommand("select * from Films where IdFilm=@IdFilm", conn);
            cmd.Parameters.AddWithValue("IdFilm", IdFilm);
            SqlDataReader sqlDataReader;

            conn.Open();


            sqlDataReader = cmd.ExecuteReader();
            Film film = new Film();
            while (sqlDataReader.Read())
            {
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
            }
            conn.Close();
            return film;
        }
        public static List<Film> GetAll()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["ConnectionStringDB"].ConnectionString.ToString();
            SqlConnection conn = new SqlConnection(connectionString);

            SqlCommand cmd = new SqlCommand("select * from Films", conn);
            SqlDataReader sqlDataReader;

            conn.Open();


            sqlDataReader = cmd.ExecuteReader();
            List<Film> FilmList = new List<Film>();
            while (sqlDataReader.Read())
            {
                Film film = new Film();
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
                FilmList.Add(film);
            }
            conn.Close();
            return FilmList;
        }
    }
}