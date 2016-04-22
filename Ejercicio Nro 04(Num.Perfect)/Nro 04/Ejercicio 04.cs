using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Nro_04
{
    class Ejercicio_04
    {
        static void Main(string[] args)
        {
            double num;
            int i=0;
            int acumulador=0;
            int flag = 0;

            Console.WriteLine("Ingrese un numero: ");
            num = double.Parse(Console.ReadLine());


            while (num > 0)
            {
                for (i = 0; i < num; i++)
                {
                    if (num % i == 0)
                    {
                        acumulador += i;
                    }
                }
                flag = 1;
                break;
            }

            Console.WriteLine("El numero ingresado es: {0}", num);
            Console.WriteLine("Los numeros son: {0}, ", i);
        }
    }
}
