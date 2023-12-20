using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CapaDatos;
using CapaNegocio;
using CapaEntidad;
using System.Data;
using System.Net.Mail;
using System.Net;
using System.Security.Cryptography.X509Certificates;
namespace CapaPresentacion
{
    public partial class RecuperacionContraseña : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
        }
        protected void BtnEntregar(object sender, EventArgs e)
        {
            var user = new RecuperarPasswordBL();
            var result = user.recoverPassword(txtCorreoElectronico.Text);
            lblMensaje.Text = result;
        }
    }
}

    
    
   

       
