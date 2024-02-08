namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        int contraseñaIncorrect = 3;
        int intentosF = 0;
        public Form1()
        {
            InitializeComponent();
        }

        public void fn_prba()
        {
            if(progressBar1.Value < 100)
            {
                progressBar1.Value += 1;
                label4.Text = progressBar1.Value.ToString() + "% ";
            }
            if (progressBar1.Value == progressBar1.Maximum)
            {
               timer1.Enabled = false;
               timer1.Stop();  
                new MDI().Show();   
                this.Hide();    
            }
        }

        public void Congelar()
        {
            intentosF++;

            if(intentosF == 1)
            {
                MessageBox.Show("Fue bloqueado, espere 30 segundos ");
                Thread.Sleep(30000);
                textBox2.Enabled = true;
                textBox1.Enabled = true;
                contraseñaIncorrect = 3;
            }

            if (intentosF == 2)
            {
                MessageBox.Show("Fue bloqueado, espere 40 segundos");
                Thread.Sleep(40000);
                textBox2.Enabled = true;
                textBox1.Enabled = true;
                contraseñaIncorrect = 3;
            }

            if(intentosF > 3)
            {
                MessageBox.Show("Fue bloqueado, espere 1 minuto");
                Thread.Sleep(60000);
                textBox2.Enabled = true;
                textBox1.Enabled = true;
                contraseñaIncorrect = 3;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            // Ignorar esto 
        }

        private void label2_Click(object sender, EventArgs e)
        {
           textBox1.Clear();
           textBox2.Clear();
            textBox1.Focus();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            progressBar1.Show();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "Ismael" && textBox2.Text == "AbyssWatchers")
            {
                timer1.Start();
                timer1_Tick(sender, e);
            }
            else
            {
                contraseñaIncorrect--;
                MessageBox.Show("Contraseña Incorrecta o Usuario incorrecto");
            }
            if (contraseñaIncorrect == 0) 
            {
                textBox1.Enabled = false;
                textBox2.Enabled = false;
            }
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {
            // Ignorar esto

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            fn_prba();
            timer1.Enabled = true;

            if(progressBar1.Value == progressBar1.Maximum)
            {
                timer1.Enabled = false;
                timer1.Stop();
                
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {
            // Application.Exit();
        }
    }
}