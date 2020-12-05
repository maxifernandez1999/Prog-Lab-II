using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
//Crear una clase llamada Calculadora que posea dos métodos estáticos(de clase):
//a.Calcular(público): Recibirá tres parámetros, el primer número, el segundo número y la
//operación matemática.El método devolverá el resultado de la operación.
//b.Validar(privado): Recibirá como parámetro el segundo número.Este método se debe
//utilizar sólo cuando la operación elegida sea la DIVISIÓN. Este método devolverá
//TRUE si el número es distinto de CERO.
namespace Ejercicio._5
{
    class Calculadora
    {
        public static float Calcular(float num1, float num2, char operacion)
        {
            float resultado = 0;
            switch (operacion)
            {
                case '+':
                    resultado = num1 + num2;
                    break;
                case '-':
                    resultado = num1 - num2;
                    break;
                case '*':
                    resultado = num1 * num2;
                    break;
                case '/':
                    if (Calculadora.Validar(num2) == true)
                    {
                        resultado = num1 / num2;
                    }
                    else if (Calculadora.Validar(num2) == false)
                    {
                        Console.WriteLine("No se puede dividir por 0");
                    }
                    
                    break;
                default:
                    break;
            }
            return resultado;
        }
        private static bool Validar(float num2)
        {
            bool retorno;
            if(num2 != 0)
            {
                retorno = true;
                return true;
            }
            else
            {
                retorno = false;
            }
            return retorno;
        }
        public static bool ValidaS_N(char c)
        {
            bool respuesta;
            if (c == 'S')
            {
                respuesta = true;
            }
            else
            {
                respuesta = false;
            }
            return respuesta;
        }
    }
}
