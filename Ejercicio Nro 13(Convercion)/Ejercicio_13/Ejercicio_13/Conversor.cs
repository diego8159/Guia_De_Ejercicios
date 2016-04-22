using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ejercicio_13
{
    class Conversor
    {
        public static string DecimalBinario(double numero)
        {
            string bin = "";
            //double resultado;

            while (true)
            {
                if ((numero % 2) != 0)
                {
                    bin = '1' + bin;
                }
                else
                {
                    bin = '0' + bin;
                    //resultado = numero / 2;
                    //numero = numero / 2;
                }
                //resultado = numero / 2;
                numero = numero / 2;
                if (numero <= 0)
                    break;
            }
            return bin;
        }

        public static double BinarioDecimal(string bin)
        {
            double n = 0;
            double noBinario = 1234;
            bool v = true;

            for (int x = bin.Length - 1, y = 0; x >= 0; x--, y++)
            {
                if (bin[x] == '0' || bin[x] == '1')
                {
                    n += (double)( double.Parse(bin[x].ToString()) * Math.Pow(2, y));
                }
                else
                {
                    Console.Write("El numero no es binario");
                    v = false;
                    break;
                }
            }
            if (v)
            {
                return n;
            }
            else
            {
                return noBinario;
            }
        }

    }
}
