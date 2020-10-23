using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Importador
{
    public class Smartphone : Producto
    {
        

        public Smartphone(string nombre, int valorDeCompra,Origen origen)
            :base(nombre,valorDeCompra,origen)
        {
            
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
        //Aplicará un Descuento del 20 % a los productos de origen Nacional.
        public override float ValorDeVenta
        {
            get
            {
                float valor = base.ValorDeVenta;
                if (base.origen == Origen.Nacional)
                {
                    return valor * 20 / 100;
                }
                return valor;
            }
        }
        


    }
}
