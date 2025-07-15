using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.Pagos
{
    public class MetodoPago
    {
        public int IdMetodoPago { get; set; }
        public Metodo Metodo { get; set; }
        public EmpresaPago Empresa { get; set; }
    }
}
