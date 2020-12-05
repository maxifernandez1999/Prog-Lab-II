using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio._42
{
    public class MiClase
    {

        //b.Crear una clase llamada MiClase y dentro colocar un método estático y 2 constructores de
        //instancia.
        //c.Dentro del método estático lanzar una excepción DivideByZeroException (sólo lanzarla).
        //d.Capturar la excepción del punto anterior en un constructor de instancia y relanzarla hacia
        //otro constructor de instancia.
        //e.En este segundo constructor instanciará otro objeto del tipo MiClase capturando su
        //excepción.Crear una excepción propia llamada UnaException (utilizar innerException para
        //almacenar la excepción original) y volver a lanzarla.
        public MiClase() 
        {
            try
            {
                MiClase c = new MiClase("xxxxxd");
            }
            catch(Exception ex)
            {
                throw new UnaExcepcion("capturada",ex);
            }
            
        }
        public MiClase(string mensaje)
        {
            try
            {
                MiClase.MetodoStatico();
            }
            catch(DivideByZeroException)
            {
                throw;
            }
        }

        public static void MetodoStatico()
        {
            throw new DivideByZeroException();
        }
    }
}
