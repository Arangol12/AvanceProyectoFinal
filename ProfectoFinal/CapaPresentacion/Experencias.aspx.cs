using CapaEntidad;
using CapaNegocio;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CapaPresentacion
{
    public partial class Experencias : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnRegistrar_Click(object sender, EventArgs e)
        {
            ExperenciaBL experiencia = new ExperenciaBL();

            try
            {
                int codigoUsuario;
                if (!int.TryParse(txtCodigoUsuario.Text, out codigoUsuario))
                {
                    Response.Write("<script language=javascript>alert('El código de usuario debe ser un número entero válido.');</script>");
                    return;
                }

                DateTime fechaInicio;
                if (!DateTime.TryParse(dtdFechaInicio.SelectedDate.ToString(), out fechaInicio))
                {
                    Response.Write("<script language=javascript>alert('Seleccione una fecha válida para el inicio de la experiencia.');</script>");
                    return;
                }

                DateTime fechaFin;
                if (!DateTime.TryParse(dtdFechaFin.SelectedDate.ToString(), out fechaFin))
                {
                    Response.Write("<script language=javascript>alert('Seleccione una fecha válida para el fin de la experiencia.');</script>");
                    return;
                }

                string mensaje = experiencia.RegistrarExprencia(new CapaEntidad.Experencia(
                    codigoUsuario,
                    fechaInicio,
                    fechaFin,
                    cboCargo.SelectedValue,
                    txtNombreEmpresa.Text,
                    ofSuburCertificado.FileName
                ));

                Response.Write("<script language=javascript>alert('" + mensaje + "');</script>");
                Response.Write("<script language=javascript>document.location.href = 'WebListarCompañia.aspx';</script>");
            }
            catch (Exception ex)
            {
                // Manejo de la excepción: mostrar un mensaje de error o registrar el error para un análisis posterior
                Response.Write("<script language=javascript>alert('Se ha producido un error: " + ex.Message + "');</script>");
            }
        }
    }
}
