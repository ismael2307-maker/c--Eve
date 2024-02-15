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
    public partial class Velocidad_Lineal : Form
    {
        public Velocidad_Lineal()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtmetro.Clear();
            txtsegundos.Clear();
            txtvelo.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btncalcualr_Click(object sender, EventArgs e)
        {
            double metro, segundo, velo;

            try
            {
                metro = Convert.ToDouble(txtmetro.Text);
                segundo = Convert.ToDouble(txtsegundos.Text);

                if( metro <= 0)
                {
                    MessageBox.Show("LOS METROS NO PUEDEN SER 0 NI NEGATIVOS");
                    return;
                }
                if(segundo <= 0)
                {
                    MessageBox.Show("LOS SEGUNDOS NO PUEDEN SER 0 NI NEGATIVOS");
                    return;
                }
                else
                {
                    velo = metro / segundo;
                    txtvelo.Text = velo.ToString() + "M/S";



                }









            }
            catch (Exception)
            {
                MessageBox.Show("No puede ser nulo", "Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
            }










        }

        private void txtmetro_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txtsegundos_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void Velocidad_Lineal_Load(object sender, EventArgs e)
        {

        }
    }
}
