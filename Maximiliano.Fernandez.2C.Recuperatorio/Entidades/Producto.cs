using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Importador
{
    public abstract class Producto
    {
//        Producto:
//a.Los productos tendrán un Porcentaje de Impuesto de Importación del 35% para
//Importados y 0% para Nacionales.


        public enum Origen { Nacional,Importado}
        private string nombre;
        protected Origen origen;
        private int valorDeCompra;

        protected Producto(string nombre, int valorDeCompra, Origen origen)
        {
            this.nombre = nombre;
            this.origen = origen;
            this.valorDeCompra = valorDeCompra;
        }

        public abstract int PorcentajeGanancia { get; }
         
        
        public int PorcentajeImpuestoImportacion
        {
            get
            {
                if (origen == Origen.Importado)
                {
                    return valorDeCompra * 35 / 100;
                }
                else if (origen == Origen.Nacional)
                {
                    return valorDeCompra * 0 / 100;
                }
                return valorDeCompra;
            }
        }
        public abstract int PorcentajeImpuestoInterno { get; }

        //b.El cálculo del Valor de Venta será:
        //i.Al Valor de Compra se le sumará lo correspondiente al Porcentaje de Impuesto
        //de Importación.
        //ii.Al resultado del punto anterior, se le sumará lo correspondiente al Porcentaje de
        //Impuesto Interno.
        //iii.Al resultado del punto anterior, se le sumará lo correspondiente al Porcentaje de
        //Ganancia.
        public virtual float ValorDeVenta
        {
            get
            {
                float valorDeVenta = valorDeCompra + PorcentajeImpuestoImportacion;
                float impuestoInterno = valorDeVenta + PorcentajeImpuestoInterno;
                float total = impuestoInterno + PorcentajeGanancia;
                return total;
            }
        }
        //c.La Etiqueta retornará el texto: "Producto [nombre] comprado a [valorDeCompra] como
        //[origen]}"
        public virtual string Etiqueta()
        {
            
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Producto {this.nombre} comprado a {this.valorDeCompra} como {this.origen}");
            return sb.ToString();

        }
    }
}
