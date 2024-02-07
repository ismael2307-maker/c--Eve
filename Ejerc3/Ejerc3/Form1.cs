namespace Ejerc3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            maskedTextBox1.Text = "";
            maskedTextBox2.Text = "";
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";

            maskedTextBox1.Focus();
            maskedTextBox2.Focus();
            textBox1.Focus();
            textBox2.Focus();
            textBox3.Focus();
            textBox4.Focus();
            textBox5.Focus();
            textBox6.Focus();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1.Enabled = false; 
            textBox2.Enabled = false;   
            textBox3.Enabled = false;
            textBox4.Enabled = false;
            textBox5.Enabled = false;
            textBox6.Enabled = false;   
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                double ingreBruto, antiguedad, antiguedadPorcentual, Insslaboral, IR, neto, Salario, Añoingreso, operacion1Bruto, operacion2Bruto;
                double año = 2024;
                
                Salario = double.Parse(maskedTextBox1.Text);
                Añoingreso = double.Parse(maskedTextBox2.Text);
                if ((Salario < 4000 || Salario > 500000) && (Añoingreso < 1900 || Añoingreso >= 2024))
                {
                    MessageBox.Show("Digite un salario valido");
                    MessageBox.Show("Digite un año valido");
                }
                else
                {

                    antiguedad = año - Añoingreso;
                    antiguedadPorcentual = ((2 * antiguedad) + 1) / 100;
                    ingreBruto = (antiguedadPorcentual * Salario) + Salario;
                    Insslaboral = ingreBruto * 0.07;
                    operacion1Bruto = ingreBruto - Insslaboral;
                    IR = operacion1Bruto * 0.1;
                    operacion2Bruto = operacion1Bruto - IR;
                    neto = operacion2Bruto;

                    textBox1.Text = antiguedad.ToString();
                    textBox2.Text = antiguedadPorcentual.ToString();
                    textBox3.Text = ingreBruto.ToString();
                    textBox4.Text = Insslaboral.ToString();
                    textBox5.Text = IR.ToString();
                    textBox6.Text = neto.ToString();
                }
            }
            catch (Exception ex) {

                MessageBox.Show(" Rellene los campos ");
            }

        }

            
           


            


        }
    }
