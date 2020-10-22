using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    //    Clase Equipo:
    //a.El constructor privado será el único lugar donde se instanciará la lista de jugadores.
    //b.La constante cantidadMaximaJugadores tendrá un valor de 6.
    //c.La propiedad DirectorTecnico será utilizada para asignar un director técnico al equipo siempre y
    //cuando cumpla con las condiciones de aptitud.
    //d.El operador explícito retornará los datos del equipo, su director técnico (en caso de no tener uno
    //asignado aún, mostrar en su lugar el string "Sin DT asignado") y todos sus jugadores, utilizando
    //StringBuilder para compilar dicha información.
    //e.El operador == entre Equipo y Jugador informará true si esa instancia de Jugador ya se encuentra
    //agregada al equipo.

    
    public class Equipo
    {
        private const int cantidadMaximaJugadores = 6;
        private DirectorTecnico directorTecnico;
        private List<Jugador> jugadores;
        private string nombre;

        public DirectorTecnico DirectorTecnico
        {
            set
            {
                this.directorTecnico = value;
            }
        }

        public Equipo(string nombre): this()
        {
            this.nombre = nombre;
        }

        private Equipo()
        {
            this.jugadores = new List<Jugador>();
        }
        //g.ValidarEquipo: Método de clase que retorna true en caso de que un equipo sea válido, para lo cual
        //debe cumplir con las siguientes condiciones:
        //i.Tener un Director Técnico asignado.
        //ii.Tener al menos un jugador de c/posición.
        //iii.Tener sólo 1 arquero.
        //iv.Cumplir con la cantidad de integrantes completa (la cantidad de jugadores agregados a la
        //lista debe ser igual a la constante “cantidadMaximaJugadores”).
        public static bool ValidarEquipo(Equipo e)
        {
            int contadorArquero = 0;
            int contadorDefensor = 0;
            int contadorCentral = 0;
            int contadorDelantero = 0;
            foreach (Jugador j in e.jugadores)
            {
                switch (j.Posicion)
                {
                    case Posicion.Arquero:
                        contadorArquero++;
                        break;
                    case Posicion.Defensor:
                        contadorDefensor++;
                        break;
                    case Posicion.Central:
                        contadorCentral++;
                        break;
                    case Posicion.Delantero:
                        contadorDelantero++;
                        break;
                    default:
                        break;
                }
            }
            if (e.directorTecnico != null && contadorArquero == 1 && contadorDefensor >= 1 && contadorDelantero >= 1 && contadorCentral >= 1
                && e.jugadores.Count == Equipo.cantidadMaximaJugadores)
            {
                return true;
            }
            return false;
        }
        public static explicit operator string(Equipo e)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Nombre del equipo: {e.nombre}");
            if (e.directorTecnico is null)
            {
                sb.AppendLine($"DT sin asignar");

            }
            sb.AppendLine($"Nombre del equipo: {e.directorTecnico}");
            foreach (Jugador j in e.jugadores)
            {
                sb.AppendLine($"Jugadores\n {j.Mostrar()}");

            }
            return sb.ToString();
        }
        //f.El operador + entre Equipo y Jugador agregará el jugador al equipo siempre y cuando:
        //i.Este no haya sido agregado aún.
        //ii.No haya sido superada la cantidad de integrantes.
        //iii.Cumpla las condiciones de aptitud.
        public static Equipo operator +(Equipo e, Jugador j)
        {
            if (!(e == j) && e.jugadores.Count <= Equipo.cantidadMaximaJugadores)
            {
                e.jugadores.Add(j);
                return e;
            }
            return e;
        }
        public static bool operator ==(Equipo e, Jugador j)
        {
            
            foreach (Jugador jugador in e.jugadores)
            {
                if(jugador == j)
                {
                    return true;
                }
            }
            return false;
        }
        public static bool operator !=(Equipo e, Jugador j)
        {
            return !(e == j);
        }


    }
}
