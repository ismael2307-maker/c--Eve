using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace checkBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Calcular_Click(object sender, EventArgs e)
        {
            double total = 0;

            if (checkMonitor.Checked == true)
            {
                total = total + 250;
            }

            if(checkMouse.Checked == true)
            {
                total = total + 20;
            }

            if(checkTeclado.Checked == true)
            {
                total = total + 15;
            }

            MessageBox.Show("El total a pagar es: " + total + " Cordobas");
        }

        private void btn_CLOSE_Click(object sender, EventArgs e)
        {
            Application.Exit();        
        }
    }
}
