using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ejercicio_10
{
    class Program
    {
        static void Main(string[] args)
        {
            //Titulo
            Console.Title = "Ejercicio 10";

            //variables
            double numero;
            string acumulador1 = "";
            string acumulador2 = "";

            //Ingreso de datos
            Console.WriteLine("Ingrese numero de altura de la piramide: ");
            numero = double.Parse(Console.ReadLine());
            Console.WriteLine("-------------------");

            for (int i = 0; i < numero; i++)
            {
                if (i == 0)//Arreilar el dibujo.
                {
                    acumulador1 += "\t";                    
                }
                acumulador1 += " *";
                acumulador2 += " ";                
                Console.WriteLine(acumulador1 + acumulador2);                
            }
            //for (int i = 0; i < numero; i++)
            //{
            //    acumulador2 += " ";
            //    Console.WriteLine(acumulador2);
            //}
            //Console.WriteLine(acumulador1 + "\n" + acumulador2);
                 

            Console.ReadLine();
        }
    }
}
