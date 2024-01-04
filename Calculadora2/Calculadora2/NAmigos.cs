using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Calculadora2
{
    public partial class NAmigos : Form
    {
        public NAmigos()
        {
            InitializeComponent();
        }

      

        private void NAmigos_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int numero, numero2;

            numero = int.Parse(textBox1.Text);
            numero2 = int.Parse(textBox2.Text);

            long suma = 0;

            for (long i = 1; i < numero; i++)
            {
                if (numero % i == 0)
                {
                    suma = suma + i;
                }
            }

            if (suma == numero2)
            {
                suma = 0;
                for (long i = 1; i < numero2; i++)
                {
                    if (numero2 % i == 0)
                    {
                        suma = suma + i;
                    }
                }

                if (suma == numero)
                {
                    Resultado.Text = "Los Numeros son Amigos";
                }
                else
                {
                    Resultado.Text = "Los Numeros no son Amigos";
                }

            }
            else
            {
                Resultado.Text = "Los Numeros no son Amigos";
            }
        }
    }
}
