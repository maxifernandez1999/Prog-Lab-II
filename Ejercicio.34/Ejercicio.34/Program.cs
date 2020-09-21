using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary;
namespace Ejercicio._34
{
    class Program
    {
        static void Main(string[] args)
        {
            VehiculoTerrestre vehiculo = new VehiculoTerrestre(4, 2, VehiculoTerrestre.Colores.Blanco, 5);
            Moto moto = new Moto(10);
            Camion camion = new Camion(1000);
            Automovil auto = new Automovil(4);
        }
    }
}
