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
    public partial class Numero_Primo : Form
    {
        public Numero_Primo()
        {
            InitializeComponent();
        }

        private void btnveri_Click(object sender, EventArgs e)
        {
            int num;

            try
            {
                num = Convert.ToInt32(txtprimo.Text);
                if (num > 0)
                {
                    bool esPrimo = true;

                    for (int i = 2; i < num; i++)
                    {

                        if (num % i == 0)
                        {
                            esPrimo = false;
                            break;
                        }
                    }
                    if (esPrimo)
                    {
                        lblprimo.Text = "EL NUMERO " + num + " ES PRIMO";
                    }
                    else
                    {
                        lblprimo.Text = "EL NUMERO " + num + " NO ES PRIMO";

                    }

                }
                else
                {
                    lblprimo.Text = " POR FAVOR INGRESE UN NUMERO POSITIVO MAYOR A 0";
                }
            }
            catch (Exception)
            {
                MessageBox.Show("No puede ser nulo", "Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
            }
        }

        private void txtprimo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtprimo.Clear();
            lblprimo.Text = "SU NUMERO ES:";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Numero_Primo_Load(object sender, EventArgs e)
        {

        }
    }
}
