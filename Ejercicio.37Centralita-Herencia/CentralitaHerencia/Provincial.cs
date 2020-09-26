using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralitaHerencia
{
    public class Provincial : Llamada
    {
        public enum Franja { Franja_1 , Franja_2, Franja_3}
        protected Franja franjaHoraria;

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

        public override string ToString()
        {
            return base.ToString();

        }
        private float CalcularCosto()
        {
            float costo = 0;
            switch(franjaHoraria)
            {
                case (Franja.Franja_1):
                    costo = base.duracion * (float)0.99;
                    break;
                case (Franja.Franja_2):
                    costo = base.duracion * (float)1.25;
                    break;
                case (Franja.Franja_3):
                    costo = base.duracion * (float)0.66;
                    break;
                default:
                    break;

            }
            return costo;
        }

        public override string Mostrar()
        {
            StringBuilder str = new StringBuilder();
            str.AppendFormat($"Duracion {base.Duracion}\nNumero Destino: {base.NroDestino}\nNumero Origen: {base.NroOrigen}\nTipo de Llamada: {base.tipoLlamada}\nCosto: {this.CostoLlamada}Franja horaria: {franjaHoraria}\n");
            return str.ToString();
        }

        public Provincial(Franja miFranja, Llamada llamada)
            :base(llamada.Duracion, llamada.NroOrigen, llamada.NroDestino)
        {
            this.franjaHoraria = miFranja;
            
        }
        public Provincial(string origen, Franja miFranja, float duracion, string destino)
            : this(miFranja, new Llamada(duracion, origen, destino))
        {
            
        }
            

    }
}
