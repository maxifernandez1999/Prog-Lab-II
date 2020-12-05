using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
namespace ClassLibrary
{
    public class Negocio
    {
        private Caja caja1;
        private Caja caja2;
        private List<string> clientes;

        public Negocio(Caja caja1, Caja caja2)
        {
            this.caja1 = caja1;
            this.caja2 = caja2;
            clientes = new List<string>();
        }

        public Caja Caja1
        {
            get
            {
                return this.caja1;
            }
        }
        public Caja Caja2
        {
            get
            {
                return this.caja2;
            }
        }
        public List<string> Clientes
        {
            get
            {
                return this.clientes;
            }
        }
        public void AsignarCaja()
        {
            Console.WriteLine("Asignando cajas");
            foreach (string s in clientes)
            {
                if (caja1.FilaClientes.Count < caja2.FilaClientes.Count)
                {
                    caja1.FilaClientes.Add(s);
                }
                else
                {
                    caja2.FilaClientes.Add(s);
                }
                Thread.Sleep(1000);
            }
        }
    }
}
