using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//f.Crear la clase VehiculoTerrestre y abstraer la información necesaria de las clases anteriores.
//Luego generar una relación de herencia entre ellas, según corresponda.
//g.VehiculoTerrestre tendrá un constructor que recibirá todos sus atributos.Modificar las
//clases que heredan de ésta para que lo reutilicen.
namespace ClassLibrary
{
    public class VehiculoTerrestre
    {
        protected enum Colores { Rojo, Blanco, Azul, Gris, Negro }
        protected short cantidadRuedas;
        protected short cantidadPuertas;
        protected Colores color;
        protected short cantidadMarchas;

        public VehiculoTerrestre(short cantidadRuedas, short cantidadPuertas, Colores color, short cantidadMarchas)
        {
            this.cantidadRuedas = cantidadRuedas;
            this.cantidadPuertas = cantidadPuertas;
            this.color = color;
            this.cantidadMarchas = cantidadMarchas;
            
        }
    }
}
