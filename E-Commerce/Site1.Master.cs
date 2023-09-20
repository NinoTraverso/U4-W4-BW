using E_Commerce.Models;
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
            if(!IsPostBack)
            {
                if (Request.Cookies["username"] != null)
                {
                    loginButton.Text = "Logout";
                    signInButton.Visible = false;
                    User user = DB.getUser(Request.Cookies["username"].Value);
                    if (user.Role == "admin") adminButton.Visible = true;
                    else adminButton.Visible = false;
                }
                else
                {
                    loginButton.Text = "Login";
                    adminButton.Visible = false;
                    signInButton.Visible = true;
                }
            }
        }

        protected void loginButton_Click(object sender, EventArgs e)
        {
            if(loginButton.Text == "Login")
            Response.Redirect(FormsAuthentication.LoginUrl);
            else
            {
                Response.Cookies.Clear();
                Response.Redirect("Default.aspx");
            }
        }

        protected void premium_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Premium.aspx");
        }

        protected void LinkButton1_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Admin/List.aspx");
        }

        protected void LinkButton2_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Admin/ModFilm.aspx");
        }

        protected void signInButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("SignIn.aspx");
        }
    }
}