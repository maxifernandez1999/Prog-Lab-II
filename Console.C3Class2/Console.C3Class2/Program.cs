using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary; //vas todas las clases que no tienen que ver con la Consola
namespace Consola.C3Class2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Instanciar las 4 mascotas
            //mostrar en consola utilizando el metodo MostrarDatos que devuelva un string, los datos de mascotas.
            //Realizar un metodo que devuelva la edad de la mascota. Usando DateTime(devuelve un int)
           
            Mascota mascota1;//Declarar
            Mascota mascota2;
            Mascota mascota3;
            Mascota mascota4;
            
            mascota1 = new Mascota("Pepe", new DateTime(1990, 01, 20), "gato");//Instanciar
            mascota2 = new Mascota("Moni", new DateTime(1991, 02, 20), "perro");
            mascota3 = new Mascota("Dardo", new DateTime(1980, 03, 20), "pejelagarto");
            mascota4 = new Mascota("MariaElena", new DateTime(1999, 04, 20), "delfin");
            Console.WriteLine(mascota1.MostrarDatos());
            Console.WriteLine(mascota2.MostrarDatos());
            Console.WriteLine(mascota3.MostrarDatos());
            Console.WriteLine(mascota4.MostrarDatos());
            Console.ReadKey();
        }
    }
}
