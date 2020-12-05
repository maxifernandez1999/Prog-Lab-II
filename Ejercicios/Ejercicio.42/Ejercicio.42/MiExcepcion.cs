using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio._42
{
    public class MiExcepcion : Exception
    {
        public MiExcepcion():base()
        {

        }
        public MiExcepcion(string message,Exception innerException) : base(message,innerException)
        {

        }
    }
}
