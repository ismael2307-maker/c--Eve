namespace EJercicio1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= 58 && e.KeyChar <= 255)
            {
                MessageBox.Show("Solo numeros", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= 58 && e.KeyChar <= 255)
            {
                MessageBox.Show("Solo numeros", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
           this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            richTextBox1.Text = "";
            richTextBox1.Focus();
            textBox1.Focus();
            textBox2.Focus();   
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try 
            {
                double not1, not2, notF;
                not1 = double.Parse(textBox1.Text);
                not2 = double.Parse(textBox2.Text);
                if ((not1 < 0 || not1 > 50) && (not1 < 0 || not2 > 50))
                {
                    MessageBox.Show("Ingrese notas validas");


                }
                else
                {
                    notF = not1 + not2;

                    if (notF < 60)
                    {
                        richTextBox1.Text = "Ha reprobado la clase con: " + notF + " Puntos";
                    }
                    else
                    {
                        richTextBox1.Text = "Ha aprobado la clase con: " + notF + " Puntos";
                    }
                }
            }catch(FormatException x)
            {
                MessageBox.Show(" Rellene los campos necesarios ");
            }
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            richTextBox1.Enabled = false;
        }
    }
}