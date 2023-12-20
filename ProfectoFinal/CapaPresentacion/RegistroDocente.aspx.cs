using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CapaDatos;
using CapaEntidad;
using CapaNegocio;
namespace CapaPresentacion
{
    public partial class RegistroDocente : System.Web.UI.Page
    {

        public void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                cargarDepartamento();
            }

        }

        protected void ddlDepartamento_SelectedIndexChanged(object sender, EventArgs e)
        {
            string departamentoSeleccionado = ddlDepartamento.SelectedValue;

            // Aquí podrías llamar a un método para cargar las provincias relacionadas con el departamento seleccionado
            cargarProvencias(departamentoSeleccionado);
        }

        protected void ddlProvencia_SelectedIndexChanged(object sender, EventArgs e)
        {

            string departamentoSeleccionado = ddlProvencia.SelectedValue;
            cargarProvencias(departamentoSeleccionado);
        }

        protected void ddlDistrito_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


        public void cargarDepartamento()
        {
            try
            {
                using (SqlConnection cn = new ConexionBD().conectar())
                {
                    using (SqlCommand cmd = new SqlCommand("sp_Obtener_Ubigeos", cn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@obtener", "departamento");

                        cn.Open();

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            // Asegúrate de que el campo de la base de datos para el nombre del departamento sea "Departamento"
                            // DataTextField debe coincidir con el nombre del campo en la consulta de tu procedimiento almacenado
                            ddlProvencia.DataSource = reader;
                            ddlProvencia.DataTextField = "Departamento"; // Nombre del campo en la base de datos
                            ddlProvencia.DataValueField = "departamento"; // El campo que identifica al departamento

                            ddlProvencia.DataBind(); // Importante: Realizar el enlace de datos

                            // Insertar un elemento por defecto al inicio del DropDownList
                            ddlProvencia.Items.Insert(0, new ListItem("--Selecciona un departamento--", ""));
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Manejo de la excepción: Puedes registrar el error, mostrar un mensaje al usuario, etc.
                Console.WriteLine("Error al cargar departamentos: " + ex.Message);
            }
        }
        public void cargarProvencias(string departamento)
        {
            using (SqlConnection cn = new ConexionBD().conectar())
            {
                using (SqlCommand cmd = new SqlCommand("sp_Obtener_Ubigeos", cn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@obtener", "Provencia");
                    cmd.Parameters.AddWithValue("@b_departamento", departamento);
                    cn.Open();

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        ddlProvencia.DataSource = reader;
                        ddlProvencia.DataTextField = "provencia";
                        ddlProvencia.DataValueField = "Provencia ";
                        ddlProvencia.DataBind();
                    }
                }
            }
            ddlProvencia.Items.Insert(0, new ListItem("Selecciona una provincia", ""));
        }
    }

}




       
    

    
    



        

        