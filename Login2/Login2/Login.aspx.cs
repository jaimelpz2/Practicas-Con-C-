using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Data;



namespace Login2
{

    public partial class Login : System.Web.UI.Page
    {
        Site1 sitip = new Site1();
        public MySqlConnection conex;
        public String strConexion = "server=localhost;user id=root; password=123;database=estudiante; SslMode=none";
        public DataTable dt = new DataTable();
        public string valor1, valor2;

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
        public bool abrir()
        {
            try
            {
                conex = new MySqlConnection(strConexion);
                conex.Open();
                dt.Clear();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "No se pudo hacer conexcion con la BSD", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

        }

        public void logear(string nombre, string pass)
        {
            try
            {
                abrir();
                MySqlCommand cmd = new MySqlCommand("SELECT * FROM usuarios WHERE usuario = @nombre AND password = @pass", conex);
                cmd.Parameters.AddWithValue("nombre", nombre);
                cmd.Parameters.AddWithValue("pass", pass);
                MySqlDataAdapter sda = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                if (dt.Rows.Count == 1)
                {
                    //MessageBox.Show("hola");
                    Response.Redirect("Bienvenida.aspx", false);
                }
                else
                {
                    //  MessageBox.Show(nombre);
                    //MessageBox.Show(pass);
                    MessageBox.Show("Usuario y/o password incorrectos");
                }

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);

            }
            finally
            {
                conex.Close();
            }


        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            HttpCookie cookie = new HttpCookie("usuario", TextBox1.Text);
            cookie.Expires = new DateTime(2021, 12, 25);
            Response.Cookies.Add(cookie);

            Session["usuario"] = TextBox1.Text;
            Session["Clave"] = TextBox2.Text;
            logear(TextBox1.Text, TextBox2.Text);
        }
    }
}