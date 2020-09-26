using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class MotoCross : VehiculoDeCarrera
    {
        private short cilindrada;

        //public MotoCross(short cantidadCombustible, bool enCompetencia, short vueltasRestantes, short numero, string escuderia)
        //    : base(cantidadCombustible, enCompetencia, vueltasRestantes, numero, escuderia)
        //{

        //}
        public MotoCross(short numero, string escuderia, short cilindrada)
            :base(numero,escuderia)
        {
            this.Cilindrada = cilindrada;
        }
        public short Cilindrada
        {
            get
            {
                return this.cilindrada;
            }
            set
            {
                this.cilindrada = value;
            }
        }

        public string MostrarDatos()
        {
            StringBuilder str = new StringBuilder();
            str = str.AppendFormat($"Cantidad de combustible: {this.cantidadCombustible}\nEnCompetencia: {this.enCompetencia}\nEscuderia : {this.escuderia}\nNumero: {this.numero}\nVueltas restantes: {this.vueltasRestantes}\nCilindrada: {this.Cilindrada}\n");
            return str.ToString();
        }
        public static bool operator ==(MotoCross a1,MotoCross a2)
        {
            return (a1.Escuderia == a2.Escuderia) && (a1.Numero == a2.Numero) && (a1.Cilindrada == a2.Cilindrada);
        }
        public static bool operator !=(MotoCross a1, MotoCross a2)
        {
            return !(a1 == a2);
        }
    }
}
