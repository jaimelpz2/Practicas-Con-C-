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
    public partial class Form1 : Form
    {
        Class1 conexion = new Class1();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           // Tabla1.DataSource = conexion.cargarDatos("Select * from cu_est");
        }

        private void button2_Click(object sender, EventArgs e)//insertar
        {
            Tabla1.DataSource = conexion.ejecucion("Insert Into cursos(Clave,Nombre,Profesor,Escuela,cant_personas)  values("+textBox1.Text+",'"+textBox2.Text+"','"+textBox3.Text+"','"+textBox4.Text+"','"+textBox5.Text+"')");
        }

        private void button1_Click(object sender, EventArgs e)//Mostrar
        {
            Tabla1.DataSource = conexion.cargarDatos("Select * from cursos");
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            
        }

        private void button3_Click(object sender, EventArgs e)//Eliminar
        {
            Eliminar delete = new Eliminar();
            delete.ShowDialog();
            //Tabla1.DataSource = conexion.ejecucion("Delete from cursos Where Clave="+textBox1.Text);
        }

        private void button4_Click(object sender, EventArgs e)//update
        {
            Update updating = new Update();
            updating.ShowDialog();
            // Tabla1.DataSource = conexion.ejecucion("");
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button6_Click(object sender, EventArgs e)//mostrar donde hay cursos menos que 10
        {
            Tabla1.DataSource = conexion.cargarDatos("Select clave,Nombre,Profesor,Escuela,cant_personas from cursos where cant_personas <=10");
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)// mostrar donde hay cursos mayor que 10
        {
            Tabla1.DataSource = conexion.cargarDatos("Select clave,Nombre,Profesor,Escuela,cant_personas from cursos where cant_personas >10");
        }
    }
}
