using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Orden
    {
        public int IdOrden { get; set; }
        public int IdUsuario { get; set; }
        public string CodigoOrden { get; set; }
        public DateTime FechaCompra { get; set; }
        public float ImporteTotal { get; set; }

        //Relacionales
        public ICollection<Turno> turnos { get; set; }
        //public ICollection<Venta> Ventas { get; set; }
        public ICollection<Articulo> Articulos { get; set; }
        public ICollection<DetallePago> detallePagos { get; set; }
    }
}
