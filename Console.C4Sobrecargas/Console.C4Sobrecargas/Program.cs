using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary;
namespace Consola.C4Sobrecargas
{
    class Program
    {
        static void Main(string[] args)
        {
            Matematica m = new Matematica(10,2);//crea un objeto de matematica
            double m1 = m.Sumar(10,4);
            Console.WriteLine(m1);
            

            if(m == 10) //con la sobrecarga de operadores se puede comparar datos de distintos tipos
            {
                Console.WriteLine("ok");
            }
            Console.ReadKey();
        }
    }
}
