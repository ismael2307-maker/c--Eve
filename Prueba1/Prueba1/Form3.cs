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
    public partial class Form3 : Form
    {
        public Form3()
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

        private void Form3_Load(object sender, EventArgs e)
        {
            textBox2.Enabled = false;
            textBox3.Enabled = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox1.Focus();
            textBox2.Focus();
            textBox3.Focus();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                double ing, Euros, Dolares;

                ing = double.Parse(textBox1.Text);
                if (ing <= 0 || ing > 500000)
                {
                    MessageBox.Show("Ingrese valores validos");
                }
                else
                {
                    if (comboBox1.SelectedItem.Equals("Euros"))
                    {
                        Euros = ing * 0.025;
                        textBox2.Text = Euros.ToString();

                    }
                    else if (comboBox1.SelectedItem.Equals("Dolares"))
                    {
                        Dolares = ing * 0.027;
                        textBox3.Text = Dolares.ToString();
                    }
                }
            }
            catch (FormatException x)
            {
                MessageBox.Show(" Rellene los campos correspondientes");
            }
        }
    }
}
