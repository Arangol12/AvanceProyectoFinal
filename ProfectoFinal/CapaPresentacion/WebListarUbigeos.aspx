<%@ Page Title="" Language="C#" MasterPageFile="~/Pagina1.Master" AutoEventWireup="true" CodeBehind="WebListarUbigeos.aspx.cs" Inherits="CapaPresentacion.WebListarUbigeos" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    
         <style>
     /* Estilos para el contenedor del formulario */
    .login-container {
        width: 800px;
        margin: 0 auto;
        background-color: #ffd800;
        border: 1px solid #ccc;
        border-radius: 8px;
        padding: 20px;
        box-shadow: 0 0 10px rgba(0, 0, 0, 0.1);
    }

    /* Estilos para la tabla */
    .table-responsive {
        width: 100%;
        overflow-x: auto;
    }

    .table {
        width: 100%;
        margin-bottom: 0; /* Eliminar margen inferior si es necesario */
    }

    .table td,
    .table th {
        white-space: nowrap; /* Evitar saltos de línea en celdas */
    }
</style>
    <div class="login-container">
        <div class="row">
            <div class="col-md-12">
                <div class="table-responsive">
                    <asp:GridView ID="dgvUbigeo" runat="server" CssClass="table table-striped table-bordered" BackColor="Silver"></asp:GridView>

                </div>

            </div>

        </div>

    </div>
</asp:Content>
