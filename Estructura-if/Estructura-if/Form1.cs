using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Estructura_if
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_OK_Click(object sender, EventArgs e)
        {
            if (txt_USUARIO.Text == "Ismael" && txt_CONTRA.Text == "2307") 
            {
                MessageBox.Show("Bienvenido ismael");
            }
            else 
            {
                MessageBox.Show("Usuario incorrecto");
            }

        }

        private void btn_CLOSE_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
