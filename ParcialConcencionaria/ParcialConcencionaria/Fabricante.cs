using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParcialConcencionaria
{
    public class Fabricante
    {
        private string marca;
        private EPais pais;

        public Fabricante(string marca, EPais pais)
        {
            this.marca = marca;
            this.pais = pais;
        }
        public static implicit operator string(Fabricante f)
        {
            return f.marca && f.pais;
        }
        public static bool operator ==(Fabricante a,Fabricante b)
        {
            if (a.marca == b.marca && b.pais == b.pais)
            {
                return true;
            }
            return false;
            
        }

        public static bool operator !=(Fabricante a, Fabricante b)
        {
            return !(a == b);
        }

    }
}
