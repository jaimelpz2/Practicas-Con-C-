using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CuadroMagico
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Magico2_CellValidated(object sender, DataGridViewCellEventArgs e)
        {

            if (e.ColumnIndex == 0 && Magico3.CurrentCell.Value != null)
            {
                foreach (DataGridViewRow row in this.Magico3.Rows)
                {
                    if (row.Index == this.Magico3.CurrentCell.RowIndex)
                    {
                        continue;
                    }
                    if (this.Magico3.CurrentCell.Value == null)
                    {
                        continue;
                    }
                    if (row.Cells[0].Value != null && row.Cells[0].Value.ToString() == Magico3.CurrentCell.Value.ToString())
                    {
                        MessageBox.Show("El Dato ya existe");
                        Magico3.CurrentCell.Value = null;
                    }
                    if (row.Cells[1].Value != null && row.Cells[1].Value.ToString() == Magico3.CurrentCell.Value.ToString())
                    {
                        MessageBox.Show("El Dato ya existe");
                        Magico3.CurrentCell.Value = null;
                    }
                    if (row.Cells[0].Value != null && row.Cells[0].Value.ToString() == Magico3.CurrentCell.Value.ToString())
                    {
                        MessageBox.Show("El Dato ya existe");
                        Magico3.CurrentCell.Value = null;
                    }

                }
            }

        }


        private void button1_Click(object sender, EventArgs e)
        {


           


        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
            Magico3.Columns.Add("", "");
            Magico3.Columns.Add("", "");
            Magico3.Columns.Add("", "");
            Magico3.Rows.Add("","");
            Magico3.Rows.Add("", "");
            Magico3.Rows.Add("", "");
        }

      

        
    }
}
