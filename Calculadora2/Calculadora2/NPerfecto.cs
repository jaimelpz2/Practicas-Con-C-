using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Calculadora2
{
    public partial class NPerfecto : Form
    {
        public NPerfecto()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            int numero;
            long suma = 0;

            numero = int.Parse(textBox1.Text);

            for (long i = 1; i < numero; i++)
            {
                if (numero % i == 0)
                {
                    suma = suma + i;
                }
            }

            if(numero == suma)
            {
                Resultado.Text = "Es un numero Perfecto";
            }
            else
            {
                Resultado.Text = "No Es un numero Perfecto";
            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
