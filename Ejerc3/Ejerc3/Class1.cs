using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejerc3
{
    class Class1
    {
        double ingresos, egresos;

        public Class1()
        {

        }

        public Class1(double ingresos, double egresos)
        {
            this.ingresos = ingresos;
            this.egresos = egresos;
        }
        public void setINGRESOS(double ingresos)
        {
            this.ingresos = ingresos;
        }

        public void setEGRESOS(double egresos)
        {
            this.egresos = egresos;
        }

        public double calcularUTIL(double ingresos,double egresos)
        {
            return ingresos - egresos;
        }

        public int validar(String Mensaje)
        {
            int num = 0, v;
            do
            {
                v = 1;
                try
                {
                    Console.Write(Mensaje);
                    num = Convert.ToInt32(Console.ReadLine());
                }
                catch (Exception error)
                {
                    v = 0;
                    Console.WriteLine("No se aceptan letras", error.Message);
                }
            } while (v == 0);
            return num;
        }
    }
}
