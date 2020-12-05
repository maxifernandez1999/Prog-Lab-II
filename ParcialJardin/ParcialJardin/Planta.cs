using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParcialJardin
{
    public abstract class Planta
    {
        private string nombre;
        private int tamanio;

        public Planta(string nombre, int tamanio)
        {
            this.nombre = nombre;
            this.tamanio = tamanio;
        }
        protected abstract bool TieneFlores { get; }
        protected abstract  bool TieneFruto { get; }
        

        public int Tamanio
        {
            get
            {
                return this.tamanio;
            }
        }
        
        public virtual string ResumenDeDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat($"Nombre: {this.nombre}\nTamanio: {this.tamanio}\n");
            if(this.TieneFruto == true && this.TieneFlores == true)
            {
                sb.AppendFormat($"Tiene frutos: SI\nTienen flores: SI");
            }
            else if (this.TieneFruto == false && this.TieneFlores == true)
            {
                sb.AppendFormat($"Tiene frutos: NO\nTienen flores: SI");
            }
            else
            {
                sb.AppendFormat($"Tiene frutos: NO\nTienen flores: NO");
            }
            
            return sb.ToString();
        }
    }
}
