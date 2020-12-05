using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio._72
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Ingrese un numero");
                string dato = Console.ReadLine();
                long dato1;
                long.TryParse(dato, out dato1);

                Console.WriteLine("Tiene " + dato1.CantidadDeDigitos() + " digitos");
                Console.ReadKey();
            }
            
            
        }
    }
}
