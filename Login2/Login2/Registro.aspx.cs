using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Windows.Forms;

namespace Login2
{
    public partial class Registro : System.Web.UI.Page
    {

        Conexion conexion = new Conexion();
        Site1 sitio = new Site1();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (this.IsPostBack == false)
            {
                if (Request.Cookies["usuario"] != null)
                {
                    TextBox1.Text = Request.Cookies["usuario"].Value;
                }

            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {/*
            string campo1,campo2;
            Site1.valor1 = campo1;
            Site1.valor2 = campo2;
           */

            

            conexion.ejecucion("Insert Into usuarios (usuario,password) VALUES ('" + TextBox1.Text + "','" + TextBox2.Text + "')");
            MessageBox.Show("Succesful insert");
            Response.Redirect("Login.aspx");
        }

    }
}