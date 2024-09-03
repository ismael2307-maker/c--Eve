namespace PromedioEstudiantes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {

            /*double[,] calificaciones = new double[4, 3];
            calificaciones[0,0] = Convert.ToDouble(txtExamen1Estudiante1.Text);
            calificaciones[0,1] = Convert.ToDouble(txtExamen2Estudiante1.Text);
            calificaciones[0,2] = Convert.ToDouble(textBoxtxtExamen3Estudiante1.Text);

            calificaciones[1,0] = Convert.ToDouble(txtExamen1Estudiante2.Text);
            calificaciones[1,1] = Convert.ToDouble(txtExamen2Estudiante2.Text);
            calificaciones[1,2] = Convert.ToDouble(txtExamen3Estudiante2.Text);

            calificaciones[2,0] = Convert.ToDouble(txtExamen1Estudiante3.Text);
            calificaciones[2,1] = Convert.ToDouble(txtExamen2Estudiante3.Text);
            calificaciones[2,2] = Convert.ToDouble(txtExamen3Estudiante3.Text);

            calificaciones[3,0] = Convert.ToDouble(txtExamen1Estudiante4.Text);
            calificaciones[3,1] = Convert.ToDouble(txtExamen2Estudiante4.Text);
            calificaciones[3,2] = Convert.ToDouble(txtExamen3Estudiante4.Text);

            double[] promediosEstudiantes = new double[4];
            double sumaGeneral = 0;

            for(int i  = 0; i < calificaciones.GetLength(0); i++)
            {
                double sumaEstudiante = 0;
                for(int j = 0; j < calificaciones.GetLength(1); j++)
                {
                    sumaEstudiante = sumaEstudiante + calificaciones[i, j];
                }
                promediosEstudiantes[i] = sumaEstudiante / calificaciones.GetLength(1);
                sumaGeneral = sumaGeneral + promediosEstudiantes[i];
            }

            double promedioGeneral = sumaGeneral / calificaciones.GetLength(0);

            lstPromedioAlumno.Items.Clear();
            for(int i = 0; i < promediosEstudiantes.Length; i++)
            {
                lstPromedioAlumno.Items.Add("Promedio del estudiante # " + (i + 1) + promediosEstudiantes[i]);
            }
            lblPromedioClase.Text = promedioGeneral.ToString();
            */
          

            double[,] calificaciones = new double[4, 3];
            calificaciones[0,0] = Convert.ToDouble(txtExamen1Estudiante1.Text);
            calificaciones[0,1] = Convert.ToDouble(txtExamen2Estudiante1.Text);
            calificaciones[0,2] = Convert.ToDouble(textBoxtxtExamen3Estudiante1.Text);

            calificaciones[1,0] = Convert.ToDouble(txtExamen1Estudiante2.Text);
            calificaciones[1,1] = Convert.ToDouble(txtExamen2Estudiante2.Text);
            calificaciones[1,2] = Convert.ToDouble(txtExamen3Estudiante2.Text);

            calificaciones[2,0] = Convert.ToDouble(txtExamen1Estudiante3.Text);
            calificaciones[2,1] = Convert.ToDouble(txtExamen2Estudiante3.Text);
            calificaciones[2,2] = Convert.ToDouble(txtExamen3Estudiante3.Text);

            calificaciones[3,0] = Convert.ToDouble(txtExamen1Estudiante4.Text);
            calificaciones[3,1] = Convert.ToDouble(txtExamen2Estudiante4.Text);
            calificaciones[3,2] = Convert.ToDouble(txtExamen3Estudiante4.Text);

            double[] promedioEstudiantes = new double[4];
            double sumaGeneral = 0;
            

            for(int i = 0;i < calificaciones.GetLength(0); i++)
            {
                double sumaEstudiante = 0;
                
                for(int j = 0; j <  calificaciones.GetLength(1); j++) 
                {
                    sumaEstudiante = sumaEstudiante + calificaciones[i, j];
                    
                }
                promedioEstudiantes[i] = sumaEstudiante / calificaciones.GetLength(1);
                sumaGeneral = sumaGeneral + promedioEstudiantes[i];
            }

            double promedioGeneral = sumaGeneral / calificaciones.GetLength(0);
            lstPromedioAlumno.Items.Clear();

            for(int i = 0; i < promedioEstudiantes.Length; i++)
            {
                
                lstPromedioAlumno.Items.Add("El promedio del estudiante #" + (i + 1) + " es: " + promedioEstudiantes[i]);
            }
            lblPromedioClase.Text = promedioGeneral.ToString();



        }
    }
}
