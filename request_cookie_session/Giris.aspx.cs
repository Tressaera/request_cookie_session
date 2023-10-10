using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace request_cookie_session
{
    public partial class Giris : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (kuladi.Text == "elif" && sifre.Text == "12345")
            {
                Session["giris"] = "ok";
                Response.Redirect("webform1.aspx");
            }
            else
             Response.Write("yanlış kullanıcı adı veya şifre");
        }

        protected void LinkButton1_Click(object sender, EventArgs e)
        {
            Session.RemoveAll();
            Session.Abandon();
            Response.Redirect("Giris.aspx");
        }
    }
}