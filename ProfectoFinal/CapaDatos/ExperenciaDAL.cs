using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidad;
namespace CapaDatos
{
    public class ExperenciaDAL
    {
        public  string registrarExperencia (Experencia unexperencia)
        {
            string r = "";
            using (SqlConnection cn = new ConexionBD().conectar())
            {
                try
                {
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = cn;
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "sp_Registra_Experencia";
                    cmd.Parameters.AddWithValue("@codigoUsuario", unexperencia.idUsuario);
                    cmd.Parameters.AddWithValue("@fechaInicio", unexperencia.fecha_Inicio);
                    cmd.Parameters.AddWithValue("@fechaFin", unexperencia.fecha_Fin);
                    cmd.Parameters.AddWithValue("@cargo", unexperencia.cargo);
                    cmd.Parameters.AddWithValue("@nombreEmpresa", unexperencia.nombre_empresa);
                    cmd.Parameters.AddWithValue("@subirCertificado", unexperencia.subir_Certificado);
                    cn.Open();
                    int f = cmd.ExecuteNonQuery();
                    if (f > 0)
                    {
                        r = "registro Agregado";
                    }
                    cn.Close();

                }catch (Exception ex)
                {
                    throw new Exception(ex.Message);
                }
                finally
                {
                    cn.Dispose();
                }
                return r;
            }
        }

    }
}
