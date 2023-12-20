using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CapaDatos;
using CapaNegocio;
using CapaEntidad;

namespace CapaPresentacion
{
    public partial class ListarUsuario : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            UsuarioBL ousuario= new UsuarioBL();
            dvgUsuario.DataSource = ousuario.listarUsuario();
            dvgUsuario.DataBind();

        }
    }
}