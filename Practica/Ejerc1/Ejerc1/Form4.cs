using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejerc1
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= 58 && e.KeyChar <= 255)
            {
                MessageBox.Show("Solo numeros", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= 58 && e.KeyChar <= 255)
            {
                MessageBox.Show("Solo numeros", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double ing, egr, util;
            ing = double.Parse(textBox1.Text);
            if(ing <=0 || ing<7000 || ing > 500000)
            {
                MessageBox.Show("Digite un valor valido");
            }
            else
            {
                egr = double.Parse(textBox2.Text); 
                if(egr <=0 || egr > ing)
                {
                    MessageBox.Show("Digite un valor valido");
                }else
                {
                    util = ing - egr;
                    textBox3.Text = util.ToString();
                }
            }
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            textBox3.Enabled = false;   
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
