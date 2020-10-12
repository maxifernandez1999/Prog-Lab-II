using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public abstract class Persona
    {
        protected short edad;
        protected string nombre;

        protected Persona(short edad, string nombre)
        {
            this.edad = edad;
            this.nombre = nombre;
        }

        public short Edad
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
            if (!(this.Nombre is null))
            {
                sb.AppendLine($"{this.Nombre}");
            }
            sb.AppendLine($"{this.Edad}");
            
            return sb.ToString();
        }
        public static explicit operator string(Persona persona)
        {
            return (string)persona;
        }
        public abstract bool Validar();

    }
}
