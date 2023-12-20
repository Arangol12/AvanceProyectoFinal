using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class Academico
    {
        public int idDatosA { get; set; }
        public int idUsuario { get; set; }
        public string titulo_Grado { get; set; }
        public string centroEstudios { get; set; }

        public DateTime fechaGrado_Obtenido { get; set; }

        public string subirTitulo { get; set; }

        public Academico()
        {
        }

        public Academico(int idDatosA, int idUsuario, string titulo_Grado, string centroEstudios, DateTime fechaGrado_Obtenido, string subirTitulo)
        {
            this.idDatosA = idDatosA;
            this.idUsuario = idUsuario;
            this.titulo_Grado = titulo_Grado;
            this.centroEstudios = centroEstudios;
            this.fechaGrado_Obtenido = fechaGrado_Obtenido;
            this.subirTitulo = subirTitulo;
        }

        public Academico(int idUsuario, string titulo_Grado, string centroEstudios, DateTime fechaGrado_Obtenido, string subirTitulo)
        {
            this.idUsuario = idUsuario;
            this.titulo_Grado = titulo_Grado;
            this.centroEstudios = centroEstudios;
            this.fechaGrado_Obtenido = fechaGrado_Obtenido;
            this.subirTitulo = subirTitulo;
        }
    }

}
