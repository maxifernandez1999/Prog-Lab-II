using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Persona
    {
        private long dni;
        private string nombre;

        public long Dni
        {
            get
            {
                return this.dni;
            }
            set
            {
                this.dni = value;
            }
        }
        public string Nombre
        {
            get
            {
                return this.nombre;
            }
            set
            {
                this.nombre = value;
            }
        }

        public string MostrarDatos()
        {
            StringBuilder str = new StringBuilder();
            str.AppendFormat($"Nombre: {this.Nombre}\nDni: {this.Dni}\n");
            return str.ToString();
        }

        public Persona(long dni, string nombre) :this(nombre)
        {
            this.Dni = dni;
        }
        public Persona(string nombre)
        {
            this.Nombre = nombre;
        }
    }
}
