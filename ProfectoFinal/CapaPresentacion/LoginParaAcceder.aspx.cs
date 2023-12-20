using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CapaDatos;
using CapaEntidad;
using CapaNegocio;

namespace CapaPresentacion
{
    public partial class LoginParaAcceder : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {

        }

        protected void Button1_Click1(object sender, EventArgs e)
        {

        }

        protected void btnAcceso_Click1(object sender, EventArgs e)
        {
            string correoelectronico =txtCorreoElectronico.Text;
            string contraseña=txtContraseña.Text;
            using (SqlConnection cn= new ConexionBD().conectar())
            {
                string query = "SELECT COUNT(*) FROM Usuario WHERE correoElectronico = @correoElectronico AND contraseña = @Contraseña";
                SqlCommand cmd = new SqlCommand(query, cn);
                cmd.Parameters.AddWithValue("@correoElectronico", correoelectronico);
                cmd.Parameters.AddWithValue("@contraseña", contraseña);
                cn.Open();
                int count = (int)cmd.ExecuteScalar();
                if (count > 0)
                {
                    // Las credenciales son correctas, redirige a la página de inicio o realiza alguna acción
                    Response.Redirect("FormularioPrincipal.aspx");
                }
                else
                {
                    // Credenciales incorrectas, muestra un mensaje de error o realiza alguna acción adicional
                    Response.Write("<script>alert('Correo electrónico o contraseña incorrectos.');</script>");
                }

                cn.Close();
            }
        }

        
    }
}