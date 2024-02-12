using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EJercicio1
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox1.Focus();
            textBox2.Focus();
            textBox3.Focus();
            textBox4.Focus();
            textBox5.Focus();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double num1, num2, num3, num4, Media, SUMA = 0;
            try 
            {
                num1 = double.Parse(textBox1.Text);
                num2 = double.Parse(textBox2.Text);
                num3 = double.Parse(textBox3.Text);
                num4 = double.Parse(textBox4.Text);
                if (num1 < 0 || num2 < 0 || num3 < 0 || num4 < 0)
                {
                    MessageBox.Show("Digite valores positivos");
                }
                else
                {
                    SUMA = num1 + num2 + num3 + num4;
                    Media = SUMA / 4;
                    textBox5.Text = Media.ToString();
                }
            }catch (FormatException ex)
            {
                MessageBox.Show("Rellene los campos");
            }
           
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            textBox5.Enabled = false;
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

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= 58 && e.KeyChar <= 255)
            {
                MessageBox.Show("Solo numeros", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= 58 && e.KeyChar <= 255)
            {
                MessageBox.Show("Solo numeros", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }
    }
}
