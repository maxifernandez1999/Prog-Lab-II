using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Logic;
/// COMO CONECTAR A LA BASE DE DATOS : .\SQLEXPRESS
/// DataBase : Crear nueva DataBase : ProductosDB
/// 
namespace View
{
    class Program
    {
        static void Main(string[] args)
        {

            try
            {
                Producto prod1 = new Producto(4, "hola", "xd", 5);
                ProductosDAO productosDAO = new ProductosDAO();
                //productosDAO.InsertarProducto(prod1);
                //productosDAO.ModificarProducto(prod1);
                //productosDAO.EliminarProducto(1);
                //List<Producto> productos = productosDAO.ListaProductos();
                //foreach (Producto p in productos)
                //{
                //    Console.WriteLine($"Producto id: {p.Id} de nombre {p.Nombre}");
                //}
                
                Producto prod2 = productosDAO.ListaProductosPorId(4);
                Console.WriteLine($"{prod2.Id},{prod2.Codigo},{prod2.Nombre},{prod2.Precio}"); 
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.ReadKey();
            
        }
    }
}
