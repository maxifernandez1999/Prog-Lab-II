using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
//    Grupo:
//Clase pública que contendrá una lista de Mascotas, un nombre y atributo de clase tipo(Enumerado TipoManada
//contendrá Única, Mixta).
//Constructores:
// De clase: inicializará el tipo como Única.
// Por defecto privado, será el único lugar donde se inicialice la lista.
// El que recibe un parámetro inicializará el nombre.
// La última sobrecarga recibirá nombre y tipo.
// Reutilizar código.
//Una sola propiedad de sólo escritura para el tipo.
//Sobrecarga de Operadores:

    public class Grupo
    {
        public enum ETipoManada { Unica,Mixta}
        private List<Mascota> manada;
        private string nombre;
        public static ETipoManada tipo;

        private Grupo()
        {
            this.manada = new List<Mascota>();
        }
        static Grupo()
        {
            tipo = ETipoManada.Unica;
        }

        public Grupo(string nombre) : this()
        {
            this.nombre = nombre;
        }

        public Grupo(string nombre, ETipoManada tipo1) : this(nombre)
        {
            tipo = tipo1;
        }

        public static ETipoManada Tipo
        {
            set
            {
                tipo = value;
            }
        }
        // Un Grupo será igual a una Mascota si esta última forma parte de la lista.
        // Si una mascota no forma parte de la lista, se podrá agregar con el +. Informar caso contrario.
        // Si una mascota forma parte de la lista, se podrá quitar con el -. Informar caso contrario.
        // Conversión implícita a String, debiendo quedar la información con el siguiente formato:
        public static bool operator !=(Grupo g, Mascota m)
        {
            return !(g == m);
        }
        public static bool operator ==(Grupo g, Mascota m)
        {
            foreach (Mascota mascota in g.manada)
            {
                if (m == mascota)
                {
                    return true;
                }
            }
            return false;
        }
        public static Grupo operator +(Grupo g, Mascota m)
        {
            if (!(g == m))
            {
                g.manada.Add(m);
                return g;
            }
            return g;
        }
        public static Grupo operator -(Grupo g, Mascota m)
        {
            if ((g == m))
            {
                g.manada.Remove(m);
                return g;

            }
            return g;
        }
        public static implicit operator string(Grupo g)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Grupo: {g.nombre}");
            sb.AppendLine($"Tipo: {Grupo.tipo}");
            sb.AppendLine($"Integrantes({g.manada.Count})");
            foreach (Mascota m in g.manada)
            {
                sb.AppendLine($"{m.ToString()}");
            }

            return sb.ToString();
        }

    }
}
