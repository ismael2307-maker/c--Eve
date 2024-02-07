using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Enfermedades
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "";
            richTextBox1.Focus();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if ((checkBox1.Checked == true) && (checkBox3.Checked == true) && (checkBox5.Checked == true) && (checkBox7.Checked == true
                )&& (checkBox9.Checked == true) && (checkBox11.Checked == true))
            {
               
            }
        }
            
    }
}
