using CapaNegocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CapaPresentacion
{
    public partial class WebListarUbigeos : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            UbigeoBL ubigeoBL = new UbigeoBL();
            dgvUbigeo.DataSource = ubigeoBL.ListarUbigeo();
            dgvUbigeo.DataBind();
        }
    }
}