using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Empleado : Persona
    {

        private int dni;
        public Empleado(short edad, string nombre)
            :this(edad,nombre,-1)
        {
            
        }
        public Empleado(short edad, string nombre, int dni)
            : base(edad, nombre)
        {
            this.dni = dni;

        }
        protected override string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Empleado: \n" + base.Mostrar());//llama a la base del metodo
            if (this.dni != -1)//si no se ingresa dni no lo imprimo
            {
                sb.AppendLine($"DNI: {this.dni}");
            }
            
            return sb.ToString();
        }
        public override string ToString()
        {
            return this.Mostrar();
        }
        public override bool Validar()//validacion
        {
            if (this.Edad > 21 && (this.Nombre.Length >= 2))
            {
                return true;
            }
            return false;
        }
        public static bool operator ==(Empleado e1, Empleado e2)
        {
            return e1.Edad == e2.Edad && e1.Nombre == e2.Nombre;
        }
        public static bool operator !=(Empleado e1, Empleado e2)
        {
            return !(e1 == e2);
        }
    }
}
