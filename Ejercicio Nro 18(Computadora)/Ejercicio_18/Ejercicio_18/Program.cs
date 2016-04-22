using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ejercicio_18
{
    class Program
    {
        static void Main(string[] args)
        {
            Computadora comp= new Computadora(true, EMarca.IBM, 7, EProcesador.Intel_Core_i7);
            
            comp.Mostrar();
            Console.ReadKey();
        }
    }
}
