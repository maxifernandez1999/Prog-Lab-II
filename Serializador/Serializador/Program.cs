using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Serializador
{
    class Program
    {
        static void Main(string[] args)
        {
            Games g = new Games("Shadow of Rome", 1);
            Serializadora<Games> s = new Serializadora<Games>();
            s.Guardar(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\ArchivoXML.txt", g);
            Console.WriteLine("xml guardado");
            s.GuardarB(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\ArchivoBinario.txt", g);
            Console.WriteLine("binario guardado");
            Console.ReadKey();


        }
    }
}
