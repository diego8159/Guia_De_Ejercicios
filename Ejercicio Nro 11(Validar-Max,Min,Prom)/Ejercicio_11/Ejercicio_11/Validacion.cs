using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ejercicio_11
{
    class Validacion
    {
        public static bool Validar(int num, int max, int min)
            {
            
                bool verdad = true;
                while(num > max || num < min)
                {
                    Console.WriteLine("Error.Reingrese: ");
                    num= int.Parse(Console.ReadLine());

                    verdad = false;
                }
                return verdad;
            }
    }
}
