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
    public partial class EjemploDataGrieview : Form
    {
        private int n = 0;
        public EjemploDataGrieview()
        {
            InitializeComponent();
        }

        private void btnadicionar_Click(object sender, EventArgs e)
        {
            int n = dataGridView1.Rows.Add();
            
            double suma = 0;
            double iva, total;
            try
            {
                
                
                    
                    dataGridView1.Rows[n].Cells[0].Value = txtcodigo.Text;
                    dataGridView1.Rows[n].Cells[1].Value = txtcantidad.Text;
                    dataGridView1.Rows[n].Cells[2].Value = txtsubtotal.Text;
                    dataGridView1.Rows[n].Cells[3].Value = txtnombre.Text;
                    dataGridView1.Rows[n].Cells[4].Value = txtprecio.Text;

                    foreach (DataGridViewRow fila in dataGridView1.Rows)
                    {
                        double valor = Convert.ToDouble(fila.Cells[2].Value);
                        suma += valor;
                        txtsubtotalfac.Text = suma.ToString();
                    }

                    iva = suma * 0.15;
                    total = suma + iva;
                    txttotal.Text = total.ToString();

                    txtcodigo.Clear();
                    txtnombre.Clear();
                    txtprecio.Clear();
                    txtcantidad.Clear();
                    txtsubtotal.Clear();
                btnadicionar.Enabled = false;
            }
            catch (Exception)
            {
                MessageBox.Show("No puede ser nulo", "Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
            }


        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            n = e.RowIndex;
            if(n != -1)
            {
                lblinformacion.Text = (string)dataGridView1.Rows [n].Cells [3].Value;
            }
        }

        private void btnborrar_Click(object sender, EventArgs e)
        {
           
            
            if(n!= -1)
            {
                dataGridView1.Rows.RemoveAt (n);
               
               
            }



        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void txtprecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txtcantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void EjemploDataGrieview_Load(object sender, EventArgs e)
        {
            txtsubtotal.Enabled = false;
        }

        private void btncalcular_Click(object sender, EventArgs e)
        {
            try
            {
                btnadicionar.Enabled = true;

                double sub, can, pre;
                can = Convert.ToDouble(txtcantidad.Text);
                pre = Convert.ToDouble(txtprecio.Text);
                if (can <= 0)
                {
                    MessageBox.Show("NO PUEDE SER NEGATIVO NI CERO");
                }
                if (pre <= 0)
                {
                    MessageBox.Show("NO PUEDE SER NEGATIVO NI CERO");
                }
                else
                {
                    sub = can * pre;
                    txtsubtotal.Text = sub.ToString();

                }
            }
            catch (Exception)
            {
                MessageBox.Show("No puede ser nulo", "Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
            }
        }
    }
}
