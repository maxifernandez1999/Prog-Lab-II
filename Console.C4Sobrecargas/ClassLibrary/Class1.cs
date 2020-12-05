using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Matematica

    {
        private int divisor;
        private int dividendo;
        public static int numero = 20;
        //SOBRECARGA DE CONSTRUCTORES
        public Matematica(int divisor) //Constructor
        {
            this.divisor = divisor;
        }
        public Matematica(int divisor, int dividendo) //sobrecarga del constructor
            : this(divisor)//llama a otro constructor de la misma clase
        {
            this.dividendo = dividendo;
        }
        //SOBRECARGA DE METODOS
        public double Sumar(int a)
        {
            return a;
        }
        public int Sumar(int a, int b)//Metodo sobrecargado
        {
            return a + b;
        }
        /// <summary>
        /// SOBRECARGAS DE OPERADORES
        /// </summary>
        /// <param name="m1"></param>
        /// <param name="p2"></param>
        /// <returns></returns>
        public static bool operator ==(Matematica m1, int divisor) //sobrecarga de ==, en este caso compara un dato de tipo Matematica con un int
        {
            return m1.divisor == divisor; //retorna true o false
        }
        public static bool operator !=(Matematica m1, int divisor)// hay que hacer siempre la contraposicision
        {
            return !(m1.divisor == divisor);//se niega el ==
        }
        public static implicit operator Matematica (int divisor)
        {
            return new Matematica(divisor);
        }
        public static explicit operator int (Matematica matematica)
        {
            return matematica.divisor;
        }
        public static long operator +(Matematica dividendo, Matematica divisor)
        {
            return dividendo.dividendo + divisor.divisor;
        }
    }
}
