using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
    public delegate void DelegadoString(string msg);
    public class Persona
    {
        public event DelegadoString EventoString;
        private string apellido;
        private string nombre;
        public Persona()
        {
            this.Nombre = String.Empty;
            this.Apellido = String.Empty;
        }

        public Persona(string apellido, string nombre)
        {
            this.apellido = apellido;
            this.nombre = nombre;
            if (this.EventoString != null)
            {
                this.EventoString.Invoke("Invocado");
            }
        }

        public string Nombre
        {
            get { return this.nombre; }
            set { this.nombre = value; }
        }
        public string Apellido
        {
            get { return this.apellido; }
            set { this.apellido = value; }
        }
        public string Mostrar()
        {
            return $"{this.Nombre},{this.Apellido}";
        }

        

    }
}
