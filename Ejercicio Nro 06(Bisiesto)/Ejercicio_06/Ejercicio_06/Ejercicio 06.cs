using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ejercicio_06
{
    class Program
    {
        static void Main(string[] args)
        {
            //Titulo
            Console.Title = "Ejercicio 06";
            //Variables
            double añio;
            //Ingreso de datos
            Console.WriteLine("Ingrese añio: ");
            añio = double.Parse(Console.ReadLine());
            //Desarrollo
            if ((añio % 4 == 0 && añio % 100 != 0) || (añio % 400 == 0))
            {
                Console.WriteLine("El añio es bisiesto!");
            }
            else
            {
                Console.WriteLine("El añio no es bisiesto!");
            }
            Console.ReadKey();
        }
    }
}
