using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        public static int i, j, estu;
        static void Main(string[] args)
        {
            Class1 c = new Class1();
            double[,] Not = new double[5, 5];

            do
            {
                estu = c.validar("Digite la cantidad de estudiantes a calificar: ");
            } while (estu <= 0 || estu > 40);

            for (i = 0; i < estu; i++)
            {
                for (j = 0; j < 4; j++)
                {
                    do
                    {
                        Not[i, j] = c.validar("Digite la nota de la prueba # " + (j + 1) + " del estudiante # " +(i + 1));
                        c.setNOTAS(Not);
                    } while (Not[i, j]<0 || Not[i, j]>25);
                    Not[i, 4] = Not[i, j] + Not[i, 4];
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
                    Console.Write("\t       " + Not[i, j]);

                }
                Console.WriteLine("");
            }

            for (i = 0; i < estu; i++)
            {
                if (Not[i, 4] >= 60)
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
