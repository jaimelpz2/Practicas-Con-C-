using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using MySql.Data.MySqlClient;

namespace BSD
{

    class Class1
    {
        public MySqlConnection conex;
        public String strConexion = "server=localhost;user id=root; password=123;database=droplearn2.0; SslMode=none";
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
            catch(Exception ex)
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
            }catch(Exception ex)
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
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "No se pudo hacer conexcion con la BSD", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
    }
   
}
