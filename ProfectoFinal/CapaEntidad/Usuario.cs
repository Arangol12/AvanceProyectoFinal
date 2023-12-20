using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class Usuario
    {

        public int idUsuario { get; set; }
        public string nombre { get; set; }
        public string apellidoPaterno { get; set; }
        public string apellidoMaterno { get; set; }

        public string numeroDocumento { get; set; }

        public string tipoDocumento { get; set; }

        public string correoElectronico { get; set; }
        public string contraseña { get; set; }

        public Usuario()
        {
        }

        public Usuario(int idUsuario, string nombre, string apellidoPaterno, string apellidoMaterno, string numeroDocumento, string tipoDocumento, string correoElectronico, string contraseña)
        {
            this.idUsuario = idUsuario;
            this.nombre = nombre;
            this.apellidoPaterno = apellidoPaterno;
            this.apellidoMaterno = apellidoMaterno;
            this.numeroDocumento = numeroDocumento;
            this.tipoDocumento = tipoDocumento;
            this.correoElectronico = correoElectronico;
            this.contraseña = contraseña;
        }

        public Usuario(string nombre, string apellidoPaterno, string apellidoMaterno, string numeroDocumento, string tipoDocumento, string correoElectronico, string contraseña)
        {
            this.nombre = nombre;
            this.apellidoPaterno = apellidoPaterno;
            this.apellidoMaterno = apellidoMaterno;
            this.numeroDocumento = numeroDocumento;
            this.tipoDocumento = tipoDocumento;
            this.correoElectronico = correoElectronico;
            this.contraseña = contraseña;
        }
    }
}
      
       
    

      
        

 

    