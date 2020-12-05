using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary;

namespace Consola.C8Colecciones
{
    class Program
    {
        static void Main(string[] args)
        {
            //LIST
            #region
            
            List<string> listaDeNombres = new List<string>();
            listaDeNombres.Add("Maxi");
            listaDeNombres.Add("Pablo");
            listaDeNombres.Add("Mauricio");
            listaDeNombres.Sort();

            foreach (string nombre in listaDeNombres)
            {
                Console.WriteLine(nombre);
            }
            listaDeNombres.Remove("Mauricio");

            for (int i = 0; i < listaDeNombres.Count; i++)
            {
                Console.WriteLine(listaDeNombres[i]);
            }
            listaDeNombres.RemoveAt(0);
            Console.WriteLine(listaDeNombres[0]);//Claudia
            #endregion

            //SORT DE LIST
            #region

            List<Persona> personas = new List<Persona>();
            personas.Add(new Persona(123, "Juan"));
            personas.Add(new Persona(231, "Pepe"));
            personas.Add(new Persona(32, "Moni"));
            personas.Add(new Persona(333, "Pablo"));

            foreach (Persona persona in personas)
            {
                Console.WriteLine($"DNI: {persona.Dni} Nombre: {persona.Nombre}");
            }
            //Ordenar de forma ascendente
            personas.Sort(OrdenarPersonas);//Criterio predeterminado //Persona : excepcion
            foreach (Persona persona in personas)
            {
                Console.WriteLine($"DNI: {persona.Dni} Nombre: {persona.Nombre}");
            }
            #endregion


            //DICTIONARY
            #region
            Dictionary<int, string> agenda = new Dictionary<int, string>();
            //Trabaja de a pares (llave valor)
            agenda.Add(123, "Juan");
            agenda.Add(1234, "Pepe");
            agenda.Add(1425, "Griselda");
            if (agenda.ContainsKey(0))
            {
                Console.WriteLine(agenda[0]);
            }
            else if (agenda.ContainsKey(123))
            {
                Console.WriteLine(agenda[123]);
            }

            foreach (KeyValuePair<int, string> contacto in agenda)
            {
                Console.WriteLine($"La clave es {contacto.Key} y el valor {contacto.Value}");
            }
            #endregion



            //QUEUE (Colas) Primero entrar primero Salir (FIFO)
            #region
            Queue<string> colaDeAtencion = new Queue<string>();
            colaDeAtencion.Enqueue("Juan Perez");
            colaDeAtencion.Enqueue("Carmina");
            colaDeAtencion.Enqueue("Pedrito");

            foreach (string clientes in colaDeAtencion)
            {
                Console.WriteLine(clientes);
            }
            for (int i = 0; i < colaDeAtencion.Count; i++)//con un foreach no se puede porque no puede cambiar el size de la coleccion
            {
                Console.WriteLine(colaDeAtencion.Dequeue());
            }
            
            Console.WriteLine(colaDeAtencion.Peek());//solo muestra el primer elemento
            Console.WriteLine(colaDeAtencion.Dequeue());
            Console.WriteLine(colaDeAtencion.Dequeue());
            Console.WriteLine(colaDeAtencion.Dequeue());

            #endregion

            //STACK (LIFO) Ultimo en entrar primero en salir
            #region
            Stack<char> letras = new Stack<char>();
            letras.Push('B');
            letras.Push('A');
            letras.Push('C');

            foreach (char letra in letras)
            {
                Console.WriteLine(letra);
            }
            letras.Peek();
            Console.WriteLine(letras.Pop());
            //NO GENERICAS
            //ARRAYLIST - Funciona igual que List
            ArrayList lista = new ArrayList();
            lista.Add("Griselda");
            lista.Add(123);
            lista.Add(new Persona());

            foreach (object item in lista)
            {
                Console.WriteLine(item.GetType().Name);
            }
            #endregion
            //HASHTABLE - Parecido a diccionario


            Console.ReadKey();


        }
        private static int OrdenarPersonas(Persona elementoSiguiente, Persona elementoActual)
        {
            int criterio = 0;
            if (elementoActual.Dni > elementoSiguiente.Dni)
            {
                criterio = -1;
            }
            else if (elementoActual.Dni < elementoSiguiente.Dni)
            {
                criterio = 1;
            }
            return criterio;
        }
    }
}
