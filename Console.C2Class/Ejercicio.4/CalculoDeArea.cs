using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio._4
{
    class CalculoDeArea
    {
        public static double CalcularCuadrado(double largo)
        {
            double area = largo * largo;
            return area;
        }
        public static double CalcularTriangulo(double largo, double alto)
        {
            double area = (largo * alto) / 2;
            return area;
        }
        public static double CalcularCirculo(double radio)
        {
            double area = 3.14 * (radio * radio);
            return area;
        }

    }
}
