using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CookiesAndSession
{
    public partial class Aplicacion1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            HttpCookie cookie = new HttpCookie("edad",TextBox1.Text);
            cookie.Expires = new DateTime(2021,12,25);
            Response.Cookies.Add(cookie);
            Label1.Text = "se creado el cookie";
        }
    }
}