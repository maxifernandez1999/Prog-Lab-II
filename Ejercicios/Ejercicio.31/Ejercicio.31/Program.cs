using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary;
namespace Ejercicio._31
{
    class Program
    {
        static void Main(string[] args)
        {
            Negocio negocio = new Negocio("El dipy papa");
            Cliente pepe = new Cliente(1, "Pepe");
            negocio.Cliente = pepe;
            if(!(negocio + pepe))
            {
                Console.WriteLine("Fue agregado a la cola de atencion");
            }
            Console.ReadKey();
        }
    }
}
