using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//b.Camión tendrá los atributos cantidadRuedas : short, cantidadPuertas : short, color : Colores,
//cantidadMarchas : short, pesoCarga : int.
//e.Crearle a cada clase un constructor que re.ciba todos sus atributos.


namespace ClassLibrary
{
    public class Camion : VehiculoTerrestre
    {
        public int pesoCarga;
       
        public Camion(short cantidadRuedas, short cantidadPuertas, Colores color, short cantidadMarchas,int pesoCarga) : base(cantidadRuedas, cantidadPuertas, color, cantidadMarchas)
        {
            this.pesoCarga = pesoCarga;
        }


    }
}
