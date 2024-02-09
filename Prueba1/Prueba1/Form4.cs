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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";

            textBox1.Focus();
            textBox2.Focus();
            textBox3.Focus();
            textBox4.Focus();
            textBox5.Focus();
            textBox6.Focus();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
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

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= 58 && e.KeyChar <= 255)
            {
                MessageBox.Show("Solo numeros", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            textBox4.Enabled = false;
            textBox5.Enabled = false;
            textBox6.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                double Art1, Art2, Art3, con1, con2, con3;
                if (comboBox1.SelectedItem.Equals("Una unidad"))
                {

                    Art1 = double.Parse(textBox1.Text);
                    if (Art1 <= 0 || Art1 > 15000)
                    {
                        MessageBox.Show("Ingrese un valor valido");
                    }
                    else
                    {
                        con1 = Art1 * 1000;
                        textBox4.Text = con1.ToString();
                    }

                }
                else if (comboBox1.SelectedItem.Equals("Dos unidades"))

                {

                    Art1 = double.Parse(textBox1.Text);
                    Art2 = double.Parse(textBox2.Text);
                    if ((Art1 <= 0 || Art1 > 15000) && (Art2 <= 0 || Art2 > 15000))
                    {
                        MessageBox.Show("Ingrese un valor valido");
                    }
                    else
                    {
                        con1 = Art1 * 1000;
                        con2 = Art2 * 1000;
                        textBox4.Text = con1.ToString();
                        textBox5.Text = con2.ToString();
                    }
                }
                else if (comboBox1.SelectedItem.Equals("Tres unidades"))
                {
                    Art1 = double.Parse(textBox1.Text);
                    Art2 = double.Parse(textBox2.Text);
                    Art3 = double.Parse(textBox3.Text);
                    con1 = Art1 * 1000;
                    con2 = Art2 * 1000;
                    con3 = Art3 * 1000;
                    textBox4.Text = con1.ToString();
                    textBox5.Text = con2.ToString();
                    textBox6.Text = con3.ToString();
                }
            }
            catch (FormatException x)
            {
                MessageBox.Show("Rellene los campos correspondientes" + x);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem.Equals("Una unidad"))
            {
                textBox1.Enabled = true;
                textBox2.Enabled = false;
                textBox3.Enabled = false;

            } else if (comboBox1.SelectedItem.Equals("Dos unidades"))
            {
                textBox1.Enabled = true;
                textBox2.Enabled = true;
                textBox3.Enabled = false;

            }else if(comboBox1.SelectedItem.Equals("Tres unidades"))
            {
                textBox1.Enabled = true;
                textBox2.Enabled = true;
                textBox3.Enabled = true;
            }
        }
    }
}
