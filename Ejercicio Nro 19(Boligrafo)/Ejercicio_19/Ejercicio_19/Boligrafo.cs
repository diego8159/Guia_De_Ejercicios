using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ejercicio_19
{
    class Boligrafo
    {

        private ConsoleColor color;
        private int tinta;

        public Boligrafo()
        {
            this.color = ConsoleColor.Blue;
            this.tinta = 100;
        }

        public ConsoleColor getColor()
        {
            return this.color;
        }

        public int getTinta()
        {
            return this.tinta;
        }

        public bool Pintar(int gasto)
        {
            
        }

        public void Regargar()
        { 
            
        }

    }
}
