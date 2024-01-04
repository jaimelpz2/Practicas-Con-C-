using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Windows.Forms;

namespace EjemploSQL
{
    public class Class1
    {

        public MySqlConnection conex;
        public String strConexion = "server=localhost;user id=root; password=123;database=estudiante; SslMode=none";
        public DataTable dt = new DataTable();

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

        public DataTable cargarDatos(String query)
        {
            try
            {
                abrir();
                MySqlDataAdapter daDatos = new MySqlDataAdapter(query, conex);
                daDatos.Fill(dt);
                return dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "No se pudo hacer conexcion con la BSD", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return dt;
            }
        }

        public bool ejecucion(String query)
        {
            try
            {

                abrir();
                MySqlCommand cmdQuery = new MySqlCommand(query, conex);
                cmdQuery.ExecuteNonQuery();
                conex.Close();

                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "No se pudo hacer conexcion con la BSD", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public  void logear(string usuario, string password)
        {
            abrir();
            MySqlCommand cmd = new MySqlCommand("SELECT usuario, password from usuarios where usuario =@usuarios AND password =@password", conex);
            cmd.Parameters.AddWithValue("usuario", usuario);
            cmd.Parameters.AddWithValue("password", password);
            MySqlDataAdapter sda = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
        }

    }
}