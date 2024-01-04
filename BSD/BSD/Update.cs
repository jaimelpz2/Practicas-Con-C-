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
    public partial class Update : Form
    {

        Class1 conexion = new Class1();
        public Update()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int indice = comboBox1.SelectedIndex;
            string item = comboBox1.Text;
            
            if (comboBox1.SelectedIndex == 5)
            {
                todo todito = new todo();
                todito.ShowDialog();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Update_Load(object sender, EventArgs e)
        {
          
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            switch (comboBox1.SelectedIndex)
            {
                case 0:
                    tabla3.DataSource = conexion.ejecucion("Update cursos SET "+ comboBox1.Text +" ='" + textBox2.Text + "' Where idCursos= '" + textBox1.Text + "'");

                    // ("Insert Into cursos(Clave,Nombre,Profesor,Escuela,cant_personas)  values(" + textBox1.Text + ",'" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + textBox5.Text + "')");
                    break;

                case 1:
                    tabla3.DataSource = conexion.ejecucion("Update cursos SET " + comboBox1.Text + " ='" + textBox2.Text + "' Where idCursos='" + textBox1.Text + "'");
                    break;

                case 2:
                    tabla3.DataSource = conexion.ejecucion("Update cursos SET " + comboBox1.Text + " ='" + textBox2.Text + "' Where idCursos= '" + textBox1.Text + "'");
                    break;

                case 3:
                    tabla3.DataSource = conexion.ejecucion("Update cursos SET " + comboBox1.Text + " ='" + textBox2.Text + "' Where idCursos='" + textBox1.Text + "'");
                    break;

                case 4:
                    tabla3.DataSource = conexion.ejecucion("Update cursos SET " + comboBox1.Text + " ='" + textBox2.Text + "' Where idCursos= '" + textBox1.Text + "'");
                    break;
                
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            tabla3.DataSource = conexion.cargarDatos("Select * from cursos");
            textBox1.Text = "";
            textBox2.Text = "";
           
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
