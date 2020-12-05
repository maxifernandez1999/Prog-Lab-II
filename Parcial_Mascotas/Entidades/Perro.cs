using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
//    Perro:
//Clase pública que hereda de Mascota con dos atributos propios privados(edad y esAlfa). Contará con un
//constructor con dos sobrecargas, en caso de no recibir edad ni esAlfa, deberán inicializarlos como 0 (cero) y false
//respectivamente.Reutilizar código.
//Implementar el método Ficha(). Retornará toda la información del Perro con el siguiente formato:
// Si es alfa: 'perro - Ramón - Salchicha, alfa de la manada, edad 2'
// Si no lo es: 'perro - Julio - Cruza, edad 13'
    public class Perro : Mascota
    {
        private int edad;
        private bool esAlfa;
        public Perro(string nombre, string raza)
            : base(nombre, raza)
        {
            this.edad = 0;
            this.esAlfa = false;
        }

        public Perro(string nombre,string raza,int edad, bool esAlfa)
            :this(nombre, raza)
        {
            this.edad = edad;
            this.esAlfa = esAlfa;
        }

        public override bool Equals(object obj)
        {
            return obj == this;
        }
        public override string ToString()
        {
            return this.Ficha();
        }
        protected override string Ficha()
        {
            StringBuilder sb = new StringBuilder();
            if(esAlfa == true)
            {
                sb.AppendLine($"Perro - {base.Nombre} - {base.Raza} - es alfa de la manada - {this.edad}");
                return sb.ToString();
            }
            else
            {
                sb.AppendLine($"Perro - {base.Nombre} - {base.Raza} -  {this.edad}");
                return sb.ToString();

            }
        }
//        Sobrecarga de Operadores:
// Dos Perros serán iguales si comparten nombre, raza y edad.Reutilizar código.
// Conversión explicita de Perro a entero, retornando su edad.
//Sobreescribir:
// Método ToString() para que publique la información del Perro. Reutilizar código.
// Método Equals() para que pueda ser comparado con cualquier objeto.Reutilizar código.

        public static bool operator !=(Perro p1, Perro p2)
        {
            return !(p1 == p2);
        }
        public static bool operator ==(Perro p1, Perro p2)
        {
            return (Mascota)p1 == (Mascota)p2 && p1.edad == p2.edad;
        }
        public static explicit operator int(Perro p)
        {
            return (int)p;
        }
    }
}
