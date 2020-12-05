using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consola.C8Indexadores
{
    class Persona
    {
        //Indexadores / tipo de propiedad
        //Se utilizan para indexar una clase

        //Enumerados
        //Es como un atributo que ya viene con opciones
        //los valores por defecto se autoincrementan pero empiezan siempre de 0
        public enum Sexo { Hombre = 10, Mujer, Otro}//tienen que ser distintos valores
        private int dni;
        private string nombre;
        private int legajo;
        private string[] palabras = new string[100];
        private Sexo sexo;
        public Persona(int dni)
        {
            this.Dni = dni; //Set se utiliza en el constructor
            this.nombre = "N/N";
            this.sexo = Sexo.Otro;//enumerado
        }
        public Persona(int dni, string nombre) : this(dni)
        {
            this.nombre = nombre;
        }
        public Persona(string nombre, int legajo)
        {
            this.legajo = legajo;
            this.nombre = nombre;
        }
        
        public int Dni//Propiedad de lectura escritura
        {
            get //parametro que retorna el valor
            {
                if (this.dni == 0)//validaciones
                {
                    this.dni = 999999999;
                }
                return this.dni;
            }
            set//parametro que guardo el valor
            {
                this.dni = value;
            }
        }

        //Ejemplo de indexador
        public string this[int i]
        {
            get
            {
                return this.palabras[i];
            }
            set
            {
                palabras[i] = value;
            }
              
        }





    }
}
