using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using España.Hernan;
using enumerados;

namespace Ejercicio_35
{
    class Garage
    {
        private string _razonSocial;
        private double _precioPorHora;
        private Auto[] _autos;

        private Garage()
        { this._autos = new Auto[5]; }

        public Garage(string razonSocial, double precioPorHora):this()
        {
            this._razonSocial = razonSocial;
            this._precioPorHora = precioPorHora;
        }

        public Garage(double precioPorHora, string razonSocial):this(razonSocial, precioPorHora)
        { }

        public Garage(string razonSocial, double precioPorHora, Auto[] autitos):this(precioPorHora, razonSocial)
        { }

        public Garage(Auto[] autitos, string razonSocial, double precioPorHora): this(razonSocial, precioPorHora, autitos)
        { }

        public void MostrarGarage()
        {
            Console.Write("Razon Social: {0}\nPrecio por hora: {1}, Autos: {2}", _razonSocial, _precioPorHora, _autos);
        }

        public static bool operator ==(Garage garage, Auto autito)
        {
            for (int i = 0; i < 5; i++)
            {
                if (garage._autos.GetValue(i) == autito)
                {
                    return true;
                }
            }

            return false;
        }

        public static bool operator !=(Garage garage, Auto autito)
        {
                return !(garage == autito);
        }

        public static Garage operator +(Garage garage, Auto autito)
        {
            if (garage != autito)//si no esta el auto en el garage
                {               
                    for (int i = 0; i < 5; i++)
                    {
                        if (garage._autos.GetValue(i) == null)
                        {
                            garage._autos[i] = autito;
                            break;
                        }
                    }
                }
            else
            {
                Console.WriteLine("El auto esta en el garage");
            }

                return garage;            
        }

    }
}
