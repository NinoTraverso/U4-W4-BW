using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;

namespace E_Commerce
{
    public partial class Fantascienza : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {

                if (!IsPostBack)
                {
                    string connectionString = ConfigurationManager.ConnectionStrings["ConnectionStringDB"].ConnectionString.ToString();

                    SqlConnection connection = new SqlConnection(connectionString);
                    connection.Open();


                    SqlCommand cmd = new SqlCommand("Select * from Films where Category = 'Fantascienza'", connection);


                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);


                    DataTable ScienceFiction = new DataTable();


                    adapter.Fill(ScienceFiction);


                    GridView1.DataSource = ScienceFiction;
                    GridView1.DataBind();


                    connection.Close();
                }
            }

        }
    }
}