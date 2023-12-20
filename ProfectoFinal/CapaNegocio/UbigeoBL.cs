using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using CapaEntidad;
namespace CapaNegocio
{
    public  class UbigeoBL
    {
        UbigeoDAL ubugioDAL = new UbigeoDAL();

        public List<Ubigeo> ListarUbigeo()
        {
            return ubugioDAL.ListarUbigeo();
        }
        public List<string> ObtenerUbigeoPorSeleccion(int? idDepartamento, int? idProvincia)
        {
            return ubugioDAL.ObtenerUbigeoPorSeleccion(idDepartamento, idProvincia);
        }
        public List<string> ObtenerProvinciasPorDepartamento(int idDepartamento)
        {
            return ubugioDAL.ObtenerProvinciasPorDepartamento(idDepartamento);
        }

        public List<string> ObtenerDistritosPorProvincia(int idDepartamento, int idProvincia)
        {
            return ubugioDAL.ObtenerDistritosPorProvincia(idDepartamento, idProvincia);
        }

    }

}

