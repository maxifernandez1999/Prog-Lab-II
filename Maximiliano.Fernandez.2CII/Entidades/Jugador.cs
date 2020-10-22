using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    //    Clase Jugador:
    //a.Mostrar retornará los datos de Jugador y su clase base.
    //b.ValidarEstadoFisico deberá validar que el índice de masa corporal se encuentre en el rango de 18.5 y
    //25 inclusive.Para calcularlo, utilizar la siguiente fórmula:
    //IMC = peso / altura^2
    //c.ValidarAptitud: Un jugador será apto para ingresar a un equipo siempre que su edad no supere los
    //40 años y se encuentre en estado físico
    public enum Posicion { Arquero, Defensor, Central, Delantero }
    public class Jugador : Persona
    {
        private float altura;
        protected float peso;
        protected Posicion posicion;

        public Jugador(string apellido, string nombre, int edad, int dni,float peso, float altura, Posicion posicion)
            : base(apellido, nombre, edad, dni)
        {
            this.peso = peso;
            this.altura = altura;
            this.posicion = posicion;
        }

        public Posicion Posicion
        {
            get
            {
                return this.posicion;
            }
        }

        public float Altura
        {
            get
            {
                return this.altura;
            }
        }
        public float Peso
        {
            get
            {
                return this.peso;
            }
        }

        public override string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append($"{base.Mostrar()}");
            sb.Append($"{this.Altura}");
            sb.Append($"{this.Peso}");
            sb.Append($"{this.Posicion}");
            return sb.ToString();
        }
        public override bool ValidarAptitud()
        {
            if(ValidarEstadoFisico() == true && Edad > 15 && Edad < 40)
            {
                return true;

            }
            return false;
        }
        public bool ValidarEstadoFisico()
        {
            float IMC = this.Peso / (this.Altura * this.Altura);
            if (IMC > 18 && IMC < 25)
            {
                return true;
            }
            return false;
        }

    }
}
