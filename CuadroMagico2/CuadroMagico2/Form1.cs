using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CuadroMagico2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

       

        private void Magico_CellValidated(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex >= 0  && Magico.CurrentCell.Value != null)
            {
                
                foreach (DataGridViewRow row in this.Magico.Rows)
                {
                    if (row.Index == this.Magico.CurrentCell.RowIndex)
                    {
                        continue;
                    }
                    if (this.Magico.CurrentCell.Value == null)
                    {
                        continue;
                    }
                    
                    // estas columnas 
                    if (row.Cells[0].Value != null && row.Cells[0].Value.ToString() == Magico.CurrentCell.Value.ToString() || row.Cells[1].Value != null && row.Cells[1].Value.ToString() == Magico.CurrentCell.Value.ToString() || row.Cells[2].Value != null && row.Cells[2].Value.ToString() == Magico.CurrentCell.Value.ToString())
                    {
                        MessageBox.Show("El Dato ya existe");
                        Magico.CurrentCell.Value = null;

                    }
                    
                    
                    // estos son los renglones 
                    if(e.RowIndex >=0 && Magico.CurrentRow.Cells[0].Value !=null && Magico.CurrentRow.Cells[1].Value != null && Magico.CurrentRow.Cells[0].Value.ToString() == Magico.CurrentRow.Cells[1].Value.ToString())
                    {
                        MessageBox.Show("El Dato ya existe");
                        Magico.CurrentCell.Value = null;
                    }
                    
                    if (e.RowIndex >= 0 && Magico.CurrentRow.Cells[1].Value != null && Magico.CurrentRow.Cells[2].Value != null && Magico.CurrentRow.Cells[1].Value.ToString() == Magico.CurrentRow.Cells[2].Value.ToString())
                    {
                        MessageBox.Show("El Dato ya existe");
                        Magico.CurrentCell.Value = null;
                    }
                    
                    if (e.RowIndex >= 0 && Magico.CurrentRow.Cells[2].Value != null && Magico.CurrentRow.Cells[0].Value != null && Magico.CurrentRow.Cells[2].Value.ToString() == Magico.CurrentRow.Cells[0].Value.ToString())
                    {
                        MessageBox.Show("El Dato ya existe");
                        Magico.CurrentCell.Value = null;
                    }
                    

                    

                }
            }
        
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            int sumaCol = 0, sumaCol2=0,sumaCol3=0;
            int sumaRow = 0,sumaRow2=0,sumaRow3=0;
            int sumDiag = 0, sumDiag2 = 0;
           

                for (int i = 0; i < Magico.RowCount; i++)
                {
                    sumaCol += int.Parse(Magico.Rows[i].Cells[0].Value.ToString());
                    sumaCol2 += int.Parse(Magico.Rows[i].Cells[1].Value.ToString());
                    sumaCol3 += int.Parse(Magico.Rows[i].Cells[2].Value.ToString());
                }
             

                for (int i = 0; i < Magico.RowCount; i++)
                {
                    sumaRow += int.Parse(Magico.Rows[0].Cells[i].Value.ToString());
                    sumaRow2 += int.Parse(Magico.Rows[1].Cells[i].Value.ToString());
                    sumaRow3 += int.Parse(Magico.Rows[2].Cells[i].Value.ToString());
                }
                


                sumDiag += int.Parse(Magico.Rows[0].Cells[0].Value.ToString()) + int.Parse(Magico.Rows[1].Cells[1].Value.ToString()) + int.Parse(Magico.Rows[2].Cells[2].Value.ToString());
                sumDiag2 += int.Parse(Magico.Rows[2].Cells[0].Value.ToString()) + int.Parse(Magico.Rows[1].Cells[1].Value.ToString()) + int.Parse(Magico.Rows[0].Cells[2].Value.ToString());

                
                
            if (sumaCol == 15 && sumaCol2 == 15 && sumaCol3 == 15 && sumaRow == 15 && sumaRow2 == 15 && sumaRow3 == 15)
            {
                MessageBox.Show("Lo Lograste");
            }
            else
            {
                MessageBox.Show("No Lo Lograste vuelve a intentarlo");
            }
           // MessageBox.Show("la Sumatoria es igual a: " + " 1: " + sumaCol + " 2: " + sumaCol2 + "3: " + sumaCol3 +"la Sumatoria de Renglones es: " + " 1: " + sumaRow + " 2: " + sumaRow2 + " 3: " + sumaRow3+ "la Sumatoria de Diagonales es: " + " 1: " + sumDiag + " 2: " + sumDiag2);
            

        }

        

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
            Magico.Columns.Clear();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            
                Magico.Columns.Add("", "");
                Magico.Columns.Add("", "");
                Magico.Columns.Add("", "");
                Magico.Rows.Add("", "");
                Magico.Rows.Add("", "");
                Magico.Rows.Add("", "");
            
        }
    }
}
