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
    public class DatosAcamedicosDAL
    {
        public string agregarDatosDocente( Academico udatosAcademicos)
        {
            string r = "";
            using (SqlConnection cn = new ConexionBD().conectar())
            {
                try
                {
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = cn;
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "sp_agregar_Datos_Academicos ";
                    cmd.Parameters.AddWithValue("@codUsuario", udatosAcademicos.idUsuario);
                    cmd.Parameters.AddWithValue("@tituloGrado", udatosAcademicos.titulo_Grado);
                    cmd.Parameters.AddWithValue("@centroEstudios", udatosAcademicos.centroEstudios);
                    cmd.Parameters.AddWithValue("@fechaGradoObtenido", udatosAcademicos.fechaGrado_Obtenido);
                    cmd.Parameters.AddWithValue("@subirTirulo", udatosAcademicos.subirTitulo);
                    cn.Open();
                    int f = cmd.ExecuteNonQuery();
                    if(f > 0)
                    {
                        r = "Registro Agregado";
                    }
                    cn.Close();
                }catch (Exception ex)
                {
                    throw new Exception(ex.Message);
                }finally
                {
                    cn.Dispose();
                }
                return r;
            }
        }
    }

}