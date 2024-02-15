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
    public partial class Depreciacion_Bienes_DataGridView : Form
    {
       
        public Depreciacion_Bienes_DataGridView()
        {
            InitializeComponent();
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btncalcular_Click(object sender, EventArgs e)
        {

            double valor;
            double depre;
            int vida = 0;
            try
            {
                valor = Convert.ToDouble(txtvalor.Text);
                if (cbotipo.Text == "Vehiculos")
                {
                    vida = 5;
                    if (valor < 1000 || valor > 350000)
                    {
                        MessageBox.Show("MONTO INVALIDO DIGITE RANGO DE 1000 A 350000");
                        return;
                    }
                }
                if (cbotipo.Text == "Computadoras")
                {
                    vida = 2;
                    if (valor < 100 || valor > 250000)
                    {
                        MessageBox.Show("MONTO INVALIDO DIGITE RANGO DE 100 A 250000");
                        return;
                    }
                }

                depre = valor / vida;

                DataTable tabla = new DataTable();
                tabla.Columns.Add("Año");
                tabla.Columns.Add("Valor");

                for (int i = 1; i <= vida; i++)
                {

                    valor = valor - depre;
                    tabla.Rows.Add(i, valor);
                }
                dataGridView1.DataSource = tabla;
            }
            catch (Exception)
            {
                MessageBox.Show("No puede ser nulo", "Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
            }
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

        private void btnborrar_Click(object sender, EventArgs e)
        {
            if(dataGridView1.Rows.Count > 0)
            {
                dataGridView1.Columns.Remove("Año");
                dataGridView1.Columns.Remove("Valor");
            }
            else
            {
                MessageBox.Show("IMPOSIBLE BORRAR");
            }
        }
    }
}
