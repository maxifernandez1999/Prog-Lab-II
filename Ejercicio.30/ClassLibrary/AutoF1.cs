using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class AutoF1
    {
        private short cantidadCombustible;
        private bool enCompetencia;
        private string escuderia;
        private short numero;
        private short vueltasRestantes;

        public AutoF1(short numero, string escuderia)
        {
            this.cantidadCombustible = 0;
            this.enCompetencia = false;
            this.vueltasRestantes = 0;
            this.numero = numero;
            this.escuderia = escuderia;
        }
        public string MostrarDatos()
        {
            StringBuilder str = new StringBuilder();
            str = str.AppendFormat($"Cantidad de combustible: {this.cantidadCombustible}\nEnCompetencia: {this.enCompetencia}\nEscuderia : {this.escuderia}\nNumero: {this.numero}\nVueltas restantes: {this.vueltasRestantes}\n");
            return str.ToString();
        }

        public short getCantidadCombustible()
        {
            return this.cantidadCombustible;
        }
        public bool setCantidadCombustible(short cantidadCombustible)
        {
            this.cantidadCombustible = cantidadCombustible;
            return true;
        }
        public short getVueltasRestantes()
        {
            return this.vueltasRestantes;
        }
        public bool setVueltasRestantes(short vueltasRestantes)
        {
            this.vueltasRestantes = vueltasRestantes;
            return true;
        }
        public bool getEnCompetencia()
        {
            return this.enCompetencia;
        }
        public bool setEnCompetencia(bool enCompetencia)
        {
            this.enCompetencia = enCompetencia;
            return true;
        }

        public static bool operator ==(AutoF1 a1, AutoF1 a2)
        {
            return a1.escuderia == a2.escuderia && a1.numero == a2.numero;
        }
        public static bool operator !=(AutoF1 a1, AutoF1 a2)
        {
            return !(a1 == a2);
        }
    }
}
