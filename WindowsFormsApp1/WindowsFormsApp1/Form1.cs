using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int edad = 0;

        private void btn_CLOSE_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_OK_Click(object sender, EventArgs e)
        {
            edad = Convert.ToInt32(txt_EDAD.Text);

            if (edad < 18)
            {
                MessageBox.Show("Eres un adolescente");

            }
            else if (edad < 40)
            {
                MessageBox.Show("Eres joven");

            }
            else if (edad < 65)
            {
                MessageBox.Show("Eres maduro");

            }
            else
            {
                MessageBox.Show("Cuidate pa");

            }
        }
    }
}
