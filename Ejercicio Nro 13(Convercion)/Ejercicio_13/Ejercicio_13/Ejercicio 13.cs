using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ejercicio_13
{
    class Program
    {
        static void Main(string[] args)
        {
            //Titulo
            Console.Title = "Ejercicio 13";

            //Variables
            string dato;
            double binario;        

            //Ingreso de datos
            dato= Conversor.DecimalBinario(5);
            Console.WriteLine("Binario: "+ dato);

            Console.Write("-----------------------\n");
            binario = Conversor.BinarioDecimal(dato);
            Console.Write("Decimal: "+ binario);//Muestra 1234, cuando el numero no es binario.

        }
    }
}
