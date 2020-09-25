using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary;
namespace Ejercicio._30
{
    class Program
    {
        static void Main(string[] args)
        {
            Competencia competencia = new Competencia(20, 2);
            AutoF1 ferrari = new AutoF1(10, "xd");
            AutoF1 mercedez = new AutoF1(11,"rx");
            AutoF1 audi = new AutoF1(12,"rtx");

            bool retorno1 = competencia + ferrari;
            bool retorno2 = competencia + mercedez;
            bool retorno3 = competencia + audi;

            if (retorno1 == true && retorno2 == true && retorno3 == true)
            {
                Console.WriteLine("Se agrego al competidor:\n{0}\n{1}\n{2}", ferrari.MostrarDatos(), mercedez.MostrarDatos(), audi.MostrarDatos());
            }
            else
            {
                Console.WriteLine("Se exedio el limite de competidores por competencia");
            }
            if (ferrari == mercedez)
            {
                Console.WriteLine("Tienen el mismo numero");
            }
            else
            {
                Console.WriteLine("NO son iguales");
            }
            Console.ReadKey();
        }
    }
}
