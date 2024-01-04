using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Calculadora2
{
    public partial class NPrimo : Form
    {
        public NPrimo()
        {
            InitializeComponent();
        }



        private void button1_Click(object sender, EventArgs e)
        {

            int numero;

            numero = int.Parse(textBox1.Text);

            for (int i = 2; i < numero; i++)
            {
                
                    if (numero % i == 0)
                    {
                        label2.Text = "Falso ";
                        break;
                    }
                    else
                    {
                        label2.Text = "verdadero";
                    }
                
               
                

            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
