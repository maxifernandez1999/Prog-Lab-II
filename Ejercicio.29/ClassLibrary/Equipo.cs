using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Equipo
    {
        private short cantidadDeJugadores;
        List<Jugador> jugadores;
        private string nombre;

        private Equipo()
        {
            this.jugadores = new List<Jugador>();
        }
        public Equipo(short cantidad, string nombre) :this()
        {
            this.cantidadDeJugadores = cantidad;
            this.nombre = nombre;
        }

        //La sobrecarga del operador + agregará jugadores a la lista siempre y cuando este no exista
        //aun en el equipo y la cantidad de jugadores no supere el límite establecido por el atributo
        //cantidadDeJugadores.
        public static bool operator +(Equipo e, Jugador j)
        {
            int cantidadJugadores = e.jugadores.Count;
            if (!(e.jugadores.Contains(j)) && e.cantidadDeJugadores > cantidadJugadores)
            {
                e.jugadores.Add(j);
                return true;
            }
            return false;
            
        }
    }
}
