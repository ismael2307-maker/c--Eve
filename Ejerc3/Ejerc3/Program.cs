using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejerc3
{
    class Program
    {
        static void Main(string[] args)
        {
            Class1 OP = new Class1();
            double ing, egre,utildad;

            do
            {
                ing = OP.validar("Digite el valor de sus ingresos: ");
                OP.setINGRESOS(ing);
            } while (ing < 7000 || ing > 500000);

            do
            {
                egre = OP.validar("Digite el valor de sus egresos: ");
                OP.setEGRESOS(egre);
            } while (egre <= 0);

            while (egre > ing || egre<=0)
            {
                Console.WriteLine("Sus egresos superan sus ingresos");
                Console.WriteLine("Vuelva a digitar el valor de sus egresos");
                egre = OP.validar("Digite el valor de sus egresos: ");
                OP.setEGRESOS(egre);
            }
            utildad = OP.calcularUTIL(ing,egre);
            Console.WriteLine("Sus ingresos son: "+ing+" Cordobas");
            Console.WriteLine("Sus egresos son: "+egre+" Cordobas");
            Console.WriteLine("Su utilidad es: "+utildad+" Cordobas");

            Console.ReadKey();
        }
    }
}
