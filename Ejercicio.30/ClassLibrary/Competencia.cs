using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Competencia
    {
        private short cantidadCompetidores;
        private short cantidadVueltas;
        public List<AutoF1> competidores;

        private Competencia()
        {
            this.competidores = new List<AutoF1>();
        }
        public Competencia(short cantidadVueltas, short cantidadCompetidores)
            :this()
        {
            this.cantidadVueltas = cantidadVueltas;
            this.cantidadCompetidores = cantidadCompetidores;
        }
       
        public string MostrarDatos()
        {
            StringBuilder str = new StringBuilder();
            str = str.AppendFormat($"Cantidad de competidores : {this.cantidadCompetidores}\nCantidad de Vueltas: {this.cantidadVueltas}\n");
            return str.ToString();
        }
        //public static bool operator -(Competencia c, AutoF1 a)
        //{
            
            
            
        //}
        public static bool operator ==(Competencia c, AutoF1 a)
        {
            if (!(c.competidores.Contains(a)))
            {
                return true;
            }
            return false;
        }
        //La sobrecarga + agregará un competidor si es que aún hay espacio(validar con
        //cantidadCompetidores) y el competidor no forma parte de la lista(== entre Competencia y
        //AutoF1).
        //Al ser agregado, el competidor cambiará su estado enCompetencia a verdadero, la cantidad
        //de vueltasRestantes será igual a la cantidadVueltas de Competencia y se le asignará un
        //número random entre 15 y 100 a cantidadCombustible.
        public static bool operator +(Competencia c, AutoF1 a)
        {
            Random rdm = new Random();
            short vueltasRest = a.getVueltasRestantes();
            short cantVueltas = c.cantidadVueltas;

            if ((c.competidores.Count < c.cantidadCompetidores) && c == a)
            {
                c.competidores.Add(a);
                a.setEnCompetencia(true);
                vueltasRest = cantVueltas;
                short cantCombustible = (short)rdm.Next(15, 100);
                a.setCantidadCombustible(cantCombustible);
                return true;
            }
            return false;
        }
        public static bool operator !=(Competencia c, AutoF1 a)
        {
            return !(c == a);
        }

    }
}
