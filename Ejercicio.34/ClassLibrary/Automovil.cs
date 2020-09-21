using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//c.Automovil: cantidadRuedas : short, cantidadPuertas : short, color : Colores,
//cantidadMarchas : short, cantidadPasajeros : int.
namespace ClassLibrary
{
    public class Automovil : VehiculoTerrestre
    {
        
        
        public int cantidadPasajeros;

        public Automovil(int cantidadPasajeros) : base(cantidadRuedas, cantidadPuertas, color, cantidadMarchas)
        {
            
            this.cantidadPasajeros = cantidadPasajeros;
        }
    }
}
