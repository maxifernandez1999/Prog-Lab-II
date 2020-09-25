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
        
        public float CostoLlamada
        {
            get
            {
                return this.CalcularCosto();
            }
        }

        private float CalcularCosto()
        {
            return base.duracion * this.costo;
        }
        public Local(string origen, float duracion, string destino, float costo)
            :base(duracion,origen,destino)
        {
            this.costo = costo;
        }
        //public Local(Llamada llamada, float costo)
        //    : base(llamada.Duracion, llamada.NroOrigen, llamada.NroDestino)
        //{
        //    this.costo = costo;

        //}
        



        new public string Mostrar()
        {
            StringBuilder str = new StringBuilder();
            str.AppendFormat($"Duracion {base.Duracion}\nNumero Destino: {base.NroDestino}\nNumero Origen: {base.NroOrigen}\nTipo de Llamada: {base.tipoLlamada}\nCosto: {this.CostoLlamada}\n");
            return str.ToString();
        }

    }
}
