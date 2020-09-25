using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralitaHerencia
{
    public class Llamada
    {
        public enum TipoLlamada {Local,Provincial,Todas }
        protected float duracion;
        protected string nroDestino;
        protected string nroOrigen;
        protected TipoLlamada tipoLlamada;
        public float Duracion
        {
            get
            {
                return this.duracion;
            }
            
        }
        public string NroDestino
        {
            get
            {
                return this.nroDestino;
            }
            
        }
        public string NroOrigen
        {
            get
            {
                return this.nroOrigen;
            }

        }
        public Llamada(float duracion, string nroDestino, string nroOrigen)
        {
            this.duracion = duracion;
            this.nroDestino = nroDestino;
            this.nroOrigen = nroOrigen;
        }

        public string Mostrar()
        {
            StringBuilder str = new StringBuilder();
            str.AppendFormat($"Duracion: {this.Duracion}\nNumero de destino: {this.NroDestino}\nNumero de origen: {this.NroOrigen}\nTipo de llamada: {this.tipoLlamada}");
            return str.ToString();
        }
        public static int OrdenarPorDuracion(Llamada llamada1, Llamada llamada2)
        {
            int retorno = 0;
            if (llamada1.Duracion < llamada2.Duracion)
            {
                retorno = -1;
            }
            else if (llamada1.Duracion > llamada2.Duracion)
            {
                retorno = 1;
            }
            return retorno;
        }

    }
}
