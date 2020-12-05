using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//13. Desarrollar una clase llamada Conversor, que posea dos métodos de clase(estáticos):
//string DecimalBinario(int). Convierte un número de entero a binario.
//int BinarioDecimal(string). Convierte un número binario a entero.
namespace Ejercicio._3
{
    class Program
    {
        static void Main(string[] args)
        {
            char validacion;
            do
            {
                Console.WriteLine("Ingrese un numero binario");
                string binario = Console.ReadLine();
                int entero = Conversor.BinarioDecimal(binario);
                Console.WriteLine(entero);

                int entero1;
                Console.WriteLine("Ingrese un numero decimal");
                int.TryParse(Console.ReadLine(), out entero1);
                string binario1 = Conversor.DecimalBinario(entero1);

                Console.WriteLine(binario1);
                Console.WriteLine("Desea continuar: S/N");
                
                char.TryParse(Console.ReadLine(), out validacion);

            } while (validacion == 'S');
            
            
            Console.ReadKey();
        }
    }
}
