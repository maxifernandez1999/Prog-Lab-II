using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Importador
{
    public class Empresa
    {
//        a.El Límite de Productos se asignará en 3 en el constructor que corresponda según lo visto.
//b.Se podrán agregar tantos productos con el operador + como diga el Límite de Productos.
//Por ejemplo, si el límite es 5 se podrán agregar hasta 5 productos.
//c.El método ToString informará "Productos de la empresa [nombre]" y en cada nueva línea
//toda la información de cada uno de sus productos en la lista.

        private int limiteProductos;
        private string nombre;
        private List<Producto> productos;
        public static Empresa singleton;

        public Empresa(string nombre) : this()
        {
            this.nombre = nombre;
        }

        public static Empresa GetEmpresa(string nombre)
        {
            if (Empresa.singleton is null)
            {
                singleton = new Empresa(nombre);
            }
            
            return Empresa.singleton;
        }
           
        public Empresa(string nombre, int limite) : this(nombre)
        {
            this.limiteProductos = limite;
            this.nombre = nombre;
        }

        private Empresa()
        {
            this.limiteProductos = 3;
            this.productos = new List<Producto>();
        }
        public static Empresa operator +(Empresa empresa,Producto producto)
        {
            if (empresa.productos.Count <= empresa.limiteProductos)
            {
                empresa.productos.Add(producto);
                return empresa;
            }
            return empresa;
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Productos de la empresa {this.nombre}");
            foreach (Producto p in this.productos)
            {
                sb.AppendLine($"Datos\n {p.Etiqueta()}");
            }
            return sb.ToString();
        }
    }
}
