﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CookiesAndSession
{
    public partial class aplicacion1b : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.Cookies["edad"] == null)
            {
                Label1.Text = "No existe la cookie edad";
            }
            else
            {
                Label1.Text = this.Request.Cookies["edad"].Value;
            }
        }
    }
}