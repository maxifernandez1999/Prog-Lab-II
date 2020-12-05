using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace Archivos
{
    public class FileManager
    {
        public void EscribirArchivoTexto(string ruta, string nombre,string texto , bool anexar) //Guardar en Archivo de Texto
        {
            StreamWriter sw = null;
            try
            {
                string rutaCompleta = ruta + "/" + nombre + ".txt";//ruta completa "/" + nombre + extension
                sw = new StreamWriter(rutaCompleta, anexar); //anexar es true;append false;override
                sw.WriteLine(texto);//Escribir con un salto de linea
                // agrego la barra porque Enviroment no la agrega al final
            }
            finally // si lanza una excepcion, si o si se cierra
            {
                if (sw != null)
                    sw.Close();
            }
        }

        public string LeerArchivoTexto(string ruta, string nombre, string texto, bool anexar)//Leer archivo misma logica
        {
            StreamReader sr = null;
            try
            {
                string rutaCompleta = ruta + "/" + nombre + ".txt";//ruta completa "/" + nombre
                sr = new StreamReader(rutaCompleta, anexar);
                string text = string.Empty;
                string newLine = sr.ReadLine(); // Lee una sola linea
                // agrego la barra porque Enviroment no la agrega al final
                while (newLine != null)
                {
                    text += newLine + "\n";
                    newLine = sr.ReadLine();
                }
                return text;
            }
            finally
            {
                if (sr != null)
                    sr.Close();
            }
        }
    }
}
