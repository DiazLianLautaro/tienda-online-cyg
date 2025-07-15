using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Servicio
    {
        public int IdServicio { get; set; }
        public string NombreServicio { get; set; }

        [DisplayName("Duración")]
        public int Duracion { get; set; }
        public float Precio { get; set; }
        public bool Disponibilidad { get; set; }
        public bool Visible { get; set; }

    }
}
