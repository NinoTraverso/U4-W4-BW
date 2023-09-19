using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace E_Commerce
{
    public partial class Site1 : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void loginButton_Click(object sender, EventArgs e)
        {
            Response.Redirect(FormsAuthentication.LoginUrl);
        }

        protected void premium_Click(object sender, EventArgs e)
        {
            Response.Redirect("Premium.aspx");
        }

        protected void LinkButton1_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Admin/List.aspx");
        }

        protected void LinkButton2_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Admin/ModFilm.aspx");
        }
    }
}