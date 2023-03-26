using Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class ActividadNegocio
    {
        public void Agregar(Actividad act)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearProcedimiento("SP_AGREGARACTIVIDAD");
                datos.setearParametro("@IDPROFESOR", act.Profesor.Id);
                datos.setearParametro("@ACTIVIDAD", act.actividad);
                datos.setearParametro("@DIAS", act.Dias);
                datos.setearParametro("@IDMODALIDAD", act.modalidad.Id);
                datos.setearParametro("@FECHAINICIO", act.fechaInicio);
                datos.setearParametro("@FECHAFIN", act.fechaFin);
                datos.setearParametro("@HORARIOINICIO", act.horarioInicio);
                datos.setearParametro("@HORARIOFIN", act.horarioFin);
                datos.setearParametro("@PRECIO", act.precio);
                datos.setearParametro("@IMAGEN", act.Imagen);



                datos.ejectutarAccion();

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

        public List<Actividad> Listar()
        {
            List<Actividad> lista = new List<Actividad>();
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearProcedimiento("SP_LISTAACTIVIDADES");

                datos.ejecutarLectura();
                while (datos.Lector.Read())
                {
                    Actividad act = new Actividad();
                    act.Id = (int)datos.Lector["idActividad"];
                    act.Profesor = new Usuario();
                    act.Profesor.Id = (int)datos.Lector["IdProfesor"];
                    act.Profesor.Nombre = (string)datos.Lector["nombreProfesor"];
                    act.Profesor.Apellido = (string)datos.Lector["apellidoProfesor"];

                    act.modalidad = new Modalidad();
                    act.modalidad.Id = (int)datos.Lector["IdModalidad"];
                    act.Profesor.Nombre = (string)datos.Lector["nombreModalidad"];

                    act.actividad = (string)datos.Lector["Actividad"];
                    act.Dias = (string)datos.Lector["Dias"];
                    act.fechaInicio = (DateTime)datos.Lector["fechaInicio"];
                    act.fechaFin = (DateTime)datos.Lector["fechaFin"];
                    act.horarioInicio = (string)datos.Lector["horarioInicio"];
                    act.horarioFin = (string)datos.Lector["horarioFin"];
                    act.precio = (decimal)datos.Lector["Precio"];
                    act.Imagen = (string)datos.Lector["Imagen"];

                    lista.Add(act);
                }
                return lista;
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
