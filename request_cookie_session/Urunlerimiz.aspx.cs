using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace request_cookie_session
{
    public partial class Urunlerimiz : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["giris"] == null)
            {
                Response.Write("bu sayfaya sadece giriş yapanlar görebilir");
                Response.End();//çalışmayı durdur.
            }
            byte id = Convert.ToByte(Request.QueryString["id"]);
            switch(id)
            {
                case 1:
                Image1.ImageUrl = "img/ana1.jpg";
                Label1.Text = "Anakart";
                break;    
                case 2:
                Image1.ImageUrl = "img/ram1.jpg";
                Label1.Text = "Ram";
                break;
                case 3:
                Image1.ImageUrl = "img/hdd1.jpg";
                Label1.Text = "Harddisk";
                break;
            }
        }
    }
}