using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.Pagos
{
    public class DetallePago
    {
        public int IdDetallePago { get; set; }
        public MetodoPago IdMetodoPago { get; set; }
        public bool Anticipado { get; set; }
        public string? EstadoPago { get; set; }
    }
}
