using Dominio.Pagos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class DetallePagoNegocio
    {
        public List<DetallePago> DetallePago()
        {
            List<DetallePago> lista = new List<DetallePago>();
            AccesoDatos datos = new();

            datos.setearConsulta("select D.Id, Anticipado, EstadoPago, MP.Id as MPID, M.Id as MID, M.Nombre as Tipo, E.Id as EID, E.Nombre as Empresa from DetallePago D, MetodoPago MP, Metodo M, EmpresaPago E");
            datos.ejecutarLectura();

            while(datos.Lector.Read())
            {
                DetallePago pagos = new DetallePago
                {
                    IdDetallePago = (int)datos.Lector["Id"],
                    Anticipado = (bool)datos.Lector["Anticipado"],
                    EstadoPago = (bool)datos.Lector["EstadoPago"],

                    MetodoPagoId = new MetodoPago
                    {
                        IdMetodoPago = (int)datos.Lector["MPID"],

                        Metodo = new Metodo
                        {
                            IdMetodo = (int)datos.Lector["MID"],
                            Descripcion = (string)datos.Lector["Tipo"]
                        },

                        Empresa = new EmpresaPago
                        {
                            IdEmpresaPago = (int)datos.Lector["EID"],
                            Descripcion = (string)datos.Lector["Empresa"]
                        }
                    },
                };

                lista.Add(pagos);

            }

            return lista;        
        }       
    }
}
