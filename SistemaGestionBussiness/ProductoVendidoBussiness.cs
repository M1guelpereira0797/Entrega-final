using SistemaGestionEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemaGestionData;

namespace SistemaGestionBussiness
{
    public class ProductoVendidoBussiness
    {
        public static List<ProductoVendido> GetUsuarios()
        {
            return ProductoVendidoData.GetUsuarios();

        }
        public static ProductoVendido GetUsuariosById(int id)
        {
            return ProductoVendidoData.GetUsuarios(id);
        }
        public static bool AltaProductoVendido(ProductoVendido productoVendido)
        {
            return ProductoVendidoData.CreateProductoVendido(productoVendido);
        }
        public static bool BorrarProducto(int Id)
        {
            return ProductoVendidoData.DeleteProductoVendido(Id);
        }
        public static bool ModificarProducto(ProductoVendido productoVendido)
        {
            return ProductoVendidoData.EditProductoVendido(productoVendido);
        }

    }
}