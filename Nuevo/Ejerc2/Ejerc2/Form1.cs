namespace Ejerc2
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

        private void btn_CLOSE_Click(object sender, EventArgs e)
        {
            Application.Exit(); 
        }

        private void btn_ACEPTAR_Click(object sender, EventArgs e)
        {
            if ((checkBox1.Checked == true) && (checkBox2.Checked == true) && checkBox3.Checked == true)
            {
                MessageBox.Show("Usted padece de la enfermedad de tranmision sexual Gonorrea ");
                MessageBox.Show("Se recomienda tomar ciprofloxacina." +
                " Esto para el tratamiento de infecciones Genococcicas no complicadas de uretra, cervix y recto");

            } else if ((checkBox7.Checked == true) && (checkBox8.Checked == true) && (checkBox9.Checked == true))
            {
                MessageBox.Show("Usted padece Neumonia ");
                MessageBox.Show("Se recomienda antibioticos, medicamentos para la tos, antifebriles/analgesicos");
            } else if (checkBox4.Checked == true && (checkBox5.Checked == true) && (checkBox6.Checked == true))
            {
                MessageBox.Show("Usted padece Sarcoidosis ");
                MessageBox.Show("No tiene cura, pero dependiendo la intensidad de sus sintomas se recomienda ir al medico");
                MessageBox.Show(" Se recomienda medicamentos como el corticoesteroides, Medicamentos que inhiben el sistema inmunitario" +
                    "Hidroxicloroquina, inhibidores del factor de necrosis tumoral alfa");
            }
        }
    }
}