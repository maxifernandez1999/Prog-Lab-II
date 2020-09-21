using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//d.Moto: cantidadRuedas : short, cantidadPuertas : short, color : Colores, cilindrada : short.
namespace ClassLibrary
{
    public class Moto : VehiculoTerrestre
    {
        
        
        public short cilandrada;

        public Moto(short cilandrada) : base(cantidadRuedas, cantidadPuertas, color, cantidadMarchas)
        {
            
            this.cilandrada = cilandrada;
        }
    }
}
