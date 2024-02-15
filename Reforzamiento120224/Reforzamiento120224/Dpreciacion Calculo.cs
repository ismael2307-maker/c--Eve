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
    public partial class Dpreciacion_Calculo : Form
    {
        public Dpreciacion_Calculo()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double valor, depre;

            try
            {
                valor = Convert.ToDouble(txtvalor.Text);

                if(cbotipo.Text == "Edificios")
                {
                    if (valor < 10000 || valor > 500000)
                    {
                        MessageBox.Show("DIGITE UN VALOR VALIDO", "RANGO DE 10000 A 500000");
                    }
                    else
                    {
                        depre = valor / 10;
                        txtdepre.Text = depre.ToString();
                    }
                }
                if (cbotipo.Text == "Vehiculos")
                {
                    if (valor < 1000 || valor > 300000)
                    {
                        MessageBox.Show("DIGITE UN VALOR VALIDO", "RANGO DE 10000 A 300000");
                    }
                    else
                    {
                        depre = valor / 5;
                        txtdepre.Text = depre.ToString();
                    }
                }
                if (cbotipo.Text == "Equipos de Computo")
                {
                    if (valor < 10 || valor > 10000)
                    {
                        MessageBox.Show("DIGITE UN VALOR VALIDO", "RANGO DE 10 A 10000");
                    }
                    else
                    {
                        depre = valor / 2;
                        txtdepre.Text = depre.ToString();
                    }
                }







            }
            catch (Exception)
            {
                MessageBox.Show("No puede ser nulo", "Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
            }
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnlimpiar_Click(object sender, EventArgs e)
        {
            cbotipo.Text = "";
            txtdepre.Clear();
            txtvalor.Clear();
            txtvalor.Enabled = false;
        }

        private void txtvalor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void cbotipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbotipo.Text == "Edificios")
            {
                txtvalor.Enabled = true;
            }
            if (cbotipo.Text == "Vehiculos")
            {
                txtvalor.Enabled = true;
            }
            if (cbotipo.Text == "Equipos de Computo")
            {
                txtvalor.Enabled = true;
            }
        }

        private void Dpreciacion_Calculo_Load(object sender, EventArgs e)
        {

        }
    }
}
