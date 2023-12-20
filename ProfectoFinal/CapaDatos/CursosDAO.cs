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
    public class CursosDAO
    {
        public List<Cursos> ListarCursos()
        {
            List<Cursos> cursos = new List<Cursos>();
            using (SqlConnection cn = new ConexionBD().conectar())
            {
                try
                {
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = cn;
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "Listar_Cursos";
                    cn.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            cursos.Add(new Cursos(int.Parse(reader[0].ToString()), reader[1].ToString()));
                        }
                    }
                }
            }
        }
    }
}
