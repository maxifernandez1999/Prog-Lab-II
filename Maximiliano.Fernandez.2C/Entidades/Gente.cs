using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Gente : Persona
    {
        //        Gente:
        //a.Herencia de persona, descripta en el diagrama.
        //b.La gente podrá no tener nombre, pero debe tener una edad cargada obligatoriamente.
        //c.Validar chequeará que esta edad sea mayor a 18 años.
        //d.El método Mostrar deberá indicar que es GENTE y luego imprimir su información.
        public Gente(short edad) : base(edad,"")
        { 
            
        }
        public Gente(short edad, string nombre)
            :this(edad)
        {
            this.Nombre = nombre;
            this.Edad = edad;
        }
        
        protected override string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"*ES UN CLIENTE");
            if (!(this.Nombre == ""))//base.Mostrar
            {
                sb.AppendLine($"Nombre: {this.Nombre}");
            }
            sb.AppendLine($"Edad: {this.Edad}");
            
            
            

            return sb.ToString();
        }
        // , toString, == y != de Gente
        public static bool operator ==(Gente e1, Gente e2)
        {
            return e1.Edad == e2.Edad && e1.Nombre == e2.Nombre;
        }
        public static bool operator !=(Gente e1, Gente e2)
        {
            return !(e1 == e2);
        }
        public override string ToString()
        {
            return this.Mostrar();
        }
        public override bool Validar()
        {
            if (this.Edad > 18)
            {
                return true;
            }
            return false;
        }
    }
}
