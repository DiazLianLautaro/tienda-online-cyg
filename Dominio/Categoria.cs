using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Categoria
    {
        public int CId { get; set; }

        [DisplayName("Descripción")]
        public string CDescripcion { get; set; }

        public override string ToString()
        {
            return CDescripcion;
        }
    }
}
