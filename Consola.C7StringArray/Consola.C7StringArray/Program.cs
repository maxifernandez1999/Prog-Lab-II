using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Consola.C7StringArray
{
    class Program
    {
        //STRINGS Y ARRAYS
        static void Main(string[] args)
        {
            //STRINGS
            string a = "Cadena";
            string b = "No Cadena";
            string.Compare(a, b);//compara dos strings y devuelve 0, -1, 1
            a.CompareTo(b);
            //todos en la ppt

            //ARRAYS 

            //no se puede usar foreach para cargar datos en el array
            Persona[] personas = new Persona[2];// { new Persona(1), new Persona(2) }; //array de 2 elementos
            //personas[0] = new Persona(1); // se cargan con un constructor en este caso
            for (int i = 0; i < personas.Length; i++)
            {
                Persona p = personas[i]; // creo un persona y le agrego el valor
                p.ToString();
            }
            foreach (Persona p in personas)//Persona es el tipo de dato
            {
                Console.WriteLine(p);
                p.ToString();
            }
        }
    }
}
