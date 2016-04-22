using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ejercicio_08
{
    class Program
    {
        static void Main(string[] args)
        {
            //titulo
            Console.Title = "Ejercicio 08";

            //Variables
            float valorHora;
            float cant_Horas;
            float antiguedad;
            float totalHotas;
            float totalBruto;
            float totalAntiguedad;
            float totalNeto;
            float totalDescuento;
            string nombre;

            //Ingreso de datos
            Console.WriteLine("Ingrese Nombre: ");
            nombre = Console.ReadLine();
            Console.WriteLine("Ingrese Valor de hora: ");
            valorHora = float.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese Cantidad de horas trabajadas: ");
            cant_Horas = float.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese Antiguedad: ");
            antiguedad = float.Parse(Console.ReadLine());

            //Caculos
            totalHotas= valorHora * cant_Horas;
            totalAntiguedad = antiguedad * 150;
            totalBruto = totalHotas + totalAntiguedad;
            totalDescuento = (float)(totalBruto * 1.13) - totalBruto;
            totalNeto = totalBruto - totalDescuento;

            //Mostrar en pantalla
            Console.Clear();
            Console.WriteLine("   Recibo de sueldo:" + "\n" +
                            "   -----------------" + "\n" +
                            "             Nombre: " + nombre + "\n" +
                            "         Antiguedad: " + antiguedad + "\n" +
                            "     Valor por hora: " + valorHora + "\n" +
                            " Total sueldo bruto: " + totalBruto + "\n" +
                            "         Descuentos: " + totalDescuento + "\n" +
                            "Valor neto a cobrar: " + totalNeto + "\n");
            Console.ReadLine();

        }
    }
}
