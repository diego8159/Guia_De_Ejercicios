using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Nro_03
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;
            bool esPrimo = true;
            int i;
            string dato;

            Console.WriteLine("Ingrese un numero: ");
            dato = Console.ReadLine();
            int.TryParse(dato, out num);

            Console.WriteLine("-------------------------------------");

            for (i = 2; i < num; i++)
            {
                   if(num % i == 0)
                   {
                       esPrimo = false; ;  
                   }

                   if (esPrimo)
                    {  
                        Console.Write(" "+ i);  
                    }else
                    {
                        Console.WriteLine("No es Primo");
                        break;
                    }
             }  
              Console.ReadLine();            
         }
     }
 }
