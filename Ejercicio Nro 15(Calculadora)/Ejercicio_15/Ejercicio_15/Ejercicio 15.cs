using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ejercicio_15
{
    class Program
    {
        static void Main(string[] args)
        {
            //Titulo
            Console.Title = "Ejercicio 15";

            //Variables
            string option;
            string dato1;
            string dato2;
            double num1;
            double num2;
            double resultado = 0;

            do
            {
                Console.WriteLine("Ingrese la operacion que desea realizar: (+ - * /)");
                option = Console.ReadLine();
                Console.WriteLine("Ingrese numero 1:");
                dato1 = Console.ReadLine();
                double.TryParse(dato1, out num1);
                Console.WriteLine("Ingrese numero 2:");
                dato2 = Console.ReadLine();
                double.TryParse(dato2, out num2);
                resultado= Calculadora.Calcular(num1, num2, option);
                Calculadora.Mostrar(resultado);
                Console.ReadKey();

            } while (Calculadora.ValidaS_N());
            Console.WriteLine("Saliendo!!!");

            Console.ReadLine();
        }
    }
}
