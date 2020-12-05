using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//12. Realizar un programa que sume números enteros hasta que el usuario lo determine, por medio de
//un mensaje "¿Continuar? (S/N)".
//En el método estático ValidaS_N(char c) de la clase ValidarRespuesta, se validará el ingreso de
//opciones.
//El método devolverá un valor de tipo booleano, TRUE si se ingresó una 'S' y FALSE si se ingresó
//cualquier otro valor.
namespace Ejercicio._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio 2";
            int numero;
            char caracter;
            int acumulador = 0;
            Console.WriteLine("Ingrese numeros: ");
            do
            {
                int.TryParse(Console.ReadLine(), out numero);
                acumulador = acumulador + numero;
                Console.WriteLine("Desea seguir ingresando numeros: S/N");
                char.TryParse(Console.ReadLine(), out caracter);
            } while (ValidarRespuesta.ValidaS_N(caracter));
            Console.WriteLine("La suma de los numeros ingresados es de: {0}",acumulador);
            Console.ReadKey();
        }
    }
}
