using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using España.Hernan;
using enumerados;

namespace Ejercicio_35
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio 35-Medelo de Parcial";

            Auto autoUno = new Auto(EMarcas.Ferrari, "rojo");
            Auto autoDos = new Auto(EMarcas.Ferrari, "azul");

            Auto autoTres = new Auto(EMarcas.Ford, "verde", 12222112);
            Auto autoCuatro = new Auto(EMarcas.Ford, "verde", 133333115);

            Auto autoCinco = new Auto("violeta", EMarcas.Lotus);
            Auto autoSeis = new Auto(DateTime.Now, EMarcas.Ferrari, "dorado");
            Auto autoSiete = new Auto(DateTime.Now, EMarcas.Ford, "fusia", 5248916);

            autoCinco.AgregarImpuestos(1000);
            autoSeis.AgregarImpuestos(1000);
            autoSiete.AgregarImpuestos(1000);

            double importeDouble = autoUno + autoDos;
            Console.WriteLine(importeDouble);

            if (autoUno == autoCinco)
                Console.WriteLine("Son iguales");
            else
                Console.WriteLine("Son diferentes");

            Auto.MostrarAuto(autoUno);
            Auto.MostrarAuto(autoTres);
            Auto.MostrarAuto(autoCinco);
            Auto.MostrarAuto(autoSiete);
            //-----------------------------------------------------
            //Bonus

            Console.ReadKey();

            Console.Clear();

            Garage miGaragage = new Garage(2, "Estacionamiento Jose");

            miGaragage += autoUno;
            miGaragage += autoDos;
            miGaragage += autoTres;
            miGaragage += autoCuatro;
            miGaragage += autoUno;
            miGaragage += autoCinco;

            Console.ReadKey();

            miGaragage.MostrarGarage();
            Console.ReadKey();

        }
    }
}
