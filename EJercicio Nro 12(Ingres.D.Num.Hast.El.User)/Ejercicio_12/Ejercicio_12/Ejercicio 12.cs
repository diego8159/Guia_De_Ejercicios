using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ejercicio_12
{
    class Program
    {
        static void Main(string[] args)
        {
            //Titulo
            Console.Title = "Ejercicio 12";

            //Variables
            double numero;
            double acumulador = 0;
            int i = 0;
            bool resp;
            //string dato= "";

            //Ingreso de datos
            do
            {
                i++;
                Console.WriteLine("Ingrese numero {0}: ", i);
                numero = double.Parse(Console.ReadLine());

                acumulador += numero;
                resp= ValidarRespuesta.ValidaS_N();

            } while (resp);

            Console.WriteLine("La suma final es: "+ acumulador);
            Console.ReadLine();
        }
    }
}
