using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ejercicio_15
{
    class Calculadora
    {
        private static double sumar(double n1, double n2)//como me doy cuenta que es un metodo estatico? si yo tengo el nombre de la clase y despues pongo .(punto) los metodos que me aparecen son metodos de la clase estaticos.
        {
            double resultado= n1 + n2;
            return resultado;
        }

        private static double restar(double n3, double n4)
        {
            double resultado = n3 - n4;
            return resultado;
        }

        private static double multiplicar(double n5, double n6)
        {
            double resultado = n5 * n6;
            return resultado;
        }

        private static double dividir(double n7, double n8)
        {
            double resultado = 0;

            if (Calculadora.Validar(n8) == true)
            {
                resultado = n7 / n8;
                return resultado;
            }
            else
            {
                Console.WriteLine("Error");
                return resultado;
            }

        }

        private static bool Validar(double variable)
        {
            if (variable != 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static double Calcular(double par1, double par2, string operacion)
        {
            double resultado = 0;

            switch (operacion)
            {
                case "+":
                    resultado= Calculadora.sumar(par1, par2);
                    break;
                case "-":
                    resultado= Calculadora.restar(par1, par2);
                    break;
                case "*":
                    resultado= Calculadora.multiplicar(par1, par2);
                    break;
                case "/":
                    resultado= Calculadora.dividir(par1, par2);
                    break;
                default:
                    break;
            }      
            return resultado;
        }

        public static void Mostrar(double resultado)
        {
             Console.WriteLine("El resultado es: {0} ", resultado);
        }

        public static bool ValidaS_N()
        {
            string respuesta;
            bool verdad = true;

            Console.WriteLine("¿Continua? (S/N)");
            respuesta = Console.ReadLine();
            respuesta = respuesta.ToLower();
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
