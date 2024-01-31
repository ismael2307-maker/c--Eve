using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TercerPrograma
{
    class Program
    {
        
        public static int i, j, estu;
        static void Main(string[] args)
        {
            double[,] notas = new double[5, 5];

            do
            {
                Console.WriteLine("Digite la cantidad de estudiantes a calificar");
                estu = int.Parse(Console.ReadLine());
            } while (estu <= 0 || estu > 40);

            for (i = 0; i < estu; i++) {
                for (j = 0; j < 4; j++)
                {
                    do
                    {
                        Console.WriteLine("Digite la nota de la prueba No." + (j + 1) + " del estudiante No." + (i + 1));
                        notas[i, j] = double.Parse(Console.ReadLine());
                    } while (notas[i, j] <= 0 || notas[i, j]>25);
                    notas[i, 4] = notas[i, j] + notas[i, 4];
                    

                }
            }
            Console.Write("                   ");
            for (j = 0; j < 4; j++)
            {
                Console.Write("\t     Nota " + (j + 1));
            }
            Console.Write("\t       Suma");
           
            

            Console.WriteLine("");
            for (i = 0; i < estu; i++)
            {
                Console.Write("Estudiante #" + (i + 1) + ":    ");
                for (j = 0; j < 5; j++)
                {
                    Console.Write("\t       " + notas[i,j]);
                   
                }
                Console.WriteLine("");
            }

            for (i = 0; i < estu; i++)
            {
                if (notas[i, 4] >= 60)
                {
                    Console.WriteLine("Estudiante #" + (i + 1) + " ha pasado la clase :)");
                }
                else
                {
                    Console.WriteLine("Estudiante #" + (i + 1) + " no ha pasado la clase :(");
                }
            }




            Console.ReadKey();
        }
    }
}
