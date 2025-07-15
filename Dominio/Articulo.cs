using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Articulo
    {
        public int IdArticulo { get; set; }
        public string Nombre { get; set; }
        public Marca Marca { get; set; }
        public Categoria Categoria { get; set; }

        [DisplayName("Descripción")]
        public string? Descripcion { get; set; }
        
        [DisplayName("Código")]
        public string Codigo { get; set; }
        
        public string? ImagenProducto { get; set; }
        public int Stock { get; set; }
        public bool Visible { get; set; }

        public ICollection<ArticuloDetalle>? ArticuloDetalles { get; set; }
    }
}
