using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class AutoF1 : VehiculoDeCarrera
    {

        protected short caballosDeFuerza;
        //public AutoF1(short numero, string escuderia, short caballosDeFuerza) : this(cantidadCombustible,enCompetencia, vueltasRestantes,numero,escuderia)
        //{
        //    this.caballosDeFuerza = caballosDeFuerza;
        //}
        public AutoF1(short numero, string escuderia, short caballosDeFuerza)
            : base(numero, escuderia)
        {
            this.CaballosDeFuerza = caballosDeFuerza;
        }

        public short CaballosDeFuerza
        {
            get
            {
                return this.caballosDeFuerza;
            }
            set
            {
                this.caballosDeFuerza = value;
            }
               
        }

        public string MostrarDatos()
        {
            StringBuilder str = new StringBuilder();
            str = str.AppendFormat($"Cantidad de combustible: {this.cantidadCombustible}\nEnCompetencia: {this.enCompetencia}\nEscuderia : {this.escuderia}\nNumero: {this.numero}\nVueltas restantes: {this.vueltasRestantes}\nCaballos de fuerza: {this.CaballosDeFuerza}\n");
            return str.ToString();
        }

        public static bool operator ==(AutoF1 a1, AutoF1 a2)
        {
            return (a1.Escuderia == a2.Escuderia) && (a1.Numero == a2.Numero) && (a1.CaballosDeFuerza == a2.CaballosDeFuerza);
        }
        public static bool operator !=(AutoF1 a1, AutoF1 a2)
        {
            return !(a1 == a2);
        }
    }
}
