using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Usuario
    {
        public int UsuarioId { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Email { get; set; }
        public string Clave { get; set; }

        [DisplayName("Teléfono")] //Apodo en columna (por la tilde).
        public string Telefono { get; set; }

        [DisplayName("Dirección")]
        public string Direccion { get; set; }

        public bool Admin { get; set; }
        public string ImagenUsuario { get; set; }
        public ICollection<Orden> IOrden { get; set; }
    }
}
