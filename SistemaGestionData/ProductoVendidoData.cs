       using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using SistemaGestionEntities;

namespace SistemaGestionData
{

    public class ProductoVendidoData
    {
        public static List<ProductoVendido> GetProductoVendidos()
        {
            string connectionString = @"Server=localhost\SQLEXPRESS01;Database=Base_Prueba3;Trusted_Connection=True;";

            List<ProductoVendido> listProductoVendidoData = new List<ProductoVendido>();

            string query = "SELECT * FROM ProductoVendido";
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        using (SqlDataReader dataReader = command.ExecuteReader())
                        {
                            if (dataReader.HasRows)
                            {
                                while (dataReader.Read())
                                {
                                    var productoVendido = new ProductoVendido();

                                    productoVendido.Id = Convert.ToInt32(dataReader["Id"]);
                                    productoVendido.idProducto = Convert.ToInt32(dataReader["IdProducto"]);
                                    productoVendido.Stock = Convert.ToInt32(dataReader["Stock"]);
                                    productoVendido.idVenta = Convert.ToInt32(dataReader["idVenta"]);


                                    listProductoVendidoData.Add(productoVendido);

                                }

                            }
                            return listProductoVendidoData;
                        }
                    }
                }

            }
            catch (Exception)
            {
                return listProductoVendidoData;
            }

        }

        
        public static ProductoVendido GetProductoVendido(int id)
        {
            string connectionString = @"Server=localhost\SQLEXPRESS01;Database=Base_Prueba3;Trusted_Connection=True;";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM Productos Vendido WHERE Id = @id";

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("id", id);
                connection.Open();

                SqlDataReader dataReader = command.ExecuteReader();

                if (dataReader.Read())
                {
                    var productoVendido = new ProductoVendido();
                    productoVendido.Id = Convert.ToInt32(dataReader["Id"]);
                    productoVendido.idProducto = Convert.ToInt32(dataReader["ID Producto"]);
                    productoVendido.Stock = Convert.ToInt32(dataReader["Stock"]);
                    productoVendido.idVenta = Convert.ToInt32(dataReader["id Venta"]);

                    return productoVendido;
                }

                throw new Exception("ID NO ENCONTRADO");
            }
        }
        public static bool DeleteProductoVendido(int id)
        {
            string connectionString = @"Server=localhost\SQLEXPRESS01;Database=Base_Prueba3;Trusted_Connection=True;";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "DELETE FROM Productos Vendido WHERE Id=@id";
                SqlCommand command = new SqlCommand(query, connection);
                connection.Open();
                command.Parameters.AddWithValue("id", id);

                return command.ExecuteNonQuery() > 0;
            }
        }

        public static bool CreateProductoVendido(ProductoVendido productoVendido)
        {
            string connectionString = @"Server=localhost\SQLEXPRESS01;Database=Base_Prueba2;Trusted_Connection=True;";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO Productos Vendido (Descripcion,Costo,PrecioVenta,Stock,IdUsuario) values(@descripcion,@costo,@precioVenta,@stock,@idUsuario)";
                SqlCommand command = new SqlCommand(query, connection);
                /*command.Parameters.AddWithValue("descripcion", producto.Descripcion);*/
                command.Parameters.AddWithValue("Id", productoVendido.Id);
                command.Parameters.AddWithValue("id Producto", productoVendido.idProducto);
                command.Parameters.AddWithValue("stock", productoVendido.Stock);
                command.Parameters.AddWithValue("id Venta", productoVendido.idVenta);

                return command.ExecuteNonQuery() > 0;

            }
        }

        public static bool EditProductoVendido(ProductoVendido productoVendido)
        {
            string connectionString = @"Server=localhost\SQLEXPRESS01;Database=Base_Prueba2Trusted_Connection=True;";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "UPDATE Productos SET Descripcion = @descripcion, Costo = @costo, PrecioVenta = @precioVenta, Stock = @stock, IdUsuario = @idUsuario WHERE  Id = @id";

                SqlCommand command = new SqlCommand(query, connection);
                /*command.Parameters.AddWithValue("descripcion", producto.Descripcion);*/
                command.Parameters.AddWithValue("Id", productoVendido.Id);
                command.Parameters.AddWithValue("Id Producto", productoVendido.idProducto);
                command.Parameters.AddWithValue("stock", productoVendido.Stock);
                command.Parameters.AddWithValue("id Venta", productoVendido.idVenta);

                connection.Open();

                return command.ExecuteNonQuery() > 0;

            }
        }
    }
}

