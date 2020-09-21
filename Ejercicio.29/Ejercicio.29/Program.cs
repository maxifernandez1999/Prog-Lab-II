using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary;
//32. Tomar el ejercicio 29 como base.
//a.Agregar propiedades de sólo lectura a los atributos partidosJugados, promedioGoles y
//totalGoles de Jugador, y de lectura/escritura a nombre y dni.
//b.Quitar el atributo promedioGoles de jugador.Calcular dicho promedio dentro de la
//propiedad de sólo lectura PromedioDeGoles.
//c.Quitar el método GetPromedioGoles, colocando dicha lógica a la respectiva propiedad.
//d.Realizar todos los cambios necesarios para que vuelva a funcionar como antes.
namespace Ejercicio._29
{
    class Program
    {
        static void Main(string[] args)
        {
            Equipo Barca = new Equipo(11, "Barcelona");
            Jugador lionelMessi = new Jugador(18035241, "Messi", 75, 20);
            Jugador luisSuarez = new Jugador(18035, "Suarez", 51, 30);
            Jugador xavi = new Jugador(18035261, "Xavi", 58, 38);

            bool retorno1 = Barca + lionelMessi;
            bool retorno2 = Barca + luisSuarez;
            bool retorno3 = Barca + xavi;
            
            if (retorno1 == true && retorno2 == true && retorno3 == true)
            {
                Console.WriteLine("Se agrego el jugador:\n{0}\n{1}\n{2}", lionelMessi.MostrarDatos(), luisSuarez.MostrarDatos(), xavi.MostrarDatos());
            }
            else
            {
                Console.WriteLine("Se exedio el limite de jugadores por equipo");
            }
            if(lionelMessi == luisSuarez)
            {
                Console.WriteLine("Tienen el mismo dni");
            }
            else
            {
                Console.WriteLine("NO son iguales");
            }
            Console.ReadKey();
        }
    }
}
