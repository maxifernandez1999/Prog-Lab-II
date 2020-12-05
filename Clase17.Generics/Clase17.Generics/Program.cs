using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Logic;
namespace Clase17.Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            Comic comic = new Comic("Un comic", 250.99, 100);
            //Las colecciones son colecciones generics
            //Se puede guardar cualquier tipo de variable dentro de <>
            Factura<Comic> factura = new Factura<Comic>();
            string text = factura.GenerarFactura(comic, 2);
            Console.WriteLine(text);
            Console.ReadKey();
        }
    }
}
