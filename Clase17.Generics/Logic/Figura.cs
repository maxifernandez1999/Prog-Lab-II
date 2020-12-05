using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Logic;
namespace Logic
{
    public class Figura : Producto
    {
        private float altura;

        protected Figura(string titulo, double precio,float altura)
            :base(titulo,precio)
        {
            this.altura = altura;
        }

        public override string MostrarDatos()
        {
            return $"Es una figura, De titulo {this.Titulo} y mide {this.altura}";
        }
    }
}
