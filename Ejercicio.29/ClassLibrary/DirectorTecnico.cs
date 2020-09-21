using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class DirectorTecnico
    {
        private DateTime fechaNacimiento;

        public DirectorTecnico(string nombre)
        {
            this.nombre = nombre;
        }
        public DirectorTecnico(string nombre, DateTime fechaNacimiento)
        {
            this.fechaNacimiento = fechaNacimiento;
        }
        public MostrarDatos()
        {

        }

        public static bool operator ==(DirectorTecnico dt1, DirectorTecnico dt2)
        {
            return dt1.nombre == dt2.nombre && dt1.fechaNacimiento == dt2.fechaNacimiento; 
        }
        public static bool operator !=(DirectorTecnico dt1, DirectorTecnico dt2)
        {
            return !(dt1 == dt2);
        }
    }
}
