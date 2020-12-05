using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public abstract class Botella
    {
        public enum Tipo {Plastico, Vidrio }
        protected int capacidadML;
        protected int contenidoML;
        protected string marca;

//        Clase Botella:
//a.Será abstracta.
//b.Tanto la capacidad como el contenido están expresados en mililitros.
//c.Tendrá un único constructor, en el cual se validará que si la capacidad es menor al contenido, el
//contenido será reemplazado por la por la variable de capacidad.Así nunca se podrá tener más
//contenido en una botella que la capacidad que ésta es capaz de guardar.
//d.La propiedad CapacidadLitros retornará la capacidad convertida a litros (dividir por 1000).
//e.Utilizar regla de 3 simple para retornar el valor de la propiedad PorcentajeContenido.
//f.ServirMedida será abstracto.
//g.GenerarInforme utilizará StringBuilder para retornar todos los datos de la botella.
//h.ToString retornará GenerarInforme

        public Botella(string marca, int capacidadML, int contenidoML)
        {
            if (capacidadML < contenidoML)
            {
                contenidoML = capacidadML; //una validacion
                this.marca = marca;
                this.capacidadML = capacidadML;
                this.contenidoML = contenidoML;
            }
            
            
        }
        public int CapacidadLitros
        {
            get { return this.capacidadML / 1000; }
            
        }
        public int Contenido
        {
            get { return this.contenidoML; }
            set
            {
                if (this.capacidadML > 0 && value > this.capacidadML) //si la capacidad es mayor al contenido
                {
                    this.contenidoML = this.capacidadML; // lleno el contenido con la capacidad total
                }
                else
                {
                    this.contenidoML = value; // si es menor que la capacidad guardo el contenido en el atributo
                }
            }
        }
        public int PorcentajeContenido
        {
            get { return this.contenidoML * 100 / this.capacidadML; }
            
        }

        protected virtual string GenerarInforme()
        {
            StringBuilder str = new StringBuilder();
            str.AppendLine($"Capacidad: {this.CapacidadLitros}");
            str.AppendLine($"Porcentaje: {this.Contenido}");
            str.AppendLine($"Porcentaje: {this.marca}");
            str.AppendLine($"Porcentaje: {this.PorcentajeContenido}");
            return str.ToString();
        }
        public abstract int ServirMedida();
        
        public string toString()
        {
            return GenerarInforme();
        }



    }
}
