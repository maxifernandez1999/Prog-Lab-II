using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodigoParcial2
{
    public class ProductosDAO
    {
        private SqlConnection sqlConnection;
        private string connectionString;
        public ProductosDAO()
        {
            this.connectionString = "Server=.\\SQLEXPRESS;Database=ProductosDB;Trusted_Connection=True;"; //direccion para la conexion a BD
            this.sqlConnection = new SqlConnection(connectionString);
        }

        public void InsertarProducto(Producto producto)
        {
            try
            {

                string command = $"INSERT INTO Productos(nombre, precio, codigo)" +
                $"VALUES(@nombre, @precio, @codigo)"; // las arrobas se remplazan por los valores de los atributos

                SqlCommand sqlCommand = new SqlCommand(command, this.sqlConnection); //conexion
                sqlCommand.Parameters.AddWithValue("nombre", producto.Nombre);
                sqlCommand.Parameters.AddWithValue("precio", producto.Precio);
                sqlCommand.Parameters.AddWithValue("codigo", producto.Codigo);
                this.sqlConnection.Open(); //Abre la conexion a la BD
                sqlCommand.ExecuteNonQuery();//despues de abrir la conexion
            }
            finally
            {
                if (sqlConnection != null && this.sqlConnection.State == System.Data.ConnectionState.Open)
                {
                    this.sqlConnection.Close();
                }


            }
        }
        public void ModificarProducto(Producto producto)
        {
            try
            {

                string command = $"UPDATE Productos " +
                    $" SET nombre = @nombre, precio = @precio, codigo = @codigo" +
                    " WHERE id=@id;"; //reemplazo todos los valores de un determinado id;

                SqlCommand sqlCommand = new SqlCommand(command, this.sqlConnection);
                sqlCommand.Parameters.AddWithValue("nombre", producto.Nombre);
                sqlCommand.Parameters.AddWithValue("precio", producto.Precio);
                sqlCommand.Parameters.AddWithValue("codigo", producto.Codigo);
                sqlCommand.Parameters.AddWithValue("id", producto.Id);
                this.sqlConnection.Open();
                sqlCommand.ExecuteNonQuery();
            }
            finally
            {
                if (sqlConnection != null && this.sqlConnection.State == System.Data.ConnectionState.Open)
                {
                    this.sqlConnection.Close();
                }


            }

        }

        public void EliminarProducto(int id)
        {
            try
            {

                string command = $"DELETE FROM Productos " +
                    " WHERE id=@id ;";


                SqlCommand sqlCommand = new SqlCommand(command, this.sqlConnection);

                sqlCommand.Parameters.AddWithValue("id", id);
                this.sqlConnection.Open();
                sqlCommand.ExecuteNonQuery();
            }
            finally
            {
                if (sqlConnection != null && this.sqlConnection.State == System.Data.ConnectionState.Open)
                {
                    this.sqlConnection.Close();
                }


            }

        }
        public List<Producto> ListaProductos()
        {
            using (SqlConnection sqlConnection = new SqlConnection(this.connectionString))
            {
                string command = "SELECT * FROM Productos";
                SqlCommand sqlCommand = new SqlCommand(command, sqlConnection);
                sqlConnection.Open();//verificar el this
                SqlDataReader reader = sqlCommand.ExecuteReader();

                List<Producto> productos = new List<Producto>();

                while (reader.Read())
                {
                    int id = (int)reader["id"];
                    string nombre = (string)reader["nombre"];
                    string codigo = (string)reader["codigo"];
                    //if (reader["descripcion"] != DBNull.Value)
                    //{
                    // descripcion = (string)reader["descripcion"];
                    //}
                    decimal precio = (decimal)reader["precio"]; // decimal
                    Producto producto = new Producto(id, codigo, nombre, precio);
                    productos.Add(producto);
                }
                return productos;
            }
        }

        public Producto ListaProductosPorId(int id)
        {
            using (SqlConnection sqlConnection = new SqlConnection(this.connectionString))
            {
                string command = $"SELECT * FROM Productos " + $" WHERE id=@id";
                SqlCommand sqlCommand = new SqlCommand(command, sqlConnection);
                sqlCommand.Parameters.AddWithValue("id", id);
                sqlConnection.Open();//verificar el this
                SqlDataReader reader = sqlCommand.ExecuteReader();
                reader.Read();
                string nombre = (string)reader["nombre"];
                string codigo = (string)reader["codigo"];
                decimal precio = (decimal)reader["precio"]; // decimal
                Producto producto = new Producto(id, codigo, nombre, precio);

                return producto;
            }
        }
    }
}
