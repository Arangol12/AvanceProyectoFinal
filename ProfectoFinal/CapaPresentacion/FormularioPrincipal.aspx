<%@ Page Title="" Language="C#" MasterPageFile="~/Pagina1.Master" AutoEventWireup="true" CodeBehind="FormularioPrincipal.aspx.cs" Inherits="CapaPresentacion.FormularioPrincipal" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
  <div class="container">
        <!-- Menú con pestañas -->
        <ul class="nav nav-tabs">
            <li class="nav-item">
                <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/RegistroDocente.aspx">Registro Docente</asp:HyperLink>
            </li>
            <li class="nav-item">
                <a class="nav-link" data-toggle="tab" href="#cursosDisponibles">Cursos Disponibles</a>
            </li>
            <li class="nav-item">
                <a class="nav-link" data-toggle="tab" href="#experiencia">Experiencia</a>
            </li>
        </ul>

        <!-- Contenido de las pestañas -->
        <div class="tab-content">
            <!-- Pestaña para registrar docente -->

            <!-- Pestaña para mostrar cursos disponibles -->
            <div id="cursosDisponibles" class="tab-pane fade">
                <!-- Tu formulario para mostrar cursos disponibles aquí -->
                <!-- ... -->
            </div>

            <!-- Pestaña para mostrar experiencia -->
            <div id="experiencia" class="tab-pane fade">
                <!-- Tu formulario para mostrar experiencia aquí -->
                <!-- ... -->
            </div>
        </div>
    </div>

    <!-- Scripts de Bootstrap y jQuery -->
    <script src="https://code.jquery.com/jquery-3.5.1.slim.min.js"></script>
    <script src="https://cdn.jsdelivr.net/npm/@popperjs/core@2.9.1/dist/umd/popper.min.js"></script>
    <script src="https://stackpath.bootstrapcdn.com/bootstrap/4.5.2/js/bootstrap.min.js"></script>
 
   

            <div id="registroDocente" class="tab-pane fade show active" style="height: 547px">
                <!-- Tu formulario de registro de docente aquí -->
                <!-- ... -->
            </div>

               

</asp:Content>
