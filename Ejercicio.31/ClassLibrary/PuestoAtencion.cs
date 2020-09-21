using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
//Puesto Atención:
//a.numeroActual es estático y privado.Se inicializará en el constructor de clase con valor 0.
//b.El método Atender simulará un tiempo de atención a un cliente: recibirá un cliente, simulará
//un tiempo de atención mediante el método de clase Sleep de la clase Thread(perteneciente
//al espacio de nombre System.Threading) y retornará true para indicar el final de la atención.
//c.NumeroActual es una propiedad estática, encargada de incrementar en 1 al atributo
//numeroActual y luego retornarlo.
namespace ClassLibrary
{
    public class PuestoAtencion
    {
        public enum Puesto { Caja1, Caja2};
        private static int numeroActual;
        private Puesto puesto;

        static PuestoAtencion()
        {
            PuestoAtencion.numeroActual = 0;
        }
        public PuestoAtencion(Puesto puesto)
        {
            this.puesto = puesto;
        }
        public static int NumeroActual
        {
            get
            {
                return PuestoAtencion.numeroActual++;
            }
        }

        public bool Atender(Cliente cli)
        {
            Thread.Sleep(1000);
            return true;
            
        }
    }
}
