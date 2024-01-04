using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CookiesAndSession
{
    public partial class Aplicacion4 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Session["usuario"] = TextBox1.Text;
            Session["clave"] = TextBox2.Text;

            Response.Redirect("Aplicacion5.aspx");

        }

        protected void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}