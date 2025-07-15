using Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class UsuarioNegocio
    {
        public int Registrar(Usuario usuario)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta("insert into Usuario (id, nombre, apellido, email, clave, telefono, direccion, isadmin, imagenusuario) values (@id, @nombre, @apellido, @email, @clave, @telefono, @direccion, @isadmin, @imagenusuario)");
                datos.setearParametro("@id", usuario.UsuarioId);
                datos.setearParametro("@nombre", usuario.Nombre);
                datos.setearParametro("@apellido", usuario.Apellido);
                datos.setearParametro("@email", usuario.Email);
                datos.setearParametro("@clave", usuario.Clave);
                datos.setearParametro("@telefono", usuario.Telefono);
                datos.setearParametro("@direccion", usuario.Direccion);
                datos.setearParametro("@isadmin", usuario.Admin);
                datos.setearParametro("@imagenusuario", usuario.ImagenUsuario);
                
                return datos.ejecutarAccionScalar();
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                datos.cerrarConexion();
            }
        }

        public bool Ingresar(Usuario usuario)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta("select Id, Nombre, Apellido, Email, Clave, Telefono, Direccion, IsAdmin from Usuario where email = @email AND clave = @clave");
                datos.setearParametro("@email", usuario.Email);
                datos.setearParametro("@clave", usuario.Clave);
                datos.ejecutarLectura();

                if(datos.Lector.Read())
                {

                    return true;
                }
                return false;

            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                datos.cerrarConexion();
            }
        }

    }
}
