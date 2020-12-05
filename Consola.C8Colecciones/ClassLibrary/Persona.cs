using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Persona
    {
        private int dni;
        private string nombre;

        public int Dni
        {
            get { return dni;  }
            set { dni = value; }
        }
        public string Nombre
        {
            get
            {
                return nombre;
            }
        }
        public Persona(int dni, string nombre)
        {
            Dni = dni;
            this.nombre = nombre;
        }
        
    }
}
