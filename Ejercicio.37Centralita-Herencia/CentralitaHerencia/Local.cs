using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Local:
//d.Sobreescribir el método Mostrar.Será protegido.Reutilizará el código escrito en la clase
//base y además agregará la propiedad CostoLlamada, utilizando un StringBuilder.
//e.Equals retornará true sólo si el objeto que recibe es de tipo Local.
//f.ToString reutilizará el código del método Mostrar.
namespace CentralitaHerencia
{
    public class Local : Llamada
    {
        protected float costo;

        #region CONSTRUCTORES
        public Local(string origen, float duracion, string destino, float costo) ////
            : base(duracion, origen, destino)
        {
            this.costo = costo;
        }
        public Local(Llamada llamada, float costo)
            : this(llamada.NroOrigen, llamada.Duracion, llamada.NroDestino, costo)
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
            if (obj.GetType() == typeof(Local))
            {
                return true;
            }
            return false;
        }


        private float CalcularCosto()
        {
            return base.duracion * this.costo;
        }
        


        public override string ToString()
        {
            return Mostrar();

        }

        protected override string Mostrar()
        {
            StringBuilder str = new StringBuilder();
            str.AppendFormat($"{base.Mostrar()}\nCosto: {this.CostoLlamada}\n");
            return str.ToString();
        }
        #endregion
    }
}
