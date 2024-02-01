using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Class1 Q = new Class1();
            int op;
            double valor,d;
            Q.menu();
            do
            {
               op = Q.validar("Digite su opcion: ");
            } while (op <= 0 || op > 3);

            switch (op)
            {
                case 1:
                    {
                        do
                        {
                            valor = Q.validar("Digite el valor del edificio: ");
                            d = Q.calcularEdificio(valor);
                        } while (valor <= 1000 || valor>100000);
                        Console.WriteLine("\n Depreciacion: " + d);
                        break;
                    }

                case 2:
                    {
                        do
                        {
                            valor = Q.validar("Digite el valor del vehiculo: ");
                            d = Q.calcularVehiculo(valor);
                        } while (valor <= 1000 || valor > 100000);
                        Console.WriteLine("\n Depreciacion: " + d);
                        break;
                    }

                case 3:
                    {
                        do
                        {
                            valor = Q.validar("Digite el valor de equipos de computo: ");
                            d = Q.calcularEquiposCompu(valor);
                        } while (valor <= 1000 || valor > 100000);
                        Console.WriteLine("\n Depreciacion: " + d);
                        break;

                    }
            }
            Console.ReadKey();
        }
    }
}
