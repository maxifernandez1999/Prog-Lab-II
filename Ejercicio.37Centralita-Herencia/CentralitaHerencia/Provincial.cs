using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Provincial:
//g.El método Mostrar será protegido.Reutilizará el código escrito en la clase base y agregará
//franjaHoraria y CostoLlamada, utilizando un StringBuilder.
//h.Equals retornará true sólo si el objeto que recibe es de tipo Provincial.
//i.ToString reutilizará el código del método Mostrar.
namespace CentralitaHerencia
{
    public class Provincial : Llamada
    {
        public enum Franja { Franja_1 , Franja_2, Franja_3}
        protected Franja franjaHoraria;

        
        #region CONSTRUCTORES
        public Provincial(string origen, Franja miFranja, float duracion, string destino)
            : base(duracion, origen, destino)
        {
            this.franjaHoraria = miFranja;
        }
        public Provincial(Franja miFranja, Llamada llamada)
            : this(llamada.NroOrigen, miFranja, llamada.Duracion, llamada.NroDestino)
        {

        }
        #endregion

        public override float CostoLlamada
        {
            get
            {
                return this.CalcularCosto(); 
            }
            
        }

        #region METODOS

        public override bool Equals(object obj)
        {
            if (obj.GetType() == typeof(Provincial))
            {
                return true;
            }
            return false;
        }

        public override string ToString()
        {
            return Mostrar();

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

        protected override string Mostrar()
        {
            StringBuilder str = new StringBuilder();
            str.AppendFormat($"{base.Mostrar()}\nCosto: {this.CostoLlamada}\nFranja horaria: {franjaHoraria}\n");
            return str.ToString();
        }
        #endregion




    }
}
