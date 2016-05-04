using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using enumerados;

namespace España.Hernan
{
    class Auto
    {

        private string _color;
        private double _precio;
        private EMarcas _marca;
        private DateTime _fecha;

        public Auto(EMarcas marca, string color)
        {
            this._marca = marca;
            this._color = color;
        }

        public Auto(EMarcas marca, string color, double precio):this(marca, color)
        { this._precio = precio; }

        public Auto(DateTime fecha, EMarcas marca, string color):this(marca, color)
        { this._fecha = fecha; }
        public Auto(DateTime fecha, EMarcas marca, string color, double precio): this(marca, color, precio)
        { }
        public Auto(string color, EMarcas marca): this(marca, color)
        { }

        public void AgregarImpuestos(double NuevoPrecio)
        {
            this._precio = this._precio + NuevoPrecio;
        }

        public static void MostrarAuto(Auto autito)
        {
            Console.WriteLine(autito._fecha);
            Console.WriteLine(autito._marca);
            Console.WriteLine(autito._color);
            Console.WriteLine(autito._precio);
        }

        public static bool operator ==(Auto auto1, Auto auto2)
        {
            bool respuesta = false;
            if (auto1._marca == auto2._marca)
                return respuesta = true;
            else
                return respuesta;
        }

        public static bool operator !=(Auto auto1, Auto auto2)
        { 
            return !(auto1 ==  auto2);
        }

        public static double operator +(Auto auto1, Auto auto2)
        {
            if (auto1 == auto2 && auto1._color == auto2._color)
            {
                double variable= (auto1._precio + auto2._precio);
                Console.WriteLine("Los autos son iguales");
                return variable;
            }
            else
            {
                Console.WriteLine("Los autos son diferentes");
                return 0;
            }
        }
    }
}

namespace enumerados
{
    public enum EMarcas
    { 
        Ford, Ferrari, Lotus
    }
}
