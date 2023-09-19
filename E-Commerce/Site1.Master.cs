using System;
using System.Collections.Generic;
using System.Linq;
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

        protected void linkButtonAzione_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Azione.aspx");
        }

        protected void linkButtonFantascienza_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Fantascienza.aspx");
        }

        protected void linkButtonHorror_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Horror.aspx");
        }

        protected void linkButtonFantasy_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Fantasy.aspx");
        }

        protected void linkButtonCommedia_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Commedia.aspx");
        }


    }
}