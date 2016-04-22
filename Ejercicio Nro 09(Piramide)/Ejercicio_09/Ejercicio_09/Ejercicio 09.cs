using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ejercicio_09
{
    class Program
    {
        static void Main(string[] args)
        {
            //Titulo
            Console.Title= "Ejercicio 09";

            //variables
            double numero;
            string acumulador = "";

            //Ingreso de datos
            Console.WriteLine("Ingrese numero de altura de la piramide: ");
            numero = double.Parse(Console.ReadLine());
            Console.WriteLine("-------------------");

            for (int i = 0; i < numero; i++)
            {
                acumulador += "*";
                Console.WriteLine(""+ acumulador);
            }
            Console.ReadLine();
        }
    }
}
