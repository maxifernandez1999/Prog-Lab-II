using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class VehiculoDeCarrera
    {
        protected short cantidadCombustible;
        protected bool enCompetencia;
        protected string escuderia;
        protected short numero;
        protected short vueltasRestantes;

        public VehiculoDeCarrera(short numero, string escuderia)
        {
            this.CantidadCombustible = 0;
            this.EnCompetencia = false;
            this.VueltasRestantes = 0;
            this.Numero = numero;
            this.Escuderia = escuderia;
        }
        public string MostrarDatos()
        {
            StringBuilder str = new StringBuilder();
            str.AppendFormat($"Numero: {this.Numero}\nEscuderia: {this.Escuderia}\nVueltas restantes: {this.VueltasRestantes}\nCantidad de combustible: {this.CantidadCombustible}\nEn competencia: {this.EnCompetencia}\n");
            return str.ToString();
        }
        public short CantidadCombustible
        {
            get
            {
                return this.cantidadCombustible;
            }
            set
            {
                this.cantidadCombustible = value;
            }
        }
        public bool EnCompetencia
        {
            get
            {
                return this.enCompetencia;
            }
            set
            {
                this.enCompetencia = value;
            }
        }
        public string Escuderia
        {
            get
            {
                return this.escuderia;
            }
            set
            {
                this.escuderia = value;
            }
        }
        public short Numero
        {
            get
            {
                return this.numero;
            }
            set
            {
                this.numero = value;
            }
        }
        public short VueltasRestantes
        {
            get
            {
                return this.vueltasRestantes;
            }
            set
            {
                this.vueltasRestantes = value;
            }
        }

        

    }
}
