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
                datos.setearConsulta("select P.id, Nombre, MarcaId, CategoriaId, M.Descripcion marca, C.Descripcion categoria, P.Descripcion, Codigo, Stock, ImagenProducto, Visible from Producto P, Marca M, Categoria C where M.Id = MarcaId and C.Id = CategoriaId");
                datos.ejecutarLectura();

                while (datos.Lector.Read())
                {
                    Articulo articulo = new()
                    {
                        IdArticulo = (int)datos.Lector["Id"],
                        Nombre = (string)datos.Lector["Nombre"],
                        Descripcion = (string)datos.Lector["Descripcion"],
                        Codigo = (string)datos.Lector["Codigo"],
                        ImagenProducto = (string)datos.Lector["ImagenProducto"],
                        Stock = (int)datos.Lector["Stock"],

                        Marca = new Marca
                        {
                            MId = (int)datos.Lector["MarcaId"],
                            MDescripcion = (string)datos.Lector["marca"]
                        },

                        Categoria = new Categoria
                        {
                            CId = (int)datos.Lector["CategoriaId"],
                            CDescripcion = (string)datos.Lector["categoria"]
                        }
                    };

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
