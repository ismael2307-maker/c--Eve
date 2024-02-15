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
    public partial class Calculo_Temperatura : Form
    {
        public Calculo_Temperatura()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnlimpiar_Click(object sender, EventArgs e)
        {
            txtcelsius.Clear();
            txtfarenheit.Clear();
            txtkelvin.Clear();
            cbotipo.Text = "";
            txtcelsius.Enabled = false;
            txtfarenheit.Enabled = false;
            txtkelvin.Enabled = false;
        }

        private void btnconvertir_Click(object sender, EventArgs e)
        {
            double celsius, faren, kelvin;
           
            try
            {
                if(cbotipo.Text == "Celsius")
                {
                    
                    celsius = Convert.ToDouble(txtcelsius.Text);
                    faren = (celsius * 9 / 5) + 32;
                    kelvin = celsius + 273.15;
                    txtfarenheit.Text = faren.ToString();
                    txtkelvin.Text = kelvin.ToString();

                }
                if (cbotipo.Text == "Farenheit")
                {

                    faren = Convert.ToDouble(txtfarenheit.Text);
                    celsius = (faren - 32) * 5 / 9;
                    kelvin = celsius + 273.15;
                    txtcelsius.Text = celsius.ToString();
                    txtkelvin.Text=kelvin.ToString();
                }
                if (cbotipo.Text == "Kelvin")
                {
                    kelvin = Convert.ToDouble(txtkelvin.Text);
                    celsius = kelvin - 273.15;
                    faren = (celsius * 9 / 5) + 32;
                    txtfarenheit.Text = faren.ToString();
                    txtcelsius.Text = celsius.ToString();

                }
            }
            catch (Exception)
            {
                MessageBox.Show("No puede ser nulo", "Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
            }
        }

        private void Calculo_Temperatura_Load(object sender, EventArgs e)
        {
            txtcelsius.Enabled = false;
            txtfarenheit.Enabled = false;
            txtkelvin.Enabled = false;

           
        }

        private void cbotipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbotipo.Text == "Celsius")
            {
                txtcelsius.Enabled = true;
                txtfarenheit.Enabled = false;
                txtkelvin.Enabled = false;
            }
            if (cbotipo.Text == "Farenheit")
            {
                txtfarenheit.Enabled = true;
                txtcelsius.Enabled = false;
                txtkelvin.Enabled=false;
            }
            if (cbotipo.Text == "Kelvin")
            {
                txtkelvin.Enabled = true;
                txtcelsius.Enabled=false;
                txtfarenheit.Enabled=false;
            }
        }

        private void txtcelsius_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txtfarenheit_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txtkelvin_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }
    }
}
