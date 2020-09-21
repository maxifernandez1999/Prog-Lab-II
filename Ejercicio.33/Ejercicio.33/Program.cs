using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//El indexador leerá la página pedida, siempre y cuando el subíndice se encuentre dentro de un rango
//correcto, sino retornará un string vacio “”.
//En el set, la asignará si ésta ya existe.
//Si el índice es superior al máximo existente, agregará una nueva página.
//Generar el código en el Main para probar la clase.
namespace Ejercicio._33
{
    class Program
    {

        static void Main(string[] args)
        {
            Libro libro = new Libro();
            libro[0] = "Linux Code";
            libro[-1] = "Windows Code";
            Console.WriteLine(libro[-1]);
            Console.ReadKey();
        }
    }
}
