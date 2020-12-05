using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio._42
{

//    42. Crear el código necesario para:
//a.Crear 2 excepciones propias(nuevas clases que herede de excepción) con los nombres
//UnaExcepcion y MiExcepcion.


    public class UnaExcepcion : Exception
    {
        public UnaExcepcion() : base()
        {

        }
        public UnaExcepcion(string message, Exception innerException) : base(message, innerException)
        {

        }
    }
}
