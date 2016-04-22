using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ejercicio_12
{
    class ValidarRespuesta
    {
        public static bool ValidaS_N()
        {
            string respuesta;
            bool verdad= true;

            Console.WriteLine("¿Continua? (S/N)");
            respuesta = Console.ReadLine();
            respuesta= respuesta.ToLower();
            while (respuesta != "s" && respuesta != "n")
	        {
                Console.WriteLine("Error.Reingrese su respuesta: ");
                respuesta = Console.ReadLine();
	        }

            if (respuesta == "s")
            {
                return verdad;
            }
            else
            {
                return verdad = false;
            }

        }
    }
}
