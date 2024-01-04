using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Windows.Forms;


namespace EjemploSQL
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        // Class1 retry = new Class1();
        public MySqlConnection conex;
        public String strConexion = "server=localhost;user id=root; password=123;database=estudiante; SslMode=none";
        public DataTable dt = new DataTable();

        public string valor1, valor2;
        protected void Page_Load(object sender, EventArgs e)
        {
            valor1 = TextBox1.Text;
            valor2 = TextBox2.Text;
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
                    Response.Redirect("WebForm2.aspx",false);
                }
                else
                {
                  //  MessageBox.Show(nombre);
                    //MessageBox.Show(pass);
                    MessageBox.Show("Usuario y/o password incorrectos");
                }
                
            }
            catch(Exception e)
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
            Boolean t1 = false, t2 = false;
            if (TextBox1.Text.Trim()=="")
            {
                MessageBox.Show("Introduzca el usuario");
            }
            else
            {
                t1 = true;
            }
            if (TextBox2.Text.Trim() == "")
            {
                MessageBox.Show("Introduzca el password");
            }
            else
            {
                t2 = true;
            }

            if(t1==true & t2 == true)
            {

                logear(valor1, valor2);
                // MessageBox.Show(this.TextBox1.Text);
                //  MessageBox.Show(this.TextBox2.Text);

            }
            /*
            string nombre, password;
            Session["usr"] = TextBox2.Text;
            nombre = this.Session["usr"].ToString();
            Session["passwrd"] = TextBox1.Text;
            password = this.Session["passwrd"].ToString();
            */
           

        }
    }
}