using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio._72
{
    public static class LongExtension
    {
        public static int CantidadDeDigitos(this long dato)
        {
            string datoString = dato.ToString();
            int cantidadDigitos = datoString.Length;
            return cantidadDigitos;
            
        }
    }
}
