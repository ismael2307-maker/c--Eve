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
    public partial class CALCULO_MEDIA : Form
    {
        public CALCULO_MEDIA()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtmedia.Clear();
            txtn1.Clear();
            txtn2.Clear();
            txtn3.Clear();
            txtn4.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btncalcular_Click(object sender, EventArgs e)
        {
            int n1, n2, n3, n4, media;

            try
            {
                n1 = Convert.ToInt32(txtn1.Text);
                n2 = Convert.ToInt32(txtn2.Text);
                n3 = Convert.ToInt32(txtn3.Text);
                n4 = Convert.ToInt32(txtn4.Text);

                if(n1 < 0)
                {
                    MessageBox.Show("SOLO NUMEROS POSITIVOS");
                    return;

                }
                if (n2 < 0)
                {
                    MessageBox.Show("SOLO NUMEROS POSITIVOS");
                    return;

                }
                if (n3 < 0)
                {
                    MessageBox.Show("SOLO NUMEROS POSITIVOS");
                    return;

                }
                if (n4 < 0)
                {
                    MessageBox.Show("SOLO NUMEROS POSITIVOS");
                    return;

                }
                else
                {
                    media = ( n1 + n2 + n3 + n4) / 4;
                    txtmedia.Text = media.ToString();


                }









            }
            catch (Exception)
            {
                MessageBox.Show("No puede ser nulo", "Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
            }
        }

        private void txtn1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txtn2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txtn3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txtn4_KeyPress(object sender, KeyPressEventArgs e)
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
