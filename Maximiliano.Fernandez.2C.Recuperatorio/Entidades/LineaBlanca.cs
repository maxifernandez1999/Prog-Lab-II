using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Importador
{

//    LineaBlanca:
//a.Si Aplica Descuento, la propiedad de Descuento retornará un 10%. Si NO aplica
//descuento, retornará 0.
//b.Valor de Venta aplicará el descuento, según corresponda.
//c.La Etiqueta agregará la información(aplica descuento: [SI o NO, según corresponda])
    public class LineaBlanca : Producto
    {
        private bool aplicaDescuento;

        public LineaBlanca(string nombre, int valorDeCompra,Origen origen)
            :base(nombre,valorDeCompra,origen)
        {
            
        }
        public LineaBlanca(string nombre, int valorDeCompra, Origen origen,bool aplicaDescuento)
            : this(nombre, valorDeCompra, origen)
        {
            this.aplicaDescuento = aplicaDescuento;
        }
        public int Descuento
        {
            get
            {
                int descuento;
                if (aplicaDescuento == true)
                {
                    descuento = 10;

                }
                else
                {
                    descuento = 0;


                }
                return descuento;

            }
        }
        public override int PorcentajeGanancia
        {
            get
            {
                return (int)base.ValorDeVenta * 10 / 100;
            }
        }
        public override int PorcentajeImpuestoInterno
        {
            get
            {
                return (int)base.ValorDeVenta * 21 / 100;
            }
        }
        public override float ValorDeVenta
        {
            get
            {
                int descuento;
                if (aplicaDescuento == true)
                {
                    descuento = (int)ValorDeVenta * Descuento / 100;

                }
                else
                {
                    descuento = (int)ValorDeVenta * Descuento / 100;

                }
                return descuento;

            }
        }
        public override string Etiqueta()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"{base.Etiqueta()}");
            if (aplicaDescuento == true)
            {
                sb.AppendLine($"Aplica descuento: SI");
            }
            else
            {
                sb.AppendLine($"Aplica descuento: NO");

            }

            return sb.ToString();
        }


    }
}
