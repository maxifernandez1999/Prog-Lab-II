using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Logic;
namespace Logic
{
    public class Comic : Producto
    {
        private int cantPaginas;

        public Comic(string titulo, double precio,int cantPaginas)
            :base(titulo,precio)
        {
            this.cantPaginas = cantPaginas;
        }

        public override string MostrarDatos()
        {
            return $"Es un comic, De titulo {this.Titulo} y tiene {this.cantPaginas}";
        }

        
    }
}
