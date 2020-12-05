using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary;
using System.Threading;
namespace Ejercicio._64
{
    class Program
    {
        static void Main(string[] args)
        {
            Caja caja1 = new Caja();
            //caja1.FilaClientes.Add("El pepe");
            //caja1.FilaClientes.Add("Ete sech");
            //caja1.FilaClientes.Add("El Polaco Masterchef");
            //caja1.FilaClientes.Add("koinor");

            Caja caja2 = new Caja();
            //caja1.FilaClientes.Add("El pepe 2");
            //caja1.FilaClientes.Add("Ete sech 2");
            //caja1.FilaClientes.Add("El Polaco Masterchef 2");
            //caja1.FilaClientes.Add("koinor 2");
            Negocio negocio = new Negocio(caja1, caja2);
            negocio.Clientes.Add("El pepe 3");
            negocio.Clientes.Add("Ete sech 3");
            negocio.Clientes.Add("El Polaco Masterchef 3");
            negocio.Clientes.Add("koinor 3");
            negocio.AsignarCaja();

            Thread threadCaja1 = new Thread(caja1.AtenderClientes);
            
            threadCaja1.Start();
            threadCaja1.Name = "Caja1";

            Thread threadCaja2 = new Thread(caja2.AtenderClientes);
            
            threadCaja2.Start();
            threadCaja2.Name = "Caja2";

            Console.ReadKey();
        }
    }
}
