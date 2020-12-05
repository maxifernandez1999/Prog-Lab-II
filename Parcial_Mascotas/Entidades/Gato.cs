using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Gato : Mascota
    {
//        Gato:
//Clase pública que hereda de Mascota.
//Implementar el método Ficha(). Retornará toda la información del Gato con un formato similar al de Perro.
//Sobrecarga de Operadores:
// Dos Gatos serán iguales si comparten nombre y raza.Reutilizar código.
//Sobreescribir:
// Método ToString() para que publique la información del Gato. Reutilizar código.
// Método Equals para que pueda ser comparado con cualquier objeto. Reutilizar código.
        public Gato(string nombre, string raza)
            :base(nombre,raza)
        {
            
        }

        public override bool Equals(object obj)
        {
            return obj == this;
        }
        protected override string Ficha()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Gato - {base.Nombre} - {base.Raza}");
            return sb.ToString();
        }
        public static bool operator !=(Gato g1, Gato g2)
        {
            return !(g1 == g2);
        }
        public static bool operator ==(Gato g1, Gato g2)
        {
            return (Mascota)g1 == (Mascota)g2;
        }
        public override string ToString()
        {
            return this.Ficha();
        }
    }
}
