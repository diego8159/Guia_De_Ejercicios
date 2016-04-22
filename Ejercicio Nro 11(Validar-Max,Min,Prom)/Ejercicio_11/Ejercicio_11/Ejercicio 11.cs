using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ejercicio_11
{
    class Program
    {
        static void Main(string[] args)
        {
            //Titulo
            Console.Title = "Ejercicio 11";

            //Variables
            int numero;
            bool verdadero;

            //Desarrollo
            Console.WriteLine("Ingrese numero: ");
            numero = int.Parse(Console.ReadLine());
            verdadero = Validacion.Validar(numero, 100, -100);

            Console.ReadLine();
        }
    }
}
