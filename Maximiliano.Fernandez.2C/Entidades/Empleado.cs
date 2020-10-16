using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Empleado : Persona
    {
//        a.Herencia de persona, descripta en el diagrama.
//b.El empleado deberá tener nombre y edad de forma obligatoria.
//c.Validar chequeará que esta edad sea mayor a 21 años y que su nombre tenga al menos 2
//caracteres.
//d.Si un empleado no recibiera el atributo DNI este deberá cargarse con -1. Estos documentos
//no se deberán mostrar por pantalla en los informes.
//e.Dos empleados serán iguales si tienen el mismo nombre y edad.
//f.El método Mostrar deberá indicar que es un EMPLEADO y luego imprimir su información.

        private int dni;
        public Empleado(short edad, string nombre)
            :base(edad,nombre)
        {
            
        }
        public Empleado(short edad, string nombre, int dni)
            : this(edad, nombre)
        {
            if (dni == 0)
            {
                this.dni = -1;
            }
            else
            {
                this.dni = dni;
            }
            
        }
        protected override string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"*ES UN EMPLEADO");//base.Mostrar()
            sb.AppendLine($"Nombre: {this.Nombre}");
            sb.AppendLine($"Edad: {this.Edad}");
            if (this.dni != -1)
            {
                sb.AppendLine($"DNI: {this.dni}");
            }
            
            return sb.ToString();
        }
        public override string ToString()
        {
            return this.Mostrar();
        }
        public override bool Validar()
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
