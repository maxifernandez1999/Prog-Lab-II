using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//27. Realizar el ejercicio anterior pero esta vez con las siguientes colecciones: Pilas, Colas y Listas.
namespace Ejercicio._27
{
    class Program
    {
        //Listas
        static void Main(string[] args)
        {
            Random rdm = new Random();
            List<int> enteros = new List<int>();
            for (int i = 0; i < 20; i++)
            {
                enteros.Add(rdm.Next(-20, 20));
                Console.WriteLine(enteros[i]);
            }
            Console.WriteLine("POSITIVOS");
            int aux;
            //utilizar propiedad sort
            enteros.Sort();// En este caso ordena por defecto de menos a mayor
            //for (int i = 0; i < (enteros.Count - 1); i++)
            //{
            //    for (int j = i + 1; j < enteros.Count; j++)
            //    {
            //        if (enteros[j] > enteros[i])
            //        {
            //            aux = enteros[j];
            //            enteros[j] = enteros[i];
            //            enteros[i] = aux;
            //        }
            //    }
            //}
            foreach (int entero in enteros)
            {
                if (entero > 0)
                {
                    Console.WriteLine(entero);
                }

            }
            Console.WriteLine("NEGATIVOS");
            //for (int i = 0; i < (enteros.Count - 1); i++)
            //{
            //    for (int j = i + 1; j < enteros.Count; j++)
            //    {
            //        if (enteros[j] < enteros[i])
            //        {
            //            aux = enteros[j];
            //            enteros[j] = enteros[i];
            //            enteros[i] = aux;
            //        }
            //    }
            //}
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
