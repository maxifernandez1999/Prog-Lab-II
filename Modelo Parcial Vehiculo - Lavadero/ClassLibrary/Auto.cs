using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Auto : Vehiculo
    {
        protected int cantidadAsientos;
        public Auto(string patente, byte cantRuedas, EMarcas marca, int cantidadAsientos)
            : base(patente, cantRuedas, marca)
        {
            this.cantidadAsientos = cantidadAsientos;
        }
        protected override string Mostrar()
        {
            StringBuilder str = new StringBuilder();
            str.AppendFormat($"Datos : {base.Mostrar()}\nCantidadAsientos: {this.cantidadAsientos}\n");
            return str.ToString();
        }
    }
}
