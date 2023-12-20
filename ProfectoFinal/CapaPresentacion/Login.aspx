<%@ Page Title="" Language="C#" MasterPageFile="~/Pagina1.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="CapaPresentacion.Login" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <style>
        /* Estilos generales */
        .form-container {
            width: 400px;
            margin: 20px auto;
            background-color: #ffd800;
            border: 1px solid #ccc;
            border-radius: 8px;
            padding: 20px;
            box-shadow: 0 0 10px rgba(0, 0, 0, 0.1);
        }

        .form-group {
            margin-bottom: 15px;
        }

        label {
            display: block;
            margin-bottom: 5px;
            font-weight: bold;
        }

        .form-control {
            width: 100%;
            padding: 8px;
            border: 1px solid #ccc;
            border-radius: 5px;
        }

        .btn {
            width: 100%;
            padding: 10px;
            border: none;
            border-radius: 5px;
            cursor: pointer;
        }

        .btn-primary {
            background-color: #ff0000;
            color: #fff;
            font-size: 16px;
        }

        .btn-primary:hover {
            background-color: darkblue;
        }

        /* Estilos específicos para el formulario de registro (inicialmente oculto) */
        .register-container {
            display: none;
        }
    </style>
    <div class="row">
        <div class="form-control">
            <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/LoginParaAcceder.aspx">Login</asp:HyperLink>
        </div>

    </div>
    <!-- HTML de los formularios -->
    <div class="form-container" id="loginForm">
        <!-- Formulario de inicio de sesión -->
        <div class="form-group">
            <asp:Label for="txtNombre" runat="server" Text="Nombre "></asp:Label>
            <asp:TextBox ID="txtNombre" runat="server" CssClass="form-control" placeholder="NombreUsuario" ></asp:TextBox>
        </div>
        <div class="form-group">
          <div class="form-group">
       <label for="txtApellidoPaterno">Apellido Paterno</label>
       <asp:TextBox ID="txtApellidoPaterno" runat="server" CssClass="form-control" placeholder="contraseña"></asp:TextBox>
   </div>
          <div class="form-group">
                   <div class="form-group">
                <label for="txtApellidoMaterno">ApellidoMaterno</label>
                <asp:TextBox ID="txtApellidoMaterno" runat="server" CssClass="form-control" placeholder="Nombre"></asp:TextBox>
            </div>
              </div>
            <div class="form-group">
                <label for="txtNumeroDocumento">Numero Documento</label>
                <asp:TextBox ID="txtNumeroDocu" runat="server" CssClass="form-control" placeholder="Apellido Paterno"></asp:TextBox>
            </div>
                  <div class="form-group">
                       <label for="ddDocumento">Tipo Documento</label>
                         <asp:RadioButtonList ID="cboDocumento" runat="server">
                        <asp:ListItem Text="DNI" Value="DNI" />
                       <asp:ListItem Text="CE" Value="CE" />
                          </asp:RadioButtonList>
                            </div>
                    
                    <div class="form-group">
                        <label for="txtCorreoElectronico">Correo Electrónico</label>
                        <asp:TextBox ID="txtCorreo" runat="server" CssClass="form-control" placeholder="Correo Electrónico"></asp:TextBox>
                    </div>
               <div class="form-group">
                 <label for="txtContraseña">Contraseña</label>
              <asp:TextBox ID="txtContraseña" runat="server" CssClass="form-control" placeholder="Correo Electrónico"></asp:TextBox>
             </div>
            <div class="form-group">
                <asp:Label ID="Label1" runat="server" Text="Nombre Usuario"></asp:Label>
                <asp:TextBox ID="txtNombreUsuario" runat="server" CssClass="form-control"></asp:TextBox>

            </div>
                   

        <div class="form-group">
       <asp:Button ID="btnSubmitRegistration" runat="server" Text="Registrarse" CssClass="btn btn-primary" OnClick="btnSubmitRegistration_Click" />

        </div>

    </div>
        </div>


   
</asp:Content>
