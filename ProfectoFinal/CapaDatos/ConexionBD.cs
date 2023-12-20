using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class ConexionBD
    {
        SqlConnection cn = new SqlConnection("server =DESKTOP-659AT79;database=ProyectoFinal;uid=ARANGO;pwd=1234");
        public SqlConnection conectar()
        {
            return cn;
        }
    }
}

