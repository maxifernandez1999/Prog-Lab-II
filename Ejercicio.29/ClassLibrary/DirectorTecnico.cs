using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//d.Dos Directores Técnicos serán iguales si tienen el mismo nombre y fecha de nacimiento.
//e.Realizar las modificaciones necesarias para reutilizar código según la nueva estructura
//(constructores, métodos de exposición de datos).
//f.Realizar las propiedades necesarias en Persona y DirectorTecnico.
namespace ClassLibrary
{
    public class DirectorTecnico : Persona
    {
        private DateTime fechaNacimiento;

        public DirectorTecnico(string nombre) :base(nombre) 
        {
            
        }
        public DirectorTecnico(long dni, string nombre, DateTime fechaNacimiento) :base( dni ,nombre)    
        {
            this.fechaNacimiento = fechaNacimiento;
        }
        new public string MostrarDatos()
        {
            StringBuilder str = new StringBuilder();
            str.AppendFormat($"Nombre: {base.Nombre}\nDni: {base.Dni}\nFecha de nacimiento: {this.fechaNacimiento}\n");
            return str.ToString();
        }

        public static bool operator ==(DirectorTecnico dt1, DirectorTecnico dt2)
        {
            return dt1.Nombre == dt2.Nombre && dt1.fechaNacimiento == dt2.fechaNacimiento; 
        }
        public static bool operator !=(DirectorTecnico dt1, DirectorTecnico dt2)
        {
            return !(dt1 == dt2);
        }
    }
}
