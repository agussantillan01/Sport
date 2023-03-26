using Dominio;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class ModalidadNegocio
    {
        public List<Modalidad> ListarModalidad()
        {
            List<Modalidad> lista = new List<Modalidad>();
            SqlConnection conexion = new SqlConnection();
            SqlCommand comando = new SqlCommand();
            SqlDataReader lector;

            try
            {
                conexion.ConnectionString = "server=.\\SQLEXPRESS; database=SPORTS; integrated security= true";
                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = "Select ID, MODALIDAD from MODALIDAD";
                comando.Connection = conexion;

                conexion.Open();
                lector = comando.ExecuteReader();

                while (lector.Read())
                {
                    Modalidad us = new Modalidad();
                    us.Id = (int)lector["ID"];
                    us.modalidad = (string)lector["MODALIDAD"];

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
    }
}
