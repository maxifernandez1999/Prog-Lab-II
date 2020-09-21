using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary; //ACA VA EL NAMESPACE DE LA LIBRERIA DE CLASES
//a.Se pide crear 3 instancias de la clase Alumno(3 objetos) en la función Main.
//Colocarle nombre, apellido y legajo a cada uno de ellos.

//b.Sólo se podrá ingresar las notas (nota1 y nota2) a través del método Estudiar.
//c.El método CalcularFinal deberá colocar la nota del final sólo si las notas 1 y 2 son mayores o
//iguales a 4, caso contrario la inicializará con -1. Para darle un valor a la nota final utilice
//el método de instancia Next de la clase Random.

//d.El método Mostrar, expondrá en la consola todos los datos de los alumnos. La nota final se
//mostrará sólo si es distinto de -1, caso contrario se mostrará la leyenda "Alumno
//desaprobado".
namespace Ejercicio16
{
    class Program
    {
        static void Main(string[] args)
        {
            byte nota1Moni;
            byte nota2Moni;
            byte nota1Coqui;
            byte nota2Coqui;
            byte nota1Pepe;
            byte nota2Pepe;
            
            Alumno moni = new Alumno("Moni", "Argento", 1000);
            Alumno coqui = new Alumno("Coqui", "Argento", 1001);
            Alumno pepe = new Alumno("Pepe", "Argento", 1002);
            Console.WriteLine("Moni: ");
            Console.WriteLine("Ingrese la nota del primer parcial: ");
            byte.TryParse(Console.ReadLine(), out nota1Moni);
            Console.WriteLine("Ingrese la nota del segundo parcial: ");
            byte.TryParse(Console.ReadLine(), out nota2Moni);

            Console.WriteLine("Coqui: ");
            Console.WriteLine("Ingrese la nota del primer parcial: ");
            byte.TryParse(Console.ReadLine(), out nota1Coqui);
            Console.WriteLine("Ingrese la nota del segundo parcial: ");
            byte.TryParse(Console.ReadLine(), out nota2Coqui);

            Console.WriteLine("Pepe: ");
            Console.WriteLine("Ingrese la nota del primer parcial: ");
            byte.TryParse(Console.ReadLine(), out nota1Pepe);
            Console.WriteLine("Ingrese la nota del segundo parcial: ");
            byte.TryParse(Console.ReadLine(), out nota2Pepe);
            
            moni.Estudiar(nota1Moni, nota2Moni);
            pepe.Estudiar(nota1Pepe, nota2Pepe);
            coqui.Estudiar(nota1Coqui, nota2Coqui);
            Console.WriteLine(moni.Mostrar());
            Console.WriteLine(coqui.Mostrar());
            Console.WriteLine(pepe.Mostrar());
            Console.ReadKey();
        }
    }
}
