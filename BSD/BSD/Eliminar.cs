using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BSD
{
    public partial class Eliminar : Form
    {

        Class1 conexion = new Class1();
        public Eliminar()
        {
            InitializeComponent();
        }

        private void Eliminar_Load(object sender, EventArgs e)
        {
          
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tabla2.DataSource = conexion.ejecucion("Delete from cursos Where idCursos="+textBox1.Text);
            MessageBox.Show("Se ha eliminado exitosamente.");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            tabla2.DataSource = conexion.cargarDatos("Select * from cursos");
            textBox1.Text = "";
            
        }
    }
}
