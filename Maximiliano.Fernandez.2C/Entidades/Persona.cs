using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public abstract class Persona //clase abstracta
    {
        protected short edad;
        protected string nombre;

        protected Persona(short edad, string nombre)
        {
            this.edad = edad;
            this.nombre = nombre;
        }

        public short Edad // propiedad de lectura y escritura
        {
            get
            {
                return this.edad;
            }
            set
            {
                this.edad = value;
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
        protected virtual string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            if (!(this.Nombre is null)) // si el nombre es distinto de null
            {
                sb.AppendLine($"Nombre: {this.Nombre}");
            }
            sb.AppendLine($"Edad: {this.Edad}");
            
            return sb.ToString();
        }
        public static explicit operator string(Persona persona)//conversor explicit que llama a mostrar()
        {
            return persona.Mostrar();
        }
        public abstract bool Validar();

    }
}
