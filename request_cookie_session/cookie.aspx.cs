using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace request_cookie_session
{
    public partial class cookie : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            HttpCookie cerezim = new HttpCookie("bilgi");//ziyaretçiye bilgi isminde çerez gidecek
            cerezim["ad"] = "tuncay";//bilgi çerezi içindeki değişken ve değerler
            cerezim["yas"] = "45";
            cerezim.Expires = DateTime.Now.AddYears(1); // çerezim 1 yıl içinde bilgiyi saklı tutacak(silinmediği sürece).
            Response.Cookies.Add(cerezim);
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            HttpCookie cerezim = new HttpCookie("bilgi");
            if (Request.Cookies["bilgi"] == null)
            {
                cerezim = Request.Cookies["bilgi"];
                Response.Write(cerezim["ad"] + " " + cerezim["yas"]);
            }
            else
                Response.Write("site tarafından böyle bir bilgi gönderilmemiş");
        }
    }
}