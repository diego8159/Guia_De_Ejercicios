using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Nro_01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio Nro 01";

            int numero=0;
            int max = 0;
            int min = 0;
            string dato;
            float promedio= 0;

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Ingrese numero");
                dato = Console.ReadLine();
                int.TryParse(dato, out numero);

                while (int.TryParse(Console.ReadLine(), out numero) == false)
                {
                    Console.WriteLine("Error");
                }
                if (i == 0)
                {
                    max = numero;
                    min = numero;
                }
                else
                {
                    if (numero < min)
                    {
                        min = numero;
                    }
                    if (numero > max)
                    {
                        max = numero;
                    }
                }
            }
            promedio = (float)numero / 5;
            Console.WriteLine("El mayor es {0}, El menor es {1}", max, min);
            Console.WriteLine("El promedio es: "+ promedio);
            Console.ReadKey();
        }
    }
}
