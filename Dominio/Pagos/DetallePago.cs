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
        public MetodoPago MetodoPagoId { get; set; }
        public bool Anticipado { get; set; }
        public bool EstadoPago { get; set; }
    }
}
