using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Camion : Vehiculo
    {
        protected float tara;
        public Camion(string patente, byte cantRuedas, EMarcas marca, float tara)
            : base(patente, cantRuedas, marca)
        {
            this.tara = tara;
        }
        protected override string Mostrar()
        {
            StringBuilder str = new StringBuilder();
            str.AppendFormat($"Datos : {base.Mostrar()}\nTara: {this.tara}\n");
            return str.ToString();
        }
    }
}
