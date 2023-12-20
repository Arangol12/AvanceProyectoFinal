using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class Ubigeo
    {

        public string IdUbigeo { get; set; }
        public string Departamento {  get; set; }

        public string Provencia { get; set; }
        public string Distrito { get; set; }

        public Ubigeo(string idUbigeo, string departamento, string provencia, string distrito)
        {
            IdUbigeo = idUbigeo;
            Departamento = departamento;
            Provencia = provencia;
            Distrito = distrito;
        }

        public Ubigeo()
        {
        }
    }
}
