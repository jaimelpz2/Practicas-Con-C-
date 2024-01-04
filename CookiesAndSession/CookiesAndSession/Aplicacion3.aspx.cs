using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CookiesAndSession
{
    public partial class Aplicacion3 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(this.IsPostBack == false)
            {
                if(Request.Cookies["email"] != null)
                {
                    TextBox1.Text = Request.Cookies["email"].Value;
                }
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            HttpCookie cookie = new HttpCookie("email", TextBox1.Text);
            cookie.Expires = new DateTime(2021, 12, 25);
            Response.Cookies.Add(cookie);
            Response.Redirect("Aplicacion4.aspx");
        }
    }
}