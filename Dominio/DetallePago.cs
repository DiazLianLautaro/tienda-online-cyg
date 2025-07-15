using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class DetallePago
    {
        public int IdDetallePago { get; set; }
        public int IdMetodoPago { get; set; } //transferencia, efectivo, debito, credito
        public bool Anticipado { get; set; }
        public string? EstadoPago { get; set; }
    }
}
