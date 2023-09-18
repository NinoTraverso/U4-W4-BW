using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace E_Commerce.Models
{
    public static class DB
    {
       public static void getAllFilm()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["ConnectionStringDB"].ToString();
            SqlConnection conn = new SqlConnection(connectionString);

            SqlCommand cmd = new SqlCommand("SELECT * FROM Persone", conn);
            SqlDataReader sqlDataReader;

            conn.Open();
            List<Film> listaFilm = new List<Film>();
            sqlDataReader = cmd.ExecuteReader();
        }
    }
}