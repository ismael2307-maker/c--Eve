using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataGreview
{
    public partial class Form1 : Form
    {
        private int n = 0;


        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Adicionamos nuevo renglon
            int n = dataGridView1.Rows.Add();

            // Colocamos la informacion
            dataGridView1.Rows[n].Cells[0].Value = textBox1.Text;
            dataGridView1.Rows[n].Cells[1].Value = textBox2.Text;
            dataGridView1.Rows[n].Cells[2].Value = textBox3.Text;

            // Limpiamos los textos
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
             n = e.RowIndex;

            if (n! = -1)
            {
                label4.Text = (String)dataGridView1.Rows[n].Cells[1].Value;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (n! = -1)
            {
                dataGridView1.Rows.Remove(n);
            }
        }
    }
}
