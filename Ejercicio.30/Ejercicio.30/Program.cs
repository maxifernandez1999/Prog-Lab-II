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
            Competencia competenciaF1 = new Competencia(20, 8, Competencia.TipoCompetencia.F1);
            Competencia competenciaMotocross = new Competencia(30, 8, Competencia.TipoCompetencia.Motocross);
            AutoF1 ferrari = new AutoF1(10, "hola mundo", 10);
            AutoF1 mercedez = new AutoF1(11, "xd", 11);
            AutoF1 audi = new AutoF1(12,"rtx", 12);

            MotoCross honda = new MotoCross(13, "hola mundo", 13);
            MotoCross cerro = new MotoCross(14, "xd", 14);
            MotoCross cientodiez = new MotoCross(15, "rtx", 15);

            bool retorno1 = competenciaF1 == ferrari;
            bool retorno2 = competenciaF1 == mercedez;
            bool retorno3 = competenciaF1 == audi;

            bool retorno4 = competenciaMotocross == honda;
            bool retorno5 = competenciaMotocross == cerro;
            bool retorno6 = competenciaMotocross == cientodiez;

            if (retorno1 == true && retorno2 == true && retorno3 == true && retorno4 == true && retorno5 == true && retorno6)
            {
                Console.WriteLine("Se agregaron los siguientes competidores:\n{0}\n{1}\n{2}\n{3}\n{4}\n{5}\n", ferrari.MostrarDatos(), mercedez.MostrarDatos(), audi.MostrarDatos(),honda.MostrarDatos(),cerro.MostrarDatos(),cientodiez.MostrarDatos());
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
