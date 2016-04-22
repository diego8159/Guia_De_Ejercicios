using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Calculadora;

namespace Euro
{
    class Euro
    {
        public static double euro = 1.3642;

        public double convertirEuro(double numero)
        {
            return numero / euro;
        }
    }
}
