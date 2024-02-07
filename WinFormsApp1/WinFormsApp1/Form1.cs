namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double valorBien,DepAnual,DepeAños,DepACum,valorRes,Dep;
            valorBien = double.Parse(maskedTextBox1.Text);
            DepeAños = double.Parse(maskedTextBox2.Text);
            if (valorBien <= 0 || valorBien > 500000)
            {
                MessageBox.Show("No puede meter valores menores que cero y mayores a 500000");
            }
            else if (comboBox1.SelectedItem.Equals("Equipos industriales"))
            {
                DepAnual = valorBien / 6;
                DepACum = DepAnual * DepeAños;
                valorRes = valorBien - DepACum;
                Dep = (valorBien - valorRes) / 6;
                textBox1.Text = Dep.ToString();
            }
            else if (comboBox1.SelectedItem.Equals("Muebles"))
            {
                DepAnual = valorBien / 10;
                DepACum = DepAnual * DepeAños;
                valorRes = valorBien - DepACum;
                Dep = (valorBien - valorRes) / 10;
                textBox1.Text = Dep.ToString();   
            }else if (comboBox1.SelectedItem.Equals("Vehiculos"))
            {
                DepAnual = valorBien / 5;
                DepACum = DepAnual * DepeAños;
                valorRes = valorBien - DepACum;
                Dep = (valorBien - valorRes) / 5;
                textBox1.Text = Dep.ToString();
            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            maskedTextBox1.Text = "";
            maskedTextBox2.Text = "";
            textBox1.Text = "";
            maskedTextBox1.Focus();
            maskedTextBox2.Focus();
            textBox1.Focus();   
        }
    }
}