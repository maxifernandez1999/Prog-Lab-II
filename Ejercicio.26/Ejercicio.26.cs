using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//26. Crear una aplicación de consola que cargue 20 números enteros(positivos y negativos) distintos de
//cero de forma aleatoria utilizando la clase Random.
//a.Mostrar el vector tal como fue ingresado
//b.Luego mostrar los positivos ordenados en forma decreciente.
//c.Por último, mostrar los negativos ordenados en forma creciente.
namespace Ejercicios.ArraysColecciones
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rdm = new Random();
            int[] enteros = new int[20];
            Console.WriteLine("NUMEROS ALEATORIOS");
            for (int i = 0; i < enteros.Length; i++)
            {
                int random = rdm.Next(-20, 20);
                enteros[i] = random;
                Console.WriteLine(enteros[i]);
            }
            Console.WriteLine("POSITIVOS");
            int aux;
            
            for (int i = 0; i < (enteros.Length - 1); i++)
            {
                for (int j = i + 1; j < enteros.Length; j++)
                {
                    if (enteros[j] > enteros[i])
                    {
                        aux = enteros[j];
                        enteros[j] = enteros[i];
                        enteros[i] = aux;
                    }
                }
            }
            foreach (int entero in enteros)
            {
                if(entero > 0)
                {
                    Console.WriteLine(entero);
                }
                
            }
            Console.WriteLine("NEGATIVOS");
            for (int i = 0; i < (enteros.Length - 1); i++)
            {
                for (int j = i + 1; j < enteros.Length; j++)
                {
                    if (enteros[j] < enteros[i])
                    {
                        aux = enteros[j];
                        enteros[j] = enteros[i];
                        enteros[i] = aux;
                    }
                }
            }
            foreach (int entero in enteros)
            {
                if (entero < 0)
                {
                    Console.WriteLine(entero);
                }

            }
            Console.ReadKey();
        }
        
    }
        
}
