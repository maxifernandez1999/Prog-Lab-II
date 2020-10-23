using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParcialConcencionaria
{
    public abstract class Vehiculo
    {
        public enum EPais { Italia,Alemania,Francia}
        protected Fabricante fabricante;
        protected static Random generadorDeVelocidades;
        protected string modelo;
        protected float precio;
        protected int velocidadMaxima;
        protected EPais pais;


        static Vehiculo()
        {

        }

        protected Vehiculo(string modelo, float precio,Fabricante fabri)
        {
            this.modelo = modelo;
            this.precio = precio;
            this.fabricante = fabri;
        }
        protected Vehiculo(string modelo,EPais pais, float precio, Fabricante fabri) : this(modelo,precio,fabri)
        {
            this.modelo = modelo;
            this.precio = precio;
            this.fabricante = fabri;
            this.pais = pais;
        }


        public int VelocidadMaxima
        {
            get
            {
                Vehiculo.generadorDeVelocidades = new Random();
                this.velocidadMaxima = generadorDeVelocidades.Next(100, 280);
                return this.velocidadMaxima;
            }
        }

        public static explicit operator string(Vehiculo v)
        {
            StringBuilder sb = new StringBuilder();
            
            sb.AppendLine($"Fabricante: {v.fabricante}");
            sb.AppendLine($"Modelo: {v.modelo}");
            sb.AppendLine($"Precio: {v.precio}");
            sb.AppendLine($"Valocidad maxima: {v.VelocidadMaxima}");
            return sb.ToString();
        }
        public static bool operator ==(Vehiculo a,Vehiculo b)
        {
            if (a.modelo == b.modelo && a.fabricante == b.fabricante)
            {
                return true;
            }
            return false;
        }
        public static bool operator !=(Vehiculo a, Vehiculo b)
        {
            return !(a == b);
        }
        public virtual string Mostrar(Vehiculo v)
        {

            return (string)v;
        }


    }
}
