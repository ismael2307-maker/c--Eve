namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void lbl_Subtotal_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double valor,Resultado=0.0,impuesto=0.0,Descuento=0.0,total2;
            try
            {
                valor = double.Parse(maskedTextBox1.Text);

                if (valor <= 0 || valor > 5000)
                {
                    MessageBox.Show("No puede meter valores menores que cero");
                }
                else
                {
                    if (radioButton1.Checked == true)
                    {
                        Descuento = valor * 0.05;
                        total2 = valor - Descuento;
                        Resultado = total2 * 1.15;
                       
                    }
                    else if (radioButton2.Checked == true)
                    {
                        impuesto = valor * 1.15;
                        Resultado = impuesto;
                    }
                    txt_Total.Text = Resultado.ToString();
                    txt_Descuento.Text = Descuento.ToString();

                }

            }catch (Exception ex)
            {
                MessageBox.Show(" Rellene los campos ");
            }   
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txt_Total.Enabled = false; 
            txt_Descuento.Enabled = false;  
        }
    }
}