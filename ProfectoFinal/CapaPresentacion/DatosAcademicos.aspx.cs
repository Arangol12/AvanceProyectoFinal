using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CapaDatos;
using CapaEntidad;
using CapaNegocio;
namespace CapaPresentacion
{
    public partial class DatosAcademicos : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            DatosAcademicosBL datosAcademicos = new DatosAcademicosBL();

            int codigoUsuario;
            if (!int.TryParse(txtCodigoUsuario.Text, out codigoUsuario))
            {
                Response.Write("<script language=javascript>alert('El código de usuario debe ser un número entero válido.');</script>");
                return;
            }

            // Asegúrate de convertir correctamente la fecha del calendario
            DateTime fechaGrado;
            if (!DateTime.TryParse(DtCalendar.SelectedDate.ToString(), out fechaGrado))
            {
                Response.Write("<script language=javascript>alert('Seleccione una fecha válida para el grado.');</script>");
                return;

            }

            string mensaje = datosAcademicos.agregarDatosAcademicos(new Academico(
                codigoUsuario,
                cboTituloGrado.SelectedValue,
                txtCentroEstudios.Text,
                fechaGrado,
                ofSubir.FileName
            ));

            Response.Write("<script language=javascript>alert('" + mensaje + "');</script>");
            Response.Write("<script language=javascript>document.location.href = 'WebListarCompañia.aspx';</script>");
        }
    }

}





