using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prueba1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo numeros", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo numeros", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo numeros", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            //Ignorar
        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo numeros", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double Base, altura, h, lados, Al, At, P, r, AreaBase;
            try
            {
                if (radioButton1.Checked == true)
                {
                    Base = double.Parse(textBox1.Text);
                    altura = double.Parse(textBox2.Text);
                    h = double.Parse(textBox3.Text);
                    lados = double.Parse(textBox4.Text);
                    Al = 4 * (Base * altura) / 2;
                    At = Al + (Base * h);
                    P = lados + lados + lados + lados;
                    textBox5.Text = At.ToString();
                    textBox6.Text = P.ToString();

                }
                else if (radioButton2.Checked == true)
                {
                    h = double.Parse(textBox3.Text);
                    r = double.Parse(textBox7.Text);
                    Al = 2 * Math.PI * (r) * (h);
                    AreaBase = Math.PI * (Math.Pow(r, 2));
                    At = (2 * AreaBase) + Al;
                    P = (2 * Math.PI) + (2 * h);
                    textBox5.Text = At.ToString();
                    textBox6.Text = P.ToString();

                }
                else if (radioButton3.Checked == true)
                {
                    lados = double.Parse(textBox4.Text);
                    altura = double.Parse(textBox2.Text);
                    P = lados * 6;
                    At = (P * altura) / 2;
                    textBox5.Text = At.ToString();
                    textBox6.Text = P.ToString();
                }


            }catch (FormatException x)
            {
                MessageBox.Show("Rellene los campos que se le solicitan");
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox5.Enabled = false;
            textBox6.Enabled = false;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
          
            textBox7.Enabled = false;
            textBox1.Enabled = true;
            textBox2.Enabled = true;
            textBox3.Enabled = true;
            textBox4.Enabled = true;
           
            
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            
            textBox1.Enabled = false;
            textBox2.Enabled = false;
            textBox4.Enabled = false;
            textBox3.Enabled = true;
            textBox7.Enabled = true;

        }

        private void textBox7_KeyPress(object sender, KeyPressEventArgs e)
        {

            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo numeros", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void textBox8_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo numeros", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            
            textBox2.Enabled = true;
            textBox4.Enabled = true;
            textBox1.Enabled = false;
            textBox3.Enabled = false;
            textBox7.Enabled = false;
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            textBox7.Text = "";

            textBox1.Focus();
            textBox2.Focus();
            textBox3.Focus();
            textBox4.Focus();
            textBox5.Focus();
            textBox6.Focus();
            textBox7.Focus();

        }
    }
}
