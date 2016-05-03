using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boligrafooo
{
    class Boligrafo
    {
        private string _marca;
        private string _color;
        private int _catidadTinta;

        public Boligrafo(string color, string marca)
        { 
            this._catidadTinta= 0;
            this._color = color;
            this._marca = marca;
        }

        public Boligrafo(string color, string marca, int cantidadTinta):this(color, marca)
        { }

        public Boligrafo(int cantidadTinta, string color, string marca):this(color, marca, cantidadTinta)
        { }

        public Boligrafo(string marca, int cantidadTinta, string color):this(cantidadTinta, color, marca)
        { }

        public void Escribir(int cantidadNecesaria)
        { 
            this._catidadTinta= cantidadNecesaria;
            if (this._catidadTinta < cantidadNecesaria)
	        {
		        this.Mostrar();
	        }
        }

        private void Mostrar()
        {
            Console.WriteLine(this._color);
            Console.WriteLine(this._marca);
            Console.WriteLine(this._catidadTinta);
            Console.WriteLine("*******************");
        }

        public static void MostrarBoligrafos(List<Boligrafo> ListaBoligrafos)
        {
            foreach (Boligrafo item in ListaBoligrafos)
	        {
		        item.Mostrar();
	        } 
        }

        public static bool operator ==(Boligrafo unPen, Boligrafo otroPen)
        {
            bool respuesta;
            return respuesta = (unPen._marca == otroPen._marca) && (unPen._color == otroPen._color);
        }

        public static bool operator !=(Boligrafo unPen, Boligrafo otroPen)
        { 
            return !(unPen == otroPen);
        }

        public static List<Boligrafo> operator +(List<Boligrafo> lista, Boligrafo unPen)
        {
            lista.Add(unPen);
            return lista;
        }

        public static List<Boligrafo> operator -(List<Boligrafo> lista, Boligrafo unPen)
        {
            foreach (Boligrafo item in lista)
            {
                if (item == unPen)
                {
                    lista.Remove(unPen);
                }
            }

            return lista;
        }

        public bool RegargarTinta()
        {
            bool retorno= false;

             if (this._catidadTinta < 50)
	        {
		        this._catidadTinta= 100;
                return retorno= true;
	        }
             else
                 return retorno;
        }

        public bool RegargarTinta(int cantidad)//:this()
        { 
            bool retorno= false;

            if (this._catidadTinta > 50)
	        {
                this._catidadTinta = cantidad;
                return retorno= true;
	        }
            else
            {
                this.RegargarTinta();
                return retorno;
            }
        }


    }
}
