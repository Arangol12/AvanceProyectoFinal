using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CapaDatos;
using CapaEntidad;
using CapaNegocio;
using System.Net;
using System.Security.Cryptography;

namespace CapaPresentacion
{
    public partial class Login : System.Web.UI.Page
    {
        public object BCrypt { get; private set; }

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        public void btnCreateAccount_Click(object sender, EventArgs e)
        {


        }

        public void btnSubmitRegistration_Click(object sender, EventArgs e)
        {
            UsuarioBL usuarioBL = new UsuarioBL();

            if (int.TryParse(txtNumeroDocu.Text, out int numeroDocumento))
            {
                // Obtener el valor seleccionado del ComboBox
                string documentoSeleccionado = cboDocumento.SelectedItem != null ? cboDocumento.SelectedItem.Value : "";

                // Generar un salt aleatorio
                byte[] salt;
                new RNGCryptoServiceProvider().GetBytes(salt = new byte[16]);

                // Hashear la contraseña utilizando PBKDF2
                var pbkdf2 = new Rfc2898DeriveBytes(txtContraseña.Text, salt, 10000);
                byte[] hash = pbkdf2.GetBytes(20);

                // Combinar el salt y el hash en una única matriz de bytes
                byte[] hashBytes = new byte[36];
                Array.Copy(salt, 0, hashBytes, 0, 16);
                Array.Copy(hash, 0, hashBytes, 16, 20);

                // Convertir el hash a una cadena base64
                string contraseñaHasheada = Convert.ToBase64String(hashBytes);

                string mensaje = usuarioBL.agregarUsuario(new Usuario(
                    txtNombre.Text,
                    txtApellidoPaterno.Text,
                    txtApellidoMaterno.Text,
                    txtNumeroDocu.Text,
                    documentoSeleccionado,
                    txtCorreo.Text,
                    contraseñaHasheada
                 
                   
                ));

                Response.Write("<script language=javascript>alert('" + mensaje + "');</script>");
                Response.Write("<script language=javascript>document.location.href = 'LoginParaAcceder.aspx';</script>");
            }
            else
            {
                // Manejar el escenario donde el texto no es un número entero válido
                Response.Write("<script language=javascript>alert('El documento debe ser un número entero.');</script>");
            }
        }
    }
}



    
