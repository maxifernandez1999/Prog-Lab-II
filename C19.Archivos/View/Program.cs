using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Archivos;
namespace View
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string texto = "Hola mundo";
                string nombreArchivo = "clase_19";
                //string ruta = ""; // se guarda en bin/debug;
                string ruta2 = Environment.GetFolderPath(Environment.SpecialFolder.Desktop); // se agrega / al final
                FileManager fm = new FileManager();
                fm.EscribirArchivoTexto(ruta2, nombreArchivo, texto, false);
                fm.EscribirArchivoTexto(ruta2, nombreArchivo, "chau mundo", true);
                //si es true, hace un append

                fm.LeerArchivoTexto(ruta2, nombreArchivo, "chau mundo", true);
            }
            catch(Exception ex)
            {
                Console.WriteLine("Ocurrio un error",ex.Message);
                //si no se creo me tira la FileNotFoundException
            }
            
        }
    }
}
