using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Realizar una clase llamada Validacion que posea un método estático llamado Validar, que posea la
//siguiente firma: bool Validar(int valor, int min, int max):
//a.valor: dato a validar
//b.min y max: rango en el cual deberá estar la variable valor.
//Pedir al usuario que ingrese 10 números enteros. Validar con el método desarrollado
//anteriormente que esten dentro del rango -100 y 100.
//Terminado el ingreso mostrar el valor mínimo, el valor máximo y el promedio.
//Nota: Utilizar variables escalares, NO utilizar vectores.
namespace Consola.C2Class
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero;
            int min = 100;
            int max = -100;
            int acumulador = 0;
            float promedio = 0;
            Console.Title = "Ejercicio 1";
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Ingrese 10 numeros: ");
                int.TryParse(Console.ReadLine(), out numero);
                if (Validacion.Validar(numero, min, max) == true)
                {
                    if (numero < min) 
                    {
                        min = numero; 
                    }
                    else if(numero > max) 
                    {
                       max = numero;
                    }
                }
                acumulador = acumulador + numero;
                promedio = acumulador / 10;
                
                
            }
            Console.WriteLine("El valor minimo es {0}, el valor maximo es  {1} y el promedio es de {2:.0}", min, max, promedio);
            Console.ReadKey();
        }
    }
}
