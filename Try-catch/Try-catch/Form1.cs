using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Try_catch
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_CLOSE_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_OK_Click(object sender, EventArgs e)
        {
            try
            {
                string bienvenido = " Bienvenido al curso de C#";
                string texto = "Hola " + txt_testo.Text + bienvenido;
                lbl_TEXT.Text = texto;
            }
            catch(OverflowException x)
            {
                MessageBox.Show("Error en el tamaño del numero "+x);
            }
            catch(FormatException x)
            {
                MessageBox.Show("Error " + x);
            }
           
        }
    }
}
