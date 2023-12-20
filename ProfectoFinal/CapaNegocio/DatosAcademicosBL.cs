using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using CapaEntidad;
namespace CapaNegocio
{
    public class DatosAcademicosBL
    {
        DatosAcamedicosDAL datosAcademicos = new DatosAcamedicosDAL();

        public string agregarDatosAcademicos (Academico udatosAcademicos)
        {
            return datosAcademicos.agregarDatosDocente (udatosAcademicos);

        }
    }
}
