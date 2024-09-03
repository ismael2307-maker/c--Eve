using System.Linq.Expressions;

namespace Matriz3por3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double[,] Matriz = new double[3, 3];

            Matriz[0,0] = Convert.ToDouble(txtNum1.Text);
            Matriz[0,1] = Convert.ToDouble(txtNum2.Text);
            Matriz[0,2] = Convert.ToDouble(txtNum3.Text);

            Matriz[1,0] = Convert.ToDouble(txtNum4.Text);
            Matriz[1,1] = Convert.ToDouble(txtNum5.Text);
            Matriz[1,2] = Convert.ToDouble(txtNum6.Text);

            Matriz[2,0] = Convert.ToDouble(txtNum7.Text);
            Matriz[2,1] =  Convert.ToDouble(txtNum8.Text);
            Matriz[2,2] =  Convert.ToDouble(txtNum9.Text);
            /*
            double[] promedioFilas = new double[3];
            double[] promedioColumnas = new double[3];

            for(int i = 0; i < 3;i++)
            {
                double sumaFila = 0;
                for(int j = 0; j < 3; j++)
                {
                    sumaFila = sumaFila + Matriz[i,j];
                }
                promedioFilas[i] = sumaFila / 3;
            }

            for (int j = 0; j < 3; j++)
            {
                double sumaColumna = 0;
                for (int i = 0; i < 3; i++)
                {
                    sumaColumna = sumaColumna + Matriz[i, j];
                }
                promedioColumnas[j] = sumaColumna / 3;
            }
            lsbPromedio.Items.Clear();
            for(int i = 0; i < 3; i++)
            {
                lsbPromedio.Items.Add("El promedio de la fila " +(i+1)+" es: " + promedioFilas[i]);
            }

            for(int j = 0; j < 3; j++)
            {
                lsbPromedio.Items.Add("El promedio de la columnas " +(j+1)+" es: " + promedioColumnas[j] );
            }
            */
            
            double[] promedioFIla = new double[3];
            double[] promedioColumnas = new double[3];
            double sumaTotalesFilas = 0;
            double sumaTotalesColumnas = 0;

            for(int i = 0; i < Matriz.GetLength(0); i++) 
            {
                double sumaFilas = 0;
                for(int j = 0; j < Matriz.GetLength(1); j++)
                {
                    sumaFilas = sumaFilas + Matriz[i, j];
                }
                promedioFIla[i] = sumaFilas / 3;
                sumaTotalesFilas = sumaTotalesFilas + sumaFilas;
            }

            for(int j = 0; j < Matriz.GetLength(1); j++)
            {
                double sumaColumnas = 0;
                for(int i = 0; i < Matriz.GetLength(0); i++)
                {
                    sumaColumnas = sumaColumnas + Matriz[i, j];
                }
                promedioColumnas[j] = sumaColumnas / 3; 
                sumaTotalesColumnas = sumaTotalesColumnas + sumaColumnas;
            }

            lsbPromedio.Items.Clear();
            double promedioGeneralFilas = sumaTotalesFilas / 3;
            double promedioGeneralColumnas = sumaTotalesColumnas / 3;
            for(int i = 0;i<promedioFIla.Length;i++)
            {
                lsbPromedio.Items.Add("El promedio de la fila "+(i+1)+" es: " + promedioFIla[i]);
            }

            for (int j = 0; j < promedioColumnas.Length; j++)
            {
                lsbPromedio.Items.Add("El promedio de la columna " + (j + 1) + " es: " + promedioColumnas[j]);
            }
            lsbPromedio.Items.Add("El promedio de todas las filas es: " + promedioGeneralFilas);
            lsbPromedio.Items.Add("El promedio de todas las columnas es: " + promedioGeneralColumnas);
            

            
            
        }
    }
}
