using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ejercicio_18
{
    class Computadora
    {

        private bool _EstaEncendida;
        private EMarca _Marca;
        private float _Peso;
        private EProcesador _Procesador;

        public Computadora(bool E, EMarca M, float P, EProcesador PRO) //Constructor de instancia.
        {
            this._EstaEncendida = E;
            this._Marca = M;
            this._Peso = P;
            this._Procesador = PRO;
        }
        public bool GetEstaEncendida()
        {
            return this._EstaEncendida;
        }
        public EMarca GetMarca()
        {
            return this._Marca;
        }
        public float GetPeso()
        {
            return this._Peso;
        }
        public EProcesador GetProcesador()
        {
            return this._Procesador;
        }
        public void SetEstaEncendida(bool encender)
        {
            this._EstaEncendida = encender;
        }
        public void SetMarca(EMarca marca)
        {
            this._Marca = marca;
        }
        public void SetPeso(float peso)
        {
            this._Peso = peso;
        }
        public void SetProcesador(EProcesador procesador)
        {
            this._Procesador = procesador;
        }
        public void Mostrar()
        {
            Console.Write(this._EstaEncendida.ToString() + this._Marca + this._Peso + this._Procesador);
        }

    }

    public enum EMarca
    {
        Asus, Apple, Samsung, Toshiba, IBM
    }
    public enum EProcesador
    {
        Intel_Core_i7, AMD_Phenom_II, AMD_Athlon_II, Intel_Celeron_430, AMD_Sempron_145
    }

}
