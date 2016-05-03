using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Boligrafooo;

namespace Ejercicio_33
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio 33 Modelo de parcial-1";

            List<Boligrafo> miLista = new List<Boligrafo>();
            Boligrafo Unboligrafo = new Boligrafo("blanco", "bic", 60);
            Unboligrafo.Escribir(70);

            if (Unboligrafo.RegargarTinta(90))
                Console.WriteLine("Boligrafo Recargado");
            else 
                Console.WriteLine("No se pudo recargar");

            Unboligrafo.Escribir(30);

            if (Unboligrafo.RegargarTinta())
                Console.WriteLine("Boligrafo Recargado");
            else 
                Console.WriteLine("No se pudo recargar");

            miLista = miLista + Unboligrafo;

            Boligrafo boligrafo2 = new Boligrafo("rojo", "Silvapen", 50);
            miLista.Add(boligrafo2); Console.WriteLine("               Muestro :");
            Boligrafo.MostrarBoligrafos(miLista); Console.ReadLine();
            Console.WriteLine("                Sumo :");
            Boligrafo Otrobligrafo = new Boligrafo("verde", "Parker", 60);
            miLista = miLista + Otrobligrafo; Boligrafo.MostrarBoligrafos(miLista);
            Console.ReadLine(); Console.WriteLine("                 Resto :");
            Boligrafo BoligrafoTres = new Boligrafo(40, "verde", "Parker");
            miLista = miLista - BoligrafoTres; Boligrafo.MostrarBoligrafos(miLista);
            Console.ReadLine();

        }
    }
}
