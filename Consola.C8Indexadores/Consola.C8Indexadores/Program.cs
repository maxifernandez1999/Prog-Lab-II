using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consola.C8Indexadores
{
    class Program
    {
        static void Main(string[] args)
        {
            Persona persona1 = new Persona(1234, "Mariana");
            Persona persona2 = new Persona(5648, "Miguel");
            Console.WriteLine(persona1.Dni);
            Console.ReadKey();
        }
    }
}
