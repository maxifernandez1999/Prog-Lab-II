using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Negocio:
//e.El constructor privado inicializará la colección y el puesto de atención como Caja1.
//f.El operador + será el único capaz de agregar un Cliente a la cola de atención.Sólo se
//agregará un Cliente si este no forma ya parte de la lista.Rehutilizar el == de Cliente.
//g.La propiedad Cliente retornará el próximo cliente en la cola de atención en el get.El set
//deberá controla que el Cliente no figure ya en la cola de atención, caso contrario lo
//agregará.
//h.El operador == retornará true si el cliente se encuentra en la colección.
//i.El operador ~(Negocio) : bool generará una atención del próximo cliente en la cola,
//utilizando la propiedad Cliente y el método Atender de PuestoAtencion. Retornará True si
//pudo realizar la operación completa.
//j.Agregar la propiedad ClientesPendientes que retorne la cantidad de clientes esperando a ser
//atendidos.
namespace ClassLibrary
{
    public class Negocio
    {
        private PuestoAtencion caja;
        Queue<Cliente> clientes;
        string nombre;

        private Negocio()
        {
            this.caja = new PuestoAtencion(PuestoAtencion.Puesto.Caja1);
            this.clientes = new Queue<Cliente>();
        }
        public Negocio(string nombre) : this()
        {
            this.nombre = nombre;
        }
        public Cliente Cliente
        {
            get
            {
                return this.clientes.Dequeue();// primero en entrar primero en salir
            }
            set
            {
                if ((clientes.Contains(value)))
                {
                    clientes.Enqueue(value);
                }
                clientes.Enqueue(value);
            }
        }

        public static bool operator !=(Negocio n,Cliente c)
        {
            return !(n == c);
        }
        public static bool operator ~(Negocio n)
        {
            return n.caja.Atender(n.Cliente);
        }
        public static bool operator +(Negocio n, Cliente c)
        {
            if (n != c) // n representa la cola
            {
                n.clientes.Enqueue(c);
                return true;
            }
            return false;
        }
        public static bool operator ==(Negocio n, Cliente c)
        {
            foreach (Cliente cli in n.clientes)
            {
                if (cli == c)
                {
                    return true;
                }
            }
            return false;
        }


    }
}
