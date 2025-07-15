using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class ArticuloDetalle
    {
        public int IdDetalleProducto { get; set; }
        public int IdProducto { get; set; }
        public DateOnly FechaIngreso { get; set; }
        public int CantidadCompra { get; set; }
        public float PrecioCompra { get; set; }
        public float PrecioVenta { get; set; }
    }
}
