using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//15. Realizar un programa que permita realizar operaciones matemáticas simples(suma, resta,
//multiplicación y división). Para ello se le debe pedir al usuario que ingrese dos números y la
//operación que desea realizar(pulsando el caracter +, -, * ó /).
//El usuario decidirá cuándo finalizar el programa.


namespace Ejercicio._5
{
    class Program
    {
        static void Main(string[] args)
        {
            char caracter;
            float resultado;
            do
            {
                int num1;
                int num2;
                char signo;
                
                Console.Title = "Ejercicio 5";
                Console.WriteLine("ingrese el primer numero: ");
                int.TryParse(Console.ReadLine(), out num1);
                Console.WriteLine("ingrese el segundo numero: ");
                int.TryParse(Console.ReadLine(), out num2);
                Console.WriteLine("ingrese la operacion que desea realizar: ");
                char.TryParse(Console.ReadLine(), out signo);

                resultado = Calculadora.Calcular(num1, num2, signo);
                Console.WriteLine("El resultadod de la operacion es: {0}", resultado);
                

                Console.WriteLine("Desea continuar S/N: ");
                char.TryParse(Console.ReadLine(), out caracter);


            } while (Calculadora.ValidaS_N(caracter) == true);
            


        }
    }
}
