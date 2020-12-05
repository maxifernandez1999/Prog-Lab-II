using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace ClassLibrary
{
    public class Caja
    {
        private List<string> filaClientes;

        public Caja()
        {
            this.filaClientes = new List<string>();
        }

        public List<string> FilaClientes
        {
            get
            {
                return this.filaClientes;
            }
        }

        public void AtenderClientes()
        {
            foreach (string s in filaClientes)
            {
                Console.WriteLine($"Atendiendo a: {s} en el thread {Thread.CurrentThread.Name}");
                Thread.Sleep(2000);
            }
            
        }
    }
}
