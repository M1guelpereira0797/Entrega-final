using SistemaGestionEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemaGestionData;

namespace SistemaGestionBussiness
{
    public class VentaBussiness
    {
        public static List<Venta> GetVentas()
        {
            return VentaData.GetVentas();

        }
        public static Venta GetVenta(int id)
        {
            return VentaData.GetVenta(id);
        }

        public static bool AltaVenta(Venta ventas )
        {
            return VentaData.CreateVenta(ventas);
        }
        public static bool BorrarProducto(int Id)
        {
            return VentaData.DeleteVenta(Id);
        }
        public static bool ModificarProducto(Venta ventas)
        {
            return VentaData.EditVenta(ventas);
        }

    }
}