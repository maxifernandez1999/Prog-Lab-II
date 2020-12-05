using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//14. Realizar una clase llamada CalculoDeArea que posea 3 métodos de clase(estáticos) que realicen el
//cálculo del área que corresponda:
//a. double CalcularCuadrado(double)
//b. double CalcularTriangulo(double, double)
//c. double CalcularCirculo(double)
//El ingreso de los datos como la visualización se deberán realizar desde el método Main().
namespace Ejercicio._4
{
    class Program
    {
        static void Main(string[] args)
        {
            double areaCuadrado;
            double areaTriangulo;
            double areaCirculo;
            double cuadrado;
            double trianguloBase;
            double trianguloAltura;
            double circulo;
            Console.Title = "Ejercicio 4";
            Console.WriteLine("Ingrese la medida de uno de los lados del cuadrado: ");
            double.TryParse(Console.ReadLine(), out cuadrado);
            Console.WriteLine("Ingrese la base y la altura del triangulo: ");
            double.TryParse(Console.ReadLine(), out trianguloBase);
            double.TryParse(Console.ReadLine(), out trianguloAltura);
            Console.WriteLine("Ingrese el radio del circulo: ");
            double.TryParse(Console.ReadLine(), out circulo);

            areaCuadrado = CalculoDeArea.CalcularCuadrado(cuadrado);
            areaTriangulo = CalculoDeArea.CalcularTriangulo(trianguloBase,trianguloAltura);
            areaCirculo = CalculoDeArea.CalcularCirculo(circulo);

            Console.WriteLine("El area del cuadrado es de : {0}, el area del triangulo es de {1}, y el area del circulo es de {2}", areaCuadrado, areaTriangulo, areaCirculo);
            Console.ReadKey();
        }
    }
}
