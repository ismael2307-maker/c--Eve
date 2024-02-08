using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Figuras : Form
    {
        public Figuras()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox2.Focus();
            textBox1.Focus();   
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double Base, altura,Al,At,h,lados,P;

             Base = double.Parse(maskedTextBox1.Text);
             altura = double.Parse(maskedTextBox2.Text);
             h = double.Parse(maskedTextBox3.Text);
            lados = double.Parse()

             Al = 4 * (Base * altura);
             At = Al + (Base * h);

            P =
             


        }
    }
}
