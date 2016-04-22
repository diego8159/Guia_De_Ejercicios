using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Nro_02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio Nro 02";

            double num;
            double cuadrado;
            double cubo;
            string dato;

            Console.WriteLine("Ingrese numero: ");
            dato = Console.ReadLine();
            double.TryParse(dato, out num);
            cuadrado= Math.Pow(num, 2);
            cubo = Math.Pow(num, 3);

            while(num < 0)
            {
	            Console.WriteLine("ERROR. Reingresar numero!!!");
                Console.ReadKey();
            }
            Console.WriteLine("El cuadrado es:"+ cuadrado);
            Console.WriteLine("El cubo es:" + cubo);
            Console.ReadKey();
        }
    }
}
