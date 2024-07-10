using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Runtime.CompilerServices;
using SistemaGestionEntities;

namespace SistemaGestionData
{

    public class VentaData
    {
        public static List<Venta> GetVentas()
        {
            string connectionString = @"Server=localhost\SQLEXPRESS01;Database=Base_Prueba3;Trusted_Connection=True;";

            List<Venta> listVentaData = new List<Venta>();

            string query = "SELECT * FROM Venta";
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
                                    var venta = new Venta();

                                    venta.Id = Convert.ToInt32(dataReader["Id"]);
                                    venta.Comentario = dataReader["Comentarios"].ToString();
                                    venta.idUsuario = dataReader["idUsuaurio"].ToString();


                                    listVentaData.Add(venta);

                                }

                            }
                            return listVentaData;
                        }
                    }
                }

            }
            catch (Exception)
            {
                return listVentaData;
            }

        }

        public static Venta GetVenta(int id)
        {
            string connectionString = @"Server=localhost\SQLEXPRESS01;Database=Base_Prueba3;Trusted_Connection=True;";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM Venta WHERE Id = @id";

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("id", id);
                connection.Open();

                SqlDataReader dataReader = command.ExecuteReader();

                if (dataReader.Read())
                {
                    var venta = new Venta();
                    venta.Id = Convert.ToInt32(dataReader["Id"]);
                    venta.Comentario = dataReader["Comentarios"].ToString();
                    venta.idUsuario = dataReader["idUsuaurio"].ToString();


                    return venta;
                }

                throw new Exception("ID NO ENCONTRADO");
            }
        }
        public static bool DeleteVenta(int id)
        {
            string connectionString = @"Server=localhost\SQLEXPRESS01;Database=Base_Prueba3;Trusted_Connection=True;";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "DELETE FROM Venta WHERE Id=@id";
                SqlCommand command = new SqlCommand(query, connection);
                connection.Open();
                command.Parameters.AddWithValue("id", id);

                return command.ExecuteNonQuery() > 0;
            }
        }

        public static bool CreateVenta(Venta ventas)
        {
            string connectionString = @"Server=localhost\SQLEXPRESS01;Database=Base_Prueba3;Trusted_Connection=True;";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO Ventas (Descripcion,Costo,PrecioVenta,Stock,IdUsuario) values(@descripcion,@costo,@precioVenta,@stock,@idUsuario)";
                SqlCommand command = new SqlCommand(query, connection);
                /*command.Parameters.AddWithValue("descripcion", producto.Descripcion);*/
                command.Parameters.AddWithValue("Id", ventas.    Id);
                command.Parameters.AddWithValue("Comentarios",ventas.Comentario);
                command.Parameters.AddWithValue("Id Usuario", ventas.idUsuario);
                

                return command.ExecuteNonQuery() > 0;

            }
        }

        public static bool EditVenta(Venta ventas)
        {
            string connectionString = @"Server=localhost\SQLEXPRESS01;Database=Base_Prueba3;Trusted_Connection=True;";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "UPDATE Productos SET Descripcion = @descripcion, Costo = @costo, PrecioVenta = @precioVenta, Stock = @stock, IdUsuario = @idUsuario WHERE  Id = @id";

                SqlCommand command = new SqlCommand(query, connection);
                /*command.Parameters.AddWithValue("descripcion", producto.Descripcion);*/
                command.Parameters.AddWithValue("Id", ventas.Id);
                command.Parameters.AddWithValue("Comentarios", ventas.Comentario);
                command.Parameters.AddWithValue("Id Usuario", ventas.idUsuario);

                connection.Open();

                return command.ExecuteNonQuery() > 0;

            }
        }
    }
}