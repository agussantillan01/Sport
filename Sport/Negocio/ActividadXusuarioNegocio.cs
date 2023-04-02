using Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Negocio
{
    public class ActividadXusuarioNegocio
    {
        public void Agregar(ActividadXusuario actXus)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearProcedimiento("SP_SOLICITUDINSCRIPCION");
                datos.setearParametro("@ID", actXus.Usuario.Id);
                datos.setearParametro("@IDACTIVIDAD", actXus.Actividad.Id);

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


        public List<ActividadXusuario> listarMisInscripciones(int idUsuario)
        {
            List<ActividadXusuario> lista = new List<ActividadXusuario>();
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearProcedimiento("SP_LISTAMISINSCRIPCIONES");
                datos.setearParametro("@IDUSUARIO", idUsuario);
                datos.ejecutarLectura();
                while (datos.Lector.Read())
                {
                    ActividadXusuario actUsuario = new ActividadXusuario();
                    actUsuario.Usuario = new Usuario();
                    actUsuario.Usuario.Id = (int)datos.Lector["IDUSUARIO"];
                    actUsuario.Usuario.Nombre = (string)datos.Lector["NOMBREUSUARIO"];
                    actUsuario.Usuario.Apellido = (string)datos.Lector["APELLIDOUSUARIO"];
                    
                    if(!(datos.Lector["DNIUSUARIO"] is DBNull))
                        actUsuario.Usuario.DNI = (int)datos.Lector["DNIUSUARIO"];

                    actUsuario.Usuario.Email = (string)datos.Lector["EMAILUSUARIO"];
                    actUsuario.Usuario.Password = (string)datos.Lector["USUARIOCONTRASEÑA"];

                    if (!(datos.Lector["USUARIOFECHANACIMIENTO"] is DBNull))
                        actUsuario.Usuario.FechaNacimiento = (DateTime)datos.Lector["USUARIOFECHANACIMIENTO"];


                    actUsuario.Actividad = new Actividad();
                    actUsuario.Actividad.Id = (int)datos.Lector["IDACTIVIDAD"];
                    actUsuario.Actividad.actividad = (string)datos.Lector["NOMBREACTIVIDAD"];
                    actUsuario.Actividad.Dias = (string)datos.Lector["DIASACTIVIDADES"];
                    actUsuario.Actividad.fechaInicio = (DateTime)datos.Lector["FECHAINICIO"];
                    actUsuario.Actividad.fechaFin = (DateTime)datos.Lector["FECHAFIN"];
                    actUsuario.Actividad.horarioInicio = (string)datos.Lector["HORARIOINICIO"];
                    actUsuario.Actividad.horarioFin = (string)datos.Lector["HORARIOFIN"];
                    actUsuario.Actividad.precio = (decimal)datos.Lector["PRECIO"];
                    if (!(datos.Lector["IMAGEN"] is DBNull))
                        actUsuario.Actividad.Imagen = (string)datos.Lector["IMAGEN"];

                    actUsuario.Actividad.modalidad = new Modalidad();
                    actUsuario.Actividad.modalidad.Id = (int)datos.Lector["IDMODALIDAD"];
                    actUsuario.Actividad.modalidad.modalidad = (string)datos.Lector["NOMBREMODALIDAD"];

                    lista.Add(actUsuario);
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




        public List<ActividadXusuario> listarMisSolicitudesPendientes(int idUsuario)
        {
            List<ActividadXusuario> lista = new List<ActividadXusuario>();
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearProcedimiento("SP_LISTAMISPENDIENTES");
                datos.setearParametro("@IDUSUARIO", idUsuario);
                datos.ejecutarLectura();
                while (datos.Lector.Read())
                {
                    ActividadXusuario actUsuario = new ActividadXusuario();
                    actUsuario.Usuario = new Usuario();
                    actUsuario.Usuario.Id = (int)datos.Lector["IDUSUARIO"];
                    actUsuario.Usuario.Nombre = (string)datos.Lector["NOMBREUSUARIO"];
                    actUsuario.Usuario.Apellido = (string)datos.Lector["APELLIDOUSUARIO"];

                    if (!(datos.Lector["DNIUSUARIO"] is DBNull))
                        actUsuario.Usuario.DNI = (int)datos.Lector["DNIUSUARIO"];

                    actUsuario.Usuario.Email = (string)datos.Lector["EMAILUSUARIO"];
                    actUsuario.Usuario.Password = (string)datos.Lector["USUARIOCONTRASEÑA"];

                    if (!(datos.Lector["USUARIOFECHANACIMIENTO"] is DBNull))
                        actUsuario.Usuario.FechaNacimiento = (DateTime)datos.Lector["USUARIOFECHANACIMIENTO"];


                    actUsuario.Actividad = new Actividad();
                    actUsuario.Actividad.Id = (int)datos.Lector["IDACTIVIDAD"];
                    actUsuario.Actividad.actividad = (string)datos.Lector["NOMBREACTIVIDAD"];
                    actUsuario.Actividad.Dias = (string)datos.Lector["DIASACTIVIDADES"];
                    actUsuario.Actividad.fechaInicio = (DateTime)datos.Lector["FECHAINICIO"];
                    actUsuario.Actividad.fechaFin = (DateTime)datos.Lector["FECHAFIN"];
                    actUsuario.Actividad.horarioInicio = (string)datos.Lector["HORARIOINICIO"];
                    actUsuario.Actividad.horarioFin = (string)datos.Lector["HORARIOFIN"];
                    actUsuario.Actividad.precio = (decimal)datos.Lector["PRECIO"];
                    if (!(datos.Lector["IMAGEN"] is DBNull))
                        actUsuario.Actividad.Imagen = (string)datos.Lector["IMAGEN"];

                    actUsuario.Actividad.modalidad = new Modalidad();
                    actUsuario.Actividad.modalidad.Id = (int)datos.Lector["IDMODALIDAD"];
                    actUsuario.Actividad.modalidad.modalidad = (string)datos.Lector["NOMBREMODALIDAD"];

                    lista.Add(actUsuario);
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
