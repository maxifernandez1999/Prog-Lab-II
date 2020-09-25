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
            //Las distintas clases heredadas son vehiculos terrestres
            //VehiculoTerrestre vehiculo = new VehiculoTerrestre(4, 2, VehiculoTerrestre.Colores.Blanco, 5);
            Moto moto = new Moto(2, 0, VehiculoTerrestre.Colores.Azul, 5, 2);
            VehiculoTerrestre camion = new Camion(6, 2, VehiculoTerrestre.Colores.Gris, 4, 2000); // cuando instancia a vehiculo terrestre no puedo ver los atributos del camion
            VehiculoTerrestre auto = new Automovil(4, 4, VehiculoTerrestre.Colores.Gris, 5, 5);

            Console.WriteLine(moto.cilandrada);
            Console.ReadKey();
        }
    }
}
