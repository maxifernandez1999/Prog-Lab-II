using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
    public class Producto
    {
        private int id;
        private string codigo;
        private string nombre;
        private decimal precio;
        private string descripcion;
        public Producto(int id, string codigo, string nombre, decimal precio)
        {
            this.Id = id;
            this.Codigo = codigo;
            this.Nombre = nombre;
            this.Precio = precio;

        }
        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public string Codigo
        {
            get { return codigo; }
            set { codigo = value; }
        }

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public decimal Precio
        {
            get { return precio; }
            set { precio = value; }
        }

        public string Descripcion
        {
            get { return descripcion; }
            set { descripcion = value; }
        }
        

    }
}
