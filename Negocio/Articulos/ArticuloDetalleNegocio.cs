using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;

namespace Negocio.Articulos
{
    internal class ArticuloDetalleNegocio
    {
        public List<ArticuloDetalle> ListarArticuloDetalle()
        {
            List<ArticuloDetalle> lista = new List<ArticuloDetalle>();
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta("");  //------------------------
                datos.ejecutarLectura();

                while (datos.Lector.Read())
                {
                    ArticuloDetalle articuloDetalle = new ArticuloDetalle();
                    articuloDetalle.IdDetalleProducto = (int)datos.Lector["Id"];
                    articuloDetalle.IdProducto = (int)datos.Lector["ProductoId"];
                    articuloDetalle.FechaIngreso = (DateOnly)datos.Lector["FechaIngreso"];
                    articuloDetalle.CantidadCompra = (int)datos.Lector["CantidadCompra"];
                    articuloDetalle.PrecioCompra = (float)datos.Lector["PrecioCompra"];
                    articuloDetalle.PrecioVenta = (float)datos.Lector["PrecioVenta"];

                    lista.Add(articuloDetalle);
                }

                return lista;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        //public int IdDetalleProducto { get; set; }
        //public int IdProducto { get; set; }
        //public DateOnly FechaIngreso { get; set; }
        //public int CantidadCompra { get; set; }
        //public float PrecioCompra { get; set; }
        //public float PrecioVenta { get; set; }
    }
}
