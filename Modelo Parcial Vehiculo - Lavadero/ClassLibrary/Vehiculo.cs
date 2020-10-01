using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public abstract class Vehiculo
    {
        public enum EMarcas { Honda,Ford,Zanella,Scania,Iveco,Fiat}
        protected string patente;
        byte cantRuedas;
        public EMarcas marca;

        public Vehiculo(string patente, byte cantRuedas, EMarcas marca)
        {
            this.patente = patente;
            this.cantRuedas = cantRuedas;
            this.marca = marca;
        }
        public string Patente
        {
            get { return this.patente; }
            
        }
        public int Marca
        {
            get { return (int)this.marca; }
            
        }
        public byte CantRuedas
        {
            get { return this.cantRuedas; }

        }
        protected virtual string Mostrar()
        {
            StringBuilder str = new StringBuilder();
            str.AppendFormat($"Patente : {this.Patente}\nCantidad de ruedas: {this.cantRuedas}\nMarca: {this.Marca}\n");
            return str.ToString();
        }
        
        public static bool operator ==(Vehiculo v1, Vehiculo v2)
        {
            if (v1.patente == v2.patente && v1.marca == v2.marca)
            {
                return true;
            }
            return false;
        }
        public static bool operator !=(Vehiculo v1, Vehiculo v2)
        {
            return !(v1 == v2);
        }


    }
}
