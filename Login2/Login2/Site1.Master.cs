using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Windows.Forms;

namespace Login2
{
    public partial class Site1 : System.Web.UI.MasterPage
    {
       // static public string valor1, valor2;


        Conexion conexion = new Conexion();
        protected void Page_Load(object sender, EventArgs e)
        {

           // valor1 = TextBox1.Text;
           // valor2 = TextBox2.Text;


        }

        protected void Button1_Click(object sender, EventArgs e)
        {

        }


        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        protected void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}