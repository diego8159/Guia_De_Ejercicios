using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Calculadora;

namespace Dolar
{
    class Dolar
    {
        public static double dolar= 1;

        public double convertirDolar(double numero)
        {
            return numero / dolar;
        }
    }
}
