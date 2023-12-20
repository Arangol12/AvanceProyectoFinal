using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using CapaEntidad;
namespace CapaNegocio
{
    public class UsuarioBL
    {
       UsuarioDAL ousuario = new UsuarioDAL();

        public string agregarUsuario(Usuario unusuario)
        {
            return ousuario.agregarUsuario(unusuario);
        }
        public List<Usuario> listarUsuario()
        {
            return ousuario.ListarUsurio();
        }

     
    }
}
