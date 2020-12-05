using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Producto
    {
        private string codigoDeBarra;
        private string marca;
        private float precio;

        public Producto(string marca, string codigo, float precio)
        {
            this.marca = marca;
        }
        public string GetMarca()
        {
            return this.marca;
        }
        public float GetPrecio()
        {
            return this.precio;
        }
        public static string MostrarProducto(Producto p)
        {
            StringBuilder str = new StringBuilder();
            str = str.AppendFormat($"Codigo de barra: {p.codigoDeBarra}\nPrecio: {p.precio}\nCodigo de barra: {p.marca}\n");
            return str.ToString();
            
             
        }
        public static bool operator ==(Producto p ,string marca)
        {
            bool retorno;
            if (p.marca == marca)
            {
                retorno = true;
            }
            else
            {
                retorno = false;
            }
            return retorno;
        }
        public static bool operator ==(Producto p1, Producto p2)
        {
            bool retorno;
            if(p1.marca == p2.marca && p1.codigoDeBarra == p2.codigoDeBarra)
            {
                retorno = true;
            }
            else
            {
                retorno = false;
            }
            return retorno;
        }
        public static bool operator !=(Producto p, string marca)
        {
            return !(p == marca);
            
        }
        public static bool operator !=(Producto p1, Producto p2)
        {
            return !(p1 == p2);
        }
        public static explicit operator string(Producto p)
        {
            string codigoBarras;
            codigoBarras = p.codigoDeBarra;
            return codigoBarras;
        }


    }
}
