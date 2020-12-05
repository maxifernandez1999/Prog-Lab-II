using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Extension
{
    public static class MetodosExtension
    {
        /// <summary>
        /// SE UTILIZA PARA AGREGAR FUNCIONALIDAD A UNA CLASE SEALED (PORQUE NO SE PUEDE HEREDAR)
        /// </summary>
        /// <param name="dato"></param>
        /// <returns></returns>
        public static int ContadorPalabras(this string dato  /*,char datochar*/)//ESTATICO
        {
            return dato.Split(' ').Length;
        }

        //MAIN
        //using Extension
        //string dato = "Hola como estas";
        //dato.ContadorPalabras(datochar); //EL DATO A UTILIZAR TIENE QUE SER EL MISMO QUE LE PASAMOS EN EL THIS

        //SE UTILIZA COMO SI FUESE UN METODO DE INSTANCIA
        
    }
}
