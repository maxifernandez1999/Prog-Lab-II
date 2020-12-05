using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ejercicio._42;
namespace View
{
    class Program
    {
        //g.MiException será capturada en el Main, mostrando el mensaje de error que esta almacena
        //por pantalla y los mensajes de todas las excepciones almacenadas en sus innerException.
        static void Main(string[] args)
        {
            try
            {
                MiClase m = new MiClase();
                OtraClase o = new OtraClase();
            }
            catch(MiExcepcion ex)
            {
                Console.WriteLine(ex.Message, ex.StackTrace);
            }

            Console.ReadKey();
        }
    }
}
