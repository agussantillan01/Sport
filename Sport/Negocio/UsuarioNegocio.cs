using Dominio;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class UsuarioNegocio
    {
        public void Agregar(Usuario usuario)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearProcedimiento("SP_AGREGAUSUARIO");
                datos.setearParametro("@EMAIL", usuario.Email);
                datos.setearParametro("@PASSWORD", usuario.Password);
                datos.setearParametro("@NOMBRE", usuario.Nombre);
                datos.setearParametro("@APELLIDO", usuario.Apellido);

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

        public List<Usuario> ListarProfesores()
        {
            List<Usuario> lista = new List<Usuario>();
            SqlConnection conexion = new SqlConnection();
            SqlCommand comando = new SqlCommand();
            SqlDataReader lector;

            try
            {
                conexion.ConnectionString = "server=.\\SQLEXPRESS; database=SPORTS; integrated security= true";
                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = "SELECT ID, NOMBRE,APELLIDO,DNI,EMAIL,CONTRASEÑA,FECHANACIMIENTO, TipoUser FROM USUARIOS where PROFESOR = 1";
                comando.Connection = conexion;

                conexion.Open();
                lector = comando.ExecuteReader();

                while (lector.Read())
                {
                    Usuario us = new Usuario();
                    us.Id = (int)lector["ID"];
                    us.Nombre = (string)lector["NOMBRE"];
                    us.Apellido = (string)lector["APELLIDO"];
                    if (!(lector["DNI"] is DBNull))
                        us.DNI = (int)lector["DNI"];
                    us.Email = (string)lector["EMAIL"];
                    us.Password = (string)lector["CONTRASEÑA"];
                    if (!(lector["FECHANACIMIENTO"] is DBNull))
                        us.FechaNacimiento = (DateTime)lector["FECHANACIMIENTO"];
                    if (!(lector["TipoUser"] is DBNull))
                        us.TipoUsuario = (TipoUsuario)lector["TipoUser"];

                    lista.Add(us);
                }

                conexion.Close();
                return lista;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        public List<Usuario> ListaUsuarios()
        {
            List<Usuario> lista = new List<Usuario>();
            SqlConnection conexion = new SqlConnection();
            SqlCommand comando = new SqlCommand();
            SqlDataReader lector;

            try
            {
                conexion.ConnectionString = "server=.\\SQLEXPRESS; database=SPORTS; integrated security= true";
                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = "SELECT ID, NOMBRE,APELLIDO,DNI,EMAIL,CONTRASEÑA,FECHANACIMIENTO FROM USUARIOS where PROFESOR = 0 and TipoUser=1";
                comando.Connection = conexion;

                conexion.Open();
                lector = comando.ExecuteReader();

                while (lector.Read())
                {
                    Usuario us = new Usuario();
                    us.Id = (int)lector["ID"];
                    us.Nombre = (string)lector["NOMBRE"];
                    us.Apellido = (string)lector["APELLIDO"];
                    if (!(lector["DNI"] is DBNull))
                        us.DNI = (int)lector["DNI"];
                    us.Email = (string)lector["EMAIL"];
                    us.Password = (string)lector["CONTRASEÑA"];
                    if (!(lector["FECHANACIMIENTO"] is DBNull))
                        us.FechaNacimiento = (DateTime)lector["FECHANACIMIENTO"];
                    if (!(lector["TipoUser"] is DBNull))
                        us.TipoUsuario = (TipoUsuario)lector["TipoUser"];
                    lista.Add(us);
                }

                conexion.Close();
                return lista;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void AsignaProfesor (int idUsuario)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearProcedimiento("SP_ASIGNAPROFESOR");
                datos.setearParametro("@IDUSUARIO", idUsuario);

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

        public List<Usuario> listaTodos(){

            List<Usuario> lista = new List<Usuario>();
            SqlConnection conexion = new SqlConnection();
            SqlCommand comando = new SqlCommand();
            SqlDataReader lector;

            try
            {
                conexion.ConnectionString = "server=.\\SQLEXPRESS; database=SPORTS; integrated security= true";
                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = "SELECT ID, NOMBRE,APELLIDO,DNI,EMAIL,CONTRASEÑA,FECHANACIMIENTO, TipoUser FROM USUARIOS";
                comando.Connection = conexion;

                conexion.Open();
                lector = comando.ExecuteReader();

                while (lector.Read())
                {
                    Usuario us = new Usuario();
                    us.Id = (int)lector["ID"];
                    us.Nombre = (string)lector["NOMBRE"];
                    us.Apellido = (string)lector["APELLIDO"];
                    if (!(lector["DNI"] is DBNull))
                        us.DNI = (int)lector["DNI"];
                    us.Email = (string)lector["EMAIL"];
                    us.Password = (string)lector["CONTRASEÑA"];
                    if (!(lector["FECHANACIMIENTO"] is DBNull))
                        us.FechaNacimiento = (DateTime)lector["FECHANACIMIENTO"];
                    if (!(lector["TipoUser"] is DBNull))
                        us.TipoUsuario = (TipoUsuario)lector["TipoUser"];

                    lista.Add(us);
                }

                conexion.Close();
                return lista;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Modificar(Usuario nuevosDatos)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearProcedimiento("SP_MODIFICARDATOSPERSONALES");
                datos.setearParametro("@IDUSUARIO", nuevosDatos.Id);
                datos.setearParametro("@NOMBRE", nuevosDatos.Nombre);
                datos.setearParametro("@APELLIDO", nuevosDatos.Apellido);
                datos.setearParametro("@DNI", nuevosDatos.DNI);
                datos.setearParametro("@EMAIL", nuevosDatos.Email);
                datos.setearParametro("@CONTRASEÑA", nuevosDatos.Password);
                datos.setearParametro("@NACIMIENTO", nuevosDatos.FechaNacimiento);


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
    }
}
