using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RadiobuttonYgroupbox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void lbl_Resultado_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void lbl_num2_Click(object sender, EventArgs e)
        {

        }

        private void lbl_num1_Click(object sender, EventArgs e)
        {

        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void maskedTextBox2_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_CLOSE_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_Calcular_Click(object sender, EventArgs e)
        {
            double Num1=0.0,Num2=0.0,Resultado=0.0;

            Num1 = double.Parse(maskedTextBox1.Text);
            Num2 = double.Parse(maskedTextBox2.Text);

            if (Num1<0 && Num2<0)
            {
                MessageBox.Show("No puedes digitar valores menores que ceros ");
            }
            else
            {
                if (rb_Suma.Checked == true)
                {
                    Resultado = Num1 + Num2;

                }else if (rb_Resta.Checked == true)
                {
                    Resultado = Num1 - Num2;

                }else if (rb_Multiplicar.Checked == true)
                {
                    Resultado = Num1 * Num2;

                }else if(rb_Dividir.Checked == true)
                {
                    Resultado = Num1 / Num2;
                }
                textBox1.Text = Resultado.ToString();
            }
        }

        private void btn_LIMPIAR_Click(object sender, EventArgs e)
        {
            maskedTextBox1.Text = "";
            maskedTextBox2.Text = "";
            textBox1.Text = "";
            maskedTextBox1.Focus();
            maskedTextBox2.Focus();
        }
    }
}
