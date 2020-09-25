using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Jugador : Persona
    {
        private int partidosJugados;
        private int totalGoles;

        //private Jugador()
        //{
        //    this.partidosJugados = 0;
        //    this.totalGoles = 0;
        //}

        public Jugador(long dni, string nombre) : base(dni,nombre)
        {
            
        }
        public Jugador(int dni, string nombre, int totalGoles, int totalPartidos) : this(dni,nombre)
        {
            this.totalGoles = totalGoles;
            this.partidosJugados = totalPartidos;
        }
        public int PartidosJugados
        {
            get
            {
                return this.partidosJugados;
            }
        }
        public double PromedioGoles
        {
            
            get
            {
                double promedioGoles = (double)this.totalGoles / (double)this.partidosJugados;
                return promedioGoles;
            }
        }
        public int TotalGoles
        {
            get
            {
                return this.totalGoles;
            }
        }
        //public int Dni
        //{
        //    get
        //    {
        //        return ;
        //    }
        //    set
        //    {
        //        this.dni = value;
        //    }
        //}
        //public string Nombre
        //{
        //    get
        //    {
        //        return this.nombre;
        //    }
        //    set
        //    {
        //        this.nombre = value;
        //    }
        //}

        new public string MostrarDatos()
        {
            StringBuilder str = new StringBuilder();
            str = str.AppendFormat($"Dni : {base.Dni}\nNombre : {base.Nombre}\nPartidos Jugados: {this.partidosJugados}\nTotal de goles: {this.totalGoles}\nPromedio de Goles: {PromedioGoles:F}\n");
            return str.ToString();
        }
        
        
        public static bool operator !=(Jugador j1, Jugador j2)
        {
            return !(j1 == j2);
        }
        public static bool operator ==(Jugador j1, Jugador j2)
        {
            return j1.Dni == j2.Dni;
        }

    }
}
