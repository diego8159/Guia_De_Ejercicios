using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Dolar;
using Euro;
using Calculadora;

namespace Ejercicio_21
{
    class Program
    {
        static void Main(string[] args)
        {

            //Titulo
            Console.Title = "Ejercicio 21";

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
                Console.WriteLine("Ingrese numero 1 Euro/Dolar:");
                dato1 = Console.ReadLine();
                double.TryParse(dato1, out num1);
                Console.WriteLine("Ingrese numero 2 Euro/Dolar:");
                dato2 = Console.ReadLine();
                double.TryParse(dato2, out num2);
                resultado = Calculadora.Calculadora.Calcular(num1, num2, option);
                Calculadora.Calculadora.Mostrar(resultado);
                Console.ReadKey();

            } while (Calculadora.Calculadora.ValidaS_N());
            Console.WriteLine("Saliendo!!!");

            Console.ReadLine();
        }
    }
}
