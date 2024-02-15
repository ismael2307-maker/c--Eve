using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Reforzamiento120224
{
    public partial class Calcule_Utilidad : Form
    {
        public Calcule_Utilidad()
        {
            InitializeComponent();
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnlimpiar_Click(object sender, EventArgs e)
        {
            txtegresos.Clear();
            txtingresos.Clear();
            txtutilidad.Clear();
        }
    }
}
