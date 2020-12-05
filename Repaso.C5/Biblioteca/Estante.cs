using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    class Estante
    {
        private Producto[] productos;
        private int ubicacionEstante;
        
        private Estante(int capacidad)
        {
            productos = new Producto[capacidad];
        }
        public Estante(int capacidad, int ubicacion) : this(capacidad)
        {
            this.ubicacionEstante = ubicacion;
            
        }
        public Producto[] GetProducto()
        {
            return this.productos;
        }

        public static string MostrarEstante(Estante e)
        {
            StringBuilder str = new StringBuilder();
            Producto[] productos = e.GetProducto();
            str.AppendFormat("En el estante {0} hay {1} con lo siguiente: ", e.ubicacionEstante, e.productos.Length);
            foreach (Producto p in productos)
            {
                Producto.MostrarProducto(p);
            }
            return str.ToString();
            
        }
        public static bool operator ==(Estante e, Producto p)
        {
            bool retorno = false;
            Producto[] productos = e.GetProducto();
            foreach (Producto pe in productos)
            {
                if(p == pe)
                {
                    retorno = true;
                }


            }
            return retorno;
        }
        public static bool operator =(Estante e, Producto p)
        {
            if(!(e== p))
            {
                for (int i = 0; i < e.productos.Length; i++)
                {
                    object.ReferenceEquals(e.productos[i], null);
                    if(e.productos[i] == null) // esta mal
                    {

                    }
                }
            }
        }
        
    }
}
