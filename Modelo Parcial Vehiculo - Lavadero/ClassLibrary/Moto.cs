using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Moto : Vehiculo
    {
        protected float cilindrada;

        public Moto(string patente, byte cantRuedas, EMarcas marca, float cilindrada)
            :base(patente,cantRuedas,marca)
        {
            this.cilindrada = cilindrada;
        }

        protected override string Mostrar()
        {
            StringBuilder str = new StringBuilder();
            str.AppendFormat($"Datos : {base.Mostrar()}\nCilindrada: {this.cilindrada}\n");
            return str.ToString();
        }
    }
}
