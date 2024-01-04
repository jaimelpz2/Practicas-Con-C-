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
    public partial class todo : Form
    {
        Class1 conexion = new Class1();
        public todo()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void todo_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tabla4.DataSource = conexion.ejecucion("Update cursos SET Clave ='" + textBox2.Text + "',Nombre='"+textBox3.Text+"',Profesor='"+textBox4.Text+"',Escuela='"+textBox5.Text+"',cant_personas='"+textBox6.Text+"' Where idCursos= '" + textBox1.Text + "'");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            tabla4.DataSource = conexion.cargarDatos("Select * from cursos");
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
        }
    }
}
