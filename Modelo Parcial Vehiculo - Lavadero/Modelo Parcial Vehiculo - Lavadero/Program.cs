using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary;
namespace Modelo_Parcial_Vehiculo___Lavadero
{
    class Program
    {
        static void Main(string[] args)
        {
            double totalFacturado = 0;
            double totalFacturadoAuto = 0;
            double totalFacturadoMoto = 0;
            double totalFacturadoCamion = 0;

            Lavadero l = new Lavadero(500, 1000, 300);
            Moto m1 = new Moto("ASD455", 2, Vehiculo.EMarcas.Fiat, 10);
            Moto m2 = new Moto("ASF484", 2, Vehiculo.EMarcas.Ford, 11);

            Camion c1 = new Camion("WED452", 6, Vehiculo.EMarcas.Honda, 10);
            Camion c2 = new Camion("WSS452", 6, Vehiculo.EMarcas.Iveco, 11);

            Auto a1 = new Auto("LPD585", 4, Vehiculo.EMarcas.Scania, 4);
            Auto a2 = new Auto("LAS785", 4, Vehiculo.EMarcas.Zanella, 5);

            l += a1;
            l += a2;
            l += m1;
            l += m2;
            l += c1;
            l += c2;
            l += a1;

            Console.WriteLine(l.MiLavadero);
            Console.ReadLine();

            l -= m1;

            Console.WriteLine(l.MiLavadero);
            Console.ReadLine();

            totalFacturado = l.MostrarTotalFacturado();

            Console.WriteLine("Total facturado : ",totalFacturado.ToString());
            Console.WriteLine();


             
            totalFacturadoAuto = l.MostrarTotalFacturado(Lavadero.EVehiculos.Auto);

            Console.WriteLine(totalFacturadoAuto.ToString());

            totalFacturadoMoto = l.MostrarTotalFacturado(Lavadero.EVehiculos.Moto);

            Console.WriteLine(totalFacturadoMoto.ToString());

            totalFacturadoCamion = l.MostrarTotalFacturado(Lavadero.EVehiculos.Camion);

            Console.WriteLine(totalFacturadoCamion.ToString());

            Console.ReadKey();



        }
    }
}
