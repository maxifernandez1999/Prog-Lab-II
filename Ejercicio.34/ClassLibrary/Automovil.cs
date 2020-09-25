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

        public Automovil(short cantidadRuedas, short cantidadPuertas, Colores color, short cantidadMarchas,int cantidadPasajeros) 
            : base(cantidadRuedas, cantidadPuertas, color, cantidadMarchas)// llama al constructor del Clase Base
        {
            //al constructor se le agrega los parametros del constructor base
            this.cantidadPasajeros = cantidadPasajeros;
        }
    }
}
