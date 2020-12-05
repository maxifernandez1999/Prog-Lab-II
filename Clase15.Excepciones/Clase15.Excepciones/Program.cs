using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase15.Excepciones
{
    class Program
    {
        static void Main(string[] args)
        {
            try//la excepcion va a ir al catch con el nombre de la excep que se lanzo
            {
                Console.WriteLine("Empezo el programa"); // Esto se ejecuta
                double resultado = Dividir(5, 0); // Lanza excepcion / solo se controlan si estan dentro de try 
                                                  //cuando relanzo la Excep en Dividir busca un bloque catch adecuado en al main
                                                  //Si la Excep ya fue controlada en Dividir: continua el flujo normal del programa desde aca

                Console.WriteLine("Ya dividio"); // No se ejecuta ya que cuando lanza excep, rompe y pasa al catch
            }
            catch(DivideByZeroException)
            {
                Console.WriteLine("Controle la excepcion");//se ejecuta esto
            }
            catch(Exception) // esta bueno ponerlos en el main // simpre va al final
            {
                Console.WriteLine("Se lleno la pila");
            }
            finally//se ejucuta siempre
            {
                //es un bloque que se ejecuta siempre
                //se utiliza en archivos
            }
            //El programa continua despues del catch
            Console.ReadKey();
            
        }
        public static double Dividir(int dividendo, int divisor)
        {
            
            try
            {
                double resultado = dividendo / divisor;//StackOverflowException
            }
            catch(DivideByZeroException ex) // se puede hacer una variable
            {
                Console.WriteLine(ex.Message); // propiedades de la excepcion
                //throw; //sirve para relanzar la excepcion
                throw new NullReferenceException(); //lanzar excepciones// sirve para cambiar el tipo de excepcion
            }
            catch(StackOverflowException)
            {
                Console.WriteLine("Se lleno la pila");
            }
            catch(NullReferenceException ex)
            {
                throw new Exception("NULL",ex); //propiedad inerrException// guarda la excepcion anterios a lanzarla
                                                //en este caso nullReferenceException
            }
            return 0;
            
        }
    }
}
