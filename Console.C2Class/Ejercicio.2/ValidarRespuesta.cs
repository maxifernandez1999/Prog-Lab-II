using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio._2
{
    class ValidarRespuesta
    {
        public static bool ValidaS_N(char c)
        {
            bool respuesta;
            if(c == 'S')
            {
                respuesta = true;
            }
            else
            {
                respuesta = false;
            }
            return respuesta;
        }
    }
}
