using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase15.Excepciones //clase heredada de exception
{
    public class DNIInvalidoException : Exception
    {
        public DNIInvalidoException() : base()
        {

        }
        public DNIInvalidoException(string message) : base(message)
        {

        }
        public DNIInvalidoException(string message, Exception innerException): base(message, innerException)
        {

        }
    }
}
