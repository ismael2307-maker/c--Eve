namespace Ejerc1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
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

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= 58 && e.KeyChar <= 255)
            {
                MessageBox.Show("Solo numeros", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();    
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double Cel, Kel, Fahren;

            try
            { 
                if (comboBox1.SelectedItem.Equals("Celsius"))
                {
                    Cel = double.Parse(textBox1.Text);
                    Kel = Cel + 273.15;
                    Fahren = (1.8 * Cel) + 32;

                    textBox2.Text = Kel.ToString();
                    textBox3.Text = Fahren.ToString();

                }
                else if (comboBox1.SelectedItem.Equals("Kelvin"))
                {
                    Kel = double.Parse(textBox2.Text);
                    Cel = Kel - 273.15;
                    Fahren = ((Kel - 273.15) * 1.8) + 32;

                    textBox1.Text = Cel.ToString();
                    textBox3.Text = Fahren.ToString();
                }
                else if (comboBox1.SelectedItem.Equals("Fahrenheit"))
                {
                    Fahren = double.Parse(textBox3.Text);
                    Cel = (Fahren - 32) / 1.8;
                    Kel = ((Fahren - 32) / 1.8) + 273.15;

                    textBox1.Text = Cel.ToString();
                    textBox2.Text = Kel.ToString();
                }
            }catch (FormatException x)
            {
                MessageBox.Show("Rellene los campos necesarios"+x);
            }
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem.Equals("Celsius"))
            {
                textBox1.Enabled = true;
                textBox2.Enabled = false;
                textBox3.Enabled = false;  
                
            }else if (comboBox1.SelectedItem.Equals("Kelvin"))
            {
                textBox1.Enabled = false;
                textBox2.Enabled = true;
                textBox3.Enabled = false;

            }else if (comboBox1.SelectedItem.Equals("Fahrenheit"))
            {
                textBox1.Enabled = false;
                textBox2.Enabled = false;
                textBox3.Enabled = true;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
        }
    }
}