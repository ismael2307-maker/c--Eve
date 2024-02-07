namespace Ejerc1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void btn_Calcular_Click(object sender, EventArgs e)
        {
            try
            {
                double kg1, kg2;
                double lb1, lb2, Conver;
                double gr1, gr2, Conver2;

                kg1 = double.Parse(maskedTextBox1.Text);
                kg2 = double.Parse(maskedTextBox2.Text);

                lb1 = kg1 * 2.205;
                lb2 = kg2 * 2.205;
                gr1 = kg1 * 1000;
                gr2 = kg2 * 1000;
                textBox1.Text = lb1.ToString();
                textBox2.Text = lb2.ToString();
                textBox3.Text = gr1.ToString();
                textBox4.Text = gr2.ToString();
            }catch (Exception ex)
            {
                MessageBox.Show(" Rellene los campos ");
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1.Enabled = false;   
            textBox2.Enabled = false; 
            textBox3.Enabled = false;
            textBox4.Enabled = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            maskedTextBox1.Text = "";
            maskedTextBox2.Text = "";
            maskedTextBox1.Focus();
            maskedTextBox2.Focus();
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox1.Focus();
            textBox2.Focus();
            textBox3.Focus();
            textBox4.Focus();
        }
    }
}