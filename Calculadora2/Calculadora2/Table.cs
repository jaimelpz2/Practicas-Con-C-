using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Calculadora2
{
    public partial class Table : Form
    {
        public Table()
        {
            InitializeComponent();
        }

     

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int numero = (int)numericUpDown1.Value;
            int resultado;
            for(int i = 1; i <= 10; i++)
            {
                resultado = numero * i;
                listBox1.Items.Add(numero + "x" + i +"="+ resultado);

            }
           
        }

       
    }
}
