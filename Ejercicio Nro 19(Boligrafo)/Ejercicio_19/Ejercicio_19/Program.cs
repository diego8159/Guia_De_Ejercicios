using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ejercicio_19
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio 19";

            int tinta;
            ConsoleColor color;
            Boligrafo boligrafo = new Boligrafo();

            color = ConsoleColor.Blue;
            tinta= boligrafo.getTinta();


        }
    }
}
