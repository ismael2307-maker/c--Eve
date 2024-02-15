namespace Reforzamiento120224
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtnotafinal.Clear();
            txtnotas1.Clear();
            txtnotas2.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double n1, n2, nf;

            try
            {
                n1 = Convert.ToDouble(txtnotas1.Text);
                 if( n1 < 0 || n1 > 50)
                {
                    MessageBox.Show("NOTA INVALIDA", "RANGO ENTRE 0 Y 50");
                    return;
                }
                 n2 = Convert.ToDouble(txtnotas2.Text);
                if(n2 < 0 || n2 > 50)
                {
                    MessageBox.Show("NOTA INVALIDA", "RANGO ENTRE 0 Y 50");
                    return;
                }
                else
                {
                    nf = n1 + n2;
                    txtnotafinal.Text = nf.ToString();
                    if( nf < 60)
                    {
                        MessageBox.Show("EL ESTUDIANTE HA DESAPROBADO");
                    }
                    if (nf >= 60)
                    {
                        MessageBox.Show("EL ESTUDIANTE HA APROBADO");
                    }

                }










            }
            catch (Exception)
            {
                MessageBox.Show("No puede ser nulo", "Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
            }









        }

        private void txtnotas1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txtnotas2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}