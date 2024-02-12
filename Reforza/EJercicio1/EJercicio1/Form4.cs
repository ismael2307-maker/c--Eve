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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();    
        }

        private void button3_Click(object sender, EventArgs e)
        {
            maskedTextBox1.Text = "";
            maskedTextBox1.Focus(); 
            richTextBox1.Text = "";
            richTextBox1.Focus();   
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int suma = 0, numero;
            try 
            {
                numero = int.Parse(maskedTextBox1.Text);
                if (numero <= 0)
                {
                    MessageBox.Show("Ingrese un valor valido");
                }
                else
                {

                    for (int i = 1; i < numero; i++)
                    {
                        int auxiliar = numero % i;
                        if (auxiliar == 0)
                        {
                            suma = suma + 1;
                        }
                    }

                    if (suma <= 2)
                    {
                        richTextBox1.Text = "El numero " + numero + " es primo";
                    }
                    else
                    {
                        richTextBox1.Text = "El numero " + numero + " no es primo";
                    }

                }
            }catch (FormatException x)
            {
                MessageBox.Show("Rellene los campos");
            }
          
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            richTextBox1.Enabled = false;
        }
    }
}
