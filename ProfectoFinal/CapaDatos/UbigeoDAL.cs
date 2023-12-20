using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using CapaEntidad;
using System.Security.Policy;
using System.Threading;
using System.Runtime.InteropServices.WindowsRuntime;
using System.CodeDom;

namespace CapaDatos
{
    public class UbigeoDAL
    {
        public List<string> ObtenerUbigeoPorSeleccion(int? idDepartamento, int? idProvincia)
        {
            List<string> resultado = new List<string>();

            using (SqlConnection cn = new ConexionBD().conectar())
            {
                cn.Open();
                SqlCommand cmd = new SqlCommand("ObtenerUbigeoPorSeleccion", cn);
                cmd.CommandType = CommandType.StoredProcedure;

                SqlParameter paramIdDepartamento = new SqlParameter("@IdDepartamento", SqlDbType.Int);
                paramIdDepartamento.Value = idDepartamento ?? (object)DBNull.Value;
                cmd.Parameters.Add(paramIdDepartamento);

                SqlParameter paramIdProvincia = new SqlParameter("@IdProvincia", SqlDbType.Int);
                paramIdProvincia.Value = idProvincia ?? (object)DBNull.Value;
                cmd.Parameters.Add(paramIdProvincia);

                using (SqlDataReader dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        resultado.Add(dr[0].ToString());
                    }
                }
            }

            return resultado;
        }



        public List<Ubigeo> ListarUbigeo()
        {
            List<Ubigeo> ubigeos = new List<Ubigeo>();
            using (SqlConnection cn = new ConexionBD().conectar())
            {
                try
                {
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = cn;
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "Listar_Ubigeos";
                    cn.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            ubigeos.Add(new Ubigeo(reader[0].ToString(), reader[1].ToString(), reader[2].ToString(), reader[3].ToString()));

                        }
                    }
                    cn.Close();
                }
                catch (Exception ex)
                {
                    throw new Exception(ex.Message);
                }
                finally
                {
                    cn.Dispose();
                }
            }
            return ubigeos;
        }
        public List<string> ObtenerProvinciasPorDepartamento(int idDepartamento)
        {
            List<string> provincias = new List<string>();

            using (SqlConnection cn = new ConexionBD().conectar())
            {
                cn.Open();

                using (SqlCommand cmd = new SqlCommand("ObtenerUbigeoPorSeleccion", cn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@IdDepartamento", idDepartamento);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string provincia = reader["Provencia"].ToString();
                            provincias.Add(provincia);
                        }
                    }
                }
            }

            return provincias;
        }

        public List<string> ObtenerDistritosPorProvincia(int idDepartamento, int idProvincia)
        {
            List<string> distritos = new List<string>();

            using (SqlConnection cn = new ConexionBD().conectar())
            {
                cn.Open();

                using (SqlCommand cmd = new SqlCommand("ObtenerUbigeoPorSeleccion", cn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@IdDepartamento", idDepartamento);
                    cmd.Parameters.AddWithValue("@IdProvincia", idProvincia);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string distrito = reader["Distrito"].ToString();
                            distritos.Add(distrito);
                        }
                    }
                }
            }

            return distritos;
        }
    }
}




       