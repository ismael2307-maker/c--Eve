using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejerc1
{
    class Class1
    {
        int I;   
        double[] Celsius = new double[10];
        double[] Kelvin = new double[10];
        double[] Fahrenheit = new double[10];
        public Class1()
        {

        }

        public Class1(double[] Celsius, double[] Kelvin, double[] Fahrenheit)
        {
            this.Celsius = Celsius;
            /*this.Kelvin = Kelvin;
            this.Fahrenheit = Fahrenheit;
            */
        }

        public void setCELCIUS(double [] Celsius)
        {
            this.Celsius = Celsius;
        }


        public double celsiusaKel(double[] Celsius)
        {
            return Celsius[I] + 273.15;
        }

        public double celciusaFahren(double[] Celsius)
        {
            return (Celsius[I] * 9 / 5) + 32;
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
