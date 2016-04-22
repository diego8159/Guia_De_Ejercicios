using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ejercicio_07
{
    class Program
    {
        static void Main(string[] args)
        {
            // Variables
            DateTime nacimiento;
            DateTime hoy;
            TimeSpan diferencia;
            bool verdad = true;

            //mensajes
            Console.Title = "Ejercicio 07";
            Console.WriteLine("Saber dias de vida\n" +
                              "------------------");
            // Nacimiento
            Console.Write("Ingrese fecha de nacimiento DD/MM/AA: ");
            //nacimiento = DateTime.Parse(Console.ReadLine());
            do
            {
                verdad = DateTime.TryParse(Console.ReadLine(), out nacimiento);
                if (verdad == false)
                    Console.WriteLine("Error");
            } while (verdad == false);

            // Validacion
            //DateTime minimo, maximo;
            //minimo = DateTime.Parse(string "01 / 01 / 0000");
            //maximo = DateTime.Parse(string "01 / 01 / 2100");
            //while (nacimiento < minimo && nacimiento > maximo){
            //    Console.WriteLine("reingrese");
            //    nacimiento = DateTime.Parse(Console.ReadLine());
            //}

            //Console.WriteLine("La fecha de nacimiento es: {0}", nacimiento);

            // Hoy            
            hoy = DateTime.Now;
            //Console.WriteLine("La fecha de hoy es: {0}", hoy);

            // Diferencia por pantalla
            diferencia = hoy - nacimiento;
            Console.WriteLine("Los dias de vida vividos son: {0}", diferencia.Days);
            Console.ReadLine();
        }
    }
}
