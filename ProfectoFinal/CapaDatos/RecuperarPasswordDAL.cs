using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Mail;
using System.Net;
using System.Data.SqlTypes;
using System.Data.SqlClient;
namespace CapaDatos
{
    public class RecuperarPasswordDAL
    {
        private SmtpClient smtpClient;


        protected string remitenteCorreo { get; set; }
        protected string password { get; set; }
        protected string host { get; set; }
        protected int port { get; set; }
        protected bool ssl { get; set; }

        protected void initializeSmtpClient()
        {
            smtpClient = new SmtpClient();
            smtpClient.Credentials = new NetworkCredential(remitenteCorreo, password);
            smtpClient.Host = host;
            smtpClient.Port = port;
            smtpClient.EnableSsl = ssl;


        }
        public void sendMail(string subject, string body, List<string> destinatarioCorreo)
        {
            var maiMessaje = new MailMessage();
            try
            {
                maiMessaje.From = new MailAddress(remitenteCorreo);
                foreach (string mail in destinatarioCorreo)
                {
                    maiMessaje.To.Add(mail);
                }
                maiMessaje.Subject = subject;
                maiMessaje.Body = body;
                maiMessaje.Priority = MailPriority.Normal;
                smtpClient.Send(maiMessaje);

            }
            catch (Exception ex) { }
            finally
            {
                maiMessaje.Dispose();
                smtpClient.Dispose();
            }


        }
        public string recoverPassword(string usuarioSolicitando)
        {
            string mensaje = string.Empty;

            try
            {
                using (SqlConnection cn = new ConexionBD().conectar())
                {
                    using (var command = new SqlCommand())
                    {
                        command.Connection = cn;
                        command.CommandText = "SELECT * FROM Usuario WHERE Nombres = @Nombres OR CorreoElectronico = @CorreoElectronico";
                        command.Parameters.AddWithValue("@Nombres", usuarioSolicitando);
                        command.Parameters.AddWithValue("@CorreoElectronico", usuarioSolicitando);
                        command.CommandType = System.Data.CommandType.Text;

                        SqlDataReader reader = command.ExecuteReader();

                        if (reader.Read())
                        {
                            string contraseña = reader.GetString(reader.GetOrdinal("Contraseña"));
                            mensaje = "La contraseña del usuario es: " + contraseña;
                        }
                        else
                        {
                            mensaje = "Lo sentimos, no se encontró un usuario con ese nombre o correo electrónico.";
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Manejo de la excepción
                mensaje = "Ocurrió un error al intentar recuperar la contraseña: " + ex.Message;
                // También podrías registrar el error en un archivo de registro o en algún otro sistema de seguimiento de errores.
            }

            return mensaje;
        }

    }
}
