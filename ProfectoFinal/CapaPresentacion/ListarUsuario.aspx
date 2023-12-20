<%@ Page Title="" Language="C#" MasterPageFile="~/Pagina1.Master" AutoEventWireup="true" CodeBehind="ListarUsuario.aspx.cs" Inherits="CapaPresentacion.ListarUsuario" %>
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

    <div class="row">
        <div class="col-md-14">
            <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/Login.aspx">AgregarUsuarios</asp:HyperLink>
        </div>
    </div>
    <div class="login-container">
    <div class="row">
        <div class="col-md-14">
            <div class="table-responsive">
                <asp:GridView ID="dvgUsuario" runat="server" CssClass="table table-striped table-bordered" BackColor="Silver">
                    <Columns>
                        <asp:HyperLinkField DataNavigateUrlFields="idUsuario" DataNavigateUrlFormatString="ActualizarUsuario.aspx" Text="Editar" />
                        <asp:HyperLinkField DataNavigateUrlFields="idUsuario" DataNavigateUrlFormatString="EliminarUsuario.aspx" Text="Eliminar" />
                    </Columns>
                </asp:GridView>
            </div>
        </div>
    </div>
</div>
   

</asp:Content>
