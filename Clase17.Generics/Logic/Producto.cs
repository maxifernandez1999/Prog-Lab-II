using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Logic;
namespace Logic
{
    public abstract class Producto<U>
    {
        private string titulo;
        private double precio;

        protected Producto(string titulo, double precio)
        {
            this.titulo = titulo;
            this.precio = precio;
        }

        public virtual string Titulo
        {
            get
            {
                return this.titulo;
            }
        }
        public virtual double Precio
        {
            get
            {
                return this.precio;
            }
        }
        public abstract string MostrarDatos();

        public string MostrarDatos1()
        {
            throw new NotImplementedException();
        }

        public string MostrarProductos()
        {
            throw new NotImplementedException();
        }
    }
}
