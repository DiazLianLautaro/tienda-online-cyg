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
                datos.setearConsulta("select Id, ProductoId, FechaIngreso, PrecioCompra, CantidadCompra, PrecioVenta from DetalleProducto");
                datos.ejecutarLectura();

                while (datos.Lector.Read())
                {
                    ArticuloDetalle articuloDetalle = new ArticuloDetalle();
                    articuloDetalle.IdDetalleProducto = (int)datos.Lector["Id"];
                    articuloDetalle.IdProducto = (int)datos.Lector["ProductoId"];
                    articuloDetalle.FechaIngreso = (DateOnly)datos.Lector["FechaIngreso"];
                    articuloDetalle.PrecioCompra = (float)datos.Lector["PrecioCompra"];
                    articuloDetalle.CantidadCompra = (int)datos.Lector["CantidadCompra"];
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
    }
}
