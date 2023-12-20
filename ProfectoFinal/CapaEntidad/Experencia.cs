using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public  class Experencia
    {
        public int idExperencia {  get; set; }
        public int idUsuario { get; set; }
        public DateTime fecha_Inicio { get; set; }

       public DateTime fecha_Fin {  get; set; }
        public string cargo { get; set; }
        public string nombre_empresa { get; set; }

        public string subir_Certificado { get; set; }

        public Experencia()
        {
        }

        public Experencia(int idExperencia, int idUsuario, DateTime fecha_Inicio, DateTime fecha_Fin, string cargo, string nombre_empresa, string subir_Certificado)
        {
            this.idExperencia = idExperencia;
            this.idUsuario = idUsuario;
            this.fecha_Inicio = fecha_Inicio;
            this.fecha_Fin = fecha_Fin;
            this.cargo = cargo;
            this.nombre_empresa = nombre_empresa;
            this.subir_Certificado = subir_Certificado;
        }

        public Experencia(int idUsuario, DateTime fecha_Inicio, DateTime fecha_Fin, string cargo, string nombre_empresa, string subir_Certificado)
        {
            this.idUsuario = idUsuario;
            this.fecha_Inicio = fecha_Inicio;
            this.fecha_Fin = fecha_Fin;
            this.cargo = cargo;
            this.nombre_empresa = nombre_empresa;
            this.subir_Certificado = subir_Certificado;
        }
    }
}
