using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CookiesAndSession
{
    public partial class Aplicacion5 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Lusuario.Text = this.Session["usuario"].ToString();
            Lclave.Text = this.Session["clave"].ToString();
        }
    }
}