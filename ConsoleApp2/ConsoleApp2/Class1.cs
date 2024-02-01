using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Class1
    {
        int tb;
        double valorb, dep;

        public Class1()
        {

        }

        public Class1(int tb, double valorb)
        {
            this.tb = tb;
            this.valorb = valorb;
        }

        public void setTB(int tb)
        {
            this.tb = tb;
        }

        public void setVALORB(double valorb) 
        {
            this.valorb = valorb;
        }

        public void menu()
        {
            Console.WriteLine("Seleccione el tipo de bien a depreciar");
            Console.WriteLine("\t \t 1.- Edificios 2.- Vehiculos 3.- Equipos de Computos");
        }

        public double calcularEdificio(double valorb) 
        {
            return valorb / 20;
        }

        public double calcularVehiculo(double valorb)
        {
            return valorb / 5;
        }

        public double calcularEquiposCompu(double valorb)
        {
            return valorb / 2;
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
