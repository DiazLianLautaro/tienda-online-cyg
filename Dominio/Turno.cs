using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Turno
    {
        public int IdTurno { get; set; }
        public DateOnly Fecha { get; set; }
        public DateTime Hora { get; set; }
        public ICollection<Servicio> Servicios { get; set; }
    }
}
