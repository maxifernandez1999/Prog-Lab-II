using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
    public class Factura<TProducto>//,U////sea o herede de producto o tengo un constructor por defecto
        where TProducto : Producto
        //where U : class
        //restricciones

    {
        public string GenerarFactura<TProducto>(TProducto producto, int unidades)  where TProducto : Producto
        {
            double precioFinal = producto.Precio + producto.Precio * 0.21;
            return $"Compraste {unidades} unidades de {producto.MostrarDatos()}. Precio final : {precioFinal}";
        }
    }
}
