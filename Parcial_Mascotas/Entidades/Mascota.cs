using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
//    Mascota:
//Clase pública con dos atributos privados(nombre y raza). El único constructor recibirá dos parámetros.
//Las propiedades Nombre y Raza serán de sólo lectura.
//Método abstracto y protegido Ficha() .
//Método virtual y protegido DatosCompletos() . Retornará el nombre y el raza con el formato "Nombre - Raza".
//Sobrecarga del operador == (igualdad), dos mascotas serán iguales si comparten nombre y raza.
    public abstract class Mascota
    {
        private string nombre;
        private string raza;

        public Mascota(string nombre, string raza)
        {
            this.nombre = nombre;
            this.raza = raza;
        }

        public string Raza
        {
            get
            {
                return this.raza;
            }
        }
        public string Nombre
        {
            get
            {
                return this.nombre;
            }
        }
        protected virtual string DatosCompletos()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"{this.Nombre} - {this.Raza}");
            return sb.ToString();
        }
        protected abstract string Ficha();
        
        public static bool operator !=(Mascota m1, Mascota m2)
        {
            return !(m1 == m2);
        }
        public static bool operator ==(Mascota m1, Mascota m2)
        {
            return m1.Nombre == m2.Nombre && m1.Raza == m2.Raza;
        }


    }
}
