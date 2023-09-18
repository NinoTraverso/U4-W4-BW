using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace E_Commerce.Admin
{
    public partial class List : System.Web.UI.Page
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

                    
                    SqlCommand cmd = new SqlCommand("Select * from Films;", connection);

                    
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);

                    
                    DataTable DB = new DataTable();

                    
                    adapter.Fill(DB);

                    
                    GridView1.DataSource = DB;
                    GridView1.DataBind();

                    
                    connection.Close();
                }


            }

        }
    }
}