using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void factorialToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Factorial facto = new Factorial();
            facto.ShowDialog();
        }

        private void numPerfectoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NPerfecto perfectos = new NPerfecto();
            perfectos.ShowDialog();
        }

        private void numAmigosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NAmigos amigos = new NAmigos();
            amigos.ShowDialog();
        }

        private void numPrimoToolStripMenuItem_Click(object sender, EventArgs e)
        {

            NPrimo primo = new NPrimo();
            primo.ShowDialog();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tablaMultiplicacionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Table multi = new Table();
            multi.ShowDialog();
        }
    }
}
