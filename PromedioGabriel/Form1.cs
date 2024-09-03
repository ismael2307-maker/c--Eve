namespace PromedioGabriel
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            double[] calificaciones = new double[4];
            string Nombre;
            //double[] promedio = new double[1];
            Nombre = txtNombre.Text;
            calificaciones[0] = Convert.ToDouble(txtNota1.Text);
            calificaciones[1] = Convert.ToDouble(txtNota2.Text);
            calificaciones[2] = Convert.ToDouble(txtNota3.Text);
            double sumaEstudiante = 0;
            for(int i = 0; i < 3; i++)
            {
                sumaEstudiante = sumaEstudiante + calificaciones[i];
                calificaciones[3] = sumaEstudiante / 3;
            }

            for(int i = 0; i < 1; i++)
            {
                // lsbResultados.Items.Add("Nombre: " + Nombre + ", Nota #1: " + calificaciones[0] + ", Nota #2: " + calificaciones[1]+", Nota #3: " + calificaciones[2]+". Su promedio es: " + calificaciones[3]);
                lsbResultados.Items.Add("Nombre: " + Nombre);
                lsbResultados.Items.Add("Nota #1: " + calificaciones[0]);
                lsbResultados.Items.Add("Nota #2: " + calificaciones[1]);
                lsbResultados.Items.Add("Nota #2: " + calificaciones[2]);
                lsbResultados.Items.Add("Promedio: " + calificaciones[3]);

            }
        }
    }
}
