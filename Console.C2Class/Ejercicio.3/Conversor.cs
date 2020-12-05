using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio._3
{
    class Conversor
    {
        public static string DecimalBinario(int entero)
        {
            string binario = Convert.ToString(entero, 2);
            return binario;
        }
        public static int BinarioDecimal(string binario)
        {
            int entero = Convert.ToInt32(binario,2);
            return entero;
            
        }
    }
}
