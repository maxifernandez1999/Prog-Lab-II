using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralitaHerencia
{
    public class Local : Llamada
    {
        protected float costo;
        
        public override float CostoLlamada
        {
            get
            {
                return this.CalcularCosto();
            }
        }
        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        private float CalcularCosto()
        {
            return base.duracion * this.costo;
        }
        public Local(string origen, float duracion, string destino, float costo)
            :this(llamada(origen,duracion,destino),costo)
        {

        }
        public Local(Llamada llamada, float costo)
            : base(llamada.Duracion, llamada.NroOrigen, llamada.NroDestino)
        {

            this.costo = costo;
        }


        public override string ToString()
        {
            return base.ToString();

        }

        public override string Mostrar()
        {
            StringBuilder str = new StringBuilder();
            str.AppendFormat($"Duracion {base.Duracion}\nNumero Destino: {base.NroDestino}\nNumero Origen: {base.NroOrigen}\nTipo de Llamada: {base.tipoLlamada}\nCosto: {this.CostoLlamada}\n");
            return str.ToString();
        }

    }
}
