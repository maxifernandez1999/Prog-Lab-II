using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio._42
{
    //f.Generar la clase OtraClase con un método de instancia, donde se instancie un objeto
    //MiClase y se capture la excepción anterior. Este método generará una excepción propia
    //llamada MiException y la lanzará.

    public class OtraClase
    {

        public OtraClase()
        {
            
            
        }
        public void MetodoDeInstancia()
        { 
            try
            {
                MiClase miClase = new MiClase();
            }
            catch(Exception ex)
            {
                throw new MiExcepcion("Exception capturada", ex);
            }
            

        }
    }
}
