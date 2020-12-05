using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio._67
{
    class Program
    {
        static void Main(string[] args)
        {
            Temporizador temp = new Temporizador();
            temp.Intervalo = 300;
            temp.Activo = true;
            Console.ReadKey();

        }
    }
}
