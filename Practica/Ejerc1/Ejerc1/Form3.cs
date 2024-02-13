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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
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

        private void button1_Click(object sender, EventArgs e)
        {
            double Valor, Dep;

            if (radioButton1.Checked == true)
            {
                Valor = double.Parse(textBox1.Text);
                if (Valor <= 0)
                {
                    MessageBox.Show("Meta un valor valido");
                }
                else
                {
                    Dep = Valor / 20;
                    richTextBox1.Text = "La depreciacion del edificio es de: " + Dep + " Dolares";
                }
            }
            else if(radioButton2.Checked == true)
            {
                Valor = double.Parse(textBox2.Text);
                if (Valor <= 0)
                {
                    MessageBox.Show("Meta un valor valido");
                }
                else
                {
                    Dep = Valor / 5;
                    richTextBox1.Text = "La depreciacion del Vehiculo es de: " + Dep + " Dolares";
                }

            }else if(radioButton3.Checked == true)
            {

                Valor = double.Parse(textBox3.Text);
                if (Valor <= 0)
                {
                    MessageBox.Show("Mete un valor valido");
                }
                else
                {
                    Dep = Valor / 2;
                    richTextBox1.Text = "La depreciacion de los equipos de computo es de: " + Dep + " Dolares";
                }
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

            if (radioButton1.Checked == true)
            {
                textBox1.Enabled = true;
                textBox2.Enabled = false;
                textBox3.Enabled = false;
            }
           
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

            if (radioButton2.Checked == true)
            {
                textBox1.Enabled = false;
                textBox2.Enabled = true;
                textBox3.Enabled = false;
            }
            
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

            if (radioButton3.Checked == true)
            {
                textBox1.Enabled = false;
                textBox2.Enabled = false;
                textBox3.Enabled = true;
            }
            
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }
    }
}

