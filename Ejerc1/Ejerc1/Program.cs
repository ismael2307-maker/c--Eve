using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejerc1
{
    class Program
    {
        static void Main(string[] args)
        {
            Class1 T = new Class1();
            double[] c = new double[10];
            double[] k = new double[10];
            double[] f = new double[10];
            int cg,i;
            do
            {
                cg = T.validar("Digite la cantidad de grados a gestionar: ");
            } while (cg <= 0 || cg > 10);

            for (i = 0; i < cg; i++)
            {
                c[i] = T.validar("Digite el grado celsius #" + (i+1)+ " Que desea transformar: ");
                T.setCELCIUS(c);
                k[i] = T.celsiusaKel(c);
                f[i] = T.celciusaFahren(c);
            }
            for(i = 0; i < cg; i++)
            {
                Console.Write("\t" +c[i]+ " Grados Celsius ");
            }
            Console.WriteLine(" ");

            for (i = 0; i < cg; i++)
            {
                Console.Write("\t" + k[i]+" Grados Kelvin ");
            }
            Console.WriteLine(" ");

            for (i = 0; i < cg; i++)
            {
                Console.Write("\t" + f[i] + " Grados fahrenheit ");
            }
            Console.WriteLine(" ");

            Console.ReadKey();
        }
    }
}
