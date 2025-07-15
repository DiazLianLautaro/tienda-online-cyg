using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;

namespace Negocio.Articulos
{
    public class ArticuloNegocio
    {
        public List<Articulo> ListarArticulo()
        {
            List<Articulo> lista = new List<Articulo>();
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.setearConsulta("select * from Producto"); //-------------
                datos.ejecutarLectura();

                while (datos.Lector.Read())
                {
                    Articulo articulo = new Articulo();
                    articulo.IdArticulo = (int)datos.Lector["Id"];
                    articulo.Nombre = (string)datos.Lector["Nombre"];
                    articulo.Descripcion = (string)datos.Lector["Descripcion"];
                    articulo.Codigo = (string)datos.Lector["Codigo"];
                    articulo.ImagenProducto = (string)datos.Lector["Imagen"];
                    articulo.Stock = (int)datos.Lector["Stock"];

                    articulo.Marca = new Marca();
                    articulo.Marca.MId = (int)datos.Lector["Id"];
                    articulo.Marca.MDescripcion = (string)datos.Lector["Descripcion"];

                    articulo.Categoria = new Categoria();
                    articulo.Categoria.CId = (int)datos.Lector["Id"];
                    articulo.Categoria.CDescripcion = (string)datos.Lector["Descrpcion"];

                    ArticuloDetalleNegocio listaDetalle = new ArticuloDetalleNegocio();
                    articulo.ArticuloDetalles = listaDetalle.ListarArticuloDetalle();

                    lista.Add(articulo);
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
