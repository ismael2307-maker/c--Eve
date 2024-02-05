namespace WinFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double ing, il;

            ing=double.Parse(maskedTextBox1.Text);
            if(ing<=0 || ing > 500000)
            {
                MessageBox.Show("No puede digitar valores menores a ceros"," Advertencia");
                maskedTextBox1.Text = " ";
                }
            else
            {
                il = ing * 0.07;
                textBox1.Text = il.ToString();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            maskedTextBox1.Text = "";
            textBox1.Text = "";
            maskedTextBox1.Focus(); 
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}